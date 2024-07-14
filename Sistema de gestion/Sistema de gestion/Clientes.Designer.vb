<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        txtBusquedaCliente = New TextBox()
        GrillaClientes = New DataGridView()
        Panel3 = New Panel()
        lblTitulo = New Label()
        lblBusqueda = New Label()
        btnAgregarCliente = New Button()
        btnEditarCliente = New Button()
        btnEliminarCliente = New Button()
        lblEdit = New Label()
        CType(GrillaClientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBusquedaCliente
        ' 
        txtBusquedaCliente.Font = New Font("Yu Gothic UI", 12F)
        txtBusquedaCliente.Location = New Point(88, 62)
        txtBusquedaCliente.Name = "txtBusquedaCliente"
        txtBusquedaCliente.Size = New Size(953, 29)
        txtBusquedaCliente.TabIndex = 18
        ' 
        ' GrillaClientes
        ' 
        GrillaClientes.AllowUserToAddRows = False
        GrillaClientes.AllowUserToDeleteRows = False
        GrillaClientes.AllowUserToResizeColumns = False
        GrillaClientes.AllowUserToResizeRows = False
        GrillaClientes.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaClientes.BorderStyle = BorderStyle.None
        GrillaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaClientes.Cursor = Cursors.Hand
        GrillaClientes.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaClientes.EnableHeadersVisualStyles = False
        GrillaClientes.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaClientes.Location = New Point(28, 96)
        GrillaClientes.MultiSelect = False
        GrillaClientes.Name = "GrillaClientes"
        GrillaClientes.ReadOnly = True
        GrillaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaClientes.RowHeadersVisible = False
        GrillaClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaClientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaClientes.ShowCellErrors = False
        GrillaClientes.ShowCellToolTips = False
        GrillaClientes.ShowEditingIcon = False
        GrillaClientes.ShowRowErrors = False
        GrillaClientes.Size = New Size(1013, 436)
        GrillaClientes.TabIndex = 20
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.Controls.Add(lblTitulo)
        Panel3.Location = New Point(28, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1013, 47)
        Panel3.TabIndex = 54
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold)
        lblTitulo.Location = New Point(455, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(100, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Clientes"
        ' 
        ' lblBusqueda
        ' 
        lblBusqueda.AutoSize = True
        lblBusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblBusqueda.Location = New Point(24, 66)
        lblBusqueda.Name = "lblBusqueda"
        lblBusqueda.Size = New Size(62, 21)
        lblBusqueda.TabIndex = 55
        lblBusqueda.Text = "Buscar:"
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.BackColor = Color.Tan
        btnAgregarCliente.FlatAppearance.BorderSize = 0
        btnAgregarCliente.FlatStyle = FlatStyle.Flat
        btnAgregarCliente.Font = New Font("Yu Gothic UI", 12F)
        btnAgregarCliente.Image = CType(resources.GetObject("btnAgregarCliente.Image"), Image)
        btnAgregarCliente.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregarCliente.Location = New Point(28, 538)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Padding = New Padding(10, 0, 10, 0)
        btnAgregarCliente.Size = New Size(176, 55)
        btnAgregarCliente.TabIndex = 56
        btnAgregarCliente.Text = "Agregar"
        btnAgregarCliente.UseVisualStyleBackColor = False
        ' 
        ' btnEditarCliente
        ' 
        btnEditarCliente.BackColor = Color.Tan
        btnEditarCliente.FlatAppearance.BorderSize = 0
        btnEditarCliente.FlatStyle = FlatStyle.Flat
        btnEditarCliente.Font = New Font("Yu Gothic UI", 12F)
        btnEditarCliente.Image = CType(resources.GetObject("btnEditarCliente.Image"), Image)
        btnEditarCliente.ImageAlign = ContentAlignment.MiddleLeft
        btnEditarCliente.Location = New Point(210, 538)
        btnEditarCliente.Name = "btnEditarCliente"
        btnEditarCliente.Padding = New Padding(10, 0, 10, 0)
        btnEditarCliente.Size = New Size(176, 55)
        btnEditarCliente.TabIndex = 57
        btnEditarCliente.Text = "Editar"
        btnEditarCliente.UseVisualStyleBackColor = False
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.BackColor = Color.Tan
        btnEliminarCliente.FlatAppearance.BorderSize = 0
        btnEliminarCliente.FlatAppearance.MouseOverBackColor = Color.Red
        btnEliminarCliente.FlatStyle = FlatStyle.Flat
        btnEliminarCliente.Font = New Font("Yu Gothic UI", 12F)
        btnEliminarCliente.Image = CType(resources.GetObject("btnEliminarCliente.Image"), Image)
        btnEliminarCliente.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminarCliente.Location = New Point(865, 538)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Padding = New Padding(10, 0, 10, 0)
        btnEliminarCliente.Size = New Size(176, 55)
        btnEliminarCliente.TabIndex = 58
        btnEliminarCliente.Text = "Eliminar"
        btnEliminarCliente.UseVisualStyleBackColor = False
        ' 
        ' lblEdit
        ' 
        lblEdit.AutoSize = True
        lblEdit.Location = New Point(1028, 596)
        lblEdit.Name = "lblEdit"
        lblEdit.Size = New Size(41, 15)
        lblEdit.TabIndex = 59
        lblEdit.Text = "Label1"
        lblEdit.Visible = False
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(lblEdit)
        Controls.Add(btnEliminarCliente)
        Controls.Add(btnEditarCliente)
        Controls.Add(btnAgregarCliente)
        Controls.Add(lblBusqueda)
        Controls.Add(Panel3)
        Controls.Add(GrillaClientes)
        Controls.Add(txtBusquedaCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "Clientes"
        Text = "Clientes"
        CType(GrillaClientes, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtBusquedaCliente As TextBox
    Friend WithEvents GrillaClientes As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents lblEdit As Label
End Class
