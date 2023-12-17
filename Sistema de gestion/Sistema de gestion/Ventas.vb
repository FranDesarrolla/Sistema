Imports System.Data.SqlClient

Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaVentas()
        ModuloSistema.conexionSql.Open()
    End Sub
    Public Sub llenarGrillaVentas()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtventa") Then
            setdedatos.Tables("dtventa").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT * FROM [Notas De Ventas]"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtventa As New DataTable
        adaptadorSql.Fill(setdedatos, "dtventa")
        GrillaVentas.DataSource = setdedatos.Tables("dtventa")



        'For Each i As Integer In New Integer() {3, 5, 6, 7, 8, 9, 11, 13, 14, 15, 19, 20, 21}
        'GrillaPacientes.Columns(i).Visible = False
        ' Next



    End Sub
End Class