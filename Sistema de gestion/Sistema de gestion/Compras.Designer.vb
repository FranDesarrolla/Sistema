<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        btnBuscarCompra = New Button()
        txtCodigoCompraBusqueda = New TextBox()
        EliminarCompra = New Button()
        EditarCompra = New Button()
        AgregarCompra = New Button()
        GrillaCompras = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        CType(GrillaCompras, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(468, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 0
        Label1.Text = "COMPRASSS"
        ' 
        ' btnBuscarCompra
        ' 
        btnBuscarCompra.BackgroundImage = My.Resources.Resources.cuadrado
        btnBuscarCompra.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscarCompra.FlatAppearance.BorderSize = 0
        btnBuscarCompra.FlatStyle = FlatStyle.Flat
        btnBuscarCompra.Location = New Point(561, 108)
        btnBuscarCompra.Name = "btnBuscarCompra"
        btnBuscarCompra.Size = New Size(21, 20)
        btnBuscarCompra.TabIndex = 27
        btnBuscarCompra.UseVisualStyleBackColor = True
        btnBuscarCompra.Visible = False
        ' 
        ' txtCodigoCompraBusqueda
        ' 
        txtCodigoCompraBusqueda.BackColor = Color.White
        txtCodigoCompraBusqueda.BorderStyle = BorderStyle.None
        txtCodigoCompraBusqueda.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigoCompraBusqueda.ForeColor = Color.Black
        txtCodigoCompraBusqueda.Location = New Point(132, 108)
        txtCodigoCompraBusqueda.Margin = New Padding(0)
        txtCodigoCompraBusqueda.Name = "txtCodigoCompraBusqueda"
        txtCodigoCompraBusqueda.Size = New Size(409, 20)
        txtCodigoCompraBusqueda.TabIndex = 26
        txtCodigoCompraBusqueda.TextAlign = HorizontalAlignment.Center
        ' 
        ' EliminarCompra
        ' 
        EliminarCompra.Location = New Point(461, 499)
        EliminarCompra.Name = "EliminarCompra"
        EliminarCompra.Size = New Size(121, 46)
        EliminarCompra.TabIndex = 25
        EliminarCompra.Text = "Eliminar"
        EliminarCompra.UseVisualStyleBackColor = True
        ' 
        ' EditarCompra
        ' 
        EditarCompra.Location = New Point(305, 499)
        EditarCompra.Name = "EditarCompra"
        EditarCompra.Size = New Size(121, 46)
        EditarCompra.TabIndex = 24
        EditarCompra.Text = "Editar"
        EditarCompra.UseVisualStyleBackColor = True
        ' 
        ' AgregarCompra
        ' 
        AgregarCompra.Location = New Point(151, 499)
        AgregarCompra.Name = "AgregarCompra"
        AgregarCompra.Size = New Size(121, 46)
        AgregarCompra.TabIndex = 23
        AgregarCompra.Text = "Agregar"
        AgregarCompra.UseVisualStyleBackColor = True
        ' 
        ' GrillaCompras
        ' 
        GrillaCompras.AllowUserToAddRows = False
        GrillaCompras.AllowUserToDeleteRows = False
        GrillaCompras.AllowUserToResizeColumns = False
        GrillaCompras.AllowUserToResizeRows = False
        GrillaCompras.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaCompras.BorderStyle = BorderStyle.None
        GrillaCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Tan
        DataGridViewCellStyle7.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.Beige
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        GrillaCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        GrillaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaCompras.Cursor = Cursors.Hand
        GrillaCompras.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaCompras.EnableHeadersVisualStyles = False
        GrillaCompras.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaCompras.Location = New Point(122, 141)
        GrillaCompras.MultiSelect = False
        GrillaCompras.Name = "GrillaCompras"
        GrillaCompras.ReadOnly = True
        GrillaCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.Beige
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        GrillaCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        GrillaCompras.RowHeadersVisible = False
        GrillaCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = Color.Beige
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewCellStyle9.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        GrillaCompras.RowsDefaultCellStyle = DataGridViewCellStyle9
        GrillaCompras.RowTemplate.Height = 25
        GrillaCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaCompras.ShowCellErrors = False
        GrillaCompras.ShowCellToolTips = False
        GrillaCompras.ShowEditingIcon = False
        GrillaCompras.ShowRowErrors = False
        GrillaCompras.Size = New Size(825, 341)
        GrillaCompras.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(691, 511)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 23)
        Button1.TabIndex = 28
        Button1.Text = "Generar Detalle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(858, 511)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 23)
        Button2.TabIndex = 29
        Button2.Text = "Generar balance "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnBuscarCompra)
        Controls.Add(txtCodigoCompraBusqueda)
        Controls.Add(EliminarCompra)
        Controls.Add(EditarCompra)
        Controls.Add(AgregarCompra)
        Controls.Add(GrillaCompras)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Compras"
        Text = "Compras"
        CType(GrillaCompras, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents txtCodigoCompraBusqueda As TextBox
    Friend WithEvents EliminarCompra As Button
    Friend WithEvents EditarCompra As Button
    Friend WithEvents AgregarCompra As Button
    Friend WithEvents GrillaCompras As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
