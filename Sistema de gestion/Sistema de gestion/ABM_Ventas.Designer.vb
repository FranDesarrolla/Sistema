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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABM_Ventas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblABM = New Label()
        lblCliente = New Label()
        btnFin = New Button()
        panelDatos = New Panel()
        Button2 = New Button()
        picBuscar = New PictureBox()
        Button1 = New Button()
        txtCuenta = New TextBox()
        lblTotal = New Label()
        lblTitotal = New Label()
        btnVolver = New Button()
        GrillaMovVentas = New DataGridView()
        btnAgregar = New Button()
        lblID = New Label()
        panelProducto = New Panel()
        btnLimpiar = New Button()
        Label15 = New Label()
        picBuscarProd = New PictureBox()
        txtCodprod = New TextBox()
        Label12 = New Label()
        lblMov = New Label()
        Label16 = New Label()
        lblIDMov = New Label()
        txtSubtotalCon = New TextBox()
        Label14 = New Label()
        txtIVAP = New TextBox()
        Label10 = New Label()
        txtDescuento = New TextBox()
        Label9 = New Label()
        txtUnitario = New TextBox()
        Label8 = New Label()
        txtCantidad = New TextBox()
        txtDescripcion = New TextBox()
        lblProd = New Label()
        btnEditar = New Button()
        btnEliminar = New Button()
        boxComprobante = New ComboBox()
        Label18 = New Label()
        boxMetodo = New ComboBox()
        Label17 = New Label()
        Label5 = New Label()
        dateTime = New DateTimePicker()
        Panel1 = New Panel()
        Panel2 = New Panel()
        GroupBox1 = New GroupBox()
        Label13 = New Label()
        Label11 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblTelefono = New Label()
        lblProvincia = New Label()
        lblLocalidad = New Label()
        lblCuit = New Label()
        lblDni = New Label()
        lblCondiva = New Label()
        lblDireccion = New Label()
        lblDatos = New Label()
        Panel3 = New Panel()
        Label21 = New Label()
        Label23 = New Label()
        pnlInferior = New Panel()
        Label19 = New Label()
        Label20 = New Label()
        panelDatos.SuspendLayout()
        CType(picBuscar, ComponentModel.ISupportInitialize).BeginInit()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).BeginInit()
        panelProducto.SuspendLayout()
        CType(picBuscarProd, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        pnlInferior.SuspendLayout()
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
        lblCliente.Font = New Font("Yu Gothic UI", 12F)
        lblCliente.Location = New Point(15, 21)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(61, 21)
        lblCliente.TabIndex = 3
        lblCliente.Text = "Cliente:"
        ' 
        ' btnFin
        ' 
        btnFin.BackColor = Color.Tan
        btnFin.Enabled = False
        btnFin.FlatAppearance.BorderSize = 0
        btnFin.FlatStyle = FlatStyle.Flat
        btnFin.Font = New Font("Yu Gothic UI", 12F)
        btnFin.Location = New Point(338, 555)
        btnFin.Name = "btnFin"
        btnFin.Size = New Size(179, 40)
        btnFin.TabIndex = 6
        btnFin.Text = "Finalizar"
        btnFin.UseVisualStyleBackColor = False
        ' 
        ' panelDatos
        ' 
        panelDatos.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelDatos.Controls.Add(Button2)
        panelDatos.Controls.Add(picBuscar)
        panelDatos.Controls.Add(Button1)
        panelDatos.Controls.Add(txtCuenta)
        panelDatos.Controls.Add(lblCliente)
        panelDatos.Location = New Point(55, 83)
        panelDatos.Name = "panelDatos"
        panelDatos.Size = New Size(217, 157)
        panelDatos.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tan
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Yu Gothic UI", 12F)
        Button2.Location = New Point(18, 107)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 34)
        Button2.TabIndex = 22
        Button2.TabStop = False
        Button2.Text = "Ver saldo"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' picBuscar
        ' 
        picBuscar.Image = CType(resources.GetObject("picBuscar.Image"), Image)
        picBuscar.Location = New Point(176, 20)
        picBuscar.Name = "picBuscar"
        picBuscar.Size = New Size(25, 25)
        picBuscar.TabIndex = 20
        picBuscar.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tan
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic UI", 12F)
        Button1.Location = New Point(18, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 34)
        Button1.TabIndex = 2
        Button1.TabStop = False
        Button1.Text = "Crear cliente"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtCuenta
        ' 
        txtCuenta.BackColor = Color.White
        txtCuenta.Font = New Font("Yu Gothic UI", 12F)
        txtCuenta.ForeColor = Color.Black
        txtCuenta.Location = New Point(79, 18)
        txtCuenta.Margin = New Padding(0)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(90, 29)
        txtCuenta.TabIndex = 1
        txtCuenta.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Yu Gothic UI", 14F, FontStyle.Bold)
        lblTotal.Location = New Point(801, 10)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(23, 25)
        lblTotal.TabIndex = 19
        lblTotal.Text = "0"
        ' 
        ' lblTitotal
        ' 
        lblTitotal.AutoSize = True
        lblTitotal.Font = New Font("Yu Gothic UI", 14F, FontStyle.Bold)
        lblTitotal.Location = New Point(726, 10)
        lblTitotal.Name = "lblTitotal"
        lblTitotal.Size = New Size(72, 25)
        lblTitotal.TabIndex = 18
        lblTitotal.Text = "TOTAL:"
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Tan
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Yu Gothic UI", 12F)
        btnVolver.Location = New Point(552, 555)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(179, 40)
        btnVolver.TabIndex = 7
        btnVolver.TabStop = False
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaMovVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaMovVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaMovVentas.Cursor = Cursors.Hand
        GrillaMovVentas.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaMovVentas.Enabled = False
        GrillaMovVentas.EnableHeadersVisualStyles = False
        GrillaMovVentas.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaMovVentas.Location = New Point(420, 246)
        GrillaMovVentas.MultiSelect = False
        GrillaMovVentas.Name = "GrillaMovVentas"
        GrillaMovVentas.ReadOnly = True
        GrillaMovVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaMovVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaMovVentas.RowHeadersVisible = False
        GrillaMovVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaMovVentas.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaMovVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaMovVentas.ShowCellErrors = False
        GrillaMovVentas.ShowCellToolTips = False
        GrillaMovVentas.ShowEditingIcon = False
        GrillaMovVentas.ShowRowErrors = False
        GrillaMovVentas.Size = New Size(593, 201)
        GrillaMovVentas.TabIndex = 7
        GrillaMovVentas.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Yu Gothic UI", 12F)
        btnAgregar.Location = New Point(8, 216)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(166, 29)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 8.25F)
        lblID.Location = New Point(29, 9)
        lblID.Name = "lblID"
        lblID.Size = New Size(13, 13)
        lblID.TabIndex = 18
        lblID.Text = "1"
        lblID.Visible = False
        ' 
        ' panelProducto
        ' 
        panelProducto.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelProducto.Controls.Add(btnLimpiar)
        panelProducto.Controls.Add(btnAgregar)
        panelProducto.Controls.Add(Label15)
        panelProducto.Controls.Add(picBuscarProd)
        panelProducto.Controls.Add(txtCodprod)
        panelProducto.Controls.Add(Label12)
        panelProducto.Controls.Add(lblMov)
        panelProducto.Controls.Add(Label16)
        panelProducto.Controls.Add(lblIDMov)
        panelProducto.Controls.Add(txtSubtotalCon)
        panelProducto.Controls.Add(Label14)
        panelProducto.Controls.Add(txtIVAP)
        panelProducto.Controls.Add(Label10)
        panelProducto.Controls.Add(txtDescuento)
        panelProducto.Controls.Add(Label9)
        panelProducto.Controls.Add(txtUnitario)
        panelProducto.Controls.Add(Label8)
        panelProducto.Controls.Add(txtCantidad)
        panelProducto.Controls.Add(txtDescripcion)
        panelProducto.Controls.Add(lblProd)
        panelProducto.Enabled = False
        panelProducto.Location = New Point(55, 246)
        panelProducto.Name = "panelProducto"
        panelProducto.Size = New Size(359, 254)
        panelProducto.TabIndex = 4
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.Tan
        btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch
        btnLimpiar.FlatAppearance.BorderSize = 0
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Yu Gothic UI", 12F)
        btnLimpiar.Location = New Point(184, 216)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(166, 29)
        btnLimpiar.TabIndex = 7
        btnLimpiar.TabStop = False
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Yu Gothic UI", 12F)
        Label15.Location = New Point(133, 166)
        Label15.Name = "Label15"
        Label15.Size = New Size(23, 21)
        Label15.TabIndex = 50
        Label15.Text = "%"
        ' 
        ' picBuscarProd
        ' 
        picBuscarProd.Image = CType(resources.GetObject("picBuscarProd.Image"), Image)
        picBuscarProd.Location = New Point(321, 11)
        picBuscarProd.Name = "picBuscarProd"
        picBuscarProd.Size = New Size(25, 25)
        picBuscarProd.TabIndex = 49
        picBuscarProd.TabStop = False
        ' 
        ' txtCodprod
        ' 
        txtCodprod.BackColor = Color.White
        txtCodprod.Font = New Font("Yu Gothic UI", 12F)
        txtCodprod.ForeColor = Color.Black
        txtCodprod.Location = New Point(87, 8)
        txtCodprod.Margin = New Padding(0)
        txtCodprod.Name = "txtCodprod"
        txtCodprod.Size = New Size(225, 29)
        txtCodprod.TabIndex = 1
        txtCodprod.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Yu Gothic UI", 12F)
        Label12.Location = New Point(208, 79)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 21)
        Label12.TabIndex = 48
        Label12.Text = "Cantidad:"
        ' 
        ' lblMov
        ' 
        lblMov.AutoSize = True
        lblMov.Font = New Font("Segoe UI", 8.25F)
        lblMov.Location = New Point(0, 327)
        lblMov.Name = "lblMov"
        lblMov.Size = New Size(41, 13)
        lblMov.TabIndex = 47
        lblMov.Text = "lblmov"
        lblMov.Visible = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Yu Gothic UI", 12F)
        Label16.Location = New Point(59, 166)
        Label16.Name = "Label16"
        Label16.Size = New Size(23, 21)
        Label16.TabIndex = 45
        Label16.Text = "%"
        ' 
        ' lblIDMov
        ' 
        lblIDMov.AutoSize = True
        lblIDMov.Font = New Font("Segoe UI", 8.25F)
        lblIDMov.Location = New Point(179, 327)
        lblIDMov.Name = "lblIDMov"
        lblIDMov.Size = New Size(38, 13)
        lblIDMov.TabIndex = 28
        lblIDMov.Text = "idmov"
        lblIDMov.Visible = False
        ' 
        ' txtSubtotalCon
        ' 
        txtSubtotalCon.BackColor = Color.White
        txtSubtotalCon.Enabled = False
        txtSubtotalCon.Font = New Font("Yu Gothic UI", 12F)
        txtSubtotalCon.ForeColor = Color.Black
        txtSubtotalCon.Location = New Point(161, 163)
        txtSubtotalCon.Margin = New Padding(0)
        txtSubtotalCon.Name = "txtSubtotalCon"
        txtSubtotalCon.Size = New Size(189, 29)
        txtSubtotalCon.TabIndex = 14
        txtSubtotalCon.Text = "0,00"
        txtSubtotalCon.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Yu Gothic UI", 12F)
        Label14.Location = New Point(158, 142)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 21)
        Label14.TabIndex = 41
        Label14.Text = "Total:"
        ' 
        ' txtIVAP
        ' 
        txtIVAP.BackColor = Color.White
        txtIVAP.Font = New Font("Yu Gothic UI", 12F)
        txtIVAP.ForeColor = Color.Black
        txtIVAP.Location = New Point(11, 162)
        txtIVAP.Margin = New Padding(0)
        txtIVAP.Name = "txtIVAP"
        txtIVAP.ReadOnly = True
        txtIVAP.Size = New Size(46, 29)
        txtIVAP.TabIndex = 4
        txtIVAP.Text = "0,00"
        txtIVAP.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic UI", 12F)
        Label10.Location = New Point(8, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 21)
        Label10.TabIndex = 36
        Label10.Text = "IVA"
        ' 
        ' txtDescuento
        ' 
        txtDescuento.BackColor = Color.White
        txtDescuento.Font = New Font("Yu Gothic UI", 12F)
        txtDescuento.ForeColor = Color.Black
        txtDescuento.Location = New Point(88, 164)
        txtDescuento.Margin = New Padding(0)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(42, 29)
        txtDescuento.TabIndex = 5
        txtDescuento.Text = "0,00"
        txtDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic UI", 12F)
        Label9.Location = New Point(85, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 21)
        Label9.TabIndex = 34
        Label9.Text = "Desc."
        ' 
        ' txtUnitario
        ' 
        txtUnitario.BackColor = Color.White
        txtUnitario.Font = New Font("Yu Gothic UI", 12F)
        txtUnitario.ForeColor = Color.Black
        txtUnitario.Location = New Point(11, 101)
        txtUnitario.Margin = New Padding(0)
        txtUnitario.Name = "txtUnitario"
        txtUnitario.Size = New Size(189, 29)
        txtUnitario.TabIndex = 2
        txtUnitario.Text = "0,00"
        txtUnitario.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 12F)
        Label8.Location = New Point(8, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(116, 21)
        Label8.TabIndex = 32
        Label8.Text = "Precio Unitario:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.White
        txtCantidad.Font = New Font("Yu Gothic UI", 12F)
        txtCantidad.ForeColor = Color.Black
        txtCantidad.Location = New Point(211, 101)
        txtCantidad.Margin = New Padding(0)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(139, 29)
        txtCantidad.TabIndex = 3
        txtCantidad.Text = "0,00"
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BackColor = Color.White
        txtDescripcion.Enabled = False
        txtDescripcion.Font = New Font("Yu Gothic UI", 12F)
        txtDescripcion.ForeColor = Color.Black
        txtDescripcion.Location = New Point(11, 44)
        txtDescripcion.Margin = New Padding(0)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(339, 29)
        txtDescripcion.TabIndex = 7
        txtDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblProd
        ' 
        lblProd.AutoSize = True
        lblProd.Font = New Font("Yu Gothic UI", 12F)
        lblProd.Location = New Point(8, 11)
        lblProd.Name = "lblProd"
        lblProd.Size = New Size(76, 21)
        lblProd.TabIndex = 28
        lblProd.Text = "Producto:"
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Tan
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Yu Gothic UI", 12F)
        btnEditar.Location = New Point(9, 8)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(131, 31)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Tan
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Yu Gothic UI", 12F)
        btnEliminar.Location = New Point(453, 8)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 31)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' boxComprobante
        ' 
        boxComprobante.BackColor = Color.Tan
        boxComprobante.FlatStyle = FlatStyle.Flat
        boxComprobante.Font = New Font("Yu Gothic UI", 12F)
        boxComprobante.FormattingEnabled = True
        boxComprobante.ItemHeight = 21
        boxComprobante.Location = New Point(450, 14)
        boxComprobante.Name = "boxComprobante"
        boxComprobante.Size = New Size(145, 29)
        boxComprobante.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Yu Gothic UI", 12F)
        Label18.Location = New Point(283, 17)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 21)
        Label18.TabIndex = 30
        Label18.Text = "Tipo de comprobante:"
        ' 
        ' boxMetodo
        ' 
        boxMetodo.BackColor = Color.Tan
        boxMetodo.FlatStyle = FlatStyle.Flat
        boxMetodo.Font = New Font("Yu Gothic UI", 12F)
        boxMetodo.FormattingEnabled = True
        boxMetodo.ItemHeight = 21
        boxMetodo.Location = New Point(799, 14)
        boxMetodo.Name = "boxMetodo"
        boxMetodo.Size = New Size(145, 29)
        boxMetodo.TabIndex = 3
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Yu Gothic UI", 12F)
        Label17.Location = New Point(655, 17)
        Label17.Name = "Label17"
        Label17.Size = New Size(127, 21)
        Label17.TabIndex = 28
        Label17.Text = "Metodo de pago:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 12F)
        Label5.Location = New Point(16, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 21)
        Label5.TabIndex = 15
        Label5.Text = "Fecha:"
        ' 
        ' dateTime
        ' 
        dateTime.Font = New Font("Yu Gothic UI", 12F)
        dateTime.Format = DateTimePickerFormat.Short
        dateTime.Location = New Point(74, 13)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(124, 29)
        dateTime.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Controls.Add(boxMetodo)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(boxComprobante)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dateTime)
        Panel1.Location = New Point(57, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(956, 54)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel2.Controls.Add(GroupBox1)
        Panel2.Location = New Point(284, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(729, 157)
        Panel2.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lblTelefono)
        GroupBox1.Controls.Add(lblProvincia)
        GroupBox1.Controls.Add(lblLocalidad)
        GroupBox1.Controls.Add(lblCuit)
        GroupBox1.Controls.Add(lblDni)
        GroupBox1.Controls.Add(lblCondiva)
        GroupBox1.Controls.Add(lblDireccion)
        GroupBox1.Controls.Add(lblDatos)
        GroupBox1.Font = New Font("Yu Gothic UI", 12F)
        GroupBox1.Location = New Point(20, 7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(689, 134)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos de facturación"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label13.Location = New Point(524, 78)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 21)
        Label13.TabIndex = 19
        Label13.Text = "Telefono"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label11.Location = New Point(356, 74)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 21)
        Label11.TabIndex = 18
        Label11.Text = "Provincia"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label7.Location = New Point(203, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 17
        Label7.Text = "Localidad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label6.Location = New Point(10, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 21)
        Label6.TabIndex = 16
        Label6.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label4.Location = New Point(524, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 21)
        Label4.TabIndex = 15
        Label4.Text = "Condición IVA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(356, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 21)
        Label3.TabIndex = 14
        Label3.Text = "CUIT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(203, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 21)
        Label2.TabIndex = 13
        Label2.Text = "DNI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(10, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 21)
        Label1.TabIndex = 12
        Label1.Text = "Nombre y apellido"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Enabled = False
        lblTelefono.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblTelefono.Location = New Point(524, 99)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(68, 21)
        lblTelefono.TabIndex = 11
        lblTelefono.Text = "Telefono"
        lblTelefono.Visible = False
        ' 
        ' lblProvincia
        ' 
        lblProvincia.AutoSize = True
        lblProvincia.Enabled = False
        lblProvincia.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblProvincia.Location = New Point(356, 99)
        lblProvincia.Name = "lblProvincia"
        lblProvincia.Size = New Size(74, 21)
        lblProvincia.TabIndex = 10
        lblProvincia.Text = "Provincia"
        lblProvincia.Visible = False
        ' 
        ' lblLocalidad
        ' 
        lblLocalidad.AutoSize = True
        lblLocalidad.Enabled = False
        lblLocalidad.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblLocalidad.Location = New Point(203, 99)
        lblLocalidad.Name = "lblLocalidad"
        lblLocalidad.Size = New Size(76, 21)
        lblLocalidad.TabIndex = 9
        lblLocalidad.Text = "Localidad"
        lblLocalidad.Visible = False
        ' 
        ' lblCuit
        ' 
        lblCuit.AutoSize = True
        lblCuit.Enabled = False
        lblCuit.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblCuit.Location = New Point(356, 45)
        lblCuit.Name = "lblCuit"
        lblCuit.Size = New Size(43, 21)
        lblCuit.TabIndex = 8
        lblCuit.Text = "CUIT"
        lblCuit.Visible = False
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Enabled = False
        lblDni.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblDni.Location = New Point(203, 45)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(37, 21)
        lblDni.TabIndex = 7
        lblDni.Text = "DNI"
        lblDni.Visible = False
        ' 
        ' lblCondiva
        ' 
        lblCondiva.AutoSize = True
        lblCondiva.Enabled = False
        lblCondiva.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblCondiva.Location = New Point(524, 45)
        lblCondiva.Name = "lblCondiva"
        lblCondiva.Size = New Size(104, 21)
        lblCondiva.TabIndex = 6
        lblCondiva.Text = "Condición Iva"
        lblCondiva.Visible = False
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Enabled = False
        lblDireccion.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblDireccion.Location = New Point(10, 99)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(75, 21)
        lblDireccion.TabIndex = 5
        lblDireccion.Text = "Dirección"
        lblDireccion.Visible = False
        ' 
        ' lblDatos
        ' 
        lblDatos.AutoSize = True
        lblDatos.Enabled = False
        lblDatos.Font = New Font("Yu Gothic UI", 12F, FontStyle.Italic)
        lblDatos.Location = New Point(10, 45)
        lblDatos.Name = "lblDatos"
        lblDatos.Size = New Size(139, 21)
        lblDatos.TabIndex = 4
        lblDatos.Text = "Nombre y apellido"
        lblDatos.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel3.Controls.Add(Label21)
        Panel3.Controls.Add(Label23)
        Panel3.Controls.Add(lblTitotal)
        Panel3.Controls.Add(lblTotal)
        Panel3.Enabled = False
        Panel3.Location = New Point(55, 506)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(958, 44)
        Panel3.TabIndex = 51
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 8.25F)
        Label21.Location = New Point(0, 327)
        Label21.Name = "Label21"
        Label21.Size = New Size(41, 13)
        Label21.TabIndex = 47
        Label21.Text = "lblmov"
        Label21.Visible = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 8.25F)
        Label23.Location = New Point(179, 327)
        Label23.Name = "Label23"
        Label23.Size = New Size(38, 13)
        Label23.TabIndex = 28
        Label23.Text = "idmov"
        Label23.Visible = False
        ' 
        ' pnlInferior
        ' 
        pnlInferior.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        pnlInferior.Controls.Add(Label19)
        pnlInferior.Controls.Add(Label20)
        pnlInferior.Controls.Add(btnEliminar)
        pnlInferior.Controls.Add(btnEditar)
        pnlInferior.Enabled = False
        pnlInferior.Location = New Point(420, 453)
        pnlInferior.Name = "pnlInferior"
        pnlInferior.Size = New Size(593, 47)
        pnlInferior.TabIndex = 5
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 8.25F)
        Label19.Location = New Point(0, 327)
        Label19.Name = "Label19"
        Label19.Size = New Size(41, 13)
        Label19.TabIndex = 47
        Label19.Text = "lblmov"
        Label19.Visible = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 8.25F)
        Label20.Location = New Point(179, 327)
        Label20.Name = "Label20"
        Label20.Size = New Size(38, 13)
        Label20.TabIndex = 28
        Label20.Text = "idmov"
        Label20.Visible = False
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(btnVolver)
        Controls.Add(btnFin)
        Controls.Add(panelProducto)
        Controls.Add(Panel1)
        Controls.Add(lblID)
        Controls.Add(GrillaMovVentas)
        Controls.Add(panelDatos)
        Controls.Add(lblABM)
        Controls.Add(Panel3)
        Controls.Add(pnlInferior)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "ABM_Ventas"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ABM_Ventas"
        panelDatos.ResumeLayout(False)
        panelDatos.PerformLayout()
        CType(picBuscar, ComponentModel.ISupportInitialize).EndInit()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).EndInit()
        panelProducto.ResumeLayout(False)
        panelProducto.PerformLayout()
        CType(picBuscarProd, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        pnlInferior.ResumeLayout(False)
        pnlInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblABM As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents panelDatos As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitotal As Label
    Friend WithEvents btnFin As Button
    Friend WithEvents GrillaMovVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblID As Label
    Friend WithEvents panelProducto As Panel
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblProd As Label
    Friend WithEvents txtSubtotalCon As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtIVAP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUnitario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblIDMov As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblMov As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents boxComprobante As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents boxMetodo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtCodprod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCondiva As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDatos As Label
    Friend WithEvents picBuscar As PictureBox
    Friend WithEvents lblCuit As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblProvincia As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents picBuscarProd As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents pnlInferior As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
