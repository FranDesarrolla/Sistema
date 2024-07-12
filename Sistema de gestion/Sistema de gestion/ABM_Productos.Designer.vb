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
        Label4 = New Label()
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
        Label10 = New Label()
        Label9 = New Label()
        btnAceptarABMP = New Button()
        btnVolverABMP = New Button()
        GroupBox1 = New GroupBox()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        btnLimpiarImagen = New Button()
        btnCargarImagen = New Button()
        pnlFicha = New Panel()
        Panel1 = New Panel()
        CType(picProducto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        pnlFicha.SuspendLayout()
        SuspendLayout()
        ' 
        ' especifiProducto
        ' 
        especifiProducto.BorderStyle = BorderStyle.None
        especifiProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        especifiProducto.Location = New Point(12, 143)
        especifiProducto.Multiline = True
        especifiProducto.Name = "especifiProducto"
        especifiProducto.Size = New Size(646, 162)
        especifiProducto.TabIndex = 3
        ' 
        ' TituloAbmProducto
        ' 
        TituloAbmProducto.Anchor = AnchorStyles.Top
        TituloAbmProducto.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        TituloAbmProducto.BorderStyle = BorderStyle.None
        TituloAbmProducto.Location = New Point(955, 9)
        TituloAbmProducto.Name = "TituloAbmProducto"
        TituloAbmProducto.Size = New Size(37, 16)
        TituloAbmProducto.TabIndex = 10
        ' 
        ' txtIvaProducto
        ' 
        txtIvaProducto.BorderStyle = BorderStyle.None
        txtIvaProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIvaProducto.Location = New Point(399, 63)
        txtIvaProducto.Name = "txtIvaProducto"
        txtIvaProducto.Size = New Size(76, 17)
        txtIvaProducto.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(399, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 17)
        Label8.TabIndex = 24
        Label8.Text = "Iva:"
        ' 
        ' CB_Activo
        ' 
        CB_Activo.AutoSize = True
        CB_Activo.BackColor = Color.Transparent
        CB_Activo.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Activo.Location = New Point(586, 22)
        CB_Activo.Name = "CB_Activo"
        CB_Activo.Size = New Size(72, 25)
        CB_Activo.TabIndex = 18
        CB_Activo.Text = "Activo"
        CB_Activo.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 21)
        Label3.TabIndex = 19
        Label3.Text = "Especificaciones:"
        ' 
        ' PrecioUnitarioProducto
        ' 
        PrecioUnitarioProducto.BorderStyle = BorderStyle.None
        PrecioUnitarioProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        PrecioUnitarioProducto.Location = New Point(6, 119)
        PrecioUnitarioProducto.Name = "PrecioUnitarioProducto"
        PrecioUnitarioProducto.Size = New Size(106, 17)
        PrecioUnitarioProducto.TabIndex = 12
        ' 
        ' lblSeñalProducto
        ' 
        lblSeñalProducto.AutoSize = True
        lblSeñalProducto.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblSeñalProducto.Location = New Point(1001, 9)
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
        Label7.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(396, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 21)
        Label7.TabIndex = 31
        Label7.Text = "Stock:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(198, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 17)
        Label6.TabIndex = 30
        Label6.Text = "Categoria:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(7, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 21)
        Label5.TabIndex = 29
        Label5.Text = "Rubro:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(185, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 28
        Label4.Text = "Unidad:"
        ' 
        ' StockProducto
        ' 
        StockProducto.BorderStyle = BorderStyle.None
        StockProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        StockProducto.Location = New Point(399, 121)
        StockProducto.Name = "StockProducto"
        StockProducto.Size = New Size(48, 17)
        StockProducto.TabIndex = 25
        ' 
        ' CategoriaProducto
        ' 
        CategoriaProducto.BorderStyle = BorderStyle.None
        CategoriaProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CategoriaProducto.Location = New Point(188, 67)
        CategoriaProducto.Name = "CategoriaProducto"
        CategoriaProducto.Size = New Size(57, 17)
        CategoriaProducto.TabIndex = 26
        ' 
        ' RubroProducto
        ' 
        RubroProducto.BorderStyle = BorderStyle.None
        RubroProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RubroProducto.Location = New Point(12, 67)
        RubroProducto.Name = "RubroProducto"
        RubroProducto.Size = New Size(47, 17)
        RubroProducto.TabIndex = 27
        ' 
        ' UnidadProducto
        ' 
        UnidadProducto.BorderStyle = BorderStyle.None
        UnidadProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        UnidadProducto.Location = New Point(188, 119)
        UnidadProducto.Name = "UnidadProducto"
        UnidadProducto.Size = New Size(47, 17)
        UnidadProducto.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 17)
        Label2.TabIndex = 37
        Label2.Text = "Cod. Producto:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(185, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 17)
        Label1.TabIndex = 36
        Label1.Text = "Descripción:"
        ' 
        ' codProducto
        ' 
        codProducto.BorderStyle = BorderStyle.None
        codProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        codProducto.Location = New Point(6, 58)
        codProducto.Name = "codProducto"
        codProducto.Size = New Size(106, 17)
        codProducto.TabIndex = 34
        ' 
        ' descripProducto
        ' 
        descripProducto.BorderStyle = BorderStyle.None
        descripProducto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        descripProducto.Location = New Point(185, 58)
        descripProducto.Name = "descripProducto"
        descripProducto.Size = New Size(395, 17)
        descripProducto.TabIndex = 32
        ' 
        ' id_producto
        ' 
        id_producto.BorderStyle = BorderStyle.None
        id_producto.Enabled = False
        id_producto.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point)
        id_producto.Location = New Point(-1, 0)
        id_producto.Name = "id_producto"
        id_producto.Size = New Size(53, 17)
        id_producto.TabIndex = 33
        id_producto.Visible = False
        ' 
        ' picProducto
        ' 
        picProducto.BorderStyle = BorderStyle.FixedSingle
        picProducto.Location = New Point(40, 41)
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
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(251, 121)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 17)
        Label11.TabIndex = 43
        Label11.Text = "Unidad:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(251, 67)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 17)
        Label10.TabIndex = 42
        Label10.Text = "Rubro:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(73, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 17)
        Label9.TabIndex = 41
        Label9.Text = "Rubro:"
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.BackColor = Color.Tan
        btnAceptarABMP.FlatAppearance.BorderSize = 0
        btnAceptarABMP.FlatStyle = FlatStyle.Flat
        btnAceptarABMP.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAceptarABMP.Location = New Point(345, 540)
        btnAceptarABMP.Name = "btnAceptarABMP"
        btnAceptarABMP.Size = New Size(176, 55)
        btnAceptarABMP.TabIndex = 39
        btnAceptarABMP.Text = "Aceptar"
        btnAceptarABMP.UseVisualStyleBackColor = False
        ' 
        ' btnVolverABMP
        ' 
        btnVolverABMP.BackColor = Color.Tan
        btnVolverABMP.FlatAppearance.BorderSize = 0
        btnVolverABMP.FlatStyle = FlatStyle.Flat
        btnVolverABMP.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolverABMP.Location = New Point(860, 540)
        btnVolverABMP.Name = "btnVolverABMP"
        btnVolverABMP.Size = New Size(176, 55)
        btnVolverABMP.TabIndex = 40
        btnVolverABMP.Text = "Volver"
        btnVolverABMP.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Tan
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(UnidadProducto)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(codProducto)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(descripProducto)
        GroupBox1.Controls.Add(CB_Activo)
        GroupBox1.Controls.Add(PrecioUnitarioProducto)
        GroupBox1.Controls.Add(StockProducto)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Location = New Point(8, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(673, 165)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detalle"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(6, 96)
        Label12.Name = "Label12"
        Label12.Size = New Size(103, 17)
        Label12.TabIndex = 44
        Label12.Text = "Precio unitario:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Tan
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtIvaProducto)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(CategoriaProducto)
        GroupBox2.Controls.Add(especifiProducto)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(RubroProducto)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(353, 209)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(673, 318)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Categorizacion"
        ' 
        ' btnLimpiarImagen
        ' 
        btnLimpiarImagen.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        btnLimpiarImagen.FlatAppearance.BorderSize = 0
        btnLimpiarImagen.FlatStyle = FlatStyle.Flat
        btnLimpiarImagen.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpiarImagen.Location = New Point(40, 385)
        btnLimpiarImagen.Name = "btnLimpiarImagen"
        btnLimpiarImagen.Size = New Size(275, 55)
        btnLimpiarImagen.TabIndex = 51
        btnLimpiarImagen.Text = "Limpiar imagen"
        btnLimpiarImagen.UseVisualStyleBackColor = False
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.BackColor = Color.Tan
        btnCargarImagen.FlatAppearance.BorderSize = 0
        btnCargarImagen.FlatStyle = FlatStyle.Flat
        btnCargarImagen.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCargarImagen.Location = New Point(40, 323)
        btnCargarImagen.Name = "btnCargarImagen"
        btnCargarImagen.Size = New Size(275, 55)
        btnCargarImagen.TabIndex = 52
        btnCargarImagen.Text = "Cargar imagen"
        btnCargarImagen.UseVisualStyleBackColor = False
        ' 
        ' pnlFicha
        ' 
        pnlFicha.BackColor = Color.Tan
        pnlFicha.Controls.Add(GroupBox1)
        pnlFicha.Location = New Point(345, 23)
        pnlFicha.Name = "pnlFicha"
        pnlFicha.Size = New Size(691, 511)
        pnlFicha.TabIndex = 53
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel1.Location = New Point(27, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(301, 427)
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
        Controls.Add(GroupBox2)
        Controls.Add(pnlFicha)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Productos"
        Text = "ABM_Productos"
        CType(picProducto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    'Friend WithEvents btnCargaImagen As Button
    Friend WithEvents btnLimpiarImagen As Button
    Friend WithEvents picProducto As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCargaImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents pnlFicha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
End Class
