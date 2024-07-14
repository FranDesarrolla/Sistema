<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        GrillaProveedores = New DataGridView()
        txtBusquedaProveedor = New TextBox()
        Panel3 = New Panel()
        lblTitulo = New Label()
        lblBusqueda = New Label()
        btnEliminarProveedor = New Button()
        btnEditarProveedor = New Button()
        btnAgregar = New Button()
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GrillaProveedores
        ' 
        GrillaProveedores.AllowUserToAddRows = False
        GrillaProveedores.AllowUserToDeleteRows = False
        GrillaProveedores.AllowUserToResizeColumns = False
        GrillaProveedores.AllowUserToResizeRows = False
        GrillaProveedores.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaProveedores.BorderStyle = BorderStyle.None
        GrillaProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaProveedores.Cursor = Cursors.Hand
        GrillaProveedores.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaProveedores.EnableHeadersVisualStyles = False
        GrillaProveedores.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaProveedores.Location = New Point(28, 96)
        GrillaProveedores.MultiSelect = False
        GrillaProveedores.Name = "GrillaProveedores"
        GrillaProveedores.ReadOnly = True
        GrillaProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaProveedores.RowHeadersVisible = False
        GrillaProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaProveedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaProveedores.ShowCellErrors = False
        GrillaProveedores.ShowCellToolTips = False
        GrillaProveedores.ShowEditingIcon = False
        GrillaProveedores.ShowRowErrors = False
        GrillaProveedores.Size = New Size(1013, 436)
        GrillaProveedores.TabIndex = 21
        ' 
        ' txtBusquedaProveedor
        ' 
        txtBusquedaProveedor.Font = New Font("Yu Gothic UI", 12F)
        txtBusquedaProveedor.Location = New Point(88, 62)
        txtBusquedaProveedor.Name = "txtBusquedaProveedor"
        txtBusquedaProveedor.Size = New Size(953, 29)
        txtBusquedaProveedor.TabIndex = 25
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.Controls.Add(lblTitulo)
        Panel3.Location = New Point(28, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1013, 47)
        Panel3.TabIndex = 55
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold)
        lblTitulo.Location = New Point(433, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(149, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Proveedores"
        ' 
        ' lblBusqueda
        ' 
        lblBusqueda.AutoSize = True
        lblBusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblBusqueda.Location = New Point(24, 66)
        lblBusqueda.Name = "lblBusqueda"
        lblBusqueda.Size = New Size(62, 21)
        lblBusqueda.TabIndex = 56
        lblBusqueda.Text = "Buscar:"
        ' 
        ' btnEliminarProveedor
        ' 
        btnEliminarProveedor.BackColor = Color.Tan
        btnEliminarProveedor.FlatAppearance.BorderSize = 0
        btnEliminarProveedor.FlatStyle = FlatStyle.Flat
        btnEliminarProveedor.Font = New Font("Yu Gothic UI", 12F)
        btnEliminarProveedor.Location = New Point(865, 538)
        btnEliminarProveedor.Name = "btnEliminarProveedor"
        btnEliminarProveedor.Size = New Size(176, 55)
        btnEliminarProveedor.TabIndex = 61
        btnEliminarProveedor.Text = "Eliminar"
        btnEliminarProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnEditarProveedor
        ' 
        btnEditarProveedor.BackColor = Color.Tan
        btnEditarProveedor.FlatAppearance.BorderSize = 0
        btnEditarProveedor.FlatStyle = FlatStyle.Flat
        btnEditarProveedor.Font = New Font("Yu Gothic UI", 12F)
        btnEditarProveedor.Location = New Point(210, 538)
        btnEditarProveedor.Name = "btnEditarProveedor"
        btnEditarProveedor.Size = New Size(176, 55)
        btnEditarProveedor.TabIndex = 60
        btnEditarProveedor.Text = "Editar"
        btnEditarProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Yu Gothic UI", 12F)
        btnAgregar.Location = New Point(28, 538)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(176, 55)
        btnAgregar.TabIndex = 62
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnAgregar)
        Controls.Add(btnEliminarProveedor)
        Controls.Add(btnEditarProveedor)
        Controls.Add(lblBusqueda)
        Controls.Add(Panel3)
        Controls.Add(txtBusquedaProveedor)
        Controls.Add(GrillaProveedores)
        FormBorderStyle = FormBorderStyle.None
        Name = "Proveedores"
        Text = "Proveedores"
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GrillaProveedores As DataGridView
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnEditarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents txtBusquedaProveedor As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnAgregar As Button
    'Friend WithEvents btnAgregarProveedor As Button
End Class
