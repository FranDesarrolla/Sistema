<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Ventas
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
        ABM = New Label()
        txtCuenta = New TextBox()
        lblCliente = New Label()
        Panel1 = New Panel()
        Panel5 = New Panel()
        lblCod = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        lblEmpresa = New Label()
        Panel4 = New Panel()
        lblLetra = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        Panel6 = New Panel()
        btnVolver = New Button()
        Button2 = New Button()
        Label8 = New Label()
        lblNombre = New Label()
        lblNombreCliente = New Label()
        lblApellido = New Label()
        lblApellidoCliente = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' ABM
        ' 
        ABM.AutoSize = True
        ABM.Location = New Point(1016, 9)
        ABM.Name = "ABM"
        ABM.Size = New Size(41, 15)
        ABM.TabIndex = 0
        ABM.Text = "Label1"
        ABM.Visible = False
        ' 
        ' txtCuenta
        ' 
        txtCuenta.Location = New Point(75, 7)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(81, 23)
        txtCuenta.TabIndex = 4
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(25, 15)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(44, 15)
        lblCliente.TabIndex = 3
        lblCliente.Text = "Cliente"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblEmpresa)
        Panel1.Controls.Add(Panel4)
        Panel1.Location = New Point(29, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1013, 65)
        Panel1.TabIndex = 9
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(lblCod)
        Panel5.Location = New Point(470, 45)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(55, 19)
        Panel5.TabIndex = 12
        ' 
        ' lblCod
        ' 
        lblCod.AutoSize = True
        lblCod.Location = New Point(6, 1)
        lblCod.Name = "lblCod"
        lblCod.Size = New Size(41, 15)
        lblCod.TabIndex = 16
        lblCod.Text = "Cod. 0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(25, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 13)
        Label6.TabIndex = 17
        Label6.Text = "Velez Sarsfield 572 - Bell Ville - 2550 - Córdoba"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(559, 29)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(117, 23)
        TextBox4.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(559, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 15
        Label5.Text = "Fecha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(789, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(12, 15)
        Label4.TabIndex = 14
        Label4.Text = "-"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(803, 29)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(181, 23)
        TextBox3.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(803, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 13
        Label3.Text = "Comprobante"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(729, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(57, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(729, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 9
        Label2.Text = "Sucursal"
        ' 
        ' lblEmpresa
        ' 
        lblEmpresa.AutoSize = True
        lblEmpresa.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmpresa.Location = New Point(23, 9)
        lblEmpresa.Name = "lblEmpresa"
        lblEmpresa.Size = New Size(99, 21)
        lblEmpresa.TabIndex = 11
        lblEmpresa.Text = "FAMILYCAN"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lblLetra)
        Panel4.Location = New Point(476, -1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(43, 47)
        Panel4.TabIndex = 10
        ' 
        ' lblLetra
        ' 
        lblLetra.AutoSize = True
        lblLetra.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblLetra.ImageAlign = ContentAlignment.MiddleRight
        lblLetra.Location = New Point(2, -2)
        lblLetra.Name = "lblLetra"
        lblLetra.Size = New Size(41, 45)
        lblLetra.TabIndex = 0
        lblLetra.Text = "X"
        lblLetra.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblApellidoCliente)
        Panel2.Controls.Add(lblApellido)
        Panel2.Controls.Add(lblNombreCliente)
        Panel2.Controls.Add(lblNombre)
        Panel2.Controls.Add(lblCliente)
        Panel2.Controls.Add(txtCuenta)
        Panel2.Location = New Point(29, 117)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 81)
        Panel2.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(29, 548)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1013, 51)
        Panel3.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(863, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 21)
        Label7.TabIndex = 19
        Label7.Text = "10.000.000,00$"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(797, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 18
        Label1.Text = "TOTAL:"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Location = New Point(29, 204)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1013, 338)
        Panel6.TabIndex = 12
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(28, 9)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(158, 31)
        btnVolver.TabIndex = 20
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(884, 9)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 31)
        Button2.TabIndex = 21
        Button2.Text = "Finalizar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(471, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 15)
        Label8.TabIndex = 17
        Label8.Text = "Editar Comprobante"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(260, 15)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(54, 15)
        lblNombre.TabIndex = 5
        lblNombre.Text = "Nombre:"
        ' 
        ' lblNombreCliente
        ' 
        lblNombreCliente.AutoSize = True
        lblNombreCliente.Location = New Point(320, 15)
        lblNombreCliente.Name = "lblNombreCliente"
        lblNombreCliente.Size = New Size(44, 15)
        lblNombreCliente.TabIndex = 6
        lblNombreCliente.Text = "Cliente"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(260, 38)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(54, 15)
        lblApellido.TabIndex = 7
        lblApellido.Text = "Apellido:"
        ' 
        ' lblApellidoCliente
        ' 
        lblApellidoCliente.AutoSize = True
        lblApellidoCliente.Location = New Point(320, 38)
        lblApellidoCliente.Name = "lblApellidoCliente"
        lblApellidoCliente.Size = New Size(51, 15)
        lblApellidoCliente.TabIndex = 8
        lblApellidoCliente.Text = "Apellido"
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(Label8)
        Controls.Add(Button2)
        Controls.Add(Panel6)
        Controls.Add(btnVolver)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ABM)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "ABM_Ventas"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ABM_Ventas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ABM As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblLetra As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblCod As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblApellidoCliente As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNombre As Label
End Class
