﻿Imports System.IO
Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class ModuloPrincipal

    Private Sub ModuloPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notificacion()
        'Abro la cadena de conexion para poder llegar a la base de datos
        Try
            conexionSql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=base_sistema_gestion;Data Source=DESKTOP-P7RK5LC\SQLEXPRESS01"
            conexionSql.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        brnRestaurar.Visible = True
    End Sub

    Private Sub brnRestaurar_Click(sender As Object, e As EventArgs) Handles brnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        brnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormEnPanel(New Productos)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(New Clientes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New Ventas)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(New Pedidos)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(New Compras)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel(New Pagos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private WithEvents timer As New Timer()

    Private Sub notificacion()
        ' Configuración del temporizador
        timer.Interval = 10 ' Intervalo en milisegundos
        timer.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Mueve la notificación hacia la derecha
        LabelNotificacion.Left += 5 ' Puedes ajustar la velocidad cambiando este valor

        ' Verifica si la notificación ha alcanzado el extremo derecho del panel
        If LabelNotificacion.Right >= PanelSuperior.Right Then
            ' Detén el temporizador y cierra el formulario cuando la notificación se ha movido completamente
            timer.Stop()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Notificaciones.Show()

    End Sub
End Class