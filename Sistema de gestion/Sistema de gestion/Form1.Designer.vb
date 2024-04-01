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
        components = New ComponentModel.Container()
        PanelSuperior = New Panel()
        PictureBox2 = New PictureBox()
        LabelNotificacion = New Label()
        brnRestaurar = New PictureBox()
        btnMinimizar = New PictureBox()
        btnMaximizar = New PictureBox()
        btnCerrar = New PictureBox()
        PanelLateral = New Panel()
        Panel9 = New Panel()
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        btnClientes = New Button()
        Button2 = New Button()
        btnProductos = New Button()
        PBLogo = New PictureBox()
        Timer1 = New Timer(components)
        PanelContenedor = New Panel()
        PanelSuperior.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelLateral.SuspendLayout()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSuperior
        ' 
        PanelSuperior.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        PanelSuperior.Controls.Add(PictureBox2)
        PanelSuperior.Controls.Add(LabelNotificacion)
        PanelSuperior.Controls.Add(brnRestaurar)
        PanelSuperior.Controls.Add(btnMinimizar)
        PanelSuperior.Controls.Add(btnMaximizar)
        PanelSuperior.Controls.Add(btnCerrar)
        PanelSuperior.Dock = DockStyle.Top
        PanelSuperior.Location = New Point(0, 0)
        PanelSuperior.Name = "PanelSuperior"
        PanelSuperior.Size = New Size(1300, 39)
        PanelSuperior.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.timbre_de_llamada
        PictureBox2.Location = New Point(12, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' LabelNotificacion
        ' 
        LabelNotificacion.AutoSize = True
        LabelNotificacion.Enabled = False
        LabelNotificacion.Location = New Point(157, 18)
        LabelNotificacion.Name = "LabelNotificacion"
        LabelNotificacion.Size = New Size(41, 15)
        LabelNotificacion.TabIndex = 2
        LabelNotificacion.Text = "Label1"
        LabelNotificacion.Visible = False
        ' 
        ' brnRestaurar
        ' 
        brnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        brnRestaurar.BackColor = Color.White
        brnRestaurar.Image = My.Resources.Resources.minimizar
        brnRestaurar.Location = New Point(1241, 7)
        brnRestaurar.Name = "brnRestaurar"
        brnRestaurar.Size = New Size(25, 25)
        brnRestaurar.SizeMode = PictureBoxSizeMode.Zoom
        brnRestaurar.TabIndex = 1
        brnRestaurar.TabStop = False
        brnRestaurar.Visible = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.White
        btnMinimizar.Image = My.Resources.Resources.menos
        btnMinimizar.Location = New Point(1210, 8)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(25, 25)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 1
        btnMinimizar.TabStop = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Image = My.Resources.Resources.cuadrado
        btnMaximizar.Location = New Point(1241, 8)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(25, 25)
        btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMaximizar.TabIndex = 1
        btnMaximizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.White
        btnCerrar.Image = My.Resources.Resources.letra_x
        btnCerrar.Location = New Point(1272, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 0
        btnCerrar.TabStop = False
        ' 
        ' PanelLateral
        ' 
        PanelLateral.BackColor = Color.Tan
        PanelLateral.Controls.Add(Panel9)
        PanelLateral.Controls.Add(Button1)
        PanelLateral.Controls.Add(Button7)
        PanelLateral.Controls.Add(Button6)
        PanelLateral.Controls.Add(Button5)
        PanelLateral.Controls.Add(Button4)
        PanelLateral.Controls.Add(btnClientes)
        PanelLateral.Controls.Add(Button2)
        PanelLateral.Controls.Add(btnProductos)
        PanelLateral.Controls.Add(PBLogo)
        PanelLateral.Dock = DockStyle.Left
        PanelLateral.Location = New Point(0, 39)
        PanelLateral.Name = "PanelLateral"
        PanelLateral.Size = New Size(231, 611)
        PanelLateral.TabIndex = 1
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Tan
        Panel9.Dock = DockStyle.Bottom
        Panel9.Location = New Point(0, 530)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(231, 81)
        Panel9.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tan
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 479)
        Button1.Name = "Button1"
        Button1.Size = New Size(231, 45)
        Button1.TabIndex = 107
        Button1.Text = "Proveedores"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Tan
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.Black
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(0, 434)
        Button7.Name = "Button7"
        Button7.Size = New Size(231, 45)
        Button7.TabIndex = 106
        Button7.Text = "Reportes"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Tan
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = Color.Black
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 389)
        Button6.Name = "Button6"
        Button6.Size = New Size(231, 45)
        Button6.TabIndex = 105
        Button6.Text = "Pagos"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Tan
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.Black
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(0, 344)
        Button5.Name = "Button5"
        Button5.Size = New Size(231, 45)
        Button5.TabIndex = 104
        Button5.Text = "Compras"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Tan
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(0, 299)
        Button4.Name = "Button4"
        Button4.Size = New Size(231, 45)
        Button4.TabIndex = 103
        Button4.Text = "Pedidos"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.Tan
        btnClientes.Dock = DockStyle.Top
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.ForeColor = Color.Black
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(0, 254)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(231, 45)
        btnClientes.TabIndex = 102
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tan
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 209)
        Button2.Name = "Button2"
        Button2.Size = New Size(231, 45)
        Button2.TabIndex = 101
        Button2.Text = "Ventas"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.Tan
        btnProductos.Dock = DockStyle.Top
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnProductos.ForeColor = Color.Black
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(0, 164)
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(231, 45)
        btnProductos.TabIndex = 100
        btnProductos.Text = "Productos"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' PBLogo
        ' 
        PBLogo.BackColor = Color.Tan
        PBLogo.Dock = DockStyle.Top
        PBLogo.Location = New Point(0, 0)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(231, 164)
        PBLogo.SizeMode = PictureBoxSizeMode.Zoom
        PBLogo.TabIndex = 0
        PBLogo.TabStop = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(231, 39)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1069, 611)
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelLateral.ResumeLayout(False)
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents brnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnProductos As Button
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LabelNotificacion As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelContenedor As Panel
End Class
