Imports System.Data.SqlClient

Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaVentas()
    End Sub

    Public Sub llenarGrillaVentas()
        'LIMPIAR DATOS DE LA GRILLA
        If setdedatos.Tables.Contains("dtventa") Then
            setdedatos.Tables("dtventa").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT NDV.IDNotaDeVenta AS ID, C.Nombre + ' ' + C.Apellido AS Cliente, E.Nombre + ' ' + E.Apellido AS Empleado, NDV.Cliente, NDV.Empleado, NDV.FechaDeVenta AS Fecha, 
	                            NDV.PuntoDeVenta as Sucursal,  NDV.Letra, NDV.MetodoDePago as Metodo, NDV.TipoFactura as Tipo, NDV.Total, C.Nombre, C.Apellido, C.Direccion, C.DNI, C.CUIT, C.CondicionIVA
                                FROM NotasDeVentas NDV
                                INNER JOIN Clientes C ON C.Cuenta = NDV.Cliente
                                INNER JOIN Empleados E ON E.Cuenta = NDV.Empleado"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtventa As New DataTable
        adaptadorSql.Fill(setdedatos, "dtventa")
        GrillaVentas.DataSource = setdedatos.Tables("dtventa")
        GrillaVentas.Font = New Font("Yu Gothic UI", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {3, 4, 9, 10, 11, 12, 13, 14, 15, 16}

        For Each columna As Integer In columnasOcultar
            GrillaVentas.Columns(columna).Visible = False
        Next

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES

        GrillaVentas.Columns(0).FillWeight = 5
        GrillaVentas.Columns(1).FillWeight = 20
        GrillaVentas.Columns(2).FillWeight = 20
        GrillaVentas.Columns(5).FillWeight = 16
        GrillaVentas.Columns(6).FillWeight = 10
        GrillaVentas.Columns(7).FillWeight = 7
        GrillaVentas.Columns(8).FillWeight = 24

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 16
            GrillaVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

        ABM_Ventas.llenarGrillaMovVentas()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        ABM_Ventas.lblABM.Text = "Editar"
        ABM_Ventas.btnFin.Enabled = True

        'Activar paneles
        ABM_Ventas.panelProducto.Enabled = True
        'ABM_Ventas.panelAdd.Enabled = True
        ABM_Ventas.GrillaMovVentas.Enabled = True
        ABM_Ventas.ActualizarDatosCliente(ABM_Ventas.txtCuenta.Text)

        ABM_Ventas.lblID.Text = GrillaVentas.CurrentRow.Cells(0).Value
        ABM_Ventas.txtCuenta.Text = GrillaVentas.CurrentRow.Cells(3).Value
        ABM_Ventas.dateTime.Value = GrillaVentas.CurrentRow.Cells(5).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)
        ABM_Ventas.llenarGrillaMovVentas()

    End Sub

    Private Function ObtenerSiguienteIDNotaDeVenta() As Integer
        Dim siguienteID As Integer = 1
        Dim consultaSql As String = "SELECT MAX(IDNotaDeVenta) FROM NotasDeVentas"

        Using comandoSql As New SqlCommand(consultaSql, conexionSql)
            Try
                If conexionSql.State = ConnectionState.Closed Then
                    conexionSql.Open()
                End If

                Dim resultado = comandoSql.ExecuteScalar()
                If Not IsDBNull(resultado) Then
                    siguienteID = Convert.ToInt32(resultado) + 1
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el siguiente ID de nota de venta: " & ex.Message)
            Finally
                If conexionSql.State = ConnectionState.Open Then
                    conexionSql.Close()
                End If
            End Try
        End Using

        Return siguienteID
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ABM_Ventas.lblABM.Text = "Agregar"
        ABM_Ventas.lblID.Text = ObtenerSiguienteIDNotaDeVenta()
        ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)
        ABM_Ventas.llenarGrillaMovVentas()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada para eliminar
        If GrillaVentas.SelectedRows.Count > 0 Then
            ' Obtener el ID de la venta seleccionada (suponiendo que el ID está en la primera columna)
            Dim idVenta = Convert.ToInt32(GrillaVentas.CurrentRow.Cells(0).Value)

            ' Construir la consulta SQL para eliminar de NotasDeVentasMov
            Dim consultaSqlMov = "DELETE FROM NotasDeVentasMov WHERE IDNotaDeVenta = @IDVenta"

            ' Construir la consulta SQL para eliminar de NotasDeVentas
            Dim consultaSqlVentas = "DELETE FROM NotasDeVentas WHERE IDNotaDeVenta = @IDVenta"

            ' Usar la conexión establecida en ModuloSistema
            Using conexion = conexionSql
                Try

                    ' Iniciar una transacción para garantizar la atomicidad
                    Using transaccion = conexion.BeginTransaction
                        Try
                            ' Eliminar registros de NotasDeVentasMov
                            Using comandoMov As New SqlCommand(consultaSqlMov, conexion, transaccion)
                                comandoMov.Parameters.AddWithValue("@IDVenta", idVenta)
                                comandoMov.ExecuteNonQuery()
                            End Using

                            ' Eliminar registro de NotasDeVentas
                            Using comandoVentas As New SqlCommand(consultaSqlVentas, conexion, transaccion)
                                comandoVentas.Parameters.AddWithValue("@IDVenta", idVenta)
                                Dim filasAfectadas = comandoVentas.ExecuteNonQuery

                                ' Verificar si se eliminó correctamente
                                If filasAfectadas > 0 Then
                                    transaccion.Commit() ' Confirmar la transacción si todo fue exitoso
                                    MessageBox.Show("Registro eliminado correctamente.")

                                    ' Volver a llenar la grilla después de eliminar
                                    llenarGrillaVentas()
                                Else
                                    transaccion.Rollback() ' Revertir la transacción si no se eliminó ningún registro
                                    MessageBox.Show("No se pudo eliminar el registro.")
                                End If
                            End Using
                        Catch ex As Exception
                            transaccion.Rollback() ' Revertir la transacción en caso de error
                            MessageBox.Show("Error al intentar eliminar el registro: " & ex.Message)
                        End Try
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al intentar conectar con la base de datos: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione una fila para eliminar.")
        End If
    End Sub
End Class