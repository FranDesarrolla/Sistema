<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnIngresar = New Button()
        PBLogo = New PictureBox()
        PanelUsuario = New Panel()
        txtUsuario = New TextBox()
        lblUsuario = New Label()
        btnCancelar = New Button()
        PanelContraseña = New Panel()
        lblContraseña = New Label()
        txtContraseña = New TextBox()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelUsuario.SuspendLayout()
        PanelContraseña.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.Tan
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnIngresar.Location = New Point(110, 108)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(142, 31)
        btnIngresar.TabIndex = 25
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' PBLogo
        ' 
        PBLogo.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        PBLogo.Location = New Point(11, 11)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(88, 88)
        PBLogo.SizeMode = PictureBoxSizeMode.Zoom
        PBLogo.TabIndex = 27
        PBLogo.TabStop = False
        ' 
        ' PanelUsuario
        ' 
        PanelUsuario.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        PanelUsuario.Controls.Add(txtUsuario)
        PanelUsuario.Controls.Add(lblUsuario)
        PanelUsuario.Location = New Point(110, 11)
        PanelUsuario.Name = "PanelUsuario"
        PanelUsuario.Size = New Size(289, 41)
        PanelUsuario.TabIndex = 23
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.White
        txtUsuario.BorderStyle = BorderStyle.None
        txtUsuario.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsuario.ForeColor = Color.Black
        txtUsuario.Location = New Point(102, 10)
        txtUsuario.Margin = New Padding(0)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(178, 20)
        txtUsuario.TabIndex = 1
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuario.Location = New Point(8, 12)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(59, 19)
        lblUsuario.TabIndex = 5
        lblUsuario.Text = "Usuario:"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Tan
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(257, 108)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(142, 31)
        btnCancelar.TabIndex = 26
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' PanelContraseña
        ' 
        PanelContraseña.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        PanelContraseña.Controls.Add(lblContraseña)
        PanelContraseña.Controls.Add(txtContraseña)
        PanelContraseña.Location = New Point(110, 58)
        PanelContraseña.Name = "PanelContraseña"
        PanelContraseña.Size = New Size(289, 41)
        PanelContraseña.TabIndex = 24
        ' 
        ' lblContraseña
        ' 
        lblContraseña.AutoSize = True
        lblContraseña.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblContraseña.Location = New Point(8, 11)
        lblContraseña.Name = "lblContraseña"
        lblContraseña.Size = New Size(82, 19)
        lblContraseña.TabIndex = 7
        lblContraseña.Text = "Contraseña:"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.BackColor = Color.White
        txtContraseña.BorderStyle = BorderStyle.None
        txtContraseña.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtContraseña.ForeColor = Color.Black
        txtContraseña.Location = New Point(102, 9)
        txtContraseña.Margin = New Padding(0)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(178, 20)
        txtContraseña.TabIndex = 2
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(410, 150)
        ControlBox = False
        Controls.Add(btnIngresar)
        Controls.Add(PBLogo)
        Controls.Add(PanelUsuario)
        Controls.Add(btnCancelar)
        Controls.Add(PanelContraseña)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelUsuario.ResumeLayout(False)
        PanelUsuario.PerformLayout()
        PanelContraseña.ResumeLayout(False)
        PanelContraseña.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnIngresar As Button
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PanelContraseña As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
End Class
