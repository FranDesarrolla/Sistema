Imports System.Data.SqlClient

Public Class Pedidos
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaPedidos()
    End Sub
    Private Sub btnBuscarPedido_Click(sender As Object, e As EventArgs) Handles btnBuscarPedido.Click
        Dim terminoBusqueda As String = txtCodigoPedidobusqueda.Text.Trim()
        llenarGrillaPedidos(terminoBusqueda) ' Llamada al método con el término de búsqueda ingresado
    End Sub
    Public Sub llenarGrillaPedidos(Optional ByVal terminoBusqueda As String = "")
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtPedido") Then
            setdedatos.Tables("dtPedido").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT   PED.IDPedido AS ID, C.Nombre + ' ' + C.Apellido AS Cliente, E.Nombre + ' ' + E.Apellido AS Empleado, PED.Cliente, PED.Empleado, PED.FechaPedido AS Fecha,  
                                      PED.PuntoDeVenta as Sucursal,C.Nombre, C.Apellido, C.Direccion, C.DNI, C.CUIT, PED.EstadoPedido
                                      FROM Pedidos PED
                                      INNER JOIN Clientes C ON C.Cuenta = PED.Cliente
                                      INNER JOIN Empleados E ON E.Cuenta = PED.Empleado"



        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtPedido As New DataTable
        adaptadorSql.Fill(setdedatos, "dtPedido")
        GrillaPedidos.DataSource = setdedatos.Tables("dtPedido")
        GrillaPedidos.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {3, 4, 7, 8, 9, 10, 11}

        For Each columna As Integer In columnasOcultar
            GrillaPedidos.Columns(columna).Visible = False
        Next

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES

        GrillaPedidos.Columns(0).FillWeight = 5
        GrillaPedidos.Columns(1).FillWeight = 20
        GrillaPedidos.Columns(2).FillWeight = 20
        GrillaPedidos.Columns(5).FillWeight = 10
        GrillaPedidos.Columns(6).FillWeight = 10
        GrillaPedidos.Columns(12).FillWeight = 15

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 12
            GrillaPedidos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i


        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusqueda) Then
            consultassql &= " WHERE Cliente LIKE '%" & terminoBusqueda & "%' OR IDPedido LIKE '%" & terminoBusqueda & "%'"
        End If

        consultassql &= " ORDER BY IDPedido ASC"


    End Sub
    Private Sub AgregarPedido_Click(sender As Object, e As EventArgs) Handles AgregarPedido.Click
        ABM_Pedidos.lblSeñalPedido.Text = "Agregar"

        Dim idPuntoVenta As String = DirectCast(ModuloPrincipal.boxPV.SelectedItem, DataRowView)("IDPuntoVenta").ToString()
        Dim idPuntoVentaRellenado As String = idPuntoVenta.PadLeft(5, "0"c)
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