<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloPrincipal))
        PanelSuperior = New Panel()
        cbModo = New ComboBox()
        PBcopy = New PictureBox()
        btnUser = New PictureBox()
        boxPV = New ComboBox()
        lblUsuario = New Label()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        PanelLateral = New Panel()
        btnReportes = New Button()
        btnPagos = New Button()
        btnCompras = New Button()
        btnProveedores = New Button()
        btnVentas = New Button()
        btnClientes = New Button()
        btnSesion = New Button()
        btnPedidos = New Button()
        btnProductos = New Button()
        btnMaximizar = New PictureBox()
        brnRestaurar = New PictureBox()
        PictureBox2 = New PictureBox()
        LabelNotificacion = New Label()
        PanelContenedor = New Panel()
        PanelSuperior.SuspendLayout()
        CType(PBcopy, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelLateral.SuspendLayout()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSuperior
        ' 
        PanelSuperior.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        PanelSuperior.Controls.Add(cbModo)
        PanelSuperior.Controls.Add(PBcopy)
        PanelSuperior.Controls.Add(btnUser)
        PanelSuperior.Controls.Add(boxPV)
        PanelSuperior.Controls.Add(lblUsuario)
        PanelSuperior.Controls.Add(btnMinimizar)
        PanelSuperior.Controls.Add(btnCerrar)
        PanelSuperior.Dock = DockStyle.Top
        PanelSuperior.Location = New Point(0, 0)
        PanelSuperior.Name = "PanelSuperior"
        PanelSuperior.Size = New Size(1300, 46)
        PanelSuperior.TabIndex = 0
        ' 
        ' cbModo
        ' 
        cbModo.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        cbModo.FlatStyle = FlatStyle.Popup
        cbModo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbModo.FormattingEnabled = True
        cbModo.ItemHeight = 17
        cbModo.Location = New Point(1059, 10)
        cbModo.Name = "cbModo"
        cbModo.Size = New Size(78, 25)
        cbModo.TabIndex = 30
        cbModo.TabStop = False
        ' 
        ' PBcopy
        ' 
        PBcopy.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        PBcopy.Location = New Point(0, 0)
        PBcopy.Name = "PBcopy"
        PBcopy.Size = New Size(231, 46)
        PBcopy.SizeMode = PictureBoxSizeMode.Zoom
        PBcopy.TabIndex = 4
        PBcopy.TabStop = False
        ' 
        ' btnUser
        ' 
        btnUser.BackgroundImageLayout = ImageLayout.Zoom
        btnUser.Image = CType(resources.GetObject("btnUser.Image"), Image)
        btnUser.Location = New Point(237, 10)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(25, 25)
        btnUser.SizeMode = PictureBoxSizeMode.StretchImage
        btnUser.TabIndex = 4
        btnUser.TabStop = False
        ' 
        ' boxPV
        ' 
        boxPV.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        boxPV.FlatStyle = FlatStyle.Popup
        boxPV.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxPV.FormattingEnabled = True
        boxPV.ItemHeight = 17
        boxPV.Location = New Point(1142, 10)
        boxPV.Name = "boxPV"
        boxPV.Size = New Size(78, 25)
        boxPV.TabIndex = 0
        boxPV.TabStop = False
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuario.Location = New Point(262, 11)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(64, 21)
        lblUsuario.TabIndex = 4
        lblUsuario.Text = "Usuario"
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.Transparent
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(1230, 10)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(25, 25)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 1
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.Transparent
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(1263, 10)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 0
        btnCerrar.TabStop = False
        ' 
        ' PanelLateral
        ' 
        PanelLateral.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        PanelLateral.Controls.Add(btnReportes)
        PanelLateral.Controls.Add(btnPagos)
        PanelLateral.Controls.Add(btnCompras)
        PanelLateral.Controls.Add(btnProveedores)
        PanelLateral.Controls.Add(btnVentas)
        PanelLateral.Controls.Add(btnClientes)
        PanelLateral.Controls.Add(btnSesion)
        PanelLateral.Controls.Add(btnPedidos)
        PanelLateral.Controls.Add(btnProductos)
        PanelLateral.Dock = DockStyle.Left
        PanelLateral.Location = New Point(0, 46)
        PanelLateral.Name = "PanelLateral"
        PanelLateral.Size = New Size(231, 604)
        PanelLateral.TabIndex = 1
        ' 
        ' btnReportes
        ' 
        btnReportes.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnReportes.Dock = DockStyle.Top
        btnReportes.FlatAppearance.BorderSize = 0
        btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnReportes.ForeColor = Color.Black
        btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), Image)
        btnReportes.ImageAlign = ContentAlignment.MiddleLeft
        btnReportes.Location = New Point(0, 385)
        btnReportes.Name = "btnReportes"
        btnReportes.Padding = New Padding(20, 0, 0, 0)
        btnReportes.Size = New Size(231, 55)
        btnReportes.TabIndex = 115
        btnReportes.TabStop = False
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = False
        ' 
        ' btnPagos
        ' 
        btnPagos.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnPagos.Dock = DockStyle.Top
        btnPagos.FlatAppearance.BorderSize = 0
        btnPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnPagos.FlatStyle = FlatStyle.Flat
        btnPagos.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPagos.ForeColor = Color.Black
        btnPagos.Image = CType(resources.GetObject("btnPagos.Image"), Image)
        btnPagos.ImageAlign = ContentAlignment.MiddleLeft
        btnPagos.Location = New Point(0, 330)
        btnPagos.Name = "btnPagos"
        btnPagos.Padding = New Padding(20, 0, 0, 0)
        btnPagos.Size = New Size(231, 55)
        btnPagos.TabIndex = 114
        btnPagos.TabStop = False
        btnPagos.Text = "Pagos"
        btnPagos.UseVisualStyleBackColor = False
        ' 
        ' btnCompras
        ' 
        btnCompras.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnCompras.Dock = DockStyle.Top
        btnCompras.FlatAppearance.BorderSize = 0
        btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnCompras.FlatStyle = FlatStyle.Flat
        btnCompras.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCompras.ForeColor = Color.Black
        btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), Image)
        btnCompras.ImageAlign = ContentAlignment.MiddleLeft
        btnCompras.Location = New Point(0, 275)
        btnCompras.Name = "btnCompras"
        btnCompras.Padding = New Padding(20, 0, 0, 0)
        btnCompras.Size = New Size(231, 55)
        btnCompras.TabIndex = 113
        btnCompras.TabStop = False
        btnCompras.Text = "Compras"
        btnCompras.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnProveedores.Dock = DockStyle.Top
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnProveedores.ForeColor = Color.Black
        btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), Image)
        btnProveedores.ImageAlign = ContentAlignment.MiddleLeft
        btnProveedores.Location = New Point(0, 220)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Padding = New Padding(20, 0, 0, 0)
        btnProveedores.Size = New Size(231, 55)
        btnProveedores.TabIndex = 112
        btnProveedores.TabStop = False
        btnProveedores.Text = "Proveedores"
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnVentas.Dock = DockStyle.Top
        btnVentas.FlatAppearance.BorderSize = 0
        btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnVentas.FlatStyle = FlatStyle.Flat
        btnVentas.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnVentas.ForeColor = Color.Black
        btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), Image)
        btnVentas.ImageAlign = ContentAlignment.MiddleLeft
        btnVentas.Location = New Point(0, 165)
        btnVentas.Name = "btnVentas"
        btnVentas.Padding = New Padding(20, 0, 0, 0)
        btnVentas.Size = New Size(231, 55)
        btnVentas.TabIndex = 111
        btnVentas.TabStop = False
        btnVentas.Text = "Ventas"
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnClientes.Dock = DockStyle.Top
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.ForeColor = Color.Black
        btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), Image)
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(0, 110)
        btnClientes.Name = "btnClientes"
        btnClientes.Padding = New Padding(20, 0, 0, 0)
        btnClientes.Size = New Size(231, 55)
        btnClientes.TabIndex = 110
        btnClientes.TabStop = False
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnSesion
        ' 
        btnSesion.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnSesion.BackgroundImageLayout = ImageLayout.None
        btnSesion.Dock = DockStyle.Bottom
        btnSesion.FlatAppearance.BorderSize = 0
        btnSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnSesion.FlatStyle = FlatStyle.Flat
        btnSesion.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSesion.ForeColor = Color.Black
        btnSesion.Image = CType(resources.GetObject("btnSesion.Image"), Image)
        btnSesion.ImageAlign = ContentAlignment.MiddleLeft
        btnSesion.Location = New Point(0, 549)
        btnSesion.Name = "btnSesion"
        btnSesion.Padding = New Padding(20, 0, 0, 0)
        btnSesion.Size = New Size(231, 55)
        btnSesion.TabIndex = 108
        btnSesion.TabStop = False
        btnSesion.Text = "Cerrar sesión"
        btnSesion.UseVisualStyleBackColor = False
        ' 
        ' btnPedidos
        ' 
        btnPedidos.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnPedidos.Dock = DockStyle.Top
        btnPedidos.FlatAppearance.BorderSize = 0
        btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnPedidos.FlatStyle = FlatStyle.Flat
        btnPedidos.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPedidos.ForeColor = Color.Black
        btnPedidos.Image = CType(resources.GetObject("btnPedidos.Image"), Image)
        btnPedidos.ImageAlign = ContentAlignment.MiddleLeft
        btnPedidos.Location = New Point(0, 55)
        btnPedidos.Name = "btnPedidos"
        btnPedidos.Padding = New Padding(20, 0, 0, 0)
        btnPedidos.Size = New Size(231, 55)
        btnPedidos.TabIndex = 103
        btnPedidos.TabStop = False
        btnPedidos.Text = "Pedidos"
        btnPedidos.UseVisualStyleBackColor = False
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        btnProductos.Dock = DockStyle.Top
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnProductos.ForeColor = Color.Black
        btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), Image)
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(0, 0)
        btnProductos.Name = "btnProductos"
        btnProductos.Padding = New Padding(20, 0, 0, 0)
        btnProductos.Size = New Size(231, 55)
        btnProductos.TabIndex = 100
        btnProductos.TabStop = False
        btnProductos.Text = "Productos"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Enabled = False
        btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), Image)
        btnMaximizar.Location = New Point(886, 11)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(25, 25)
        btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMaximizar.TabIndex = 1
        btnMaximizar.TabStop = False
        btnMaximizar.Visible = False
        ' 
        ' brnRestaurar
        ' 
        brnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        brnRestaurar.BackColor = Color.Transparent
        brnRestaurar.Enabled = False
        brnRestaurar.Image = CType(resources.GetObject("brnRestaurar.Image"), Image)
        brnRestaurar.Location = New Point(917, 11)
        brnRestaurar.Name = "brnRestaurar"
        brnRestaurar.Size = New Size(25, 25)
        brnRestaurar.SizeMode = PictureBoxSizeMode.Zoom
        brnRestaurar.TabIndex = 1
        brnRestaurar.TabStop = False
        brnRestaurar.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Enabled = False
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(948, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' LabelNotificacion
        ' 
        LabelNotificacion.AutoSize = True
        LabelNotificacion.Enabled = False
        LabelNotificacion.Location = New Point(979, 11)
        LabelNotificacion.Name = "LabelNotificacion"
        LabelNotificacion.Size = New Size(41, 15)
        LabelNotificacion.TabIndex = 2
        LabelNotificacion.Text = "Label1"
        LabelNotificacion.Visible = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.Tan
        PanelContenedor.Controls.Add(LabelNotificacion)
        PanelContenedor.Controls.Add(PictureBox2)
        PanelContenedor.Controls.Add(brnRestaurar)
        PanelContenedor.Controls.Add(btnMaximizar)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(231, 46)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1069, 604)
        PanelContenedor.TabIndex = 3
        ' 
        ' ModuloPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1300, 650)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelLateral)
        Controls.Add(PanelSuperior)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModuloPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "344"
        PanelSuperior.ResumeLayout(False)
        PanelSuperior.PerformLayout()
        CType(PBcopy, ComponentModel.ISupportInitialize).EndInit()
        CType(btnUser, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelLateral.ResumeLayout(False)
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        PanelContenedor.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnPedidos As Button
    Friend WithEvents boxPV As ComboBox
    Friend WithEvents btnSesion As Button
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnUser As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PBcopy As PictureBox
    Friend WithEvents cbModo As ComboBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents brnRestaurar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelNotificacion As Label
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnProveedores As Button
End Class
