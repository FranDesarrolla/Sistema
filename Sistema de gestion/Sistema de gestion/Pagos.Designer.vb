<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        lblTitulo = New Label()
        btnAgregar = New Button()
        GrillaProveedores = New DataGridView()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Panel3.SuspendLayout()
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(467, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(79, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Pagos"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.Tan
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAgregar.Location = New Point(28, 538)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(503, 55)
        btnAgregar.TabIndex = 68
        btnAgregar.Text = "Cobrar"
        btnAgregar.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaProveedores.Location = New Point(28, 64)
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
        GrillaProveedores.Size = New Size(503, 468)
        GrillaProveedores.TabIndex = 63
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        DataGridView1.Location = New Point(538, 64)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowCellErrors = False
        DataGridView1.ShowCellToolTips = False
        DataGridView1.ShowEditingIcon = False
        DataGridView1.ShowRowErrors = False
        DataGridView1.Size = New Size(503, 468)
        DataGridView1.TabIndex = 69
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tan
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(538, 538)
        Button1.Name = "Button1"
        Button1.Size = New Size(503, 55)
        Button1.TabIndex = 72
        Button1.Text = "Pagar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Pagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(btnAgregar)
        Controls.Add(GrillaProveedores)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pagos"
        Text = "Pagos"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(GrillaProveedores, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GrillaProveedores As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
