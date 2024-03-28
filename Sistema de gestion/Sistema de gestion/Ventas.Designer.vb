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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnAgregar = New Button()
        btnEliminar = New Button()
        Button4 = New Button()
        Button5 = New Button()
        btnEditar = New Button()
        GrillaVentas = New DataGridView()
        CType(GrillaVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.White
        btnAgregar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.ForeColor = Color.Black
        btnAgregar.Location = New Point(919, 65)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(138, 55)
        btnAgregar.TabIndex = 5
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(919, 187)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(138, 55)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(24, 535)
        Button4.Name = "Button4"
        Button4.Size = New Size(176, 55)
        Button4.TabIndex = 8
        Button4.Text = "Emitir Factura"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(727, 535)
        Button5.Name = "Button5"
        Button5.Size = New Size(176, 55)
        Button5.TabIndex = 9
        Button5.Text = "Emitir Remito"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(919, 126)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(138, 55)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
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
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaVentas.RowHeadersVisible = False
        GrillaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaVentas.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaVentas.RowTemplate.Height = 25
        GrillaVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaVentas.ShowCellErrors = False
        GrillaVentas.ShowCellToolTips = False
        GrillaVentas.ShowEditingIcon = False
        GrillaVentas.ShowRowErrors = False
        GrillaVentas.Size = New Size(879, 464)
        GrillaVentas.TabIndex = 11
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(GrillaVentas)
        Controls.Add(btnEditar)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ventas"
        Text = "Ventas"
        CType(GrillaVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents GrillaVentas As DataGridView
End Class
