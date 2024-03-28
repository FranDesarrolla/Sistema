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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblABM = New Label()
        lblCliente = New Label()
        Panel1 = New Panel()
        Panel5 = New Panel()
        lblCod = New Label()
        Label6 = New Label()
        txtFecha = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        txtComprobante = New TextBox()
        Label3 = New Label()
        txtSucursal = New TextBox()
        Label2 = New Label()
        lblEmpresa = New Label()
        Panel4 = New Panel()
        lblLetra = New Label()
        btnVolver = New Button()
        Panel2 = New Panel()
        txtCuenta = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        lblDireccion = New Label()
        lblDirec = New Label()
        lblApellidoCliente = New Label()
        lblApellido = New Label()
        lblNombreCliente = New Label()
        lblNombre = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        GrillaMovVentas = New DataGridView()
        btnAgregar = New Button()
        lblID = New Label()
        Panel8 = New Panel()
        lblMov = New Label()
        btnLimpiar = New Button()
        Label16 = New Label()
        lblIDMov = New Label()
        txtIVA = New TextBox()
        Label15 = New Label()
        txtSubtotalCon = New TextBox()
        Label14 = New Label()
        txtSubtotalSin = New TextBox()
        Label11 = New Label()
        TextBox7 = New TextBox()
        txtIVAP = New TextBox()
        Label10 = New Label()
        txtDescuento = New TextBox()
        Label9 = New Label()
        txtUnitario = New TextBox()
        Label8 = New Label()
        txtCantidad = New TextBox()
        lblCantidad = New Label()
        txtProducto = New TextBox()
        txtCodigo = New TextBox()
        lblProd = New Label()
        btnEditar = New Button()
        btnEliminar = New Button()
        Panel6 = New Panel()
        btnFin = New Button()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblABM
        ' 
        lblABM.AutoSize = True
        lblABM.Location = New Point(1016, 9)
        lblABM.Name = "lblABM"
        lblABM.Size = New Size(41, 15)
        lblABM.TabIndex = 0
        lblABM.Text = "Label1"
        lblABM.Visible = False
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCliente.Location = New Point(25, 24)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(54, 19)
        lblCliente.TabIndex = 3
        lblCliente.Text = "Cliente:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtFecha)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtComprobante)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtSucursal)
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
        Panel5.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel5.Controls.Add(lblCod)
        Panel5.Location = New Point(470, 45)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(57, 19)
        Panel5.TabIndex = 12
        ' 
        ' lblCod
        ' 
        lblCod.AutoSize = True
        lblCod.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        lblCod.Location = New Point(8, 3)
        lblCod.Name = "lblCod"
        lblCod.Size = New Size(41, 15)
        lblCod.TabIndex = 16
        lblCod.Text = "Cod. 0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(25, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(299, 19)
        Label6.TabIndex = 17
        Label6.Text = "Velez Sarsfield 572 - Bell Ville - 2550 - Córdoba"
        ' 
        ' txtFecha
        ' 
        txtFecha.BackColor = Color.White
        txtFecha.BorderStyle = BorderStyle.None
        txtFecha.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtFecha.Location = New Point(559, 31)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(86, 20)
        txtFecha.TabIndex = 1
        txtFecha.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(559, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 19)
        Label5.TabIndex = 15
        Label5.Text = "Fecha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(786, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(15, 19)
        Label4.TabIndex = 14
        Label4.Text = "-"
        ' 
        ' txtComprobante
        ' 
        txtComprobante.BackColor = Color.White
        txtComprobante.BorderStyle = BorderStyle.None
        txtComprobante.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtComprobante.Location = New Point(803, 31)
        txtComprobante.Name = "txtComprobante"
        txtComprobante.Size = New Size(94, 20)
        txtComprobante.TabIndex = 3
        txtComprobante.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(803, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 19)
        Label3.TabIndex = 13
        Label3.Text = "Comprobante"
        ' 
        ' txtSucursal
        ' 
        txtSucursal.BackColor = Color.White
        txtSucursal.BorderStyle = BorderStyle.None
        txtSucursal.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSucursal.Location = New Point(727, 31)
        txtSucursal.Name = "txtSucursal"
        txtSucursal.Size = New Size(57, 20)
        txtSucursal.TabIndex = 2
        txtSucursal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(727, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 19)
        Label2.TabIndex = 9
        Label2.Text = "Sucursal"
        ' 
        ' lblEmpresa
        ' 
        lblEmpresa.AutoSize = True
        lblEmpresa.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmpresa.Location = New Point(25, 9)
        lblEmpresa.Name = "lblEmpresa"
        lblEmpresa.Size = New Size(119, 25)
        lblEmpresa.TabIndex = 11
        lblEmpresa.Text = "FAMILYCAN"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel4.Controls.Add(lblLetra)
        Panel4.Location = New Point(470, -1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(57, 47)
        Panel4.TabIndex = 10
        ' 
        ' lblLetra
        ' 
        lblLetra.AutoSize = True
        lblLetra.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        lblLetra.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblLetra.ImageAlign = ContentAlignment.MiddleRight
        lblLetra.Location = New Point(9, 1)
        lblLetra.Name = "lblLetra"
        lblLetra.Size = New Size(41, 45)
        lblLetra.TabIndex = 0
        lblLetra.Text = "X"
        lblLetra.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Tan
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolver.Location = New Point(29, 9)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(158, 31)
        btnVolver.TabIndex = 24
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        Panel2.Controls.Add(txtCuenta)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(lblDireccion)
        Panel2.Controls.Add(lblDirec)
        Panel2.Controls.Add(lblApellidoCliente)
        Panel2.Controls.Add(lblApellido)
        Panel2.Controls.Add(lblNombreCliente)
        Panel2.Controls.Add(lblNombre)
        Panel2.Controls.Add(lblCliente)
        Panel2.Location = New Point(29, 117)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 81)
        Panel2.TabIndex = 10
        ' 
        ' txtCuenta
        ' 
        txtCuenta.BackColor = Color.White
        txtCuenta.BorderStyle = BorderStyle.None
        txtCuenta.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCuenta.ForeColor = Color.Black
        txtCuenta.Location = New Point(91, 22)
        txtCuenta.Margin = New Padding(0)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(66, 20)
        txtCuenta.TabIndex = 27
        txtCuenta.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(636, 19)
        Label12.Name = "Label12"
        Label12.Size = New Size(97, 19)
        Label12.TabIndex = 12
        Label12.Text = "###########"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(559, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 19)
        Label13.TabIndex = 11
        Label13.Text = "CUIT/DNI:"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDireccion.Location = New Point(636, 40)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(97, 19)
        lblDireccion.TabIndex = 10
        lblDireccion.Text = "###########"
        ' 
        ' lblDirec
        ' 
        lblDirec.AutoSize = True
        lblDirec.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDirec.Location = New Point(562, 40)
        lblDirec.Name = "lblDirec"
        lblDirec.Size = New Size(68, 19)
        lblDirec.TabIndex = 9
        lblDirec.Text = "Direccion:"
        ' 
        ' lblApellidoCliente
        ' 
        lblApellidoCliente.AutoSize = True
        lblApellidoCliente.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblApellidoCliente.Location = New Point(324, 40)
        lblApellidoCliente.Name = "lblApellidoCliente"
        lblApellidoCliente.Size = New Size(97, 19)
        lblApellidoCliente.TabIndex = 8
        lblApellidoCliente.Text = "###########"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblApellido.Location = New Point(250, 40)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(61, 19)
        lblApellido.TabIndex = 7
        lblApellido.Text = "Apellido:"
        ' 
        ' lblNombreCliente
        ' 
        lblNombreCliente.AutoSize = True
        lblNombreCliente.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblNombreCliente.Location = New Point(324, 19)
        lblNombreCliente.Name = "lblNombreCliente"
        lblNombreCliente.Size = New Size(97, 19)
        lblNombreCliente.TabIndex = 6
        lblNombreCliente.Text = "###########"
        lblNombreCliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblNombre.Location = New Point(250, 20)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(62, 19)
        lblNombre.TabIndex = 5
        lblNombre.Text = "Nombre:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
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
        Label7.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(854, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 25)
        Label7.TabIndex = 19
        Label7.Text = "10.000.000,00$"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(780, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 25)
        Label1.TabIndex = 18
        Label1.Text = "TOTAL:"
        ' 
        ' GrillaMovVentas
        ' 
        GrillaMovVentas.AllowUserToAddRows = False
        GrillaMovVentas.AllowUserToDeleteRows = False
        GrillaMovVentas.AllowUserToResizeColumns = False
        GrillaMovVentas.AllowUserToResizeRows = False
        GrillaMovVentas.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaMovVentas.BorderStyle = BorderStyle.None
        GrillaMovVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        GrillaMovVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        GrillaMovVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaMovVentas.Cursor = Cursors.Hand
        GrillaMovVentas.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaMovVentas.EnableHeadersVisualStyles = False
        GrillaMovVentas.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaMovVentas.Location = New Point(251, 204)
        GrillaMovVentas.MultiSelect = False
        GrillaMovVentas.Name = "GrillaMovVentas"
        GrillaMovVentas.ReadOnly = True
        GrillaMovVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        GrillaMovVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        GrillaMovVentas.RowHeadersVisible = False
        GrillaMovVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        GrillaMovVentas.RowsDefaultCellStyle = DataGridViewCellStyle6
        GrillaMovVentas.RowTemplate.Height = 25
        GrillaMovVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaMovVentas.ShowCellErrors = False
        GrillaMovVentas.ShowCellToolTips = False
        GrillaMovVentas.ShowEditingIcon = False
        GrillaMovVentas.ShowRowErrors = False
        GrillaMovVentas.Size = New Size(790, 295)
        GrillaMovVentas.TabIndex = 5
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(6, 304)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(204, 31)
        btnAgregar.TabIndex = 23
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblID.Location = New Point(523, 18)
        lblID.Name = "lblID"
        lblID.Size = New Size(13, 13)
        lblID.TabIndex = 18
        lblID.Text = "1"
        lblID.Visible = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel8.Controls.Add(lblMov)
        Panel8.Controls.Add(btnLimpiar)
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(lblIDMov)
        Panel8.Controls.Add(txtIVA)
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(txtSubtotalCon)
        Panel8.Controls.Add(Label14)
        Panel8.Controls.Add(txtSubtotalSin)
        Panel8.Controls.Add(Label11)
        Panel8.Controls.Add(TextBox7)
        Panel8.Controls.Add(txtIVAP)
        Panel8.Controls.Add(Label10)
        Panel8.Controls.Add(txtDescuento)
        Panel8.Controls.Add(Label9)
        Panel8.Controls.Add(txtUnitario)
        Panel8.Controls.Add(Label8)
        Panel8.Controls.Add(txtCantidad)
        Panel8.Controls.Add(lblCantidad)
        Panel8.Controls.Add(txtProducto)
        Panel8.Controls.Add(txtCodigo)
        Panel8.Controls.Add(lblProd)
        Panel8.Controls.Add(btnAgregar)
        Panel8.Location = New Point(28, 204)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(217, 338)
        Panel8.TabIndex = 26
        ' 
        ' lblMov
        ' 
        lblMov.AutoSize = True
        lblMov.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblMov.Location = New Point(130, 6)
        lblMov.Name = "lblMov"
        lblMov.Size = New Size(41, 13)
        lblMov.TabIndex = 47
        lblMov.Text = "lblmov"
        lblMov.Visible = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.Tan
        btnLimpiar.BackgroundImage = My.Resources.Resources.menos
        btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch
        btnLimpiar.FlatAppearance.BorderSize = 0
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpiar.Location = New Point(197, 3)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(17, 17)
        btnLimpiar.TabIndex = 46
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(37, 192)
        Label16.Name = "Label16"
        Label16.Size = New Size(20, 19)
        Label16.TabIndex = 45
        Label16.Text = "%"
        ' 
        ' lblIDMov
        ' 
        lblIDMov.AutoSize = True
        lblIDMov.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblIDMov.Location = New Point(86, 6)
        lblIDMov.Name = "lblIDMov"
        lblIDMov.Size = New Size(38, 13)
        lblIDMov.TabIndex = 28
        lblIDMov.Text = "idmov"
        lblIDMov.Visible = False
        ' 
        ' txtIVA
        ' 
        txtIVA.BackColor = Color.White
        txtIVA.BorderStyle = BorderStyle.None
        txtIVA.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIVA.ForeColor = Color.Black
        txtIVA.Location = New Point(96, 192)
        txtIVA.Margin = New Padding(0)
        txtIVA.Name = "txtIVA"
        txtIVA.Size = New Size(114, 20)
        txtIVA.TabIndex = 44
        txtIVA.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(96, 173)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 19)
        Label15.TabIndex = 43
        Label15.Text = "Importe IVA:"
        ' 
        ' txtSubtotalCon
        ' 
        txtSubtotalCon.BackColor = Color.White
        txtSubtotalCon.BorderStyle = BorderStyle.None
        txtSubtotalCon.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubtotalCon.ForeColor = Color.Black
        txtSubtotalCon.Location = New Point(6, 275)
        txtSubtotalCon.Margin = New Padding(0)
        txtSubtotalCon.Name = "txtSubtotalCon"
        txtSubtotalCon.Size = New Size(204, 20)
        txtSubtotalCon.TabIndex = 42
        txtSubtotalCon.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(6, 256)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 19)
        Label14.TabIndex = 41
        Label14.Text = "Subtotal (Con IVA):"
        ' 
        ' txtSubtotalSin
        ' 
        txtSubtotalSin.BackColor = Color.White
        txtSubtotalSin.BorderStyle = BorderStyle.None
        txtSubtotalSin.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubtotalSin.ForeColor = Color.Black
        txtSubtotalSin.Location = New Point(6, 235)
        txtSubtotalSin.Margin = New Padding(0)
        txtSubtotalSin.Name = "txtSubtotalSin"
        txtSubtotalSin.Size = New Size(204, 20)
        txtSubtotalSin.TabIndex = 40
        txtSubtotalSin.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(6, 216)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 19)
        Label11.TabIndex = 39
        Label11.Text = "Subtotal (Sin IVA):"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.White
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Enabled = False
        TextBox7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox7.ForeColor = Color.Black
        TextBox7.Location = New Point(185, 30)
        TextBox7.Margin = New Padding(0)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(25, 20)
        TextBox7.TabIndex = 38
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtIVAP
        ' 
        txtIVAP.BackColor = Color.White
        txtIVAP.BorderStyle = BorderStyle.None
        txtIVAP.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIVAP.ForeColor = Color.Black
        txtIVAP.Location = New Point(6, 192)
        txtIVAP.Margin = New Padding(0)
        txtIVAP.Name = "txtIVAP"
        txtIVAP.Size = New Size(30, 20)
        txtIVAP.TabIndex = 37
        txtIVAP.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(6, 173)
        Label10.Name = "Label10"
        Label10.Size = New Size(30, 19)
        Label10.TabIndex = 36
        Label10.Text = "IVA"
        ' 
        ' txtDescuento
        ' 
        txtDescuento.BackColor = Color.White
        txtDescuento.BorderStyle = BorderStyle.None
        txtDescuento.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtDescuento.ForeColor = Color.Black
        txtDescuento.Location = New Point(6, 150)
        txtDescuento.Margin = New Padding(0)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(100, 20)
        txtDescuento.TabIndex = 35
        txtDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(6, 131)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 19)
        Label9.TabIndex = 34
        Label9.Text = "Descuento (%):"
        ' 
        ' txtUnitario
        ' 
        txtUnitario.BackColor = Color.White
        txtUnitario.BorderStyle = BorderStyle.None
        txtUnitario.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtUnitario.ForeColor = Color.Black
        txtUnitario.Location = New Point(81, 101)
        txtUnitario.Margin = New Padding(0)
        txtUnitario.Name = "txtUnitario"
        txtUnitario.Size = New Size(129, 20)
        txtUnitario.TabIndex = 33
        txtUnitario.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(81, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 19)
        Label8.TabIndex = 32
        Label8.Text = "Precio Unitario:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.White
        txtCantidad.BorderStyle = BorderStyle.None
        txtCantidad.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCantidad.ForeColor = Color.Black
        txtCantidad.Location = New Point(6, 101)
        txtCantidad.Margin = New Padding(0)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(68, 20)
        txtCantidad.TabIndex = 31
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCantidad.Location = New Point(6, 82)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(64, 19)
        lblCantidad.TabIndex = 30
        lblCantidad.Text = "Cantidad"
        ' 
        ' txtProducto
        ' 
        txtProducto.BackColor = Color.White
        txtProducto.BorderStyle = BorderStyle.None
        txtProducto.Enabled = False
        txtProducto.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtProducto.ForeColor = Color.Black
        txtProducto.Location = New Point(6, 55)
        txtProducto.Margin = New Padding(0)
        txtProducto.Name = "txtProducto"
        txtProducto.ReadOnly = True
        txtProducto.Size = New Size(204, 20)
        txtProducto.TabIndex = 29
        txtProducto.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.White
        txtCodigo.BorderStyle = BorderStyle.None
        txtCodigo.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigo.ForeColor = Color.Black
        txtCodigo.Location = New Point(6, 30)
        txtCodigo.Margin = New Padding(0)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(168, 20)
        txtCodigo.TabIndex = 28
        txtCodigo.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblProd
        ' 
        lblProd.AutoSize = True
        lblProd.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblProd.Location = New Point(6, 8)
        lblProd.Name = "lblProd"
        lblProd.Size = New Size(68, 19)
        lblProd.TabIndex = 28
        lblProd.Text = "Producto:"
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Tan
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(3, 3)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(131, 31)
        btnEditar.TabIndex = 24
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Tan
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(140, 3)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 31)
        btnEliminar.TabIndex = 27
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel6.Controls.Add(btnFin)
        Panel6.Controls.Add(btnEditar)
        Panel6.Controls.Add(btnEliminar)
        Panel6.Location = New Point(251, 505)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(791, 37)
        Panel6.TabIndex = 27
        ' 
        ' btnFin
        ' 
        btnFin.BackColor = Color.Tan
        btnFin.FlatAppearance.BorderSize = 0
        btnFin.FlatStyle = FlatStyle.Flat
        btnFin.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnFin.Location = New Point(630, 3)
        btnFin.Name = "btnFin"
        btnFin.Size = New Size(158, 31)
        btnFin.TabIndex = 28
        btnFin.Text = "Finalizar"
        btnFin.UseVisualStyleBackColor = False
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(btnVolver)
        Controls.Add(Panel6)
        Controls.Add(Panel8)
        Controls.Add(lblID)
        Controls.Add(GrillaMovVentas)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblABM)
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
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblABM As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblLetra As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComprobante As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblCod As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblApellidoCliente As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDirec As Label
    Friend WithEvents GrillaMovVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblProd As Label
    Friend WithEvents txtSubtotalCon As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubtotalSin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtIVAP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUnitario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblIDMov As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblMov As Label
End Class
