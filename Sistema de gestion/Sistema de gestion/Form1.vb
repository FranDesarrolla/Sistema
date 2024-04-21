Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ModuloPrincipal
    Private Sub ModuloPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Muestra el formulario de inicio de sesión
        Dim loginForm As New Login()
        loginForm.ShowDialog()

        ' Oculta este formulario (ModuloPrincipal) solo si el inicio de sesión fue exitoso
        If loginForm.DialogResult = DialogResult.OK Then
            Me.Hide()
        Else
            ' Si el inicio de sesión falló o se cerró el formulario de inicio de sesión, cierra la aplicación
            Application.Exit()
            Return
        End If

        RutaDelLogoDelSistema()
        notificacion()
        ModuloSistema.CargarCadenaConexion()
        LlenarComboBoxPV()

        lblUsuario.Text = loginForm.txtUsuario.Text

        cbModo.Items.Add("Claro")
        cbModo.Items.Add("Oscuro")

    End Sub

    Public Sub RutaDelLogoDelSistema()
        Dim rutaProyecto As String = Application.StartupPath

        Dim nombreArchivo As String = "copyright.png"
        Dim rutaImagen As String = Path.Combine(rutaProyecto, nombreArchivo)

        PBcopy.Image = Image.FromFile(rutaImagen)
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

    Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh

        ' Verificar si la conexión está abierta
        If ModuloSistema.conexionSql.State = ConnectionState.Open Then
            ModuloSistema.conexionSql.Close() ' Si está abierta, cerrar la conexión
        End If

        ' Abrir la conexión
        ModuloSistema.conexionSql.Open()

        fh.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormEnPanel(New Productos)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(New Clientes)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormEnPanel(New Ventas)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        AbrirFormEnPanel(New Pedidos)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormEnPanel(New Compras)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        AbrirFormEnPanel(New Pagos)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        AbrirFormEnPanel(New Proveedores)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private WithEvents timer As New Timer()
    Private limiteFinal As Integer = 1200 ' Ajusta este valor según tu límite final

    Private Sub notificacion()
        ' Configuración del temporizador
        timer.Interval = 10 ' Intervalo en milisegundos
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Mueve la notificación hacia la derecha
        LabelNotificacion.Left += 5 ' Puedes ajustar la velocidad cambiando este valor

        ' Verifica si la notificación ha alcanzado el extremo derecho del panel
        If LabelNotificacion.Right >= limiteFinal Then
            ' Detén el temporizador y cierra el formulario cuando la notificación alcanza el límite
            timer.Stop()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Notificaciones.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(New Reportes)
        ModuloSistema.conexionSql.Close()
    End Sub

    Public Sub LlenarComboBoxPV()
        Dim query As String = "SELECT IDPuntoVenta, PuntoDeVenta, Descripcion, NumeracionFacturaA, NumeracionFacturaB, NumeracionNDebitoA, NumeracionNDebitoB, NumeracionNCreditoA, NumeracionNCreditoB FROM PuntosDeVentas"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim dtPV As New DataTable
        adaptadorSql.Fill(dtPV)
        boxPV.DataSource = dtPV
        boxPV.DisplayMember = "PuntoDeVenta"
    End Sub

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModo.SelectedIndexChanged
        Select Case cbModo.SelectedIndex
            Case 0 ' Modo Claro
                CambiarPaletaClaro()
            Case 1 ' Modo Oscuro
                CambiarPaletaOscuro()
        End Select
    End Sub
End Class
