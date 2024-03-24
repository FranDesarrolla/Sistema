Imports System.Data.SqlClient

Public Class Productos
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaProductos() ' Llamada al método sin término de búsqueda para mostrar todos los productos
        'ModuloSistema.conexionSql.Open() ' Abre la conexión SQL
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim terminoBusqueda As String = txtCodigoPbusqueda.Text.Trim()
        llenarGrillaProductos(terminoBusqueda) ' Llamada al método con el término de búsqueda ingresado
    End Sub

    Public Sub llenarGrillaProductos(Optional ByVal terminoBusqueda As String = "")
        'Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtProducto") Then
            setdedatos.Tables("dtProducto").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT IDProducto,Codigo, Descripcion, Especificaciones, Unidad, Rubro, Categoria, Stock, PrecioUnitario FROM Productos"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusqueda) Then
            consultassql &= " WHERE Descripcion LIKE '%" & terminoBusqueda & "%' OR Codigo LIKE '%" & terminoBusqueda & "%'"
        End If

        consultassql &= " ORDER BY Codigo ASC"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtProducto As New DataTable
        adaptadorSql.Fill(setdedatos, "dtProducto")
        GrillaProductos.DataSource = setdedatos.Tables("dtProducto")
        GrillaProductos.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        Dim columnasOcultas As Integer() = {2}
        For Each col In columnasOcultas
            GrillaProductos.Columns(col).Visible = False
        Next

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES
        GrillaProductos.Columns(0).FillWeight = 8
        GrillaProductos.Columns(1).FillWeight = 18
        GrillaProductos.Columns(2).FillWeight = 30
        GrillaProductos.Columns(3).FillWeight = 5
        GrillaProductos.Columns(4).FillWeight = 7
        GrillaProductos.Columns(5).FillWeight = 7
        GrillaProductos.Columns(6).FillWeight = 7
        GrillaProductos.Columns(7).FillWeight = 7

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA
        For i As Integer = 0 To 7
            GrillaProductos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ABM_Productos.lblSeñalProducto.Text = "EDITAR"

        ABM_Productos.id_producto.Text = GrillaProductos.CurrentRow.Cells(0).Value
        ABM_Productos.codProducto.Text = GrillaProductos.CurrentRow.Cells(1).Value
        ABM_Productos.descripProducto.Text = GrillaProductos.CurrentRow.Cells(2).Value
        ABM_Productos.especifiProducto.Text = GrillaProductos.CurrentRow.Cells(3).Value
        ABM_Productos.UnidadProducto.Text = GrillaProductos.CurrentRow.Cells(4).Value
        ABM_Productos.RubroProducto.Text = GrillaProductos.CurrentRow.Cells(5).Value
        ABM_Productos.CategoriaProducto.Text = GrillaProductos.CurrentRow.Cells(6).Value
        ABM_Productos.StockProducto.Text = GrillaProductos.CurrentRow.Cells(7).Value
        ABM_Productos.PrecioUnitarioProducto.Text = GrillaProductos.CurrentRow.Cells(8).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Productos)
        ModuloSistema.conexionSql.Close()


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        ABM_Productos.lblSeñalProducto.Text = "AGREGAR"

        ModuloPrincipal.AbrirFormEnPanel(ABM_Productos)

    End Sub
End Class
