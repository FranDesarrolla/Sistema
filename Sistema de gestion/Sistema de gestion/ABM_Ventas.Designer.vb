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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblABM = New Label()
        lblCliente = New Label()
        btnFin = New Button()
        panelDatos = New Panel()
        txtCuenta = New TextBox()
        panelTotal = New Panel()
        lblTotal = New Label()
        lblTitotal = New Label()
        btnVolver = New Button()
        GrillaMovVentas = New DataGridView()
        btnAgregar = New Button()
        lblID = New Label()
        panelProducto = New Panel()
        btnBuscar = New PictureBox()
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
        btnLimpiar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        panelAdd = New Panel()
        panelAdicional = New Panel()
        boxComprobante = New ComboBox()
        Label18 = New Label()
        boxMetodo = New ComboBox()
        Label17 = New Label()
        Label5 = New Label()
        dateTime = New DateTimePicker()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        panelDatos.SuspendLayout()
        panelTotal.SuspendLayout()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).BeginInit()
        panelProducto.SuspendLayout()
        CType(btnBuscar, ComponentModel.ISupportInitialize).BeginInit()
        panelAdd.SuspendLayout()
        panelAdicional.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        lblCliente.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCliente.Location = New Point(29, 19)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(53, 17)
        lblCliente.TabIndex = 3
        lblCliente.Text = "Cliente:"
        ' 
        ' btnFin
        ' 
        btnFin.BackColor = Color.Tan
        btnFin.Enabled = False
        btnFin.FlatAppearance.BorderSize = 0
        btnFin.FlatStyle = FlatStyle.Flat
        btnFin.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnFin.Location = New Point(824, 3)
        btnFin.Name = "btnFin"
        btnFin.Size = New Size(131, 31)
        btnFin.TabIndex = 3
        btnFin.Text = "Finalizar"
        btnFin.UseVisualStyleBackColor = False
        ' 
        ' panelDatos
        ' 
        panelDatos.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelDatos.Controls.Add(txtCuenta)
        panelDatos.Controls.Add(lblCliente)
        panelDatos.Location = New Point(57, 44)
        panelDatos.Name = "panelDatos"
        panelDatos.Size = New Size(217, 54)
        panelDatos.TabIndex = 2
        ' 
        ' txtCuenta
        ' 
        txtCuenta.BackColor = Color.White
        txtCuenta.BorderStyle = BorderStyle.None
        txtCuenta.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCuenta.ForeColor = Color.Black
        txtCuenta.Location = New Point(90, 18)
        txtCuenta.Margin = New Padding(0)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(90, 18)
        txtCuenta.TabIndex = 1
        txtCuenta.TextAlign = HorizontalAlignment.Center
        ' 
        ' panelTotal
        ' 
        panelTotal.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        panelTotal.Controls.Add(lblTotal)
        panelTotal.Controls.Add(lblTitotal)
        panelTotal.Location = New Point(54, 516)
        panelTotal.Name = "panelTotal"
        panelTotal.Size = New Size(958, 50)
        panelTotal.TabIndex = 8
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(799, 16)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(18, 19)
        lblTotal.TabIndex = 19
        lblTotal.Text = "0"
        ' 
        ' lblTitotal
        ' 
        lblTitotal.AutoSize = True
        lblTitotal.Font = New Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitotal.Location = New Point(724, 16)
        lblTitotal.Name = "lblTitotal"
        lblTitotal.Size = New Size(63, 19)
        lblTitotal.TabIndex = 18
        lblTitotal.Text = "TOTAL:"
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Tan
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolver.Location = New Point(12, 7)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(179, 40)
        btnVolver.TabIndex = 1
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
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaMovVentas.Location = New Point(54, 221)
        GrillaMovVentas.MultiSelect = False
        GrillaMovVentas.Name = "GrillaMovVentas"
        GrillaMovVentas.ReadOnly = True
        GrillaMovVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaMovVentas.RowTemplate.Height = 25
        GrillaMovVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaMovVentas.ShowCellErrors = False
        GrillaMovVentas.ShowCellToolTips = False
        GrillaMovVentas.ShowEditingIcon = False
        GrillaMovVentas.ShowRowErrors = False
        GrillaMovVentas.Size = New Size(958, 246)
        GrillaMovVentas.TabIndex = 7
        GrillaMovVentas.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(13, 12)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(230, 40)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblID.Location = New Point(29, 9)
        lblID.Name = "lblID"
        lblID.Size = New Size(13, 13)
        lblID.TabIndex = 18
        lblID.Text = "1"
        ' 
        ' panelProducto
        ' 
        panelProducto.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelProducto.Controls.Add(btnBuscar)
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
        panelProducto.Location = New Point(57, 104)
        panelProducto.Name = "panelProducto"
        panelProducto.Size = New Size(691, 111)
        panelProducto.TabIndex = 4
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackgroundImage = My.Resources.Resources.cuadrado
        btnBuscar.BackgroundImageLayout = ImageLayout.Zoom
        btnBuscar.Location = New Point(195, 31)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(20, 20)
        btnBuscar.TabIndex = 33
        btnBuscar.TabStop = False
        ' 
        ' txtCodprod
        ' 
        txtCodprod.BackColor = Color.White
        txtCodprod.BorderStyle = BorderStyle.None
        txtCodprod.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodprod.ForeColor = Color.Black
        txtCodprod.Location = New Point(11, 32)
        txtCodprod.Margin = New Padding(0)
        txtCodprod.Name = "txtCodprod"
        txtCodprod.Size = New Size(174, 18)
        txtCodprod.TabIndex = 1
        txtCodprod.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(175, 59)
        Label12.Name = "Label12"
        Label12.Size = New Size(68, 17)
        Label12.TabIndex = 48
        Label12.Text = "Cantidad:"
        ' 
        ' lblMov
        ' 
        lblMov.AutoSize = True
        lblMov.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label16.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(368, 79)
        Label16.Name = "Label16"
        Label16.Size = New Size(20, 19)
        Label16.TabIndex = 45
        Label16.Text = "%"
        ' 
        ' lblIDMov
        ' 
        lblIDMov.AutoSize = True
        lblIDMov.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
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
        txtSubtotalCon.BorderStyle = BorderStyle.None
        txtSubtotalCon.Enabled = False
        txtSubtotalCon.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubtotalCon.ForeColor = Color.Black
        txtSubtotalCon.Location = New Point(556, 79)
        txtSubtotalCon.Margin = New Padding(0)
        txtSubtotalCon.Name = "txtSubtotalCon"
        txtSubtotalCon.Size = New Size(123, 18)
        txtSubtotalCon.TabIndex = 14
        txtSubtotalCon.Text = "0,00"
        txtSubtotalCon.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(556, 59)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 17)
        Label14.TabIndex = 41
        Label14.Text = "Total:"
        ' 
        ' txtIVAP
        ' 
        txtIVAP.BackColor = Color.White
        txtIVAP.BorderStyle = BorderStyle.None
        txtIVAP.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIVAP.ForeColor = Color.Black
        txtIVAP.Location = New Point(319, 79)
        txtIVAP.Margin = New Padding(0)
        txtIVAP.Name = "txtIVAP"
        txtIVAP.ReadOnly = True
        txtIVAP.Size = New Size(46, 18)
        txtIVAP.TabIndex = 4
        txtIVAP.Text = "0,00"
        txtIVAP.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(319, 59)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 17)
        Label10.TabIndex = 36
        Label10.Text = "IVA"
        ' 
        ' txtDescuento
        ' 
        txtDescuento.BackColor = Color.White
        txtDescuento.BorderStyle = BorderStyle.None
        txtDescuento.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtDescuento.ForeColor = Color.Black
        txtDescuento.Location = New Point(412, 79)
        txtDescuento.Margin = New Padding(0)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(97, 18)
        txtDescuento.TabIndex = 5
        txtDescuento.Text = "0,00"
        txtDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(412, 57)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 17)
        Label9.TabIndex = 34
        Label9.Text = "Descuento (%):"
        ' 
        ' txtUnitario
        ' 
        txtUnitario.BackColor = Color.White
        txtUnitario.BorderStyle = BorderStyle.None
        txtUnitario.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtUnitario.ForeColor = Color.Black
        txtUnitario.Location = New Point(11, 79)
        txtUnitario.Margin = New Padding(0)
        txtUnitario.Name = "txtUnitario"
        txtUnitario.Size = New Size(129, 18)
        txtUnitario.TabIndex = 2
        txtUnitario.Text = "0,00"
        txtUnitario.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(11, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 17)
        Label8.TabIndex = 32
        Label8.Text = "Precio Unitario:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.White
        txtCantidad.BorderStyle = BorderStyle.None
        txtCantidad.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCantidad.ForeColor = Color.Black
        txtCantidad.Location = New Point(179, 79)
        txtCantidad.Margin = New Padding(0)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(104, 18)
        txtCantidad.TabIndex = 3
        txtCantidad.Text = "0,00"
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BackColor = Color.White
        txtDescripcion.BorderStyle = BorderStyle.None
        txtDescripcion.Enabled = False
        txtDescripcion.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtDescripcion.ForeColor = Color.Black
        txtDescripcion.Location = New Point(227, 32)
        txtDescripcion.Margin = New Padding(0)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(452, 18)
        txtDescripcion.TabIndex = 7
        txtDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblProd
        ' 
        lblProd.AutoSize = True
        lblProd.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblProd.Location = New Point(8, 11)
        lblProd.Name = "lblProd"
        lblProd.Size = New Size(69, 17)
        lblProd.TabIndex = 28
        lblProd.Text = "Producto:"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.Tan
        btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch
        btnLimpiar.FlatAppearance.BorderSize = 0
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpiar.Location = New Point(13, 59)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(230, 39)
        btnLimpiar.TabIndex = 46
        btnLimpiar.TabStop = False
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Tan
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(3, 3)
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
        btnEliminar.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(140, 3)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 31)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' panelAdd
        ' 
        panelAdd.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelAdd.Controls.Add(btnFin)
        panelAdd.Controls.Add(btnEditar)
        panelAdd.Controls.Add(btnEliminar)
        panelAdd.Enabled = False
        panelAdd.Location = New Point(54, 473)
        panelAdd.Name = "panelAdd"
        panelAdd.Size = New Size(958, 37)
        panelAdd.TabIndex = 5
        ' 
        ' panelAdicional
        ' 
        panelAdicional.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelAdicional.Controls.Add(boxComprobante)
        panelAdicional.Controls.Add(Label18)
        panelAdicional.Controls.Add(boxMetodo)
        panelAdicional.Controls.Add(Label17)
        panelAdicional.Location = New Point(503, 44)
        panelAdicional.Name = "panelAdicional"
        panelAdicional.Size = New Size(297, 54)
        panelAdicional.TabIndex = 3
        ' 
        ' boxComprobante
        ' 
        boxComprobante.BackColor = Color.Tan
        boxComprobante.FlatStyle = FlatStyle.Flat
        boxComprobante.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxComprobante.FormattingEnabled = True
        boxComprobante.ItemHeight = 15
        boxComprobante.Location = New Point(149, 27)
        boxComprobante.Name = "boxComprobante"
        boxComprobante.Size = New Size(145, 23)
        boxComprobante.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(5, 30)
        Label18.Name = "Label18"
        Label18.Size = New Size(143, 17)
        Label18.TabIndex = 30
        Label18.Text = "Tipo de comprobante:"
        ' 
        ' boxMetodo
        ' 
        boxMetodo.BackColor = Color.Tan
        boxMetodo.FlatStyle = FlatStyle.Flat
        boxMetodo.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxMetodo.FormattingEnabled = True
        boxMetodo.ItemHeight = 15
        boxMetodo.Location = New Point(149, 2)
        boxMetodo.Name = "boxMetodo"
        boxMetodo.Size = New Size(145, 23)
        boxMetodo.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(5, 5)
        Label17.Name = "Label17"
        Label17.Size = New Size(112, 17)
        Label17.TabIndex = 28
        Label17.Text = "Metodo de pago:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(14, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 15
        Label5.Text = "Fecha:"
        ' 
        ' dateTime
        ' 
        dateTime.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        dateTime.Format = DateTimePickerFormat.Short
        dateTime.Location = New Point(72, 14)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(124, 24)
        dateTime.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dateTime)
        Panel1.Location = New Point(280, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(217, 54)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel2.Controls.Add(btnVolver)
        Panel2.Location = New Point(806, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(203, 54)
        Panel2.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel3.Controls.Add(btnAgregar)
        Panel3.Controls.Add(btnLimpiar)
        Panel3.Location = New Point(754, 104)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(255, 111)
        Panel3.TabIndex = 5
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(panelAdicional)
        Controls.Add(panelAdd)
        Controls.Add(panelProducto)
        Controls.Add(lblID)
        Controls.Add(GrillaMovVentas)
        Controls.Add(panelTotal)
        Controls.Add(panelDatos)
        Controls.Add(lblABM)
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
        panelTotal.ResumeLayout(False)
        panelTotal.PerformLayout()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).EndInit()
        panelProducto.ResumeLayout(False)
        panelProducto.PerformLayout()
        CType(btnBuscar, ComponentModel.ISupportInitialize).EndInit()
        panelAdd.ResumeLayout(False)
        panelAdicional.ResumeLayout(False)
        panelAdicional.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblABM As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents panelDatos As Panel
    Friend WithEvents panelTotal As Panel
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
    Friend WithEvents panelAdd As Panel
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
    Friend WithEvents panelAdicional As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents boxComprobante As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents boxMetodo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnBuscar As PictureBox
    Friend WithEvents txtCodprod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
