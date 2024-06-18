<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Label2 = New Label()
        btnBuscar = New Button()
        GrillaProductos = New DataGridView()
        DataGridView1 = New DataGridView()
        txtCodigoPbusqueda = New TextBox()
        btnAceptarABMP = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        Panel2 = New Panel()
        CType(GrillaProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1015, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        Label2.Visible = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackgroundImage = My.Resources.Resources.cuadrado
        btnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBuscar.Location = New Point(787, 69)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(21, 22)
        btnBuscar.TabIndex = 15
        btnBuscar.UseVisualStyleBackColor = True
        btnBuscar.Visible = False
        ' 
        ' GrillaProductos
        ' 
        GrillaProductos.AllowUserToAddRows = False
        GrillaProductos.AllowUserToDeleteRows = False
        GrillaProductos.AllowUserToResizeColumns = False
        GrillaProductos.AllowUserToResizeRows = False
        GrillaProductos.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaProductos.BorderStyle = BorderStyle.None
        GrillaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaProductos.Cursor = Cursors.Hand
        GrillaProductos.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaProductos.EnableHeadersVisualStyles = False
        GrillaProductos.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaProductos.Location = New Point(28, 96)
        GrillaProductos.MultiSelect = False
        GrillaProductos.Name = "GrillaProductos"
        GrillaProductos.ReadOnly = True
        GrillaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaProductos.RowHeadersVisible = False
        GrillaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaProductos.RowTemplate.Height = 25
        GrillaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaProductos.ShowCellErrors = False
        GrillaProductos.ShowCellToolTips = False
        GrillaProductos.ShowEditingIcon = False
        GrillaProductos.ShowRowErrors = False
        GrillaProductos.Size = New Size(780, 436)
        GrillaProductos.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.Tan
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        DataGridView1.Location = New Point(814, 69)
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
        DataGridView1.Size = New Size(227, 525)
        DataGridView1.TabIndex = 17
        ' 
        ' txtCodigoPbusqueda
        ' 
        txtCodigoPbusqueda.BackColor = Color.White
        txtCodigoPbusqueda.BorderStyle = BorderStyle.None
        txtCodigoPbusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigoPbusqueda.ForeColor = Color.Black
        txtCodigoPbusqueda.Location = New Point(28, 69)
        txtCodigoPbusqueda.Margin = New Padding(0)
        txtCodigoPbusqueda.Name = "txtCodigoPbusqueda"
        txtCodigoPbusqueda.Size = New Size(780, 22)
        txtCodigoPbusqueda.TabIndex = 18
        txtCodigoPbusqueda.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.BackColor = Color.Tan
        btnAceptarABMP.FlatAppearance.BorderSize = 0
        btnAceptarABMP.FlatStyle = FlatStyle.Flat
        btnAceptarABMP.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAceptarABMP.Location = New Point(28, 539)
        btnAceptarABMP.Name = "btnAceptarABMP"
        btnAceptarABMP.Size = New Size(176, 55)
        btnAceptarABMP.TabIndex = 40
        btnAceptarABMP.Text = "Agregar"
        btnAceptarABMP.UseVisualStyleBackColor = False
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
        btnEditar.TabIndex = 41
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
        btnEliminar.TabIndex = 42
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Location = New Point(28, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 43)
        Panel2.TabIndex = 52
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Panel2)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAceptarABMP)
        Controls.Add(txtCodigoPbusqueda)
        Controls.Add(DataGridView1)
        Controls.Add(GrillaProductos)
        Controls.Add(btnBuscar)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(GrillaProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GrillaProductos As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCodigoPbusqueda As TextBox
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel2 As Panel
End Class
