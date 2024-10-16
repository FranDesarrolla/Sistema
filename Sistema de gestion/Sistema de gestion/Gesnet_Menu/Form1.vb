Imports System.Data.SqlClient
Imports System.IO

Public Class ModuloPrincipal
    Private Sub ModuloPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSistema.CargarCadenaConexion()

        Using loginForm As New Login()
            If loginForm.ShowDialog() <> DialogResult.OK Then
                Application.Exit()
                Return
            End If
            lblUsuario.Text = loginForm.txtUsuario.Text
        End Using

        InicializarComponentes()
        CargarConfiguracion()
    End Sub

    Private Sub CargarConfiguracion()
        Dim rutaConfig As String = "configuracion.ini"
        If IO.File.Exists(rutaConfig) Then
            Dim modoOscuro As Boolean = False
            Using sr As New IO.StreamReader(rutaConfig)
                Dim linea As String = sr.ReadLine()
                modoOscuro = Boolean.Parse(linea.Split("="c)(1))
            End Using
            If modoOscuro Then
                cbModo.SelectedIndex = 1 ' Establecer en "Modo Oscuro"
                ModuloSistema.CambiarPaletaOscuro()
            Else
                cbModo.SelectedIndex = 0 ' Establecer en "Modo Claro"
                ModuloSistema.CambiarPaletaClaro()
            End If
        Else
            ' Si no existe el archivo de configuración, usar el modo claro por defecto
            cbModo.SelectedIndex = 0
            ModuloSistema.CambiarPaletaClaro()
        End If
    End Sub

    Private Sub InicializarComponentes()
        RutaDelLogoDelSistema()
        Notificacion()
        LlenarComboBoxPV()
        InicializarModo()
    End Sub

    Private Sub InicializarModo()
        cbModo.Items.AddRange(New String() {"Claro", "Oscuro"})
        cbModo.SelectedIndex = 0 ' Establece un valor predeterminado
    End Sub

    Public Sub RutaDelLogoDelSistema()
        Dim rutaImagen As String = Path.Combine(Application.StartupPath, "copyright.png")
        Using img As Image = Image.FromFile(rutaImagen)
            PBcopy.Image = img.Clone()
        End Using
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnMaximizarRestaurar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click, brnRestaurar.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            brnRestaurar.Visible = False
            btnMaximizar.Visible = True
        Else
            Me.WindowState = FormWindowState.Maximized
            btnMaximizar.Visible = False
            brnRestaurar.Visible = True
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub AbrirFormEnPanel(ByVal formHijo As Form)
        ' Limpiar controles previos en el panel
        Me.PanelContenedor.Controls.Clear()

        ' Configurar el nuevo formulario
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
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

    Private Sub Notificacion()
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
        Dim query As String = "SELECT ID, PuntoDeVenta FROM PuntosDeVentas"
        Using adaptadorSql As New SqlDataAdapter(query, ModuloSistema.conexionSql)
            Dim dtPV As New DataTable()
            adaptadorSql.Fill(dtPV)
            boxPV.DataSource = dtPV
            boxPV.DisplayMember = "PuntoDeVenta"
        End Using
    End Sub

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModo.SelectedIndexChanged
        Select Case cbModo.SelectedIndex
            Case 0 ' Modo Claro
                ModuloSistema.CambiarPaletaClaro()
                GuardarConfiguracion(False) ' Guardar modo claro en el archivo .ini
            Case 1 ' Modo Oscuro
                ModuloSistema.CambiarPaletaOscuro()
                GuardarConfiguracion(True) ' Guardar modo oscuro en el archivo .ini
        End Select
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Me.Hide()

        Using loginForm As New Login()
            If loginForm.ShowDialog() = DialogResult.OK Then
                lblUsuario.Text = loginForm.txtUsuario.Text
                Me.Show()
            Else
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        AbrirFormEnPanel(Usuarios)
    End Sub

    Private Sub GuardarConfiguracion(modoOscuro As Boolean)
        Dim rutaConfig As String = "Config.ini"
        Using sw As New IO.StreamWriter(rutaConfig)
            sw.WriteLine("ModoOscuro=" & modoOscuro.ToString())
        End Using
    End Sub

End Class