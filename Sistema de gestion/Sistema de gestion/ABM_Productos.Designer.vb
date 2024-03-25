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
        descripProducto = New TextBox()
        especifiProducto = New TextBox()
        id_producto = New TextBox()
        codProducto = New TextBox()
        UnidadProducto = New TextBox()
        TituloAbmProducto = New TextBox()
        Panel1 = New Panel()
        StockProducto = New TextBox()
        CategoriaProducto = New TextBox()
        RubroProducto = New TextBox()
        PrecioUnitarioProducto = New TextBox()
        TextBox18 = New TextBox()
        btnAceptarABMP = New Button()
        Button2 = New Button()
        lblSeñalProducto = New Label()
        CB_Activo = New CheckBox()
        ID = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' descripProducto
        ' 
        descripProducto.Location = New Point(169, 74)
        descripProducto.Name = "descripProducto"
        descripProducto.Size = New Size(330, 23)
        descripProducto.TabIndex = 2
        ' 
        ' especifiProducto
        ' 
        especifiProducto.Location = New Point(169, 109)
        especifiProducto.Name = "especifiProducto"
        especifiProducto.Size = New Size(330, 23)
        especifiProducto.TabIndex = 3
        ' 
        ' id_producto
        ' 
        id_producto.Enabled = False
        id_producto.Location = New Point(169, 13)
        id_producto.Name = "id_producto"
        id_producto.Size = New Size(62, 23)
        id_producto.TabIndex = 4
        ' 
        ' codProducto
        ' 
        codProducto.Location = New Point(169, 42)
        codProducto.Name = "codProducto"
        codProducto.Size = New Size(120, 23)
        codProducto.TabIndex = 6
        ' 
        ' UnidadProducto
        ' 
        UnidadProducto.Location = New Point(613, 13)
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
        Panel1.Controls.Add(CB_Activo)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ID)
        Panel1.Controls.Add(StockProducto)
        Panel1.Controls.Add(CategoriaProducto)
        Panel1.Controls.Add(RubroProducto)
        Panel1.Controls.Add(UnidadProducto)
        Panel1.Controls.Add(id_producto)
        Panel1.Controls.Add(especifiProducto)
        Panel1.Controls.Add(codProducto)
        Panel1.Controls.Add(descripProducto)
        Panel1.Location = New Point(41, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 161)
        Panel1.TabIndex = 11
        ' 
        ' StockProducto
        ' 
        StockProducto.Location = New Point(613, 109)
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
        ' CB_Activo
        ' 
        CB_Activo.AutoSize = True
        CB_Activo.Location = New Point(767, 15)
        CB_Activo.Name = "CB_Activo"
        CB_Activo.Size = New Size(60, 19)
        CB_Activo.TabIndex = 18
        CB_Activo.Text = "Activo"
        CB_Activo.UseVisualStyleBackColor = True
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(98, 16)
        ID.Name = "ID"
        ID.Size = New Size(20, 15)
        ID.TabIndex = 16
        ID.Text = "id:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 17
        Label1.Text = "Descrip. Producto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 18
        Label2.Text = "Codi. Producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 19
        Label3.Text = "Especificaciones:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(542, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 20
        Label4.Text = "Unidad:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(548, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 21
        Label5.Text = "Rubro:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(529, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 22
        Label6.Text = "Categoria:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(551, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 23
        Label7.Text = "Stock:"
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
    Friend WithEvents descripProducto As TextBox
    Friend WithEvents especifiProducto As TextBox
    Friend WithEvents id_producto As TextBox
    Friend WithEvents codProducto As TextBox
    Friend WithEvents UnidadProducto As TextBox
    Friend WithEvents TituloAbmProducto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StockProducto As TextBox
    Friend WithEvents CategoriaProducto As TextBox
    Friend WithEvents RubroProducto As TextBox
    Friend WithEvents PrecioUnitarioProducto As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSeñalProducto As Label
    Friend WithEvents CB_Activo As CheckBox
    Friend WithEvents ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
