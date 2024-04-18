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
        Panel1 = New Panel()
        lblContraseña = New Label()
        txtContraseña = New TextBox()
        txtUsuario = New TextBox()
        lblUsuario = New Label()
        btnCancelar = New Button()
        Panel2 = New Panel()
        PBLogo = New PictureBox()
        btnIngresar = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Controls.Add(lblContraseña)
        Panel1.Controls.Add(txtContraseña)
        Panel1.Location = New Point(110, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 41)
        Panel1.TabIndex = 2
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
        btnCancelar.Location = New Point(257, 109)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(142, 31)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel2.Controls.Add(txtUsuario)
        Panel2.Controls.Add(lblUsuario)
        Panel2.Location = New Point(110, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(289, 41)
        Panel2.TabIndex = 1
        ' 
        ' PBLogo
        ' 
        PBLogo.BackColor = Color.Tan
        PBLogo.Location = New Point(11, 12)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(88, 88)
        PBLogo.SizeMode = PictureBoxSizeMode.Zoom
        PBLogo.TabIndex = 15
        PBLogo.TabStop = False
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.Tan
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnIngresar.Location = New Point(110, 109)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(142, 31)
        btnIngresar.TabIndex = 3
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
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
        Controls.Add(Panel2)
        Controls.Add(btnCancelar)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents btnIngresar As Button
End Class
