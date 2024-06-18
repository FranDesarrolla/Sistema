Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ModuloPrincipal
    Private Sub ModuloPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ModuloSistema.CargarCadenaConexion()

        Dim loginForm As New Login()
        loginForm.ShowDialog()

        If loginForm.DialogResult = DialogResult.OK Then
            Me.Hide()
        Else
            Application.Exit()
            Return
        End If

        InicializarComponentes()
        lblUsuario.Text = loginForm.txtUsuario.Text
    End Sub

    Private Sub InicializarComponentes()
        RutaDelLogoDelSistema()
        notificacion()
        LlenarComboBoxPV()
        InicializarModo()
    End Sub

    Private Sub InicializarModo()
        cbModo.Items.AddRange(New String() {"Claro", "Oscuro"})
    End Sub

    Public Sub RutaDelLogoDelSistema()
        Dim rutaImagen As String = Path.Combine(Application.StartupPath, "copyright.png")
        PBcopy.Image = Image.FromFile(rutaImagen)
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

    Public Sub AbrirFormEnPanel(ByVal formHijo As Form)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If

        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(formHijo)
        Me.PanelContenedor.Tag = formHijo

        formHijo.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Me.AbrirFormEnPanel(Productos)
    End Sub


    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(Clientes)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormEnPanel(Ventas)
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        AbrirFormEnPanel(Pedidos)
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormEnPanel(Compras)
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        AbrirFormEnPanel(Pagos)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        AbrirFormEnPanel(Proveedores)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(Reportes)
    End Sub

    Private WithEvents timer As New Timer()
    Private limiteFinal As Integer = 1200 ' Ajusta este valor según tu límite final

    Private Sub notificacion()
        timer.Interval = 10 ' Intervalo en milisegundos
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        LabelNotificacion.Left += 5 ' Puedes ajustar la velocidad cambiando este valor
        If LabelNotificacion.Right >= limiteFinal Then
            timer.Stop()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Notificaciones.Show()
    End Sub

    Public Sub LlenarComboBoxPV()
        Dim query As String = "SELECT IDPuntoVenta, PuntoDeVenta FROM PuntosDeVentas"
        Using adaptadorSql As New SqlDataAdapter(query, ModuloSistema.conexionSql)
            Dim dtPV As New DataTable
            adaptadorSql.Fill(dtPV)
            boxPV.DataSource = dtPV
            boxPV.DisplayMember = "PuntoDeVenta"
        End Using
    End Sub

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModo.SelectedIndexChanged
        Select Case cbModo.SelectedIndex
            Case 0 ' Modo Claro
                CambiarPaletaClaro()
            Case 1 ' Modo Oscuro
                CambiarPaletaOscuro()
        End Select
    End Sub

    Private Sub CambiarPaletaClaro()
        ' Implementa el cambio a modo claro
    End Sub

    Private Sub CambiarPaletaOscuro()
        ' Implementa el cambio a modo oscuro
    End Sub

End Class
