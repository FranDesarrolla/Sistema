Imports System.Data.SqlClient
Imports System.IO

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSistema.CargarCadenaConexion()
        RutaDelLogoDelSistema()
    End Sub

    Public Sub RutaDelLogoDelSistema()
        Dim rutaProyecto As String = Application.StartupPath
        Dim nombreArchivo As String = "gesnet.png"
        Dim rutaImagen As String = Path.Combine(rutaProyecto, nombreArchivo)
        PBLogo.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim patron As String = "Gesnet"

        If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        Else
            Dim consultassql As String = "EXEC dbo.SP_ValidarUsuario @Usuario, @Password, @Patron"
            Using connection As New SqlConnection(conexionSql.ConnectionString),
                command As New SqlCommand(consultassql, connection)
                command.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                command.Parameters.AddWithValue("@Password", txtContraseña.Text)
                command.Parameters.AddWithValue("@Patron", patron)
                Try
                    connection.Open()
                    Dim resultadoConsulta As Object = command.ExecuteScalar()
                    If resultadoConsulta IsNot Nothing Then
                        ' El inicio de sesión fue exitoso, establece DialogResult.OK y cierra el formulario de inicio de sesión
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation, "Advertencia")
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

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text.Length = 1 Then
            txtUsuario.Text = txtUsuario.Text.Substring(0, 1).ToUpper()
            txtUsuario.SelectionStart = txtUsuario.Text.Length
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIngresar.PerformClick()
        End If
    End Sub
End Class