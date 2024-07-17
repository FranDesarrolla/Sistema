Imports System.Data.SqlClient
Public Class Usuarios
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim patron As String = "Gesnet"

        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        Else
            Dim consultaSQL As String = "EXEC dbo.SP_AgregarUsuario @Usuario, @Password, @Patron"
            Using connection As New SqlConnection(conexionSql.ConnectionString),
                command As New SqlCommand(consultaSQL, connection)
                command.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text)
                command.Parameters.AddWithValue("@Patron", patron)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Usuario creado exitosamente", MsgBoxStyle.Information, "Éxito")
                Catch ex As Exception
                    ' Manejar errores de ejecución de consulta
                    MsgBox("Error al ejecutar la consulta: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    connection.Close() ' Asegúrate de cerrar la conexión
                End Try
            End Using
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtUsuario.Text = "" Then
            MsgBox("Debe ingresar el nombre de usuario", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        Else
            Dim consultaSQL As String = "DELETE FROM dbo.Usuarios WHERE Usuario = @Usuario"
            Using connection As New SqlConnection(conexionSql.ConnectionString),
                command As New SqlCommand(consultaSQL, connection)
                command.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                Try
                    connection.Open()
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MsgBox("Usuario eliminado exitosamente", MsgBoxStyle.Information, "Éxito")
                    Else
                        MsgBox("Usuario no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                Catch ex As Exception
                    ' Manejar errores de ejecución de consulta
                    MsgBox("Error al ejecutar la consulta: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    connection.Close() ' Asegúrate de cerrar la conexión
                End Try
            End Using
        End If
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
