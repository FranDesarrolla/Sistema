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
        PanelSuperior = New Panel()
        brnRestaurar = New PictureBox()
        btnMinimizar = New PictureBox()
        btnMaximizar = New PictureBox()
        btnCerrar = New PictureBox()
        PanelLateral = New Panel()
        Panel7 = New Panel()
        Button7 = New Button()
        Panel6 = New Panel()
        Button6 = New Button()
        Panel5 = New Panel()
        Button5 = New Button()
        Panel4 = New Panel()
        Button4 = New Button()
        Panel3 = New Panel()
        btnClientes = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        Panel1 = New Panel()
        btnProductos = New Button()
        PictureBox1 = New PictureBox()
        PanelContenedor = New Panel()
        PanelSuperior.SuspendLayout()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelLateral.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSuperior
        ' 
        PanelSuperior.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
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
        ' brnRestaurar
        ' 
        brnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        brnRestaurar.Image = My.Resources.Resources.minimizar
        brnRestaurar.Location = New Point(1241, 8)
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
        PanelLateral.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        PanelLateral.Controls.Add(Panel7)
        PanelLateral.Controls.Add(Button7)
        PanelLateral.Controls.Add(Panel6)
        PanelLateral.Controls.Add(Button6)
        PanelLateral.Controls.Add(Panel5)
        PanelLateral.Controls.Add(Button5)
        PanelLateral.Controls.Add(Panel4)
        PanelLateral.Controls.Add(Button4)
        PanelLateral.Controls.Add(Panel3)
        PanelLateral.Controls.Add(btnClientes)
        PanelLateral.Controls.Add(Panel2)
        PanelLateral.Controls.Add(Button2)
        PanelLateral.Controls.Add(Panel1)
        PanelLateral.Controls.Add(btnProductos)
        PanelLateral.Controls.Add(PictureBox1)
        PanelLateral.Dock = DockStyle.Left
        PanelLateral.Location = New Point(0, 39)
        PanelLateral.Name = "PanelLateral"
        PanelLateral.Size = New Size(231, 611)
        PanelLateral.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel7.Location = New Point(3, 413)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(5, 32)
        Panel7.TabIndex = 11
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(12, 413)
        Button7.Name = "Button7"
        Button7.Size = New Size(219, 32)
        Button7.TabIndex = 12
        Button7.Text = "Reportes"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel6.Location = New Point(3, 375)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 32)
        Panel6.TabIndex = 9
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(12, 375)
        Button6.Name = "Button6"
        Button6.Size = New Size(219, 32)
        Button6.TabIndex = 10
        Button6.Text = "Pagos"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel5.Location = New Point(3, 337)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 32)
        Panel5.TabIndex = 7
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(12, 337)
        Button5.Name = "Button5"
        Button5.Size = New Size(219, 32)
        Button5.TabIndex = 8
        Button5.Text = "Compras"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel4.Location = New Point(3, 299)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(5, 32)
        Panel4.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(12, 299)
        Button4.Name = "Button4"
        Button4.Size = New Size(219, 32)
        Button4.TabIndex = 6
        Button4.Text = "Pedidos"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel3.Location = New Point(3, 261)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(5, 32)
        Panel3.TabIndex = 3
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.ForeColor = Color.White
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(12, 261)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(219, 32)
        btnClientes.TabIndex = 4
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel2.Location = New Point(3, 223)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 32)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(12, 223)
        Button2.Name = "Button2"
        Button2.Size = New Size(219, 32)
        Button2.TabIndex = 2
        Button2.Text = "Ventas"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        Panel1.Location = New Point(3, 185)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 32)
        Panel1.TabIndex = 0
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.FromArgb(CByte(26), CByte(32), CByte(40))
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(200))
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnProductos.ForeColor = Color.White
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(12, 185)
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(219, 32)
        btnProductos.TabIndex = 0
        btnProductos.Text = "Productos"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.FamilyCannVerde
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(231, 164)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(82))
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(231, 39)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1069, 611)
        PanelContenedor.TabIndex = 2
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
        Text = "ModuloPrincipal"
        PanelSuperior.ResumeLayout(False)
        CType(brnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelLateral.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents brnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnProductos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClientes As Button
End Class
