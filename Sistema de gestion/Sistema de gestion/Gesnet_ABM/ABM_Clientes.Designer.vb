<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Clientes
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
        lblCuenta = New Label()
        lblNombre = New Label()
        lblApellido = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblCp = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtCuenta = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtNacionalidad = New TextBox()
        txtCp = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        dtFechaNacimiento = New DateTimePicker()
        lblSeñalCliente = New Label()
        Label14 = New Label()
        txtIDCliente = New TextBox()
        lblDni = New Label()
        lblCuit = New Label()
        lblCondicionIva = New Label()
        txtDni = New TextBox()
        txtCuit = New TextBox()
        gbDatos = New GroupBox()
        Label12 = New Label()
        Label15 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cbCondicionIva = New ComboBox()
        chActivo = New CheckBox()
        gbUbicacion = New GroupBox()
        Label16 = New Label()
        cbLocalidades = New ComboBox()
        cbProvincia = New ComboBox()
        gbGeneralidades = New GroupBox()
        pnlFicha = New Panel()
        btnVolver = New Button()
        btnAceptar = New Button()
        gbDatos.SuspendLayout()
        gbUbicacion.SuspendLayout()
        gbGeneralidades.SuspendLayout()
        pnlFicha.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCuenta
        ' 
        lblCuenta.AutoSize = True
        lblCuenta.Font = New Font("Yu Gothic UI", 12F)
        lblCuenta.Location = New Point(12, 32)
        lblCuenta.Name = "lblCuenta"
        lblCuenta.Size = New Size(59, 21)
        lblCuenta.TabIndex = 0
        lblCuenta.Text = "Cuenta"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Yu Gothic UI", 12F)
        lblNombre.Location = New Point(240, 32)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(68, 21)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Yu Gothic UI", 12F)
        lblApellido.Location = New Point(549, 32)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(67, 21)
        lblApellido.TabIndex = 2
        lblApellido.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 12F)
        Label4.Location = New Point(12, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 21)
        Label4.TabIndex = 3
        Label4.Text = "Nacionalidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 12F)
        Label5.Location = New Point(240, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 4
        Label5.Text = "Provincia"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 12F)
        Label6.Location = New Point(549, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 21)
        Label6.TabIndex = 5
        Label6.Text = "Localidad"
        ' 
        ' lblCp
        ' 
        lblCp.AutoSize = True
        lblCp.Font = New Font("Yu Gothic UI", 12F)
        lblCp.Location = New Point(12, 112)
        lblCp.Name = "lblCp"
        lblCp.Size = New Size(106, 21)
        lblCp.TabIndex = 6
        lblCp.Text = "Codigo Postal"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 12F)
        Label8.Location = New Point(239, 112)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 7
        Label8.Text = "Dirección"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic UI", 12F)
        Label9.Location = New Point(12, 39)
        Label9.Name = "Label9"
        Label9.Size = New Size(154, 21)
        Label9.TabIndex = 8
        Label9.Text = "Fecha de Nacimiento"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic UI", 12F)
        Label10.Location = New Point(239, 39)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 21)
        Label10.TabIndex = 9
        Label10.Text = "Telefono"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Yu Gothic UI", 12F)
        Label11.Location = New Point(549, 39)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 21)
        Label11.TabIndex = 10
        Label11.Text = "Email"
        ' 
        ' txtCuenta
        ' 
        txtCuenta.Location = New Point(12, 56)
        txtCuenta.MaxLength = 6
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(200, 29)
        txtCuenta.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(240, 56)
        txtNombre.MaxLength = 50
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(277, 29)
        txtNombre.TabIndex = 2
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(549, 56)
        txtApellido.MaxLength = 50
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(278, 29)
        txtApellido.TabIndex = 3
        ' 
        ' txtNacionalidad
        ' 
        txtNacionalidad.Location = New Point(12, 58)
        txtNacionalidad.MaxLength = 25
        txtNacionalidad.Name = "txtNacionalidad"
        txtNacionalidad.Size = New Size(200, 29)
        txtNacionalidad.TabIndex = 1
        ' 
        ' txtCp
        ' 
        txtCp.Location = New Point(12, 136)
        txtCp.MaxLength = 4
        txtCp.Name = "txtCp"
        txtCp.Size = New Size(200, 29)
        txtCp.TabIndex = 4
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(240, 136)
        txtDireccion.MaxLength = 75
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(277, 29)
        txtDireccion.TabIndex = 5
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(239, 63)
        txtTelefono.MaxLength = 25
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(278, 29)
        txtTelefono.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(549, 63)
        txtEmail.MaxLength = 50
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(376, 29)
        txtEmail.TabIndex = 3
        ' 
        ' dtFechaNacimiento
        ' 
        dtFechaNacimiento.Font = New Font("Yu Gothic UI", 12F)
        dtFechaNacimiento.Format = DateTimePickerFormat.Short
        dtFechaNacimiento.Location = New Point(12, 63)
        dtFechaNacimiento.Name = "dtFechaNacimiento"
        dtFechaNacimiento.Size = New Size(200, 29)
        dtFechaNacimiento.TabIndex = 1
        ' 
        ' lblSeñalCliente
        ' 
        lblSeñalCliente.AutoSize = True
        lblSeñalCliente.Location = New Point(1024, 0)
        lblSeñalCliente.Name = "lblSeñalCliente"
        lblSeñalCliente.Size = New Size(47, 15)
        lblSeñalCliente.TabIndex = 25
        lblSeñalCliente.Text = "Label12"
        lblSeñalCliente.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Yu Gothic UI", 12F)
        Label14.Location = New Point(12, 12)
        Label14.Name = "Label14"
        Label14.Size = New Size(28, 21)
        Label14.TabIndex = 30
        Label14.Text = "ID:"
        Label14.Visible = False
        ' 
        ' txtIDCliente
        ' 
        txtIDCliente.Enabled = False
        txtIDCliente.Location = New Point(46, 9)
        txtIDCliente.Name = "txtIDCliente"
        txtIDCliente.Size = New Size(43, 23)
        txtIDCliente.TabIndex = 31
        txtIDCliente.Visible = False
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Font = New Font("Yu Gothic UI", 12F)
        lblDni.Location = New Point(12, 109)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(37, 21)
        lblDni.TabIndex = 32
        lblDni.Text = "DNI"
        ' 
        ' lblCuit
        ' 
        lblCuit.AutoSize = True
        lblCuit.Font = New Font("Yu Gothic UI", 12F)
        lblCuit.Location = New Point(240, 109)
        lblCuit.Name = "lblCuit"
        lblCuit.Size = New Size(43, 21)
        lblCuit.TabIndex = 33
        lblCuit.Text = "CUIT"
        ' 
        ' lblCondicionIva
        ' 
        lblCondicionIva.AutoSize = True
        lblCondicionIva.Font = New Font("Yu Gothic UI", 12F)
        lblCondicionIva.Location = New Point(549, 109)
        lblCondicionIva.Name = "lblCondicionIva"
        lblCondicionIva.Size = New Size(107, 21)
        lblCondicionIva.TabIndex = 34
        lblCondicionIva.Text = "Condición IVA"
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(12, 133)
        txtDni.MaxLength = 8
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(200, 29)
        txtDni.TabIndex = 4
        ' 
        ' txtCuit
        ' 
        txtCuit.Location = New Point(239, 133)
        txtCuit.MaxLength = 13
        txtCuit.Name = "txtCuit"
        txtCuit.Size = New Size(278, 29)
        txtCuit.TabIndex = 5
        ' 
        ' gbDatos
        ' 
        gbDatos.BackColor = Color.Tan
        gbDatos.Controls.Add(Label12)
        gbDatos.Controls.Add(Label15)
        gbDatos.Controls.Add(Label7)
        gbDatos.Controls.Add(Label3)
        gbDatos.Controls.Add(Label2)
        gbDatos.Controls.Add(Label1)
        gbDatos.Controls.Add(cbCondicionIva)
        gbDatos.Controls.Add(chActivo)
        gbDatos.Controls.Add(txtNombre)
        gbDatos.Controls.Add(txtCuit)
        gbDatos.Controls.Add(lblNombre)
        gbDatos.Controls.Add(lblCondicionIva)
        gbDatos.Controls.Add(txtDni)
        gbDatos.Controls.Add(lblCuit)
        gbDatos.Controls.Add(lblApellido)
        gbDatos.Controls.Add(txtApellido)
        gbDatos.Controls.Add(lblCuenta)
        gbDatos.Controls.Add(lblDni)
        gbDatos.Controls.Add(txtCuenta)
        gbDatos.Font = New Font("Yu Gothic UI", 12F)
        gbDatos.Location = New Point(16, 14)
        gbDatos.Name = "gbDatos"
        gbDatos.Size = New Size(951, 181)
        gbDatos.TabIndex = 1
        gbDatos.TabStop = False
        gbDatos.Text = "Datos personales:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Yu Gothic UI", 12F)
        Label12.ForeColor = Color.Red
        Label12.Location = New Point(500, 112)
        Label12.Name = "Label12"
        Label12.Size = New Size(17, 21)
        Label12.TabIndex = 59
        Label12.Text = "*"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Yu Gothic UI", 12F)
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(810, 112)
        Label15.Name = "Label15"
        Label15.Size = New Size(17, 21)
        Label15.TabIndex = 61
        Label15.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 12F)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(195, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(17, 21)
        Label7.TabIndex = 58
        Label7.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 12F)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(810, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 21)
        Label3.TabIndex = 57
        Label3.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 12F)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(195, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(17, 21)
        Label2.TabIndex = 56
        Label2.Text = "*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 12F)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(500, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 21)
        Label1.TabIndex = 55
        Label1.Text = "*"
        ' 
        ' cbCondicionIva
        ' 
        cbCondicionIva.BackColor = Color.Tan
        cbCondicionIva.FlatStyle = FlatStyle.Flat
        cbCondicionIva.Font = New Font("Yu Gothic UI", 12F)
        cbCondicionIva.FormattingEnabled = True
        cbCondicionIva.ItemHeight = 21
        cbCondicionIva.Location = New Point(549, 133)
        cbCondicionIva.Name = "cbCondicionIva"
        cbCondicionIva.Size = New Size(278, 29)
        cbCondicionIva.TabIndex = 6
        ' 
        ' chActivo
        ' 
        chActivo.AutoSize = True
        chActivo.Location = New Point(853, 28)
        chActivo.Name = "chActivo"
        chActivo.Size = New Size(72, 25)
        chActivo.TabIndex = 35
        chActivo.Text = "Activo"
        chActivo.UseVisualStyleBackColor = True
        ' 
        ' gbUbicacion
        ' 
        gbUbicacion.BackColor = Color.Tan
        gbUbicacion.Controls.Add(Label16)
        gbUbicacion.Controls.Add(cbLocalidades)
        gbUbicacion.Controls.Add(cbProvincia)
        gbUbicacion.Controls.Add(lblCp)
        gbUbicacion.Controls.Add(Label4)
        gbUbicacion.Controls.Add(Label5)
        gbUbicacion.Controls.Add(Label6)
        gbUbicacion.Controls.Add(Label8)
        gbUbicacion.Controls.Add(txtNacionalidad)
        gbUbicacion.Controls.Add(txtCp)
        gbUbicacion.Controls.Add(txtDireccion)
        gbUbicacion.Font = New Font("Yu Gothic UI", 12F)
        gbUbicacion.Location = New Point(16, 194)
        gbUbicacion.Name = "gbUbicacion"
        gbUbicacion.Size = New Size(951, 190)
        gbUbicacion.TabIndex = 2
        gbUbicacion.TabStop = False
        gbUbicacion.Text = "Ubicación:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Yu Gothic UI", 12F)
        Label16.ForeColor = Color.Red
        Label16.Location = New Point(195, 37)
        Label16.Name = "Label16"
        Label16.Size = New Size(17, 21)
        Label16.TabIndex = 62
        Label16.Text = "*"
        ' 
        ' cbLocalidades
        ' 
        cbLocalidades.BackColor = Color.Tan
        cbLocalidades.FlatStyle = FlatStyle.Flat
        cbLocalidades.Font = New Font("Yu Gothic UI", 12F)
        cbLocalidades.FormattingEnabled = True
        cbLocalidades.ItemHeight = 21
        cbLocalidades.Location = New Point(549, 58)
        cbLocalidades.Name = "cbLocalidades"
        cbLocalidades.Size = New Size(278, 29)
        cbLocalidades.TabIndex = 3
        ' 
        ' cbProvincia
        ' 
        cbProvincia.BackColor = Color.Tan
        cbProvincia.FlatStyle = FlatStyle.Flat
        cbProvincia.Font = New Font("Yu Gothic UI", 12F)
        cbProvincia.FormattingEnabled = True
        cbProvincia.ItemHeight = 21
        cbProvincia.Location = New Point(240, 58)
        cbProvincia.Name = "cbProvincia"
        cbProvincia.Size = New Size(277, 29)
        cbProvincia.TabIndex = 2
        ' 
        ' gbGeneralidades
        ' 
        gbGeneralidades.BackColor = Color.Tan
        gbGeneralidades.Controls.Add(dtFechaNacimiento)
        gbGeneralidades.Controls.Add(Label9)
        gbGeneralidades.Controls.Add(Label10)
        gbGeneralidades.Controls.Add(Label11)
        gbGeneralidades.Controls.Add(txtTelefono)
        gbGeneralidades.Controls.Add(txtEmail)
        gbGeneralidades.Font = New Font("Yu Gothic UI", 12F)
        gbGeneralidades.Location = New Point(16, 384)
        gbGeneralidades.Name = "gbGeneralidades"
        gbGeneralidades.Size = New Size(951, 124)
        gbGeneralidades.TabIndex = 3
        gbGeneralidades.TabStop = False
        gbGeneralidades.Text = "Generalidades:"
        ' 
        ' pnlFicha
        ' 
        pnlFicha.BackColor = Color.Tan
        pnlFicha.Controls.Add(gbGeneralidades)
        pnlFicha.Controls.Add(gbUbicacion)
        pnlFicha.Controls.Add(gbDatos)
        pnlFicha.Location = New Point(46, 10)
        pnlFicha.Name = "pnlFicha"
        pnlFicha.Size = New Size(984, 526)
        pnlFicha.TabIndex = 54
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Tan
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Yu Gothic UI", 12F)
        btnVolver.Location = New Point(854, 542)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(176, 55)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.Tan
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Yu Gothic UI", 12F)
        btnAceptar.Location = New Point(46, 542)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(176, 55)
        btnAceptar.TabIndex = 1
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' ABM_Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnVolver)
        Controls.Add(btnAceptar)
        Controls.Add(lblSeñalCliente)
        Controls.Add(pnlFicha)
        Controls.Add(txtIDCliente)
        Controls.Add(Label14)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Clientes"
        Text = "ABM_Clientes"
        gbDatos.ResumeLayout(False)
        gbDatos.PerformLayout()
        gbUbicacion.ResumeLayout(False)
        gbUbicacion.PerformLayout()
        gbGeneralidades.ResumeLayout(False)
        gbGeneralidades.PerformLayout()
        pnlFicha.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCuenta As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents txtCp As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtFechaNacimiento As DateTimePicker
    Friend WithEvents lblSeñalCliente As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents lblCuit As Label
    Friend WithEvents lblCondicionIva As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents gbUbicacion As GroupBox
    Friend WithEvents gbGeneralidades As GroupBox
    Friend WithEvents pnlFicha As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbLocalidades As ComboBox
    Friend WithEvents chActivo As CheckBox
    Friend WithEvents cbCondicionIva As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
