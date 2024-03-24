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
        TextBox1 = New TextBox()
        descripProducto = New TextBox()
        especifiProducto = New TextBox()
        TextBox2 = New TextBox()
        id_producto = New TextBox()
        TextBox6 = New TextBox()
        codProducto = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        UnidadProducto = New TextBox()
        TituloAbmProducto = New TextBox()
        Panel1 = New Panel()
        StockProducto = New TextBox()
        CategoriaProducto = New TextBox()
        RubroProducto = New TextBox()
        TextBox13 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        PrecioUnitarioProducto = New TextBox()
        TextBox18 = New TextBox()
        btnAceptarABMP = New Button()
        Button2 = New Button()
        lblSeñalProducto = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Menu
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(14, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(18, 16)
        TextBox1.TabIndex = 0
        TextBox1.Text = "ID:"
        ' 
        ' descripProducto
        ' 
        descripProducto.Location = New Point(137, 78)
        descripProducto.Name = "descripProducto"
        descripProducto.Size = New Size(330, 23)
        descripProducto.TabIndex = 2
        ' 
        ' especifiProducto
        ' 
        especifiProducto.Location = New Point(137, 112)
        especifiProducto.Name = "especifiProducto"
        especifiProducto.Size = New Size(330, 23)
        especifiProducto.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Menu
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(14, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(103, 16)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Especificaciones:"
        ' 
        ' id_producto
        ' 
        id_producto.Enabled = False
        id_producto.Location = New Point(137, 9)
        id_producto.Name = "id_producto"
        id_producto.Size = New Size(62, 23)
        id_producto.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = SystemColors.Menu
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(14, 45)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(85, 16)
        TextBox6.TabIndex = 5
        TextBox6.Text = "Cod. Producto:"
        ' 
        ' codProducto
        ' 
        codProducto.Location = New Point(137, 42)
        codProducto.Name = "codProducto"
        codProducto.Size = New Size(120, 23)
        codProducto.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = SystemColors.Menu
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Location = New Point(14, 81)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(103, 16)
        TextBox8.TabIndex = 7
        TextBox8.Text = "Descrip. Producto:"
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = SystemColors.Menu
        TextBox9.BorderStyle = BorderStyle.None
        TextBox9.Location = New Point(548, 81)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(62, 16)
        TextBox9.TabIndex = 8
        TextBox9.Text = "Categoria:"
        ' 
        ' UnidadProducto
        ' 
        UnidadProducto.Location = New Point(613, 9)
        UnidadProducto.Name = "UnidadProducto"
        UnidadProducto.Size = New Size(62, 23)
        UnidadProducto.TabIndex = 9
        ' 
        ' TituloAbmProducto
        ' 
        TituloAbmProducto.Anchor = AnchorStyles.Top
        TituloAbmProducto.BackColor = SystemColors.Menu
        TituloAbmProducto.BorderStyle = BorderStyle.None
        TituloAbmProducto.Location = New Point(304, 12)
        TituloAbmProducto.Name = "TituloAbmProducto"
        TituloAbmProducto.Size = New Size(412, 16)
        TituloAbmProducto.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(StockProducto)
        Panel1.Controls.Add(CategoriaProducto)
        Panel1.Controls.Add(RubroProducto)
        Panel1.Controls.Add(TextBox13)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(UnidadProducto)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox11)
        Panel1.Controls.Add(TextBox12)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(id_producto)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(especifiProducto)
        Panel1.Controls.Add(codProducto)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(descripProducto)
        Panel1.Location = New Point(41, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 152)
        Panel1.TabIndex = 11
        ' 
        ' StockProducto
        ' 
        StockProducto.Location = New Point(613, 112)
        StockProducto.Name = "StockProducto"
        StockProducto.Size = New Size(62, 23)
        StockProducto.TabIndex = 12
        ' 
        ' CategoriaProducto
        ' 
        CategoriaProducto.Location = New Point(613, 74)
        CategoriaProducto.Name = "CategoriaProducto"
        CategoriaProducto.Size = New Size(62, 23)
        CategoriaProducto.TabIndex = 12
        ' 
        ' RubroProducto
        ' 
        RubroProducto.Location = New Point(613, 42)
        RubroProducto.Name = "RubroProducto"
        RubroProducto.Size = New Size(62, 23)
        RubroProducto.TabIndex = 15
        ' 
        ' TextBox13
        ' 
        TextBox13.BackColor = SystemColors.Menu
        TextBox13.BorderStyle = BorderStyle.None
        TextBox13.Location = New Point(548, 118)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(62, 16)
        TextBox13.TabIndex = 14
        TextBox13.Text = "Stock:"
        ' 
        ' TextBox11
        ' 
        TextBox11.BackColor = SystemColors.Menu
        TextBox11.BorderStyle = BorderStyle.None
        TextBox11.Location = New Point(548, 12)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(62, 16)
        TextBox11.TabIndex = 12
        TextBox11.Text = "Unidad:"
        ' 
        ' TextBox12
        ' 
        TextBox12.BackColor = SystemColors.Menu
        TextBox12.BorderStyle = BorderStyle.None
        TextBox12.Location = New Point(548, 45)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(62, 16)
        TextBox12.TabIndex = 13
        TextBox12.Text = "Rubro:"
        ' 
        ' PrecioUnitarioProducto
        ' 
        PrecioUnitarioProducto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PrecioUnitarioProducto.Location = New Point(517, 344)
        PrecioUnitarioProducto.Name = "PrecioUnitarioProducto"
        PrecioUnitarioProducto.Size = New Size(109, 29)
        PrecioUnitarioProducto.TabIndex = 12
        ' 
        ' TextBox18
        ' 
        TextBox18.BackColor = SystemColors.Menu
        TextBox18.BorderStyle = BorderStyle.None
        TextBox18.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox18.Location = New Point(380, 347)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(106, 22)
        TextBox18.TabIndex = 13
        TextBox18.Text = "Precio Unitario:"
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.Location = New Point(424, 462)
        btnAceptarABMP.Name = "btnAceptarABMP"
        btnAceptarABMP.Size = New Size(75, 52)
        btnAceptarABMP.TabIndex = 14
        btnAceptarABMP.Text = "Aceptar"
        btnAceptarABMP.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(551, 462)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 52)
        Button2.TabIndex = 15
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblSeñalProducto
        ' 
        lblSeñalProducto.AutoSize = True
        lblSeñalProducto.Location = New Point(906, 13)
        lblSeñalProducto.Name = "lblSeñalProducto"
        lblSeñalProducto.Size = New Size(41, 15)
        lblSeñalProducto.TabIndex = 17
        lblSeñalProducto.Text = "Label1"
        ' 
        ' ABM_Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 611)
        Controls.Add(lblSeñalProducto)
        Controls.Add(Button2)
        Controls.Add(btnAceptarABMP)
        Controls.Add(TextBox18)
        Controls.Add(PrecioUnitarioProducto)
        Controls.Add(Panel1)
        Controls.Add(TituloAbmProducto)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Productos"
        Text = "ABM_Productos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents descripProducto As TextBox
    Friend WithEvents especifiProducto As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents id_producto As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents codProducto As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents UnidadProducto As TextBox
    Friend WithEvents TituloAbmProducto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents StockProducto As TextBox
    Friend WithEvents CategoriaProducto As TextBox
    Friend WithEvents RubroProducto As TextBox
    Friend WithEvents PrecioUnitarioProducto As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSeñalProducto As Label
End Class
