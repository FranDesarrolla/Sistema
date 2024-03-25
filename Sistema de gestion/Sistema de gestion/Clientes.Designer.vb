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
        Label1 = New Label()
        btnAgregarCliente = New Button()
        btnEditarCliente = New Button()
        btnEliminarCliente = New Button()
        GrillaClientes = New DataGridView()
        txtBusquedaCliente = New TextBox()
        btnBuscarCliente = New Button()
        CType(GrillaClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(496, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Clientes"
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Location = New Point(203, 477)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(135, 62)
        btnAgregarCliente.TabIndex = 6
        btnAgregarCliente.Text = "Agregar"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnEditarCliente
        ' 
        btnEditarCliente.Location = New Point(391, 477)
        btnEditarCliente.Name = "btnEditarCliente"
        btnEditarCliente.Size = New Size(135, 62)
        btnEditarCliente.TabIndex = 7
        btnEditarCliente.Text = "Editar"
        btnEditarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.Location = New Point(572, 477)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Size = New Size(135, 62)
        btnEliminarCliente.TabIndex = 8
        btnEliminarCliente.Text = "Eliminar"
        btnEliminarCliente.UseVisualStyleBackColor = True
        ' 
        ' GrillaClientes
        ' 
        GrillaClientes.AllowUserToAddRows = False
        GrillaClientes.AllowUserToDeleteRows = False
        GrillaClientes.AllowUserToResizeColumns = False
        GrillaClientes.AllowUserToResizeRows = False
        GrillaClientes.BackgroundColor = Color.Silver
        GrillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaClientes.Location = New Point(86, 115)
        GrillaClientes.MultiSelect = False
        GrillaClientes.Name = "GrillaClientes"
        GrillaClientes.ReadOnly = True
        GrillaClientes.RowHeadersVisible = False
        GrillaClientes.RowTemplate.Height = 25
        GrillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaClientes.ShowCellErrors = False
        GrillaClientes.ShowCellToolTips = False
        GrillaClientes.ShowEditingIcon = False
        GrillaClientes.ShowRowErrors = False
        GrillaClientes.Size = New Size(783, 289)
        GrillaClientes.TabIndex = 17
        ' 
        ' txtBusquedaCliente
        ' 
        txtBusquedaCliente.Location = New Point(203, 86)
        txtBusquedaCliente.Name = "txtBusquedaCliente"
        txtBusquedaCliente.Size = New Size(113, 23)
        txtBusquedaCliente.TabIndex = 18
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.Location = New Point(347, 85)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(25, 23)
        btnBuscarCliente.TabIndex = 19
        btnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(114), CByte(34), CByte(52))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnBuscarCliente)
        Controls.Add(txtBusquedaCliente)
        Controls.Add(GrillaClientes)
        Controls.Add(btnEliminarCliente)
        Controls.Add(btnEditarCliente)
        Controls.Add(btnAgregarCliente)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Clientes"
        Text = "Clientes"
        CType(GrillaClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents GrillaClientes As DataGridView
    Friend WithEvents txtBusquedaCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
End Class
