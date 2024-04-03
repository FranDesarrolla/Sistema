<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Proveedores
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
        lblSeñalProveedor = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        txtCuentaProv = New TextBox()
        txtNombreProv = New TextBox()
        txtApellidoProv = New TextBox()
        txtFirmaProv = New TextBox()
        txtNacionalidadProv = New TextBox()
        txtProvinciaProv = New TextBox()
        txtLocalidadProv = New TextBox()
        txtCodigoPostalProv = New TextBox()
        txtDireccionProv = New TextBox()
        DpFechaNaProv = New DateTimePicker()
        txtTelefonoProv = New TextBox()
        txtEmailProv = New TextBox()
        DpFechaRegistroProv = New DateTimePicker()
        txtEstadoCuentaProv = New TextBox()
        txtIdProv = New TextBox()
        btnVolverProveedor = New Button()
        BtnAceptarProveedor = New Button()
        SuspendLayout()
        ' 
        ' lblSeñalProveedor
        ' 
        lblSeñalProveedor.AutoSize = True
        lblSeñalProveedor.Location = New Point(1016, 27)
        lblSeñalProveedor.Name = "lblSeñalProveedor"
        lblSeñalProveedor.Size = New Size(41, 15)
        lblSeñalProveedor.TabIndex = 0
        lblSeñalProveedor.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 1
        Label2.Text = "IDProveedor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 2
        Label3.Text = "Cuenta:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nombre:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(379, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 4
        Label5.Text = "Apeliido:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(730, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 15)
        Label6.TabIndex = 5
        Label6.Text = "Firma:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 163)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 15)
        Label7.TabIndex = 6
        Label7.Text = "Nacionalidad:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(319, 163)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 7
        Label8.Text = "Provincia:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(618, 163)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 15)
        Label9.TabIndex = 8
        Label9.Text = "Localidad:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(856, 163)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 15)
        Label10.TabIndex = 9
        Label10.Text = "Codigo Postal:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 257)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 15)
        Label11.TabIndex = 10
        Label11.Text = "Direccion:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(328, 257)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 15)
        Label12.TabIndex = 11
        Label12.Text = "FechaDeNacimiento:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(618, 257)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 15)
        Label13.TabIndex = 12
        Label13.Text = "Telefono:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(12, 322)
        Label14.Name = "Label14"
        Label14.Size = New Size(39, 15)
        Label14.TabIndex = 13
        Label14.Text = "Email:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(12, 391)
        Label15.Name = "Label15"
        Label15.Size = New Size(104, 15)
        Label15.TabIndex = 14
        Label15.Text = "Fecha De Registro:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(354, 391)
        Label16.Name = "Label16"
        Label16.Size = New Size(103, 15)
        Label16.TabIndex = 15
        Label16.Text = "Estado De Cuenta:"
        ' 
        ' txtCuentaProv
        ' 
        txtCuentaProv.Location = New Point(79, 38)
        txtCuentaProv.Name = "txtCuentaProv"
        txtCuentaProv.Size = New Size(161, 23)
        txtCuentaProv.TabIndex = 16
        ' 
        ' txtNombreProv
        ' 
        txtNombreProv.Location = New Point(79, 85)
        txtNombreProv.Name = "txtNombreProv"
        txtNombreProv.Size = New Size(161, 23)
        txtNombreProv.TabIndex = 17
        ' 
        ' txtApellidoProv
        ' 
        txtApellidoProv.Location = New Point(436, 85)
        txtApellidoProv.Name = "txtApellidoProv"
        txtApellidoProv.Size = New Size(161, 23)
        txtApellidoProv.TabIndex = 18
        ' 
        ' txtFirmaProv
        ' 
        txtFirmaProv.Location = New Point(779, 85)
        txtFirmaProv.Name = "txtFirmaProv"
        txtFirmaProv.Size = New Size(161, 23)
        txtFirmaProv.TabIndex = 19
        ' 
        ' txtNacionalidadProv
        ' 
        txtNacionalidadProv.Location = New Point(98, 160)
        txtNacionalidadProv.Name = "txtNacionalidadProv"
        txtNacionalidadProv.Size = New Size(161, 23)
        txtNacionalidadProv.TabIndex = 20
        ' 
        ' txtProvinciaProv
        ' 
        txtProvinciaProv.Location = New Point(384, 160)
        txtProvinciaProv.Name = "txtProvinciaProv"
        txtProvinciaProv.Size = New Size(161, 23)
        txtProvinciaProv.TabIndex = 21
        ' 
        ' txtLocalidadProv
        ' 
        txtLocalidadProv.Location = New Point(685, 160)
        txtLocalidadProv.Name = "txtLocalidadProv"
        txtLocalidadProv.Size = New Size(161, 23)
        txtLocalidadProv.TabIndex = 22
        ' 
        ' txtCodigoPostalProv
        ' 
        txtCodigoPostalProv.Location = New Point(946, 160)
        txtCodigoPostalProv.Name = "txtCodigoPostalProv"
        txtCodigoPostalProv.Size = New Size(95, 23)
        txtCodigoPostalProv.TabIndex = 23
        ' 
        ' txtDireccionProv
        ' 
        txtDireccionProv.Location = New Point(78, 254)
        txtDireccionProv.Name = "txtDireccionProv"
        txtDireccionProv.Size = New Size(227, 23)
        txtDireccionProv.TabIndex = 24
        ' 
        ' DpFechaNaProv
        ' 
        DpFechaNaProv.Format = DateTimePickerFormat.Short
        DpFechaNaProv.Location = New Point(446, 251)
        DpFechaNaProv.Name = "DpFechaNaProv"
        DpFechaNaProv.Size = New Size(99, 23)
        DpFechaNaProv.TabIndex = 25
        ' 
        ' txtTelefonoProv
        ' 
        txtTelefonoProv.Location = New Point(685, 254)
        txtTelefonoProv.Name = "txtTelefonoProv"
        txtTelefonoProv.Size = New Size(161, 23)
        txtTelefonoProv.TabIndex = 26
        ' 
        ' txtEmailProv
        ' 
        txtEmailProv.Location = New Point(57, 319)
        txtEmailProv.Name = "txtEmailProv"
        txtEmailProv.Size = New Size(373, 23)
        txtEmailProv.TabIndex = 27
        ' 
        ' DpFechaRegistroProv
        ' 
        DpFechaRegistroProv.Format = DateTimePickerFormat.Short
        DpFechaRegistroProv.Location = New Point(122, 385)
        DpFechaRegistroProv.Name = "DpFechaRegistroProv"
        DpFechaRegistroProv.Size = New Size(107, 23)
        DpFechaRegistroProv.TabIndex = 28
        ' 
        ' txtEstadoCuentaProv
        ' 
        txtEstadoCuentaProv.Location = New Point(463, 388)
        txtEstadoCuentaProv.Name = "txtEstadoCuentaProv"
        txtEstadoCuentaProv.Size = New Size(47, 23)
        txtEstadoCuentaProv.TabIndex = 29
        ' 
        ' txtIdProv
        ' 
        txtIdProv.Enabled = False
        txtIdProv.Location = New Point(90, 6)
        txtIdProv.Name = "txtIdProv"
        txtIdProv.Size = New Size(107, 23)
        txtIdProv.TabIndex = 30
        ' 
        ' btnVolverProveedor
        ' 
        btnVolverProveedor.Location = New Point(547, 501)
        btnVolverProveedor.Name = "btnVolverProveedor"
        btnVolverProveedor.Size = New Size(83, 31)
        btnVolverProveedor.TabIndex = 32
        btnVolverProveedor.Text = "Volver"
        btnVolverProveedor.UseVisualStyleBackColor = True
        ' 
        ' BtnAceptarProveedor
        ' 
        BtnAceptarProveedor.Location = New Point(374, 501)
        BtnAceptarProveedor.Name = "BtnAceptarProveedor"
        BtnAceptarProveedor.Size = New Size(83, 31)
        BtnAceptarProveedor.TabIndex = 31
        BtnAceptarProveedor.Text = "Aceptar"
        BtnAceptarProveedor.UseVisualStyleBackColor = True
        ' 
        ' ABM_Proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnVolverProveedor)
        Controls.Add(BtnAceptarProveedor)
        Controls.Add(txtIdProv)
        Controls.Add(txtEstadoCuentaProv)
        Controls.Add(DpFechaRegistroProv)
        Controls.Add(txtEmailProv)
        Controls.Add(txtTelefonoProv)
        Controls.Add(DpFechaNaProv)
        Controls.Add(txtDireccionProv)
        Controls.Add(txtCodigoPostalProv)
        Controls.Add(txtLocalidadProv)
        Controls.Add(txtProvinciaProv)
        Controls.Add(txtNacionalidadProv)
        Controls.Add(txtFirmaProv)
        Controls.Add(txtApellidoProv)
        Controls.Add(txtNombreProv)
        Controls.Add(txtCuentaProv)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblSeñalProveedor)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Proveedores"
        Text = "ABM_Proveedores"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSeñalProveedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCuentaProv As TextBox
    Friend WithEvents txtNombreProv As TextBox
    Friend WithEvents txtApellidoProv As TextBox
    Friend WithEvents txtFirmaProv As TextBox
    Friend WithEvents txtNacionalidadProv As TextBox
    Friend WithEvents txtProvinciaProv As TextBox
    Friend WithEvents txtLocalidadProv As TextBox
    Friend WithEvents txtCodigoPostalProv As TextBox
    Friend WithEvents txtDireccionProv As TextBox
    Friend WithEvents DpFechaNaProv As DateTimePicker
    Friend WithEvents txtTelefonoProv As TextBox
    Friend WithEvents txtEmailProv As TextBox
    Friend WithEvents DpFechaRegistroProv As DateTimePicker
    Friend WithEvents txtEstadoCuentaProv As TextBox
    Friend WithEvents txtIdProv As TextBox
    Friend WithEvents btnVolverProveedor As Button
    Friend WithEvents BtnAceptarProveedor As Button
End Class
