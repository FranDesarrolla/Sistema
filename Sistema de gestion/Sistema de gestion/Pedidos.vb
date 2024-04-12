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

        Dim consultassql As String = "SELECT 	IDPedido as NroPedido, Cliente, Empleado, FechaPedido, EstadoPedido FROM Pedidos"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusqueda) Then
            consultassql &= " WHERE Cliente LIKE '%" & terminoBusqueda & "%' OR IDPedido LIKE '%" & terminoBusqueda & "%'"
        End If

        consultassql &= " ORDER BY IDPedido ASC"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtProducto As New DataTable
        adaptadorSql.Fill(setdedatos, "dtPedido")
        GrillaPedidos.DataSource = setdedatos.Tables("dtPedido")
        GrillaPedidos.Font = New Font("Arial", 10)



        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 4
            GrillaPedidos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i


    End Sub

    Private Sub AgregarPedido_Click(sender As Object, e As EventArgs) Handles AgregarPedido.Click
        ABM_Pedidos.lblSeñalPedido.Text = "AGREGAR"

        ModuloPrincipal.AbrirFormEnPanel(ABM_Pedidos)
    End Sub

    Private Sub txtCodigoPedidobusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoPedidobusqueda.TextChanged
        llenarGrillaPedidos(txtCodigoPedidobusqueda.Text.Trim())
    End Sub

    Private Sub EditarPedido_Click(sender As Object, e As EventArgs) Handles EditarPedido.Click
        ABM_Pedidos.lblSeñalPedido.Text = "EDITAR"

        ModuloPrincipal.AbrirFormEnPanel(ABM_Pedidos)
    End Sub
End Class