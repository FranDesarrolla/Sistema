Imports System.Data.SqlClient

Public Class Notificaciones
    Private Sub Notificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarGrillaNotificaciones()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LlenarGrillaNotificaciones()
        'Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtNotificaciones") Then
            setdedatos.Tables("dtNotificaciones").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT id_notificacion AS Codigo,mensaje FROM notificaciones"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtNotificaciones As New DataTable
        adaptadorSql.Fill(setdedatos, "dtNotificaciones")
        GrillaNotificaciones.DataSource = setdedatos.Tables("dtNotificaciones")
        GrillaNotificaciones.Font = New Font("Arial", 10)

        GrillaNotificaciones.Columns(0).Visible = False

        For i As Integer = 0 To 1
            GrillaNotificaciones.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

    End Sub

    Private Sub btnCerrarNotificaciones_Click(sender As Object, e As EventArgs) Handles btnCerrarNotificaciones.Click
        Close()
    End Sub
End Class