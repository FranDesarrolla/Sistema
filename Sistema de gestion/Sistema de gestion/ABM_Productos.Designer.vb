<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Productos
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
        especifiProducto = New TextBox()
        TituloAbmProducto = New TextBox()
        txtIvaProducto = New TextBox()
        Label8 = New Label()
        CB_Activo = New CheckBox()
        Label3 = New Label()
        PrecioUnitarioProducto = New TextBox()
        lblSeñalProducto = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        lblUnidad = New Label()
        StockProducto = New TextBox()
        CategoriaProducto = New TextBox()
        RubroProducto = New TextBox()
        UnidadProducto = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        codProducto = New TextBox()
        descripProducto = New TextBox()
        id_producto = New TextBox()
        picProducto = New PictureBox()
        Label11 = New Label()
        lblCategoria = New Label()
        lblRubro = New Label()
        btnAceptarABMP = New Button()
        btnVolverABMP = New Button()
        gbDetalle = New GroupBox()
        lblPorc = New Label()
        Label12 = New Label()
        gbCategorizacion = New GroupBox()
        btnLimpiarImagen = New Button()
        btnCargarImagen = New Button()
        pnlFicha = New Panel()
        Panel1 = New Panel()
        CType(picProducto, ComponentModel.ISupportInitialize).BeginInit()
        gbDetalle.SuspendLayout()
        gbCategorizacion.SuspendLayout()
        pnlFicha.SuspendLayout()
        SuspendLayout()
        ' 
        ' especifiProducto
        ' 
        especifiProducto.Font = New Font("Yu Gothic UI", 12F)
        especifiProducto.ForeColor = SystemColors.WindowText
        especifiProducto.Location = New Point(12, 130)
        especifiProducto.MaxLength = 255
        especifiProducto.Multiline = True
        especifiProducto.Name = "especifiProducto"
        especifiProducto.Size = New Size(646, 175)
        especifiProducto.TabIndex = 3
        ' 
        ' TituloAbmProducto
        ' 
        TituloAbmProducto.Anchor = AnchorStyles.Top
        TituloAbmProducto.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        TituloAbmProducto.BorderStyle = BorderStyle.None
        TituloAbmProducto.Enabled = False
        TituloAbmProducto.Location = New Point(915, 0)
        TituloAbmProducto.Name = "TituloAbmProducto"
        TituloAbmProducto.Size = New Size(37, 16)
        TituloAbmProducto.TabIndex = 10
        TituloAbmProducto.TabStop = False
        TituloAbmProducto.Visible = False
        ' 
        ' txtIvaProducto
        ' 
        txtIvaProducto.Font = New Font("Yu Gothic UI", 12F)
        txtIvaProducto.Location = New Point(185, 121)
        txtIvaProducto.MaxLength = 3
        txtIvaProducto.Name = "txtIvaProducto"
        txtIvaProducto.Size = New Size(43, 29)
        txtIvaProducto.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Yu Gothic UI", 12F)
        Label8.Location = New Point(181, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 21)
        Label8.TabIndex = 24
        Label8.Text = "Iva"
        ' 
        ' CB_Activo
        ' 
        CB_Activo.AutoSize = True
        CB_Activo.BackColor = Color.Transparent
        CB_Activo.Font = New Font("Yu Gothic UI", 12F)
        CB_Activo.Location = New Point(594, 20)
        CB_Activo.Name = "CB_Activo"
        CB_Activo.Size = New Size(72, 25)
        CB_Activo.TabIndex = 7
        CB_Activo.TabStop = False
        CB_Activo.Text = "Activo"
        CB_Activo.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic UI", 12F)
        Label3.Location = New Point(8, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 21)
        Label3.TabIndex = 19
        Label3.Text = "Especificaciones"
        ' 
        ' PrecioUnitarioProducto
        ' 
        PrecioUnitarioProducto.Font = New Font("Yu Gothic UI", 12F)
        PrecioUnitarioProducto.Location = New Point(11, 121)
        PrecioUnitarioProducto.MaxLength = 10
        PrecioUnitarioProducto.Name = "PrecioUnitarioProducto"
        PrecioUnitarioProducto.Size = New Size(106, 29)
        PrecioUnitarioProducto.TabIndex = 3
        ' 
        ' lblSeñalProducto
        ' 
        lblSeñalProducto.AutoSize = True
        lblSeñalProducto.Font = New Font("Yu Gothic UI", 12F)
        lblSeñalProducto.Location = New Point(1014, 0)
        lblSeñalProducto.Name = "lblSeñalProducto"
        lblSeñalProducto.Size = New Size(56, 21)
        lblSeñalProducto.TabIndex = 17
        lblSeñalProducto.Text = "Label1"
        lblSeñalProducto.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Yu Gothic UI", 12F)
        Label7.Location = New Point(311, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 21)
        Label7.TabIndex = 31
        Label7.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Yu Gothic UI", 12F)
        Label6.Location = New Point(287, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 21)
        Label6.TabIndex = 30
        Label6.Text = "Categoria"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic UI", 12F)
        Label5.Location = New Point(7, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 21)
        Label5.TabIndex = 29
        Label5.Text = "Rubro"
        ' 
        ' lblUnidad
        ' 
        lblUnidad.AutoSize = True
        lblUnidad.BackColor = Color.Transparent
        lblUnidad.Enabled = False
        lblUnidad.Font = New Font("Yu Gothic UI", 12F)
        lblUnidad.Location = New Point(511, 125)
        lblUnidad.Name = "lblUnidad"
        lblUnidad.Size = New Size(0, 21)
        lblUnidad.TabIndex = 28
        ' 
        ' StockProducto
        ' 
        StockProducto.Font = New Font("Yu Gothic UI", 12F)
        StockProducto.Location = New Point(315, 121)
        StockProducto.MaxLength = 12
        StockProducto.Name = "StockProducto"
        StockProducto.Size = New Size(71, 29)
        StockProducto.TabIndex = 5
        ' 
        ' CategoriaProducto
        ' 
        CategoriaProducto.Font = New Font("Yu Gothic UI", 12F)
        CategoriaProducto.Location = New Point(291, 60)
        CategoriaProducto.MaxLength = 3
        CategoriaProducto.Name = "CategoriaProducto"
        CategoriaProducto.Size = New Size(43, 29)
        CategoriaProducto.TabIndex = 2
        ' 
        ' RubroProducto
        ' 
        RubroProducto.Font = New Font("Yu Gothic UI", 12F)
        RubroProducto.Location = New Point(11, 60)
        RubroProducto.MaxLength = 3
        RubroProducto.Name = "RubroProducto"
        RubroProducto.Size = New Size(43, 29)
        RubroProducto.TabIndex = 1
        ' 
        ' UnidadProducto
        ' 
        UnidadProducto.Font = New Font("Yu Gothic UI", 12F)
        UnidadProducto.Location = New Point(458, 121)
        UnidadProducto.MaxLength = 3
        UnidadProducto.Name = "UnidadProducto"
        UnidadProducto.Size = New Size(43, 29)
        UnidadProducto.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic UI", 12F)
        Label2.Location = New Point(7, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 21)
        Label2.TabIndex = 37
        Label2.Text = "Cod. Producto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic UI", 12F)
        Label1.Location = New Point(181, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 21)
        Label1.TabIndex = 36
        Label1.Text = "Descripción"
        ' 
        ' codProducto
        ' 
        codProducto.Font = New Font("Yu Gothic UI", 12F)
        codProducto.ForeColor = SystemColors.WindowText
        codProducto.Location = New Point(11, 57)
        codProducto.MaxLength = 15
        codProducto.Name = "codProducto"
        codProducto.Size = New Size(106, 29)
        codProducto.TabIndex = 1
        ' 
        ' descripProducto
        ' 
        descripProducto.Font = New Font("Yu Gothic UI", 12F)
        descripProducto.ForeColor = SystemColors.WindowText
        descripProducto.Location = New Point(185, 57)
        descripProducto.MaxLength = 75
        descripProducto.Name = "descripProducto"
        descripProducto.Size = New Size(473, 29)
        descripProducto.TabIndex = 2
        ' 
        ' id_producto
        ' 
        id_producto.BorderStyle = BorderStyle.None
        id_producto.Enabled = False
        id_producto.Font = New Font("Microsoft Sans Serif", 11F)
        id_producto.Location = New Point(0, 0)
        id_producto.Name = "id_producto"
        id_producto.Size = New Size(53, 17)
        id_producto.TabIndex = 33
        id_producto.Visible = False
        ' 
        ' picProducto
        ' 
        picProducto.BorderStyle = BorderStyle.FixedSingle
        picProducto.Location = New Point(40, 38)
        picProducto.Name = "picProducto"
        picProducto.Size = New Size(275, 275)
        picProducto.SizeMode = PictureBoxSizeMode.StretchImage
        picProducto.TabIndex = 44
        picProducto.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Yu Gothic UI", 12F)
        Label11.Location = New Point(453, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 21)
        Label11.TabIndex = 43
        Label11.Text = "Unidad"
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.BackColor = Color.Transparent
        lblCategoria.Enabled = False
        lblCategoria.Font = New Font("Yu Gothic UI", 12F)
        lblCategoria.Location = New Point(343, 64)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(0, 21)
        lblCategoria.TabIndex = 42
        ' 
        ' lblRubro
        ' 
        lblRubro.AutoSize = True
        lblRubro.BackColor = Color.Transparent
        lblRubro.Enabled = False
        lblRubro.Font = New Font("Yu Gothic UI", 12F)
        lblRubro.Location = New Point(64, 64)
        lblRubro.Name = "lblRubro"
        lblRubro.Size = New Size(0, 21)
        lblRubro.TabIndex = 41
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.BackColor = Color.Tan
        btnAceptarABMP.FlatAppearance.BorderSize = 0
        btnAceptarABMP.FlatStyle = FlatStyle.Flat
        btnAceptarABMP.Font = New Font("Yu Gothic UI", 12F)
        btnAceptarABMP.Location = New Point(345, 532)
        btnAceptarABMP.Name = "btnAceptarABMP"
        btnAceptarABMP.Size = New Size(176, 55)
        btnAceptarABMP.TabIndex = 5
        btnAceptarABMP.Text = "Aceptar"
        btnAceptarABMP.UseVisualStyleBackColor = False
        ' 
        ' btnVolverABMP
        ' 
        btnVolverABMP.BackColor = Color.Tan
        btnVolverABMP.FlatAppearance.BorderSize = 0
        btnVolverABMP.FlatStyle = FlatStyle.Flat
        btnVolverABMP.Font = New Font("Yu Gothic UI", 12F)
        btnVolverABMP.Location = New Point(860, 532)
        btnVolverABMP.Name = "btnVolverABMP"
        btnVolverABMP.Size = New Size(176, 55)
        btnVolverABMP.TabIndex = 6
        btnVolverABMP.Text = "Volver"
        btnVolverABMP.UseVisualStyleBackColor = False
        ' 
        ' gbDetalle
        ' 
        gbDetalle.BackColor = Color.Tan
        gbDetalle.Controls.Add(lblPorc)
        gbDetalle.Controls.Add(Label11)
        gbDetalle.Controls.Add(lblUnidad)
        gbDetalle.Controls.Add(Label12)
        gbDetalle.Controls.Add(UnidadProducto)
        gbDetalle.Controls.Add(Label1)
        gbDetalle.Controls.Add(txtIvaProducto)
        gbDetalle.Controls.Add(codProducto)
        gbDetalle.Controls.Add(Label7)
        gbDetalle.Controls.Add(Label2)
        gbDetalle.Controls.Add(StockProducto)
        gbDetalle.Controls.Add(descripProducto)
        gbDetalle.Controls.Add(Label8)
        gbDetalle.Controls.Add(CB_Activo)
        gbDetalle.Controls.Add(PrecioUnitarioProducto)
        gbDetalle.Font = New Font("Yu Gothic UI", 12F)
        gbDetalle.Location = New Point(8, 2)
        gbDetalle.Name = "gbDetalle"
        gbDetalle.Size = New Size(673, 165)
        gbDetalle.TabIndex = 1
        gbDetalle.TabStop = False
        gbDetalle.Text = "Detalle"
        ' 
        ' lblPorc
        ' 
        lblPorc.AutoSize = True
        lblPorc.BackColor = Color.Transparent
        lblPorc.Font = New Font("Yu Gothic UI", 12F)
        lblPorc.Location = New Point(231, 125)
        lblPorc.Name = "lblPorc"
        lblPorc.Size = New Size(23, 21)
        lblPorc.TabIndex = 45
        lblPorc.Text = "%"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Yu Gothic UI", 12F)
        Label12.Location = New Point(7, 93)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 21)
        Label12.TabIndex = 44
        Label12.Text = "Precio unitario"
        ' 
        ' gbCategorizacion
        ' 
        gbCategorizacion.BackColor = Color.Tan
        gbCategorizacion.Controls.Add(Label5)
        gbCategorizacion.Controls.Add(CategoriaProducto)
        gbCategorizacion.Controls.Add(especifiProducto)
        gbCategorizacion.Controls.Add(Label3)
        gbCategorizacion.Controls.Add(lblCategoria)
        gbCategorizacion.Controls.Add(lblRubro)
        gbCategorizacion.Controls.Add(RubroProducto)
        gbCategorizacion.Controls.Add(Label6)
        gbCategorizacion.Font = New Font("Yu Gothic UI", 12F)
        gbCategorizacion.Location = New Point(353, 192)
        gbCategorizacion.Name = "gbCategorizacion"
        gbCategorizacion.Size = New Size(673, 318)
        gbCategorizacion.TabIndex = 2
        gbCategorizacion.TabStop = False
        gbCategorizacion.Text = "Categorizacion"
        ' 
        ' btnLimpiarImagen
        ' 
        btnLimpiarImagen.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        btnLimpiarImagen.FlatAppearance.BorderSize = 0
        btnLimpiarImagen.FlatStyle = FlatStyle.Flat
        btnLimpiarImagen.Font = New Font("Yu Gothic UI", 12F)
        btnLimpiarImagen.Location = New Point(40, 387)
        btnLimpiarImagen.Name = "btnLimpiarImagen"
        btnLimpiarImagen.Size = New Size(275, 55)
        btnLimpiarImagen.TabIndex = 4
        btnLimpiarImagen.TabStop = False
        btnLimpiarImagen.Text = "Limpiar imagen"
        btnLimpiarImagen.UseVisualStyleBackColor = False
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.BackColor = Color.Tan
        btnCargarImagen.FlatAppearance.BorderSize = 0
        btnCargarImagen.FlatStyle = FlatStyle.Flat
        btnCargarImagen.Font = New Font("Yu Gothic UI", 12F)
        btnCargarImagen.Location = New Point(40, 325)
        btnCargarImagen.Name = "btnCargarImagen"
        btnCargarImagen.Size = New Size(275, 55)
        btnCargarImagen.TabIndex = 3
        btnCargarImagen.Text = "Cargar imagen"
        btnCargarImagen.UseVisualStyleBackColor = False
        ' 
        ' pnlFicha
        ' 
        pnlFicha.BackColor = Color.Tan
        pnlFicha.Controls.Add(gbDetalle)
        pnlFicha.Location = New Point(345, 25)
        pnlFicha.Name = "pnlFicha"
        pnlFicha.Size = New Size(691, 499)
        pnlFicha.TabIndex = 53
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Location = New Point(27, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(301, 431)
        Panel1.TabIndex = 54
        ' 
        ' ABM_Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnCargarImagen)
        Controls.Add(btnLimpiarImagen)
        Controls.Add(id_producto)
        Controls.Add(btnVolverABMP)
        Controls.Add(btnAceptarABMP)
        Controls.Add(lblSeñalProducto)
        Controls.Add(TituloAbmProducto)
        Controls.Add(picProducto)
        Controls.Add(gbCategorizacion)
        Controls.Add(pnlFicha)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Productos"
        Text = "ABM_Productos"
        CType(picProducto, ComponentModel.ISupportInitialize).EndInit()
        gbDetalle.ResumeLayout(False)
        gbDetalle.PerformLayout()
        gbCategorizacion.ResumeLayout(False)
        gbCategorizacion.PerformLayout()
        pnlFicha.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents especifiProducto As TextBox
    Friend WithEvents TituloAbmProducto As TextBox
    Friend WithEvents PrecioUnitarioProducto As TextBox
    Friend WithEvents lblSeñalProducto As Label
    Friend WithEvents CB_Activo As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIvaProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents StockProducto As TextBox
    Friend WithEvents CategoriaProducto As TextBox
    Friend WithEvents RubroProducto As TextBox
    Friend WithEvents UnidadProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents codProducto As TextBox
    Friend WithEvents descripProducto As TextBox
    Friend WithEvents id_producto As TextBox
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents btnVolverABMP As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblRubro As Label
    'Friend WithEvents btnCargaImagen As Button
    Friend WithEvents btnLimpiarImagen As Button
    Friend WithEvents picProducto As PictureBox
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents gbCategorizacion As GroupBox
    Friend WithEvents btnCargaImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents pnlFicha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPorc As Label
End Class
