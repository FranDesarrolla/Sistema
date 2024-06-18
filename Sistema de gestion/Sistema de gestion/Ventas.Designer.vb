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
        GrillaVentas = New DataGridView()
        btnAgregar = New Button()
        btnRemito = New Button()
        btnFactura = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
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
        GrillaVentas.Location = New Point(28, 70)
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
        GrillaVentas.Size = New Size(780, 462)
        GrillaVentas.TabIndex = 11
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(28, 539)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(176, 55)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnRemito
        ' 
        btnRemito.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnRemito.FlatAppearance.BorderSize = 0
        btnRemito.FlatStyle = FlatStyle.Flat
        btnRemito.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemito.Location = New Point(839, 158)
        btnRemito.Name = "btnRemito"
        btnRemito.Size = New Size(176, 55)
        btnRemito.TabIndex = 14
        btnRemito.Text = "Emite Remito"
        btnRemito.UseVisualStyleBackColor = False
        ' 
        ' btnFactura
        ' 
        btnFactura.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnFactura.FlatAppearance.BorderSize = 0
        btnFactura.FlatStyle = FlatStyle.Flat
        btnFactura.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnFactura.Location = New Point(839, 87)
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
        btnEditar.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(210, 539)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(176, 55)
        btnEditar.TabIndex = 16
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Tan
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(632, 539)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(176, 55)
        btnEliminar.TabIndex = 13
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(839, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 55)
        Button1.TabIndex = 47
        Button1.Text = "Emite Presupuesto"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.Location = New Point(814, 69)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 525)
        Panel1.TabIndex = 50
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Location = New Point(28, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 43)
        Panel2.TabIndex = 51
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Button1)
        Controls.Add(btnEditar)
        Controls.Add(btnFactura)
        Controls.Add(btnRemito)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Controls.Add(GrillaVentas)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ventas"
        Text = "Ventas"
        CType(GrillaVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GrillaVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnRemito As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
