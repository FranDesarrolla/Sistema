Imports System.Data.SqlClient

Public Class Pedidos
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaPedidos()
    End Sub

    Public Sub llenarGrillaPedidos(Optional ByVal terminoBusqueda As String = "")
        ' LIMPIAR DATOS DE LA GRILLA
        If setdedatos.Tables.Contains("dtPedido") Then
            setdedatos.Tables("dtPedido").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT PED.IDPedido AS 'Pedido', C.Nombre + ' ' + C.Apellido AS Cliente, E.Nombre + ' ' + E.Apellido AS Empleado, PED.Cliente, PED.Empleado, PED.FechaPedido AS Fecha,  
                           PED.PuntoDeVenta as Sucursal, C.Nombre, C.Apellido, C.Direccion, C.DNI, C.CUIT, PED.Estado
                           FROM Pedidos PED
                           INNER JOIN Clientes C ON C.Cuenta = PED.Cliente
                           INNER JOIN Empleados E ON E.Cuenta = PED.Empleado
                           INNER JOIN Provincias P ON P.IDProvincia = C.Provincia
                           INNER JOIN Localidades L ON L.IDLocalidad = C.Localidad"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusqueda) Then
            ' Construir las condiciones de búsqueda para cada campo
            Dim condicionesBusqueda As String = " WHERE PED.IDPedido LIKE '%" & terminoBusqueda & "%'" &
                                     " OR C.Nombre LIKE '%" & terminoBusqueda & "%'" &
                                     " OR C.Apellido LIKE '%" & terminoBusqueda & "%'" &
                                     " OR P.Provincia Like '%" & terminoBusqueda & "%'" &
                                     " OR L.Localidad LIKE '%" & terminoBusqueda & "%'"
            ' Añadir las condiciones a la consulta
            consultassql &= condicionesBusqueda
        End If

        consultassql &= " ORDER BY PED.IDPedido ASC"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtPedido As New DataTable
        adaptadorSql.Fill(setdedatos, "dtPedido")
        GrillaPedidos.DataSource = setdedatos.Tables("dtPedido")
        GrillaPedidos.Font = New Font("Arial", 10)

        ' Añadir una columna de imagen al principio de la grilla si no existe
        If Not GrillaPedidos.Columns.Contains("EstadoImagen") Then
            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "EstadoImagen"
            imgCol.HeaderText = "Estado"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            ' Insertar la columna al principio sin desplazar las columnas existentes
            GrillaPedidos.Columns.Insert(0, imgCol)
        End If

        ' CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        ' Primero, asegurar que todas las columnas estén visibles
        For i As Integer = 0 To GrillaPedidos.Columns.Count - 1
            GrillaPedidos.Columns(i).Visible = True
        Next

        ' Ahora ocultar las columnas no deseadas
        Dim columnasOcultar() As Integer = {4, 5, 8, 9, 10, 11, 12, 13}
        For Each columna As Integer In columnasOcultar
            If GrillaPedidos.Columns.Count > columna Then
                GrillaPedidos.Columns(columna).Visible = False
            End If
        Next

        ' CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES
        GrillaPedidos.Columns(0).FillWeight = 8
        GrillaPedidos.Columns(1).FillWeight = 10
        GrillaPedidos.Columns(2).FillWeight = 27.5
        GrillaPedidos.Columns(3).FillWeight = 27.5
        GrillaPedidos.Columns(6).FillWeight = 15
        GrillaPedidos.Columns(7).FillWeight = 12

        ' COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA
        For i As Integer = 0 To GrillaPedidos.Columns.Count - 1
            GrillaPedidos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

        ' Asignar las imágenes correspondientes a cada estado en el evento DataBindingComplete
        AddHandler GrillaPedidos.DataBindingComplete, AddressOf GrillaPedidos_DataBindingComplete
    End Sub

    Private Sub GrillaPedidos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For Each row As DataGridViewRow In GrillaPedidos.Rows
            Dim estado As Integer = Convert.ToInt32(row.Cells("Estado").Value)

            Select Case estado
                Case 1
                    row.Cells("EstadoImagen").Value = My.Resources.pendiente_1 ' Imagen para estado 1
                Case 2
                    row.Cells("EstadoImagen").Value = My.Resources.preparado_2 ' Imagen para estado 2
                Case 3
                    row.Cells("EstadoImagen").Value = My.Resources.aceptado_3 ' Imagen para estado 3
                Case 4
                    row.Cells("EstadoImagen").Value = My.Resources.facturado_4 ' Imagen para estado 4
                Case 5
                    row.Cells("EstadoImagen").Value = My.Resources.terminado_5 ' Imagen para estado 5
                Case 6
                    row.Cells("EstadoImagen").Value = My.Resources.faltadepago_6 ' Imagen para estado 6
                Case 7
                    row.Cells("EstadoImagen").Value = My.Resources.anulado_7 ' Imagen para estado 7
                Case Else
                    row.Cells("EstadoImagen").Value = My.Resources.pendiente_1 ' Imagen por defecto
            End Select
        Next
    End Sub


    Private Sub ActualizarEstadoPedido(idPedido As Integer, nuevoEstado As Integer)
        Dim consultaSQL As String = "UPDATE Pedidos SET Estado = @NuevoEstado WHERE IDPedido = @IDPedido"

        ' Obtener el estado actual del pedido
        Dim estadoActual As Integer
        Dim consultaEstadoSQL As String = "SELECT Estado FROM Pedidos WHERE IDPedido = @IDPedido"

        Try
            ' Verificar el estado actual del pedido
            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(consultaEstadoSQL, connection)
                command.Parameters.AddWithValue("@IDPedido", idPedido)
                connection.Open()

                estadoActual = Convert.ToInt32(command.ExecuteScalar())
            End Using

            ' Verificar si el nuevo estado es válido (no puede retroceder de estado)
            If nuevoEstado <= estadoActual Then
                MessageBox.Show("No se puede retroceder el estado del pedido.")
                Exit Sub
            End If

            ' Actualizar el estado del pedido
            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(consultaSQL, connection)
                command.Parameters.AddWithValue("@NuevoEstado", nuevoEstado)
                command.Parameters.AddWithValue("@IDPedido", idPedido)
                connection.Open()

                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Estado del pedido actualizado con éxito.")

            ' Volver a llenar la grilla para reflejar los cambios
            llenarGrillaPedidos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado del pedido: " & ex.Message)
        End Try
    End Sub

    Private Sub DeshabilitarBotonesPorEstado(estado As Integer)
        ' Definir los botones y colores
        Dim botones As Button() = {btnPendiente, btnPreparar, btnAceptar, btnFacturar, btnTerminar, btnFaltapagar, btnAnular}
        Dim colorActivo As Color = Color.FromArgb(237, 244, 226)
        Dim colorInactivo As Color = Color.Tan

        ' Habilitar todos los botones primero y establecer color activo
        For Each btn As Button In botones
            btn.Enabled = True
            btn.BackColor = colorActivo
        Next

        ' Deshabilitar los botones basados en el estado y establecer color inactivo
        Select Case estado
            Case 1 ' PENDIENTE
                DeshabilitarBotones({btnPendiente}, colorInactivo)
            Case 2 ' PREPARADO
                DeshabilitarBotones({btnPendiente, btnPreparar}, colorInactivo)
            Case 3 ' ACEPTADO
                DeshabilitarBotones({btnPendiente, btnPreparar, btnAceptar}, colorInactivo)
            Case 4 ' FACTURADO
                DeshabilitarBotones({btnPendiente, btnPreparar, btnAceptar, btnFacturar}, colorInactivo)
            Case 5 ' TERMINADO
                DeshabilitarBotones({btnPendiente, btnPreparar, btnAceptar, btnFacturar, btnTerminar, btnFaltapagar, btnAnular}, colorInactivo)
            Case 6 ' FALTA DE PAGO
                DeshabilitarBotones({btnPendiente, btnPreparar, btnAceptar, btnFacturar, btnFaltapagar}, colorInactivo)
            Case 7 ' ANULADO
                DeshabilitarBotones({btnPendiente, btnPreparar, btnAceptar, btnFacturar, btnTerminar, btnFaltapagar, btnAnular}, colorInactivo)
        End Select
    End Sub

    Private Sub DeshabilitarBotones(botones As Button(), colorInactivo As Color)
        For Each btn As Button In botones
            btn.Enabled = False
            btn.BackColor = colorInactivo
        Next
    End Sub

    Private Sub ActualizarBotones()
        ' Verificar que haya una fila seleccionada
        If GrillaPedidos.CurrentRow IsNot Nothing Then
            Dim estado As Integer = Convert.ToInt32(GrillaPedidos.CurrentRow.Cells("Estado").Value)
            DeshabilitarBotonesPorEstado(estado)
        End If
    End Sub

    Private Sub GrillaPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles GrillaPedidos.SelectionChanged
        ' Actualizar el estado de los botones cuando se cambie la selección
        ActualizarBotones()
    End Sub

    Private Sub btnPendiente_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 1)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnPreparar_Click(sender As Object, e As EventArgs) Handles btnPreparar.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 2)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 3)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 4)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 5)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnFaltapagar_Click(sender As Object, e As EventArgs) Handles btnFaltapagar.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 6)
        llenarGrillaPedidos()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim idPedido As Integer = ObtenerIDPedidoSeleccionado()
        ActualizarEstadoPedido(idPedido, 7)
        llenarGrillaPedidos()
    End Sub

    Private Function ObtenerIDPedidoSeleccionado() As Integer
        ' Lógica para obtener el ID del pedido seleccionado
        ' Por ejemplo:
        Return Convert.ToInt32(GrillaPedidos.CurrentRow.Cells("Pedido").Value)
    End Function

    Private Sub AgregarPedido_Click(sender As Object, e As EventArgs) Handles AgregarPedido.Click
        ABM_Pedidos.lblSeñalPedido.Text = "Agregar"

        Dim idPuntoVenta = DirectCast(ModuloPrincipal.boxPV.SelectedItem, DataRowView)("IDPuntoVenta").ToString
        Dim idPuntoVentaRellenado = idPuntoVenta.PadLeft(5, "0"c)
        ABM_Pedidos.txtSucursal.Text = idPuntoVentaRellenado

        ABM_Pedidos.btnCabecera.Text = "Confirmar Cabecera"
        ABM_Pedidos.lblSeñalPedido.Text = "Agregar"
        ABM_Pedidos.lblID.Text = 0
        ModuloPrincipal.AbrirFormEnPanel(ABM_Pedidos)
    End Sub

    Private Sub txtCodigoPedidobusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoPedidobusqueda.TextChanged
        llenarGrillaPedidos(txtCodigoPedidobusqueda.Text.Trim())
    End Sub

    Private Sub EditarPedido_Click(sender As Object, e As EventArgs) Handles EditarPedido.Click
        ABM_Pedidos.btnCabecera.Text = "Actualizar Cabecera"
        ABM_Pedidos.lblSeñalPedido.Text = "Editar"
        ABM_Pedidos.btnFin.Enabled = True

        'Activar paneles
        ABM_Pedidos.panelProducto.Enabled = True
        ABM_Pedidos.panelAdd.Enabled = True
        ABM_Pedidos.GrillaMovPedidos.Enabled = True

        ABM_Pedidos.lblID.Text = GrillaPedidos.CurrentRow.Cells(0).Value
        ABM_Pedidos.txtCuenta.Text = GrillaPedidos.CurrentRow.Cells(3).Value
        ABM_Pedidos.lblNombreCliente.Text = GrillaPedidos.CurrentRow.Cells(7).Value
        ABM_Pedidos.lblApellidoCliente.Text = GrillaPedidos.CurrentRow.Cells(8).Value
        ABM_Pedidos.lblDireccion.Text = GrillaPedidos.CurrentRow.Cells(9).Value
        ABM_Pedidos.lblDNII.Text = GrillaPedidos.CurrentRow.Cells(10).Value
        ABM_Pedidos.lblCUITT.Text = GrillaPedidos.CurrentRow.Cells(11).Value
        ABM_Pedidos.dateTime.Value = GrillaPedidos.CurrentRow.Cells(5).Value
        ABM_Pedidos.txtSucursal.Text = GrillaPedidos.CurrentRow.Cells(6).Value
        'ABM_Pedidos.lblLetra.Text = GrillaPedidos.CurrentRow.Cells(7).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Pedidos)
    End Sub

End Class
