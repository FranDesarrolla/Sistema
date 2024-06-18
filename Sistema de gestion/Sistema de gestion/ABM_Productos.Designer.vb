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
        TextBox18 = New TextBox()
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
        ID = New Label()
        id_producto = New TextBox()
        panelProducto = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        btnAceptarABMP = New Button()
        btnVolverABMP = New Button()
        panelProducto.SuspendLayout()
        SuspendLayout()
        ' 
        ' especifiProducto
        ' 
        especifiProducto.BorderStyle = BorderStyle.None
        especifiProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        especifiProducto.Location = New Point(171, 398)
        especifiProducto.Multiline = True
        especifiProducto.Name = "especifiProducto"
        especifiProducto.Size = New Size(793, 120)
        especifiProducto.TabIndex = 3
        ' 
        ' TituloAbmProducto
        ' 
        TituloAbmProducto.Anchor = AnchorStyles.Top
        TituloAbmProducto.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        TituloAbmProducto.BorderStyle = BorderStyle.None
        TituloAbmProducto.Location = New Point(304, 12)
        TituloAbmProducto.Name = "TituloAbmProducto"
        TituloAbmProducto.Size = New Size(412, 16)
        TituloAbmProducto.TabIndex = 10
        ' 
        ' txtIvaProducto
        ' 
        txtIvaProducto.BorderStyle = BorderStyle.None
        txtIvaProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtIvaProducto.Location = New Point(303, 175)
        txtIvaProducto.Name = "txtIvaProducto"
        txtIvaProducto.Size = New Size(76, 18)
        txtIvaProducto.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label8.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(303, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 17)
        Label8.TabIndex = 24
        Label8.Text = "Iva:"
        ' 
        ' CB_Activo
        ' 
        CB_Activo.AutoSize = True
        CB_Activo.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        CB_Activo.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CB_Activo.Location = New Point(875, 47)
        CB_Activo.Name = "CB_Activo"
        CB_Activo.Size = New Size(72, 25)
        CB_Activo.TabIndex = 18
        CB_Activo.Text = "Activo"
        CB_Activo.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label3.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(167, 371)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 21)
        Label3.TabIndex = 19
        Label3.Text = "Especificaciones:"
        ' 
        ' PrecioUnitarioProducto
        ' 
        PrecioUnitarioProducto.BorderStyle = BorderStyle.None
        PrecioUnitarioProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        PrecioUnitarioProducto.Location = New Point(171, 206)
        PrecioUnitarioProducto.Name = "PrecioUnitarioProducto"
        PrecioUnitarioProducto.Size = New Size(239, 18)
        PrecioUnitarioProducto.TabIndex = 12
        ' 
        ' TextBox18
        ' 
        TextBox18.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        TextBox18.BorderStyle = BorderStyle.None
        TextBox18.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox18.Location = New Point(172, 178)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(124, 17)
        TextBox18.TabIndex = 13
        TextBox18.Text = "Precio Unitario:"
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
        Label7.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label7.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(168, 306)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 21)
        Label7.TabIndex = 31
        Label7.Text = "Stock:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label6.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(193, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 17)
        Label6.TabIndex = 30
        Label6.Text = "Categoria:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label5.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(167, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 21)
        Label5.TabIndex = 29
        Label5.Text = "Rubro:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label4.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(352, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 17)
        Label4.TabIndex = 28
        Label4.Text = "Unidad:"
        ' 
        ' StockProducto
        ' 
        StockProducto.BorderStyle = BorderStyle.None
        StockProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        StockProducto.Location = New Point(171, 333)
        StockProducto.Name = "StockProducto"
        StockProducto.Size = New Size(48, 18)
        StockProducto.TabIndex = 25
        ' 
        ' CategoriaProducto
        ' 
        CategoriaProducto.BorderStyle = BorderStyle.None
        CategoriaProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CategoriaProducto.Location = New Point(352, 237)
        CategoriaProducto.Name = "CategoriaProducto"
        CategoriaProducto.Size = New Size(47, 18)
        CategoriaProducto.TabIndex = 26
        ' 
        ' RubroProducto
        ' 
        RubroProducto.BorderStyle = BorderStyle.None
        RubroProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RubroProducto.Location = New Point(197, 239)
        RubroProducto.Name = "RubroProducto"
        RubroProducto.Size = New Size(47, 18)
        RubroProducto.TabIndex = 27
        ' 
        ' UnidadProducto
        ' 
        UnidadProducto.BorderStyle = BorderStyle.None
        UnidadProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        UnidadProducto.Location = New Point(40, 238)
        UnidadProducto.Name = "UnidadProducto"
        UnidadProducto.Size = New Size(47, 18)
        UnidadProducto.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label2.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(167, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 17)
        Label2.TabIndex = 37
        Label2.Text = "Cod. Producto:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label1.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(167, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 36
        Label1.Text = "Descripción:"
        ' 
        ' codProducto
        ' 
        codProducto.BorderStyle = BorderStyle.None
        codProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        codProducto.Location = New Point(171, 67)
        codProducto.Name = "codProducto"
        codProducto.Size = New Size(106, 18)
        codProducto.TabIndex = 34
        ' 
        ' descripProducto
        ' 
        descripProducto.BorderStyle = BorderStyle.None
        descripProducto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        descripProducto.Location = New Point(171, 138)
        descripProducto.Name = "descripProducto"
        descripProducto.Size = New Size(793, 18)
        descripProducto.TabIndex = 32
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ID.Location = New Point(168, 11)
        ID.Name = "ID"
        ID.Size = New Size(24, 17)
        ID.TabIndex = 35
        ID.Text = "ID:"
        ' 
        ' id_producto
        ' 
        id_producto.BorderStyle = BorderStyle.None
        id_producto.Enabled = False
        id_producto.Font = New Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point)
        id_producto.Location = New Point(168, 37)
        id_producto.Name = "id_producto"
        id_producto.Size = New Size(53, 18)
        id_producto.TabIndex = 33
        ' 
        ' panelProducto
        ' 
        panelProducto.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        panelProducto.Controls.Add(Label11)
        panelProducto.Controls.Add(Label10)
        panelProducto.Controls.Add(Label9)
        panelProducto.Controls.Add(id_producto)
        panelProducto.Controls.Add(ID)
        panelProducto.Controls.Add(txtIvaProducto)
        panelProducto.Controls.Add(Label8)
        panelProducto.Controls.Add(CategoriaProducto)
        panelProducto.Controls.Add(RubroProducto)
        panelProducto.Controls.Add(Label6)
        panelProducto.Controls.Add(Label4)
        panelProducto.Controls.Add(UnidadProducto)
        panelProducto.Enabled = False
        panelProducto.Location = New Point(132, 31)
        panelProducto.Name = "panelProducto"
        panelProducto.Size = New Size(867, 507)
        panelProducto.TabIndex = 38
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label11.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(405, 238)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 17)
        Label11.TabIndex = 43
        Label11.Text = "Unidad:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label10.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(250, 239)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 17)
        Label10.TabIndex = 42
        Label10.Text = "Rubro:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label9.Font = New Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(93, 239)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 17)
        Label9.TabIndex = 41
        Label9.Text = "Rubro:"
        ' 
        ' btnAceptarABMP
        ' 
        btnAceptarABMP.BackColor = Color.Tan
        btnAceptarABMP.FlatAppearance.BorderSize = 0
        btnAceptarABMP.FlatStyle = FlatStyle.Flat
        btnAceptarABMP.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAceptarABMP.Location = New Point(132, 544)
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
        btnVolverABMP.Location = New Point(823, 544)
        btnVolverABMP.Name = "btnVolverABMP"
        btnVolverABMP.Size = New Size(176, 55)
        btnVolverABMP.TabIndex = 40
        btnVolverABMP.Text = "Volver"
        btnVolverABMP.UseVisualStyleBackColor = False
        ' 
        ' ABM_Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnVolverABMP)
        Controls.Add(btnAceptarABMP)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(codProducto)
        Controls.Add(descripProducto)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(especifiProducto)
        Controls.Add(CB_Activo)
        Controls.Add(Label5)
        Controls.Add(StockProducto)
        Controls.Add(lblSeñalProducto)
        Controls.Add(TextBox18)
        Controls.Add(PrecioUnitarioProducto)
        Controls.Add(TituloAbmProducto)
        Controls.Add(panelProducto)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Productos"
        Text = "ABM_Productos"
        panelProducto.ResumeLayout(False)
        panelProducto.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents especifiProducto As TextBox
    Friend WithEvents TituloAbmProducto As TextBox
    Friend WithEvents PrecioUnitarioProducto As TextBox
    Friend WithEvents TextBox18 As TextBox
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
    Friend WithEvents ID As Label
    Friend WithEvents id_producto As TextBox
    Friend WithEvents panelProducto As Panel
    Friend WithEvents btnAceptarABMP As Button
    Friend WithEvents btnVolverABMP As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
