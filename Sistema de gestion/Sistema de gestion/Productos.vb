Imports System.Data.SqlClient

Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaProductos()
    End Sub

    Public Sub llenarGrillaProductos(Optional ByVal terminoBusqueda As String = "")
        ' Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtProducto") Then
            setdedatos.Tables("dtProducto").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT IDProducto, Codigo, Descripcion, Especificaciones, Unidad as 'U', Rubro, Categoria, Stock, PrecioUnitario as 'Unitario', Iva FROM Productos"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusqueda) Then
            ' Construir las condiciones de búsqueda para cada campo
            Dim condicionesBusqueda As String = " WHERE Codigo LIKE '%" & terminoBusqueda & "%'" &
                                                 " OR Descripcion LIKE '%" & terminoBusqueda & "%'" &
                                                 " OR Especificaciones LIKE '%" & terminoBusqueda & "%'"

            ' Añadir las condiciones a la consulta
            consultassql &= condicionesBusqueda
        End If

        consultassql &= " ORDER BY Codigo ASC"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtProducto As New DataTable
        adaptadorSql.Fill(setdedatos, "dtProducto")
        GrillaProductos.DataSource = setdedatos.Tables("dtProducto")
        GrillaProductos.Font = New Font("Arial", 10)

        ' CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        Dim columnasOcultas As Integer() = {0, 2, 5, 6, 9}
        For Each col In columnasOcultas
            GrillaProductos.Columns(col).Visible = False
        Next

        ' CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES
        GrillaProductos.Columns(1).FillWeight = 15
        GrillaProductos.Columns(3).FillWeight = 50
        GrillaProductos.Columns(4).FillWeight = 5
        GrillaProductos.Columns(7).FillWeight = 15
        GrillaProductos.Columns(8).FillWeight = 15

        ' COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA
        For i As Integer = 0 To 8
            GrillaProductos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i
    End Sub

    Private Sub GrillaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductos.CellClick
        ' Verificar si la celda seleccionada está en una fila válida
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtener el código del producto de la celda seleccionada
            Dim codigoProducto As String = GrillaProductos.Rows(e.RowIndex).Cells("Codigo").Value.ToString()

            ' Llamar al método para llenar la grilla de stock con base en el código del producto
            LlenarGrillaStock(codigoProducto)

            ' Cargar la imagen del producto desde la base de datos
            CargarImagenProducto(Convert.ToInt32(GrillaProductos.Rows(e.RowIndex).Cells("IDProducto").Value))
        End If
    End Sub

    Private Sub LlenarGrillaStock(codigoProducto As String)
        ' Limpiar datos de la grilla de stock (supongamos que se llama GrillaStockDepositos)
        If setdedatos.Tables.Contains("dtStock") Then
            setdedatos.Tables("dtStock").Rows.Clear()
        End If

        ' Consulta SQL para obtener el stock de los depósitos
        Dim consultaSQL As String = "SELECT d.NumeroDeposito, d.Nombre as 'Deposito', sd.CantidadStock as 'Stock' " &
                                    "FROM StockDepositos sd " &
                                    "INNER JOIN Depositos d ON sd.NumeroDeposito = d.NumeroDeposito " &
                                    "WHERE sd.CodigoProducto = @CodigoProducto"

        Using comandoSql As New SqlCommand(consultaSQL, conexionSql)
            comandoSql.Parameters.AddWithValue("@CodigoProducto", codigoProducto)

            Dim adaptadorSql As New SqlDataAdapter(comandoSql)
            Dim dtStock As New DataTable
            adaptadorSql.Fill(setdedatos, "dtStock")
            GrillaStockDepositos.DataSource = setdedatos.Tables("dtStock")
            GrillaStockDepositos.Font = New Font("Yu Gothic UI", 10)

            ' Configurar columnas visibles
            Dim columnasVisibles As Integer() = {0}
            For Each col In columnasVisibles
                GrillaStockDepositos.Columns(col).Visible = False
            Next

            ' Configurar ancho de las columnas
            GrillaStockDepositos.Columns(1).FillWeight = 65 ' Nombre
            GrillaStockDepositos.Columns(2).FillWeight = 35 ' CantidadStock

            ' Configurar auto tamaño de columnas
            For i As Integer = 0 To 2
                GrillaStockDepositos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next i
        End Using
    End Sub

    Private Sub CargarImagenProducto(idProducto As Integer)
        Dim consultaSQL As String = "SELECT Imagen FROM ProductosImagenes WHERE IDProducto = @IDProducto"

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString),
                  command As New SqlCommand(consultaSQL, connection)
                command.Parameters.AddWithValue("@IDProducto", idProducto)
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim imageData As Byte() = If(reader("Imagen") IsNot DBNull.Value, CType(reader("Imagen"), Byte()), Nothing)
                        If imageData IsNot Nothing Then
                            Using ms As New IO.MemoryStream(imageData)
                                ABM_Productos.picProducto.Image = Image.FromStream(ms)
                            End Using
                        Else
                            ABM_Productos.picProducto.Image = Nothing
                        End If
                    Else
                        ABM_Productos.picProducto.Image = Nothing
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen del producto: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCodigoPbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoPbusqueda.TextChanged
        llenarGrillaProductos(txtCodigoPbusqueda.Text.Trim())
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ABM_Productos.lblSeñalProducto.Text = "EDITAR"
        ABM_Productos.codProducto.Enabled = False

        ' Asignar valores de la fila seleccionada a los campos del formulario de edición
        ABM_Productos.id_producto.Text = GrillaProductos.CurrentRow.Cells(0).Value
        ABM_Productos.codProducto.Text = GrillaProductos.CurrentRow.Cells(1).Value
        ABM_Productos.descripProducto.Text = GrillaProductos.CurrentRow.Cells(2).Value
        ABM_Productos.especifiProducto.Text = GrillaProductos.CurrentRow.Cells(3).Value
        ABM_Productos.UnidadProducto.Text = GrillaProductos.CurrentRow.Cells(4).Value
        ABM_Productos.RubroProducto.Text = GrillaProductos.CurrentRow.Cells(5).Value
        ABM_Productos.CategoriaProducto.Text = GrillaProductos.CurrentRow.Cells(6).Value
        ABM_Productos.StockProducto.Text = GrillaProductos.CurrentRow.Cells(7).Value
        ABM_Productos.PrecioUnitarioProducto.Text = GrillaProductos.CurrentRow.Cells(8).Value
        ABM_Productos.txtIvaProducto.Text = GrillaProductos.CurrentRow.Cells(9).Value

        ' Cargar la imagen del producto desde la base de datos
        CargarImagenProducto(Convert.ToInt32(GrillaProductos.CurrentRow.Cells(0).Value))

        ModuloPrincipal.AbrirFormEnPanel(ABM_Productos)
    End Sub

    Private Sub btnAceptarABMP_Click(sender As Object, e As EventArgs) Handles btnAceptarABMP.Click
        ABM_Productos.lblSeñalProducto.Text = "AGREGAR"

        ModuloPrincipal.AbrirFormEnPanel(ABM_Productos)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada para eliminar
        If GrillaProductos.SelectedRows.Count > 0 Then
            ' Obtener el ID del producto seleccionado (suponiendo que el ID está en la primera columna)
            Dim idProducto = Convert.ToInt32(GrillaProductos.CurrentRow.Cells(0).Value)

            ' Construir la consulta SQL para eliminar de ProductosImagenes
            Dim consultaSqlImagen = "DELETE FROM ProductosImagenes WHERE IDProducto = @IDProducto"

            ' Construir la consulta SQL para eliminar de Productos
            Dim consultaSqlProducto = "DELETE FROM Productos WHERE IDProducto = @IDProducto"

            ' Usar la conexión establecida en ModuloSistema
            If conexionSql.State = ConnectionState.Closed Then
                conexionSql.Open()
            End If

            Try
                ' Iniciar una transacción para garantizar la atomicidad
                Using transaccion = conexionSql.BeginTransaction
                    Try
                        ' Eliminar registros de ProductosImagenes
                        Using comandoImagen As New SqlCommand(consultaSqlImagen, conexionSql, transaccion)
                            comandoImagen.Parameters.AddWithValue("@IDProducto", idProducto)
                            comandoImagen.ExecuteNonQuery()
                        End Using

                        ' Eliminar registro de Productos
                        Using comandoProducto As New SqlCommand(consultaSqlProducto, conexionSql, transaccion)
                            comandoProducto.Parameters.AddWithValue("@IDProducto", idProducto)
                            Dim filasAfectadas = comandoProducto.ExecuteNonQuery

                            ' Verificar si se eliminó correctamente
                            If filasAfectadas > 0 Then
                                transaccion.Commit() ' Confirmar la transacción si todo fue exitoso
                                MessageBox.Show("Registro eliminado correctamente.")

                                ' Volver a llenar la grilla después de eliminar
                                llenarGrillaProductos()
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
            Finally
                conexionSql.Close()
            End Try
        Else
            MessageBox.Show("Seleccione una fila para eliminar.")
        End If
    End Sub

End Class