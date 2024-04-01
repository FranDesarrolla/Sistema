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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        btnAgregarCliente = New Button()
        btnEditarCliente = New Button()
        btnEliminarCliente = New Button()
        txtBusquedaCliente = New TextBox()
        btnBuscarCliente = New Button()
        GrillaClientes = New DataGridView()
        CType(GrillaClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(496, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 37)
        Label1.TabIndex = 0
        Label1.Text = "Clientes"
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Location = New Point(41, 527)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(135, 37)
        btnAgregarCliente.TabIndex = 6
        btnAgregarCliente.Text = "Agregar"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnEditarCliente
        ' 
        btnEditarCliente.Location = New Point(182, 527)
        btnEditarCliente.Name = "btnEditarCliente"
        btnEditarCliente.Size = New Size(135, 37)
        btnEditarCliente.TabIndex = 7
        btnEditarCliente.Text = "Editar"
        btnEditarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.Location = New Point(323, 527)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Size = New Size(135, 37)
        btnEliminarCliente.TabIndex = 8
        btnEliminarCliente.Text = "Eliminar"
        btnEliminarCliente.UseVisualStyleBackColor = True
        ' 
        ' txtBusquedaCliente
        ' 
        txtBusquedaCliente.Location = New Point(41, 85)
        txtBusquedaCliente.Name = "txtBusquedaCliente"
        txtBusquedaCliente.Size = New Size(388, 23)
        txtBusquedaCliente.TabIndex = 18
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.Location = New Point(435, 85)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(25, 23)
        btnBuscarCliente.TabIndex = 19
        btnBuscarCliente.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        GrillaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        GrillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaClientes.Cursor = Cursors.Hand
        GrillaClientes.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaClientes.EnableHeadersVisualStyles = False
        GrillaClientes.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaClientes.Location = New Point(41, 114)
        GrillaClientes.MultiSelect = False
        GrillaClientes.Name = "GrillaClientes"
        GrillaClientes.ReadOnly = True
        GrillaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        GrillaClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        GrillaClientes.RowHeadersVisible = False
        GrillaClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        GrillaClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        GrillaClientes.RowTemplate.Height = 25
        GrillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaClientes.ShowCellErrors = False
        GrillaClientes.ShowCellToolTips = False
        GrillaClientes.ShowEditingIcon = False
        GrillaClientes.ShowRowErrors = False
        GrillaClientes.Size = New Size(989, 407)
        GrillaClientes.TabIndex = 20
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(GrillaClientes)
        Controls.Add(btnBuscarCliente)
        Controls.Add(txtBusquedaCliente)
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
    Friend WithEvents txtBusquedaCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents GrillaClientes As DataGridView
End Class
