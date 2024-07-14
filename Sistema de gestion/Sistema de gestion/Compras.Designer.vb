<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        GrillaCompras = New DataGridView()
        Panel2 = New Panel()
        lblTitulo = New Label()
        btnEditarCompra = New Button()
        btnAgregarCompra = New Button()
        btnAddCompra = New Button()
        btnDeleteCompra = New Button()
        Panel1 = New Panel()
        btnDetalle = New Button()
        btnBalance = New Button()
        CType(GrillaCompras, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GrillaCompras
        ' 
        GrillaCompras.AllowUserToAddRows = False
        GrillaCompras.AllowUserToDeleteRows = False
        GrillaCompras.AllowUserToResizeColumns = False
        GrillaCompras.AllowUserToResizeRows = False
        GrillaCompras.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaCompras.BorderStyle = BorderStyle.None
        GrillaCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaCompras.Cursor = Cursors.Hand
        GrillaCompras.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaCompras.EnableHeadersVisualStyles = False
        GrillaCompras.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaCompras.Location = New Point(28, 71)
        GrillaCompras.MultiSelect = False
        GrillaCompras.Name = "GrillaCompras"
        GrillaCompras.ReadOnly = True
        GrillaCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaCompras.RowHeadersVisible = False
        GrillaCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaCompras.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaCompras.ShowCellErrors = False
        GrillaCompras.ShowCellToolTips = False
        GrillaCompras.ShowEditingIcon = False
        GrillaCompras.ShowRowErrors = False
        GrillaCompras.Size = New Size(780, 461)
        GrillaCompras.TabIndex = 22
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Controls.Add(lblTitulo)
        Panel2.Location = New Point(28, 11)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 47)
        Panel2.TabIndex = 53
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold)
        lblTitulo.Location = New Point(452, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(110, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Compras"
        ' 
        ' btnEditarCompra
        ' 
        btnEditarCompra.BackColor = Color.Tan
        btnEditarCompra.FlatAppearance.BorderSize = 0
        btnEditarCompra.FlatStyle = FlatStyle.Flat
        btnEditarCompra.Font = New Font("Yu Gothic UI", 12F)
        btnEditarCompra.Image = CType(resources.GetObject("btnEditarCompra.Image"), Image)
        btnEditarCompra.ImageAlign = ContentAlignment.MiddleLeft
        btnEditarCompra.Location = New Point(210, 538)
        btnEditarCompra.Name = "btnEditarCompra"
        btnEditarCompra.Padding = New Padding(10, 0, 10, 0)
        btnEditarCompra.Size = New Size(176, 55)
        btnEditarCompra.TabIndex = 57
        btnEditarCompra.Text = "Editar"
        btnEditarCompra.UseVisualStyleBackColor = False
        ' 
        ' btnAgregarCompra
        ' 
        btnAgregarCompra.BackColor = Color.Tan
        btnAgregarCompra.FlatAppearance.BorderSize = 0
        btnAgregarCompra.FlatStyle = FlatStyle.Flat
        btnAgregarCompra.Font = New Font("Yu Gothic UI", 12F)
        btnAgregarCompra.Location = New Point(28, 538)
        btnAgregarCompra.Name = "btnAgregarCompra"
        btnAgregarCompra.Size = New Size(176, 55)
        btnAgregarCompra.TabIndex = 59
        btnAgregarCompra.Text = "Agregar"
        btnAgregarCompra.UseVisualStyleBackColor = False
        ' 
        ' btnAddCompra
        ' 
        btnAddCompra.BackColor = Color.Tan
        btnAddCompra.FlatAppearance.BorderSize = 0
        btnAddCompra.FlatStyle = FlatStyle.Flat
        btnAddCompra.Font = New Font("Yu Gothic UI", 12F)
        btnAddCompra.Image = CType(resources.GetObject("btnAddCompra.Image"), Image)
        btnAddCompra.ImageAlign = ContentAlignment.MiddleLeft
        btnAddCompra.Location = New Point(28, 538)
        btnAddCompra.Name = "btnAddCompra"
        btnAddCompra.Padding = New Padding(10, 0, 10, 0)
        btnAddCompra.Size = New Size(176, 55)
        btnAddCompra.TabIndex = 58
        btnAddCompra.Text = "Agregar"
        btnAddCompra.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCompra
        ' 
        btnDeleteCompra.BackColor = Color.Tan
        btnDeleteCompra.FlatAppearance.BorderSize = 0
        btnDeleteCompra.FlatAppearance.MouseOverBackColor = Color.Red
        btnDeleteCompra.FlatStyle = FlatStyle.Flat
        btnDeleteCompra.Font = New Font("Yu Gothic UI", 12F)
        btnDeleteCompra.Image = CType(resources.GetObject("btnDeleteCompra.Image"), Image)
        btnDeleteCompra.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteCompra.Location = New Point(632, 538)
        btnDeleteCompra.Name = "btnDeleteCompra"
        btnDeleteCompra.Padding = New Padding(10, 0, 10, 0)
        btnDeleteCompra.Size = New Size(176, 55)
        btnDeleteCompra.TabIndex = 59
        btnDeleteCompra.Text = "Eliminar"
        btnDeleteCompra.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.Location = New Point(814, 193)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 400)
        Panel1.TabIndex = 60
        ' 
        ' btnDetalle
        ' 
        btnDetalle.BackColor = Color.Tan
        btnDetalle.FlatAppearance.BorderSize = 0
        btnDetalle.FlatStyle = FlatStyle.Flat
        btnDetalle.Font = New Font("Yu Gothic UI", 12F)
        btnDetalle.Location = New Point(814, 132)
        btnDetalle.Name = "btnDetalle"
        btnDetalle.Size = New Size(227, 55)
        btnDetalle.TabIndex = 61
        btnDetalle.Text = "Generar detalle"
        btnDetalle.UseVisualStyleBackColor = False
        ' 
        ' btnBalance
        ' 
        btnBalance.BackColor = Color.Tan
        btnBalance.FlatAppearance.BorderSize = 0
        btnBalance.FlatStyle = FlatStyle.Flat
        btnBalance.Font = New Font("Yu Gothic UI", 12F)
        btnBalance.Location = New Point(814, 71)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(227, 55)
        btnBalance.TabIndex = 62
        btnBalance.Text = "Generar balance"
        btnBalance.UseVisualStyleBackColor = False
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnBalance)
        Controls.Add(btnDetalle)
        Controls.Add(btnDeleteCompra)
        Controls.Add(btnAddCompra)
        Controls.Add(btnEditarCompra)
        Controls.Add(Panel2)
        Controls.Add(GrillaCompras)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Compras"
        Text = "Compras"
        CType(GrillaCompras, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents EliminarCompra As Button
    Friend WithEvents EditarCompra As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GrillaCompras As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditarCompra As Button
    Friend WithEvents btnAgregarCompra As Button
    Friend WithEvents btnAddCompra As Button
    Friend WithEvents btnDeleteCompra As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnBalance As Button
End Class
