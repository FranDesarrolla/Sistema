<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Label2 = New Label()
        GrillaProductos = New DataGridView()
        GrillaStockDepositos = New DataGridView()
        txtCodigoPbusqueda = New TextBox()
        btnAceptarABMP = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        panelTitulo = New Panel()
        lblTitulo = New Label()
        lblBusqueda = New Label()
        lblStock = New Label()
        btnStock = New Button()
        panelStock = New Panel()
        CB_Inactivos = New CheckBox()
        lblEdit = New Label()
        btnMaximizar = New PictureBox()
        brnRestaurar = New PictureBox()
        PictureBox2 = New PictureBox()
        LabelNotificacion = New Label()
        PanelContenedor = New Panel()
        CType(GrillaProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(GrillaStockDepositos, ComponentModel.ISupportInitialize).BeginInit()
        panelTitulo.SuspendLayout()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1016, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        Label2.Visible = False
        ' 
        ' GrillaProductos
        ' 
        GrillaProductos.AllowUserToAddRows = False
        GrillaProductos.AllowUserToDeleteRows = False
        GrillaProductos.AllowUserToResizeColumns = False
        GrillaProductos.AllowUserToResizeRows = False
        GrillaProductos.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaProductos.BorderStyle = BorderStyle.None
        GrillaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaProductos.Cursor = Cursors.Hand
        GrillaProductos.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaProductos.EnableHeadersVisualStyles = False
        GrillaProductos.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaProductos.Location = New Point(28, 96)
        GrillaProductos.MultiSelect = False
        GrillaProductos.Name = "GrillaProductos"
        GrillaProductos.ReadOnly = True
        GrillaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaProductos.RowHeadersVisible = False
        GrillaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.Tan
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaProductos.ScrollBars = ScrollBars.Vertical
        GrillaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaProductos.ShowCellErrors = False
        GrillaProductos.ShowCellToolTips = False
        GrillaProductos.ShowEditingIcon = False
        GrillaProductos.ShowRowErrors = False
        GrillaProductos.Size = New Size(780, 436)
        GrillaProductos.TabIndex = 2
        ' 
        ' GrillaStockDepositos
        ' 
        GrillaStockDepositos.AllowUserToAddRows = False
        GrillaStockDepositos.AllowUserToDeleteRows = False
        GrillaStockDepositos.AllowUserToResizeColumns = False
        GrillaStockDepositos.AllowUserToResizeRows = False
        GrillaStockDepositos.BackgroundColor = Color.Tan
        GrillaStockDepositos.BorderStyle = BorderStyle.None
        GrillaStockDepositos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        GrillaStockDepositos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        GrillaStockDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaStockDepositos.Cursor = Cursors.Hand
        GrillaStockDepositos.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaStockDepositos.EnableHeadersVisualStyles = False
        GrillaStockDepositos.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaStockDepositos.Location = New Point(814, 120)
        GrillaStockDepositos.MultiSelect = False
        GrillaStockDepositos.Name = "GrillaStockDepositos"
        GrillaStockDepositos.ReadOnly = True
        GrillaStockDepositos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        GrillaStockDepositos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        GrillaStockDepositos.RowHeadersVisible = False
        GrillaStockDepositos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.Tan
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        GrillaStockDepositos.RowsDefaultCellStyle = DataGridViewCellStyle6
        GrillaStockDepositos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaStockDepositos.ShowCellErrors = False
        GrillaStockDepositos.ShowCellToolTips = False
        GrillaStockDepositos.ShowEditingIcon = False
        GrillaStockDepositos.ShowRowErrors = False
        GrillaStockDepositos.Size = New Size(227, 412)
        GrillaStockDepositos.TabIndex = 17
        GrillaStockDepositos.TabStop = False
        ' 
        ' txtCodigoPbusqueda
        ' 
        txtCodigoPbusqueda.BackColor = Color.White
        txtCodigoPbusqueda.Font = New Font("Yu Gothic UI", 12F)
        txtCodigoPbusqueda.ForeColor = Color.Black
        txtCodigoPbusqueda.Location = New Point(88, 62)
        txtCodigoPbusqueda.Margin = New Padding(0)
        txtCodigoPbusqueda.MaxLength = 255
        txtCodigoPbusqueda.Name = "txtCodigoPbusqueda"
        txtCodigoPbusqueda.Size = New Size(720, 29)
        txtCodigoPbusqueda.TabIndex = 1
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.BackColor = Color.Tan
        btnAceptarABMP.FlatAppearance.BorderSize = 0
        btnAceptarABMP.FlatStyle = FlatStyle.Flat
        btnAceptarABMP.Font = New Font("Yu Gothic UI", 12F)
        btnAceptarABMP.Image = CType(resources.GetObject("btnAceptarABMP.Image"), Image)
        btnAceptarABMP.ImageAlign = ContentAlignment.MiddleLeft
        btnAceptarABMP.Location = New Point(28, 538)
        btnAceptarABMP.Name = "btnAceptarABMP"
        btnAceptarABMP.Padding = New Padding(10, 0, 10, 0)
        btnAceptarABMP.Size = New Size(176, 55)
        btnAceptarABMP.TabIndex = 3
        btnAceptarABMP.Text = "Agregar"
        btnAceptarABMP.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Tan
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Yu Gothic UI", 12F)
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleLeft
        btnEditar.Location = New Point(210, 538)
        btnEditar.Name = "btnEditar"
        btnEditar.Padding = New Padding(10, 0, 10, 0)
        btnEditar.Size = New Size(176, 55)
        btnEditar.TabIndex = 4
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Tan
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Yu Gothic UI", 12F)
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminar.Location = New Point(632, 538)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(176, 55)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' panelTitulo
        ' 
        panelTitulo.BackColor = Color.Tan
        panelTitulo.Controls.Add(lblTitulo)
        panelTitulo.Location = New Point(28, 11)
        panelTitulo.Name = "panelTitulo"
        panelTitulo.Size = New Size(1013, 47)
        panelTitulo.TabIndex = 52
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold)
        lblTitulo.Location = New Point(446, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(123, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Productos"
        ' 
        ' lblBusqueda
        ' 
        lblBusqueda.AutoSize = True
        lblBusqueda.BackColor = Color.Transparent
        lblBusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblBusqueda.Location = New Point(24, 66)
        lblBusqueda.Name = "lblBusqueda"
        lblBusqueda.Size = New Size(62, 21)
        lblBusqueda.TabIndex = 54
        lblBusqueda.Text = "Buscar:"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        lblStock.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblStock.Location = New Point(857, 97)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(151, 21)
        lblStock.TabIndex = 55
        lblStock.Text = "Stock por deposito"
        ' 
        ' btnStock
        ' 
        btnStock.BackColor = Color.Tan
        btnStock.FlatAppearance.BorderSize = 0
        btnStock.FlatStyle = FlatStyle.Flat
        btnStock.Font = New Font("Yu Gothic UI", 12F)
        btnStock.Image = CType(resources.GetObject("btnStock.Image"), Image)
        btnStock.ImageAlign = ContentAlignment.MiddleLeft
        btnStock.Location = New Point(814, 538)
        btnStock.Name = "btnStock"
        btnStock.Padding = New Padding(15, 0, 15, 0)
        btnStock.Size = New Size(227, 55)
        btnStock.TabIndex = 6
        btnStock.Text = "Stock"
        btnStock.UseVisualStyleBackColor = False
        ' 
        ' panelStock
        ' 
        panelStock.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelStock.Location = New Point(814, 96)
        panelStock.Name = "panelStock"
        panelStock.Size = New Size(227, 24)
        panelStock.TabIndex = 56
        ' 
        ' CB_Inactivos
        ' 
        CB_Inactivos.AutoSize = True
        CB_Inactivos.BackColor = Color.Transparent
        CB_Inactivos.FlatAppearance.BorderSize = 0
        CB_Inactivos.Font = New Font("Yu Gothic UI", 12F)
        CB_Inactivos.Location = New Point(854, 65)
        CB_Inactivos.Name = "CB_Inactivos"
        CB_Inactivos.Size = New Size(150, 25)
        CB_Inactivos.TabIndex = 57
        CB_Inactivos.TabStop = False
        CB_Inactivos.Text = "Ver solo inactivos"
        CB_Inactivos.UseVisualStyleBackColor = False
        ' 
        ' lblEdit
        ' 
        lblEdit.AutoSize = True
        lblEdit.Location = New Point(1026, 596)
        lblEdit.Name = "lblEdit"
        lblEdit.Size = New Size(40, 15)
        lblEdit.TabIndex = 58
        lblEdit.Text = "lblEdit"
        lblEdit.Visible = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Enabled = False
        btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), Image)
        btnMaximizar.Location = New Point(1755, 11)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(25, 25)
        btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMaximizar.TabIndex = 1
        btnMaximizar.TabStop = False
        btnMaximizar.Visible = False
        ' 
        ' brnRestaurar
        ' 
        brnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        brnRestaurar.BackColor = Color.Transparent
        brnRestaurar.Enabled = False
        brnRestaurar.Image = CType(resources.GetObject("brnRestaurar.Image"), Image)
        brnRestaurar.Location = New Point(1786, 11)
        brnRestaurar.Name = "brnRestaurar"
        brnRestaurar.Size = New Size(25, 25)
        brnRestaurar.SizeMode = PictureBoxSizeMode.Zoom
        brnRestaurar.TabIndex = 1
        brnRestaurar.TabStop = False
        brnRestaurar.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Enabled = False
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(948, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' LabelNotificacion
        ' 
        LabelNotificacion.AutoSize = True
        LabelNotificacion.Enabled = False
        LabelNotificacion.Location = New Point(979, 11)
        LabelNotificacion.Name = "LabelNotificacion"
        LabelNotificacion.Size = New Size(41, 15)
        LabelNotificacion.TabIndex = 2
        LabelNotificacion.Text = "Label1"
        LabelNotificacion.Visible = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        PanelContenedor.Controls.Add(LabelNotificacion)
        PanelContenedor.Controls.Add(PictureBox2)
        PanelContenedor.Controls.Add(brnRestaurar)
        PanelContenedor.Controls.Add(btnMaximizar)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(0, 0)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1069, 611)
        PanelContenedor.TabIndex = 59
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(lblEdit)
        Controls.Add(CB_Inactivos)
        Controls.Add(GrillaStockDepositos)
        Controls.Add(btnStock)
        Controls.Add(lblStock)
        Controls.Add(lblBusqueda)
        Controls.Add(panelTitulo)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAceptarABMP)
        Controls.Add(txtCodigoPbusqueda)
        Controls.Add(GrillaProductos)
        Controls.Add(Label2)
        Controls.Add(panelStock)
        Controls.Add(PanelContenedor)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(GrillaProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(GrillaStockDepositos, ComponentModel.ISupportInitialize).EndInit()
        panelTitulo.ResumeLayout(False)
        panelTitulo.PerformLayout()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(brnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        PanelContenedor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblEdit As Label
    Public WithEvents Label2 As Label
    Public WithEvents GrillaProductos As DataGridView
    Public WithEvents GrillaStockDepositos As DataGridView
    Public WithEvents txtCodigoPbusqueda As TextBox
    Public WithEvents btnAceptarABMP As Button
    Public WithEvents btnEditar As Button
    Public WithEvents btnEliminar As Button
    Public WithEvents panelTitulo As Panel
    Public WithEvents lblBusqueda As Label
    Public WithEvents lblStock As Label
    Public WithEvents btnStock As Button
    Public WithEvents panelStock As Panel
    Public WithEvents CB_Inactivos As CheckBox
    Public WithEvents lblTitulo As Label
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents brnRestaurar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelNotificacion As Label
    Public WithEvents PanelContenedor As Panel
End Class
