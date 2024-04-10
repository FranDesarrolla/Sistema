Imports System.Data.SqlClient

Public Class Pedidos
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaPedidos()
    End Sub

    Public Sub llenarGrillaPedidos()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtPedido") Then
            setdedatos.Tables("dtPedido").Rows.Clear()
        End If

        Dim consultassql As String = "select * from pedidos"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtPedido As New DataTable
        adaptadorSql.Fill(setdedatos, "dtPedido")
        GrillaPedidos.DataSource = setdedatos.Tables("dtPedido")



        'For Each i As Integer In New Integer() {3, 5, 6, 7, 8, 9, 11, 13, 14, 15, 19, 20, 21}
        'GrillaPacientes.Columns(i).Visible = False
        ' Next



    End Sub

    Private Sub GrillaPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class