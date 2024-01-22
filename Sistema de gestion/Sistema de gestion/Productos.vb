Imports System.Data.SqlClient

Public Class Productos
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaProductos()
        ModuloSistema.conexionSql.Open()
    End Sub

    Public Sub llenarGrillaProductos()
        'Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dt") Then
            setdedatos.Tables("dt").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT a.idproducto as Codigo, a.idproveedor as Proveedor, a.NombreProducto AS Producto, a.Descripcion AS Descripcion, a.UnidadMedida AS UM, a.Categoria, a.Rubro, a.Stock, a.PrecioUnitario AS Precio, a.Descuentos, a.Impuestos FROM Productos a"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dt As New DataTable
        adaptadorSql.Fill(setdedatos, "dt")
        GrillaProductos.DataSource = setdedatos.Tables("dt")
        GrillaProductos.Font = New Font("Arial", 10)

        GrillaProductos.Columns(1).Visible = False
        GrillaProductos.Columns(5).Visible = False
        GrillaProductos.Columns(6).Visible = False
        GrillaProductos.Columns(9).Visible = False
        GrillaProductos.Columns(10).Visible = False

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES

        GrillaProductos.Columns(0).FillWeight = 10
        GrillaProductos.Columns(2).FillWeight = 29
        GrillaProductos.Columns(3).FillWeight = 40
        GrillaProductos.Columns(4).FillWeight = 5
        GrillaProductos.Columns(7).FillWeight = 8
        GrillaProductos.Columns(8).FillWeight = 8

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 6
            GrillaProductos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

    End Sub



    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class