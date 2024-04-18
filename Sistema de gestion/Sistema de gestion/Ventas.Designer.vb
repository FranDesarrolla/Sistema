<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        GrillaVentas = New DataGridView()
        btnAgregar = New Button()
        btnEliminar = New Button()
        btnRemito = New Button()
        btnFactura = New Button()
        btnEditar = New Button()
        CType(GrillaVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GrillaVentas
        ' 
        GrillaVentas.AllowUserToAddRows = False
        GrillaVentas.AllowUserToDeleteRows = False
        GrillaVentas.AllowUserToResizeColumns = False
        GrillaVentas.AllowUserToResizeRows = False
        GrillaVentas.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaVentas.BorderStyle = BorderStyle.None
        GrillaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        GrillaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        GrillaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaVentas.Cursor = Cursors.Hand
        GrillaVentas.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaVentas.EnableHeadersVisualStyles = False
        GrillaVentas.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaVentas.Location = New Point(24, 65)
        GrillaVentas.MultiSelect = False
        GrillaVentas.Name = "GrillaVentas"
        GrillaVentas.ReadOnly = True
        GrillaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        GrillaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        GrillaVentas.RowHeadersVisible = False
        GrillaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        GrillaVentas.RowsDefaultCellStyle = DataGridViewCellStyle6
        GrillaVentas.RowTemplate.Height = 25
        GrillaVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaVentas.ShowCellErrors = False
        GrillaVentas.ShowCellToolTips = False
        GrillaVentas.ShowEditingIcon = False
        GrillaVentas.ShowRowErrors = False
        GrillaVentas.Size = New Size(879, 464)
        GrillaVentas.TabIndex = 11
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(919, 65)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(138, 55)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Tan
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(919, 187)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(138, 55)
        btnEliminar.TabIndex = 13
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnRemito
        ' 
        btnRemito.BackColor = Color.Tan
        btnRemito.FlatAppearance.BorderSize = 0
        btnRemito.FlatStyle = FlatStyle.Flat
        btnRemito.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemito.Location = New Point(727, 535)
        btnRemito.Name = "btnRemito"
        btnRemito.Size = New Size(176, 55)
        btnRemito.TabIndex = 14
        btnRemito.Text = "Emite Remito"
        btnRemito.UseVisualStyleBackColor = False
        ' 
        ' btnFactura
        ' 
        btnFactura.BackColor = Color.Tan
        btnFactura.FlatAppearance.BorderSize = 0
        btnFactura.FlatStyle = FlatStyle.Flat
        btnFactura.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnFactura.Location = New Point(24, 535)
        btnFactura.Name = "btnFactura"
        btnFactura.Size = New Size(176, 55)
        btnFactura.TabIndex = 15
        btnFactura.Text = "Emite Factura"
        btnFactura.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.Tan
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(919, 126)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(138, 55)
        btnEditar.TabIndex = 16
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnEditar)
        Controls.Add(btnFactura)
        Controls.Add(btnRemito)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Controls.Add(GrillaVentas)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ventas"
        Text = "Ventas"
        CType(GrillaVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GrillaVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRemito As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnEditar As Button
End Class
