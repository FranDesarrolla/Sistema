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
        Panel2 = New Panel()
        lblTitulo = New Label()
        lblBusqueda = New Label()
        Label1 = New Label()
        btnStock = New Button()
        Panel1 = New Panel()
        CB_Inactivos = New CheckBox()
        lblEdit = New Label()
        CType(GrillaProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(GrillaStockDepositos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
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
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
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
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Controls.Add(lblTitulo)
        Panel2.Location = New Point(28, 11)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 47)
        Panel2.TabIndex = 52
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
        lblBusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblBusqueda.Location = New Point(24, 66)
        lblBusqueda.Name = "lblBusqueda"
        lblBusqueda.Size = New Size(62, 21)
        lblBusqueda.TabIndex = 54
        lblBusqueda.Text = "Buscar:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(857, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 21)
        Label1.TabIndex = 55
        Label1.Text = "Stock por deposito"
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Location = New Point(814, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 24)
        Panel1.TabIndex = 56
        ' 
        ' CB_Inactivos
        ' 
        CB_Inactivos.AutoSize = True
        CB_Inactivos.BackColor = Color.Transparent
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
        Controls.Add(Label1)
        Controls.Add(lblBusqueda)
        Controls.Add(Panel2)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAceptarABMP)
        Controls.Add(txtCodigoPbusqueda)
        Controls.Add(GrillaProductos)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(GrillaProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(GrillaStockDepositos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GrillaProductos As DataGridView
    Friend WithEvents GrillaStockDepositos As DataGridView
    Friend WithEvents txtCodigoPbusqueda As TextBox
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CB_Inactivos As CheckBox
    Friend WithEvents lblEdit As Label
End Class
