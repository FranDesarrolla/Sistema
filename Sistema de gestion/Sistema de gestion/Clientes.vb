Imports System.Data.SqlClient
Public Class Clientes
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaClientes()
        ModuloSistema.conexionSql.Open()
    End Sub
    Public Sub llenarGrillaClientes()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtClientes") Then
            setdedatos.Tables("dtClientes").Rows.Clear()
        End If

        Dim consultassql As String = "select * from clientes"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtClientes As New DataTable
        adaptadorSql.Fill(setdedatos, "dtClientes")
        GrillaClientes.DataSource = setdedatos.Tables("dtClientes")

        'For Each i As Integer In New Integer() {3, 5, 6, 7, 8, 9, 11, 13, 14, 15, 19, 20, 21}
        'GrillaPacientes.Columns(i).Visible = False
        ' Next

    End Sub

    Private Sub GrillaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentClick

    End Sub
End Class