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
        btnEliminarProveedor = New Button()
        btnEditarProveedor = New Button()
        btnAgregarProveedor = New Button()
        btnBuscarProveedor = New Button()
        txtBusquedaProveedor = New TextBox()
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaProveedores.Location = New Point(40, 102)
        GrillaProveedores.MultiSelect = False
        GrillaProveedores.Name = "GrillaProveedores"
        GrillaProveedores.ReadOnly = True
        GrillaProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaProveedores.RowTemplate.Height = 25
        GrillaProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaProveedores.ShowCellErrors = False
        GrillaProveedores.ShowCellToolTips = False
        GrillaProveedores.ShowEditingIcon = False
        GrillaProveedores.ShowRowErrors = False
        GrillaProveedores.Size = New Size(989, 407)
        GrillaProveedores.TabIndex = 21
        ' 
        ' btnEliminarProveedor
        ' 
        btnEliminarProveedor.Location = New Point(322, 515)
        btnEliminarProveedor.Name = "btnEliminarProveedor"
        btnEliminarProveedor.Size = New Size(135, 37)
        btnEliminarProveedor.TabIndex = 24
        btnEliminarProveedor.Text = "Eliminar"
        btnEliminarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnEditarProveedor
        ' 
        btnEditarProveedor.Location = New Point(181, 515)
        btnEditarProveedor.Name = "btnEditarProveedor"
        btnEditarProveedor.Size = New Size(135, 37)
        btnEditarProveedor.TabIndex = 23
        btnEditarProveedor.Text = "Editar"
        btnEditarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarProveedor
        ' 
        btnAgregarProveedor.Location = New Point(40, 515)
        btnAgregarProveedor.Name = "btnAgregarProveedor"
        btnAgregarProveedor.Size = New Size(135, 37)
        btnAgregarProveedor.TabIndex = 22
        btnAgregarProveedor.Text = "Agregar"
        btnAgregarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarProveedor
        ' 
        btnBuscarProveedor.Location = New Point(434, 73)
        btnBuscarProveedor.Name = "btnBuscarProveedor"
        btnBuscarProveedor.Size = New Size(25, 23)
        btnBuscarProveedor.TabIndex = 26
        btnBuscarProveedor.UseVisualStyleBackColor = True
        ' 
        ' txtBusquedaProveedor
        ' 
        txtBusquedaProveedor.Location = New Point(40, 73)
        txtBusquedaProveedor.Name = "txtBusquedaProveedor"
        txtBusquedaProveedor.Size = New Size(388, 23)
        txtBusquedaProveedor.TabIndex = 25
        ' 
        ' Proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnBuscarProveedor)
        Controls.Add(txtBusquedaProveedor)
        Controls.Add(btnEliminarProveedor)
        Controls.Add(btnEditarProveedor)
        Controls.Add(btnAgregarProveedor)
        Controls.Add(GrillaProveedores)
        FormBorderStyle = FormBorderStyle.None
        Name = "Proveedores"
        Text = "Proveedores"
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GrillaProveedores As DataGridView
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnEditarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents txtBusquedaProveedor As TextBox
End Class
