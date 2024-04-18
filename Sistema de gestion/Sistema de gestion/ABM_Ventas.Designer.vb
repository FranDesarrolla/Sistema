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
        panelCabecera = New Panel()
        dateTime = New DateTimePicker()
        Panel5 = New Panel()
        lblCod = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtComprobante = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        lblEmpresa = New Label()
        Panel4 = New Panel()
        lblLetra = New Label()
        txtSucursal = New TextBox()
        btnFin = New Button()
        panelDatos = New Panel()
        lblNombreEmpleado = New Label()
        lblEmpleado = New Label()
        txtQuien = New TextBox()
        lblQuien = New Label()
        lblCUITT = New Label()
        lblCUIT = New Label()
        txtCuenta = New TextBox()
        lblDNII = New Label()
        lblDNI = New Label()
        lblDireccion = New Label()
        lblDirec = New Label()
        lblApellidoCliente = New Label()
        lblApellido = New Label()
        lblNombreCliente = New Label()
        lblNombre = New Label()
        panelTotal = New Panel()
        lblTotal = New Label()
        lblTitotal = New Label()
        btnVolver = New Button()
        GrillaMovVentas = New DataGridView()
        btnAgregar = New Button()
        lblID = New Label()
        panelProducto = New Panel()
        Label12 = New Label()
        boxProductos = New ComboBox()
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
        txtIVAP = New TextBox()
        Label10 = New Label()
        txtDescuento = New TextBox()
        Label9 = New Label()
        txtUnitario = New TextBox()
        Label8 = New Label()
        txtCantidad = New TextBox()
        txtCodigo = New TextBox()
        lblProd = New Label()
        lblCantidad = New Label()
        btnEditar = New Button()
        btnEliminar = New Button()
        panelAdd = New Panel()
        panelAdicional = New Panel()
        btnCabecera = New Button()
        boxComprobante = New ComboBox()
        Label18 = New Label()
        boxMetodo = New ComboBox()
        Label17 = New Label()
        Panel1 = New Panel()
        panelCabecera.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        panelDatos.SuspendLayout()
        panelTotal.SuspendLayout()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).BeginInit()
        panelProducto.SuspendLayout()
        panelAdd.SuspendLayout()
        panelAdicional.SuspendLayout()
        Panel1.SuspendLayout()
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
        lblCliente.Location = New Point(25, 15)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(54, 19)
        lblCliente.TabIndex = 3
        lblCliente.Text = "Cliente:"
        ' 
        ' panelCabecera
        ' 
        panelCabecera.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        panelCabecera.Controls.Add(dateTime)
        panelCabecera.Controls.Add(Panel5)
        panelCabecera.Controls.Add(Label6)
        panelCabecera.Controls.Add(Label5)
        panelCabecera.Controls.Add(Label4)
        panelCabecera.Controls.Add(txtComprobante)
        panelCabecera.Controls.Add(Label3)
        panelCabecera.Controls.Add(Label2)
        panelCabecera.Controls.Add(lblEmpresa)
        panelCabecera.Controls.Add(Panel4)
        panelCabecera.Location = New Point(29, 25)
        panelCabecera.Name = "panelCabecera"
        panelCabecera.Size = New Size(1013, 65)
        panelCabecera.TabIndex = 1
        ' 
        ' dateTime
        ' 
        dateTime.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        dateTime.Format = DateTimePickerFormat.Short
        dateTime.Location = New Point(559, 29)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(97, 23)
        dateTime.TabIndex = 1
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(556, 9)
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
        txtComprobante.Enabled = False
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
        Label3.Location = New Point(800, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 19)
        Label3.TabIndex = 13
        Label3.Text = "Comprobante"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(724, 9)
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
        ' txtSucursal
        ' 
        txtSucursal.BackColor = Color.White
        txtSucursal.BorderStyle = BorderStyle.None
        txtSucursal.Enabled = False
        txtSucursal.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSucursal.Location = New Point(753, 56)
        txtSucursal.Name = "txtSucursal"
        txtSucursal.Size = New Size(59, 20)
        txtSucursal.TabIndex = 2
        txtSucursal.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnFin
        ' 
        btnFin.BackColor = Color.Tan
        btnFin.Enabled = False
        btnFin.FlatAppearance.BorderSize = 0
        btnFin.FlatStyle = FlatStyle.Flat
        btnFin.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnFin.Location = New Point(630, 3)
        btnFin.Name = "btnFin"
        btnFin.Size = New Size(158, 31)
        btnFin.TabIndex = 3
        btnFin.Text = "Finalizar"
        btnFin.UseVisualStyleBackColor = False
        ' 
        ' panelDatos
        ' 
        panelDatos.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        panelDatos.Controls.Add(lblNombreEmpleado)
        panelDatos.Controls.Add(lblEmpleado)
        panelDatos.Controls.Add(txtQuien)
        panelDatos.Controls.Add(lblQuien)
        panelDatos.Controls.Add(lblCUITT)
        panelDatos.Controls.Add(lblCUIT)
        panelDatos.Controls.Add(txtCuenta)
        panelDatos.Controls.Add(lblDNII)
        panelDatos.Controls.Add(lblDNI)
        panelDatos.Controls.Add(lblDireccion)
        panelDatos.Controls.Add(lblDirec)
        panelDatos.Controls.Add(lblApellidoCliente)
        panelDatos.Controls.Add(lblApellido)
        panelDatos.Controls.Add(lblNombreCliente)
        panelDatos.Controls.Add(lblNombre)
        panelDatos.Controls.Add(lblCliente)
        panelDatos.Location = New Point(29, 95)
        panelDatos.Name = "panelDatos"
        panelDatos.Size = New Size(1013, 70)
        panelDatos.TabIndex = 2
        ' 
        ' lblNombreEmpleado
        ' 
        lblNombreEmpleado.AutoSize = True
        lblNombreEmpleado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblNombreEmpleado.Location = New Point(740, 37)
        lblNombreEmpleado.Name = "lblNombreEmpleado"
        lblNombreEmpleado.Size = New Size(97, 19)
        lblNombreEmpleado.TabIndex = 32
        lblNombreEmpleado.Text = "###########"
        ' 
        ' lblEmpleado
        ' 
        lblEmpleado.AutoSize = True
        lblEmpleado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmpleado.Location = New Point(662, 37)
        lblEmpleado.Name = "lblEmpleado"
        lblEmpleado.Size = New Size(72, 19)
        lblEmpleado.TabIndex = 31
        lblEmpleado.Text = "Empleado:"
        ' 
        ' txtQuien
        ' 
        txtQuien.BackColor = Color.White
        txtQuien.BorderStyle = BorderStyle.None
        txtQuien.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtQuien.Location = New Point(742, 14)
        txtQuien.Name = "txtQuien"
        txtQuien.Size = New Size(95, 20)
        txtQuien.TabIndex = 2
        txtQuien.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblQuien
        ' 
        lblQuien.AutoSize = True
        lblQuien.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblQuien.Location = New Point(662, 14)
        lblQuien.Name = "lblQuien"
        lblQuien.Size = New Size(49, 19)
        lblQuien.TabIndex = 30
        lblQuien.Text = "Quien:"
        ' 
        ' lblCUITT
        ' 
        lblCUITT.AutoSize = True
        lblCUITT.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCUITT.Location = New Point(86, 36)
        lblCUITT.Name = "lblCUITT"
        lblCUITT.Size = New Size(97, 19)
        lblCUITT.TabIndex = 29
        lblCUITT.Text = "###########"
        lblCUITT.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCUIT
        ' 
        lblCUIT.AutoSize = True
        lblCUIT.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCUIT.Location = New Point(28, 36)
        lblCUIT.Name = "lblCUIT"
        lblCUIT.Size = New Size(42, 19)
        lblCUIT.TabIndex = 28
        lblCUIT.Text = "CUIT:"
        ' 
        ' txtCuenta
        ' 
        txtCuenta.BackColor = Color.White
        txtCuenta.BorderStyle = BorderStyle.None
        txtCuenta.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCuenta.ForeColor = Color.Black
        txtCuenta.Location = New Point(86, 13)
        txtCuenta.Margin = New Padding(0)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(66, 20)
        txtCuenta.TabIndex = 1
        txtCuenta.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblDNII
        ' 
        lblDNII.AutoSize = True
        lblDNII.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDNII.Location = New Point(516, 14)
        lblDNII.Name = "lblDNII"
        lblDNII.Size = New Size(97, 19)
        lblDNII.TabIndex = 12
        lblDNII.Text = "###########"
        lblDNII.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDNI
        ' 
        lblDNI.AutoSize = True
        lblDNI.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDNI.Location = New Point(442, 15)
        lblDNI.Name = "lblDNI"
        lblDNI.Size = New Size(36, 19)
        lblDNI.TabIndex = 11
        lblDNI.Text = "DNI:"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDireccion.Location = New Point(516, 36)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(97, 19)
        lblDireccion.TabIndex = 10
        lblDireccion.Text = "###########"
        ' 
        ' lblDirec
        ' 
        lblDirec.AutoSize = True
        lblDirec.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblDirec.Location = New Point(442, 36)
        lblDirec.Name = "lblDirec"
        lblDirec.Size = New Size(68, 19)
        lblDirec.TabIndex = 9
        lblDirec.Text = "Direccion:"
        ' 
        ' lblApellidoCliente
        ' 
        lblApellidoCliente.AutoSize = True
        lblApellidoCliente.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblApellidoCliente.Location = New Point(296, 36)
        lblApellidoCliente.Name = "lblApellidoCliente"
        lblApellidoCliente.Size = New Size(97, 19)
        lblApellidoCliente.TabIndex = 8
        lblApellidoCliente.Text = "###########"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblApellido.Location = New Point(222, 36)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(61, 19)
        lblApellido.TabIndex = 7
        lblApellido.Text = "Apellido:"
        ' 
        ' lblNombreCliente
        ' 
        lblNombreCliente.AutoSize = True
        lblNombreCliente.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblNombreCliente.Location = New Point(296, 15)
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
        lblNombre.Location = New Point(222, 15)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(62, 19)
        lblNombre.TabIndex = 5
        lblNombre.Text = "Nombre:"
        ' 
        ' panelTotal
        ' 
        panelTotal.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        panelTotal.Controls.Add(lblTotal)
        panelTotal.Controls.Add(lblTitotal)
        panelTotal.Location = New Point(251, 535)
        panelTotal.Name = "panelTotal"
        panelTotal.Size = New Size(791, 50)
        panelTotal.TabIndex = 8
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(630, 11)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(23, 25)
        lblTotal.TabIndex = 19
        lblTotal.Text = "0"
        ' 
        ' lblTitotal
        ' 
        lblTitotal.AutoSize = True
        lblTitotal.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitotal.Location = New Point(555, 11)
        lblTitotal.Name = "lblTitotal"
        lblTitotal.Size = New Size(73, 25)
        lblTitotal.TabIndex = 18
        lblTitotal.Text = "TOTAL:"
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Tan
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolver.Location = New Point(6, 10)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(204, 31)
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
        GrillaMovVentas.Location = New Point(251, 202)
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
        GrillaMovVentas.Size = New Size(791, 284)
        GrillaMovVentas.TabIndex = 7
        GrillaMovVentas.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(6, 322)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(204, 31)
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
        lblID.Visible = False
        ' 
        ' panelProducto
        ' 
        panelProducto.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelProducto.Controls.Add(Label12)
        panelProducto.Controls.Add(boxProductos)
        panelProducto.Controls.Add(lblMov)
        panelProducto.Controls.Add(btnLimpiar)
        panelProducto.Controls.Add(Label16)
        panelProducto.Controls.Add(lblIDMov)
        panelProducto.Controls.Add(txtIVA)
        panelProducto.Controls.Add(Label15)
        panelProducto.Controls.Add(txtSubtotalCon)
        panelProducto.Controls.Add(Label14)
        panelProducto.Controls.Add(txtSubtotalSin)
        panelProducto.Controls.Add(Label11)
        panelProducto.Controls.Add(txtIVAP)
        panelProducto.Controls.Add(Label10)
        panelProducto.Controls.Add(txtDescuento)
        panelProducto.Controls.Add(Label9)
        panelProducto.Controls.Add(txtUnitario)
        panelProducto.Controls.Add(Label8)
        panelProducto.Controls.Add(txtCantidad)
        panelProducto.Controls.Add(txtCodigo)
        panelProducto.Controls.Add(lblProd)
        panelProducto.Controls.Add(btnAgregar)
        panelProducto.Enabled = False
        panelProducto.Location = New Point(29, 170)
        panelProducto.Name = "panelProducto"
        panelProducto.Size = New Size(217, 359)
        panelProducto.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(139, 102)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 19)
        Label12.TabIndex = 48
        Label12.Text = "Cantidad:"
        ' 
        ' boxProductos
        ' 
        boxProductos.BackColor = Color.Tan
        boxProductos.FlatStyle = FlatStyle.Flat
        boxProductos.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxProductos.FormattingEnabled = True
        boxProductos.Location = New Point(6, 53)
        boxProductos.Name = "boxProductos"
        boxProductos.Size = New Size(204, 25)
        boxProductos.TabIndex = 1
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
        btnLimpiar.TabStop = False
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(55, 164)
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
        txtIVA.Enabled = False
        txtIVA.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIVA.ForeColor = Color.Black
        txtIVA.Location = New Point(6, 208)
        txtIVA.Margin = New Padding(0)
        txtIVA.Name = "txtIVA"
        txtIVA.Size = New Size(204, 20)
        txtIVA.TabIndex = 12
        txtIVA.Text = "0,00"
        txtIVA.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(3, 187)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 19)
        Label15.TabIndex = 43
        Label15.Text = "Importe IVA:"
        ' 
        ' txtSubtotalCon
        ' 
        txtSubtotalCon.BackColor = Color.White
        txtSubtotalCon.BorderStyle = BorderStyle.None
        txtSubtotalCon.Enabled = False
        txtSubtotalCon.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubtotalCon.ForeColor = Color.Black
        txtSubtotalCon.Location = New Point(6, 292)
        txtSubtotalCon.Margin = New Padding(0)
        txtSubtotalCon.Name = "txtSubtotalCon"
        txtSubtotalCon.Size = New Size(204, 20)
        txtSubtotalCon.TabIndex = 14
        txtSubtotalCon.Text = "0,00"
        txtSubtotalCon.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(3, 270)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 19)
        Label14.TabIndex = 41
        Label14.Text = "Subtotal (Con IVA):"
        ' 
        ' txtSubtotalSin
        ' 
        txtSubtotalSin.BackColor = Color.White
        txtSubtotalSin.BorderStyle = BorderStyle.None
        txtSubtotalSin.Enabled = False
        txtSubtotalSin.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubtotalSin.ForeColor = Color.Black
        txtSubtotalSin.Location = New Point(6, 250)
        txtSubtotalSin.Margin = New Padding(0)
        txtSubtotalSin.Name = "txtSubtotalSin"
        txtSubtotalSin.Size = New Size(204, 20)
        txtSubtotalSin.TabIndex = 13
        txtSubtotalSin.Text = "0,00"
        txtSubtotalSin.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(3, 228)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 19)
        Label11.TabIndex = 39
        Label11.Text = "Subtotal (Sin IVA):"
        ' 
        ' txtIVAP
        ' 
        txtIVAP.BackColor = Color.White
        txtIVAP.BorderStyle = BorderStyle.None
        txtIVAP.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIVAP.ForeColor = Color.Black
        txtIVAP.Location = New Point(6, 164)
        txtIVAP.Margin = New Padding(0)
        txtIVAP.Name = "txtIVAP"
        txtIVAP.ReadOnly = True
        txtIVAP.Size = New Size(46, 20)
        txtIVAP.TabIndex = 4
        txtIVAP.Text = "0,00"
        txtIVAP.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(3, 145)
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
        txtDescuento.Location = New Point(81, 164)
        txtDescuento.Margin = New Padding(0)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(129, 20)
        txtDescuento.TabIndex = 5
        txtDescuento.Text = "0,00"
        txtDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(76, 144)
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
        txtUnitario.Location = New Point(6, 123)
        txtUnitario.Margin = New Padding(0)
        txtUnitario.Name = "txtUnitario"
        txtUnitario.Size = New Size(129, 20)
        txtUnitario.TabIndex = 2
        txtUnitario.Text = "0,00"
        txtUnitario.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(3, 102)
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
        txtCantidad.Location = New Point(142, 123)
        txtCantidad.Margin = New Padding(0)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(68, 20)
        txtCantidad.TabIndex = 3
        txtCantidad.Text = "0,00"
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.White
        txtCodigo.BorderStyle = BorderStyle.None
        txtCodigo.Enabled = False
        txtCodigo.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigo.ForeColor = Color.Black
        txtCodigo.Location = New Point(6, 81)
        txtCodigo.Margin = New Padding(0)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(204, 20)
        txtCodigo.TabIndex = 7
        txtCodigo.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblProd
        ' 
        lblProd.AutoSize = True
        lblProd.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblProd.Location = New Point(3, 32)
        lblProd.Name = "lblProd"
        lblProd.Size = New Size(68, 19)
        lblProd.TabIndex = 28
        lblProd.Text = "Producto:"
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblCantidad.Location = New Point(248, 313)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(64, 19)
        lblCantidad.TabIndex = 30
        lblCantidad.Text = "Cantidad"
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
        btnEditar.TabIndex = 1
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
        panelAdd.Location = New Point(251, 492)
        panelAdd.Name = "panelAdd"
        panelAdd.Size = New Size(791, 37)
        panelAdd.TabIndex = 5
        ' 
        ' panelAdicional
        ' 
        panelAdicional.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelAdicional.Controls.Add(btnCabecera)
        panelAdicional.Controls.Add(boxComprobante)
        panelAdicional.Controls.Add(Label18)
        panelAdicional.Controls.Add(boxMetodo)
        panelAdicional.Controls.Add(Label17)
        panelAdicional.Location = New Point(251, 170)
        panelAdicional.Name = "panelAdicional"
        panelAdicional.Size = New Size(791, 27)
        panelAdicional.TabIndex = 3
        ' 
        ' btnCabecera
        ' 
        btnCabecera.BackColor = Color.Tan
        btnCabecera.FlatAppearance.BorderSize = 0
        btnCabecera.FlatStyle = FlatStyle.Flat
        btnCabecera.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCabecera.Location = New Point(599, 3)
        btnCabecera.Name = "btnCabecera"
        btnCabecera.Size = New Size(187, 21)
        btnCabecera.TabIndex = 3
        btnCabecera.Text = "Confirmar Cabecera"
        btnCabecera.UseVisualStyleBackColor = False
        ' 
        ' boxComprobante
        ' 
        boxComprobante.BackColor = Color.Tan
        boxComprobante.FlatStyle = FlatStyle.Flat
        boxComprobante.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxComprobante.FormattingEnabled = True
        boxComprobante.ItemHeight = 17
        boxComprobante.Location = New Point(406, 1)
        boxComprobante.Name = "boxComprobante"
        boxComprobante.Size = New Size(121, 25)
        boxComprobante.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(257, 4)
        Label18.Name = "Label18"
        Label18.Size = New Size(143, 19)
        Label18.TabIndex = 30
        Label18.Text = "Tipo de comprobante:"
        ' 
        ' boxMetodo
        ' 
        boxMetodo.BackColor = Color.Tan
        boxMetodo.FlatStyle = FlatStyle.Flat
        boxMetodo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        boxMetodo.FormattingEnabled = True
        boxMetodo.ItemHeight = 17
        boxMetodo.Location = New Point(124, 1)
        boxMetodo.Name = "boxMetodo"
        boxMetodo.Size = New Size(121, 25)
        boxMetodo.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(3, 4)
        Label17.Name = "Label17"
        Label17.Size = New Size(115, 19)
        Label17.TabIndex = 28
        Label17.Text = "Metodo de pago:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(227), CByte(238), CByte(212))
        Panel1.Controls.Add(btnVolver)
        Panel1.Location = New Point(29, 535)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(217, 50)
        Panel1.TabIndex = 6
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(panelAdicional)
        Controls.Add(panelAdd)
        Controls.Add(panelProducto)
        Controls.Add(lblID)
        Controls.Add(GrillaMovVentas)
        Controls.Add(panelTotal)
        Controls.Add(txtSucursal)
        Controls.Add(panelDatos)
        Controls.Add(panelCabecera)
        Controls.Add(lblABM)
        Controls.Add(lblCantidad)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "ABM_Ventas"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ABM_Ventas"
        panelCabecera.ResumeLayout(False)
        panelCabecera.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        panelDatos.ResumeLayout(False)
        panelDatos.PerformLayout()
        panelTotal.ResumeLayout(False)
        panelTotal.PerformLayout()
        CType(GrillaMovVentas, ComponentModel.ISupportInitialize).EndInit()
        panelProducto.ResumeLayout(False)
        panelProducto.PerformLayout()
        panelAdd.ResumeLayout(False)
        panelAdicional.ResumeLayout(False)
        panelAdicional.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblABM As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents panelDatos As Panel
    Friend WithEvents panelTotal As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblLetra As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComprobante As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblCod As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitotal As Label
    Friend WithEvents btnFin As Button
    Friend WithEvents lblApellidoCliente As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDirec As Label
    Friend WithEvents GrillaMovVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblDNII As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblID As Label
    Friend WithEvents panelProducto As Panel
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents panelAdd As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblProd As Label
    Friend WithEvents txtSubtotalCon As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubtotalSin As TextBox
    Friend WithEvents Label11 As Label
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
    Friend WithEvents panelAdicional As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents boxComprobante As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents boxMetodo As ComboBox
    Friend WithEvents lblCUITT As Label
    Friend WithEvents lblCUIT As Label
    Friend WithEvents boxProductos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCabecera As Button
    Friend WithEvents txtQuien As TextBox
    Friend WithEvents lblQuien As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Panel1 As Panel
End Class
