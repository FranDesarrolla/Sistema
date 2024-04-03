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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaClientes.Location = New Point(41, 114)
        GrillaClientes.MultiSelect = False
        GrillaClientes.Name = "GrillaClientes"
        GrillaClientes.ReadOnly = True
        GrillaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
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
