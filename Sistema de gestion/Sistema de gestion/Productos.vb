Imports System.Data.SqlClient

Public Class Productos
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaProductos()
    End Sub

    Public Sub llenarGrillaProductos()
        'Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dt") Then
            setdedatos.Tables("dt").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT a.idproducto, a.idproveedor, a.NombreProducto, a.Descripcion, a.UnidadMedida, a.Categoria, a.Rubro, a.Stock, a.PrecioUnitario, a.Descuentos, a.Impuestos FROM Productos a"



        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dt As New DataTable
        adaptadorSql.Fill(setdedatos, "dt")
        GrillaProductos.DataSource = setdedatos.Tables("dt")
    End Sub

    Private Sub GrillaProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductos.CellContentClick

    End Sub
End Class