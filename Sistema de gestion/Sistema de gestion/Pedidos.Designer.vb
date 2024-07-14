<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        GrillaPedidos = New DataGridView()
        txtCodigoPedidobusqueda = New TextBox()
        Panel3 = New Panel()
        lblTitulo = New Label()
        lblBusqueda = New Label()
        EliminarPedido = New Button()
        EditarPedido = New Button()
        AgregarPedido = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel11 = New Panel()
        btnAnular = New Button()
        Panel10 = New Panel()
        btnFaltapagar = New Button()
        Panel9 = New Panel()
        btnTerminar = New Button()
        Panel8 = New Panel()
        btnFacturar = New Button()
        Panel7 = New Panel()
        btnAceptar = New Button()
        Panel6 = New Panel()
        btnPreparar = New Button()
        Panel5 = New Panel()
        btnPendiente = New Button()
        Panel1 = New Panel()
        CType(GrillaPedidos, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GrillaPedidos
        ' 
        GrillaPedidos.AllowUserToAddRows = False
        GrillaPedidos.AllowUserToDeleteRows = False
        GrillaPedidos.AllowUserToResizeColumns = False
        GrillaPedidos.AllowUserToResizeRows = False
        GrillaPedidos.BackgroundColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        GrillaPedidos.BorderStyle = BorderStyle.None
        GrillaPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Tan
        DataGridViewCellStyle1.Font = New Font("Arial", 10F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GrillaPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GrillaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaPedidos.Cursor = Cursors.Hand
        GrillaPedidos.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaPedidos.EnableHeadersVisualStyles = False
        GrillaPedidos.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaPedidos.Location = New Point(28, 96)
        GrillaPedidos.MultiSelect = False
        GrillaPedidos.Name = "GrillaPedidos"
        GrillaPedidos.ReadOnly = True
        GrillaPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GrillaPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        GrillaPedidos.RowHeadersVisible = False
        GrillaPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        GrillaPedidos.RowsDefaultCellStyle = DataGridViewCellStyle3
        GrillaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaPedidos.ShowCellErrors = False
        GrillaPedidos.ShowCellToolTips = False
        GrillaPedidos.ShowEditingIcon = False
        GrillaPedidos.ShowRowErrors = False
        GrillaPedidos.Size = New Size(780, 436)
        GrillaPedidos.TabIndex = 12
        ' 
        ' txtCodigoPedidobusqueda
        ' 
        txtCodigoPedidobusqueda.BackColor = Color.White
        txtCodigoPedidobusqueda.Font = New Font("Yu Gothic UI", 12F)
        txtCodigoPedidobusqueda.ForeColor = Color.Black
        txtCodigoPedidobusqueda.Location = New Point(88, 62)
        txtCodigoPedidobusqueda.Margin = New Padding(0)
        txtCodigoPedidobusqueda.Name = "txtCodigoPedidobusqueda"
        txtCodigoPedidobusqueda.Size = New Size(720, 29)
        txtCodigoPedidobusqueda.TabIndex = 19
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
        lblTitulo.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold)
        lblTitulo.Location = New Point(457, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(99, 32)
        lblTitulo.TabIndex = 53
        lblTitulo.Text = "Pedidos"
        ' 
        ' lblBusqueda
        ' 
        lblBusqueda.AutoSize = True
        lblBusqueda.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        lblBusqueda.Location = New Point(24, 66)
        lblBusqueda.Name = "lblBusqueda"
        lblBusqueda.Size = New Size(62, 21)
        lblBusqueda.TabIndex = 56
        lblBusqueda.Text = "Buscar:"
        ' 
        ' EliminarPedido
        ' 
        EliminarPedido.BackColor = Color.Tan
        EliminarPedido.FlatAppearance.BorderSize = 0
        EliminarPedido.FlatAppearance.MouseOverBackColor = Color.Red
        EliminarPedido.FlatStyle = FlatStyle.Flat
        EliminarPedido.Font = New Font("Yu Gothic UI", 12F)
        EliminarPedido.Image = CType(resources.GetObject("EliminarPedido.Image"), Image)
        EliminarPedido.ImageAlign = ContentAlignment.MiddleLeft
        EliminarPedido.Location = New Point(632, 538)
        EliminarPedido.Name = "EliminarPedido"
        EliminarPedido.Padding = New Padding(10, 0, 10, 0)
        EliminarPedido.Size = New Size(176, 55)
        EliminarPedido.TabIndex = 61
        EliminarPedido.Text = "Eliminar"
        EliminarPedido.UseVisualStyleBackColor = False
        ' 
        ' EditarPedido
        ' 
        EditarPedido.BackColor = Color.Tan
        EditarPedido.FlatAppearance.BorderSize = 0
        EditarPedido.FlatStyle = FlatStyle.Flat
        EditarPedido.Font = New Font("Yu Gothic UI", 12F)
        EditarPedido.Image = CType(resources.GetObject("EditarPedido.Image"), Image)
        EditarPedido.ImageAlign = ContentAlignment.MiddleLeft
        EditarPedido.Location = New Point(210, 538)
        EditarPedido.Name = "EditarPedido"
        EditarPedido.Padding = New Padding(10, 0, 10, 0)
        EditarPedido.Size = New Size(176, 55)
        EditarPedido.TabIndex = 60
        EditarPedido.Text = "Editar"
        EditarPedido.UseVisualStyleBackColor = False
        ' 
        ' AgregarPedido
        ' 
        AgregarPedido.BackColor = Color.Tan
        AgregarPedido.FlatAppearance.BorderSize = 0
        AgregarPedido.FlatStyle = FlatStyle.Flat
        AgregarPedido.Font = New Font("Yu Gothic UI", 12F)
        AgregarPedido.Image = CType(resources.GetObject("AgregarPedido.Image"), Image)
        AgregarPedido.ImageAlign = ContentAlignment.MiddleLeft
        AgregarPedido.Location = New Point(28, 538)
        AgregarPedido.Name = "AgregarPedido"
        AgregarPedido.Padding = New Padding(10, 0, 10, 0)
        AgregarPedido.Size = New Size(176, 55)
        AgregarPedido.TabIndex = 59
        AgregarPedido.Text = "Agregar"
        AgregarPedido.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Label1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(852, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 21)
        Label1.TabIndex = 71
        Label1.Text = "Manejo de estados"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        Panel2.Location = New Point(812, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(227, 32)
        Panel2.TabIndex = 65
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel4.Controls.Add(Panel11)
        Panel4.Controls.Add(btnAnular)
        Panel4.Controls.Add(Panel10)
        Panel4.Controls.Add(btnFaltapagar)
        Panel4.Controls.Add(Panel9)
        Panel4.Controls.Add(btnTerminar)
        Panel4.Controls.Add(Panel8)
        Panel4.Controls.Add(btnFacturar)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(btnAceptar)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(btnPreparar)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(btnPendiente)
        Panel4.Controls.Add(Panel1)
        Panel4.Location = New Point(812, 89)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(227, 298)
        Panel4.TabIndex = 55
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 270)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(227, 10)
        Panel11.TabIndex = 94
        ' 
        ' btnAnular
        ' 
        btnAnular.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnAnular.Dock = DockStyle.Top
        btnAnular.FlatAppearance.BorderSize = 0
        btnAnular.FlatStyle = FlatStyle.Flat
        btnAnular.Font = New Font("Yu Gothic UI", 9.75F)
        btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), Image)
        btnAnular.ImageAlign = ContentAlignment.MiddleLeft
        btnAnular.Location = New Point(0, 241)
        btnAnular.Name = "btnAnular"
        btnAnular.Size = New Size(227, 29)
        btnAnular.TabIndex = 93
        btnAnular.Text = "Anular"
        btnAnular.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 231)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(227, 10)
        Panel10.TabIndex = 92
        ' 
        ' btnFaltapagar
        ' 
        btnFaltapagar.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnFaltapagar.Dock = DockStyle.Top
        btnFaltapagar.FlatAppearance.BorderSize = 0
        btnFaltapagar.FlatStyle = FlatStyle.Flat
        btnFaltapagar.Font = New Font("Yu Gothic UI", 9.75F)
        btnFaltapagar.Image = CType(resources.GetObject("btnFaltapagar.Image"), Image)
        btnFaltapagar.ImageAlign = ContentAlignment.MiddleLeft
        btnFaltapagar.Location = New Point(0, 202)
        btnFaltapagar.Name = "btnFaltapagar"
        btnFaltapagar.Size = New Size(227, 29)
        btnFaltapagar.TabIndex = 91
        btnFaltapagar.Text = "Falta de pagar"
        btnFaltapagar.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 192)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(227, 10)
        Panel9.TabIndex = 90
        ' 
        ' btnTerminar
        ' 
        btnTerminar.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnTerminar.Dock = DockStyle.Top
        btnTerminar.FlatAppearance.BorderSize = 0
        btnTerminar.FlatStyle = FlatStyle.Flat
        btnTerminar.Font = New Font("Yu Gothic UI", 9.75F)
        btnTerminar.Image = CType(resources.GetObject("btnTerminar.Image"), Image)
        btnTerminar.ImageAlign = ContentAlignment.MiddleLeft
        btnTerminar.Location = New Point(0, 163)
        btnTerminar.Name = "btnTerminar"
        btnTerminar.Size = New Size(227, 29)
        btnTerminar.TabIndex = 89
        btnTerminar.Text = "Terminar"
        btnTerminar.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 153)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(227, 10)
        Panel8.TabIndex = 88
        ' 
        ' btnFacturar
        ' 
        btnFacturar.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnFacturar.Dock = DockStyle.Top
        btnFacturar.FlatAppearance.BorderSize = 0
        btnFacturar.FlatStyle = FlatStyle.Flat
        btnFacturar.Font = New Font("Yu Gothic UI", 9.75F)
        btnFacturar.Image = CType(resources.GetObject("btnFacturar.Image"), Image)
        btnFacturar.ImageAlign = ContentAlignment.MiddleLeft
        btnFacturar.Location = New Point(0, 124)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(227, 29)
        btnFacturar.TabIndex = 87
        btnFacturar.Text = "Facturar"
        btnFacturar.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 114)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(227, 10)
        Panel7.TabIndex = 86
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnAceptar.Dock = DockStyle.Top
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Yu Gothic UI", 9.75F)
        btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), Image)
        btnAceptar.ImageAlign = ContentAlignment.MiddleLeft
        btnAceptar.Location = New Point(0, 85)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(227, 29)
        btnAceptar.TabIndex = 85
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 75)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(227, 10)
        Panel6.TabIndex = 84
        ' 
        ' btnPreparar
        ' 
        btnPreparar.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnPreparar.Dock = DockStyle.Top
        btnPreparar.FlatAppearance.BorderSize = 0
        btnPreparar.FlatStyle = FlatStyle.Flat
        btnPreparar.Font = New Font("Yu Gothic UI", 9.75F)
        btnPreparar.Image = CType(resources.GetObject("btnPreparar.Image"), Image)
        btnPreparar.ImageAlign = ContentAlignment.MiddleLeft
        btnPreparar.Location = New Point(0, 46)
        btnPreparar.Name = "btnPreparar"
        btnPreparar.Size = New Size(227, 29)
        btnPreparar.TabIndex = 83
        btnPreparar.Text = "Preparar"
        btnPreparar.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 36)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(227, 10)
        Panel5.TabIndex = 82
        ' 
        ' btnPendiente
        ' 
        btnPendiente.BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        btnPendiente.Dock = DockStyle.Top
        btnPendiente.FlatAppearance.BorderSize = 0
        btnPendiente.FlatStyle = FlatStyle.Flat
        btnPendiente.Font = New Font("Yu Gothic UI", 9.75F)
        btnPendiente.Image = CType(resources.GetObject("btnPendiente.Image"), Image)
        btnPendiente.ImageAlign = ContentAlignment.MiddleLeft
        btnPendiente.Location = New Point(0, 7)
        btnPendiente.Name = "btnPendiente"
        btnPendiente.Size = New Size(227, 29)
        btnPendiente.TabIndex = 81
        btnPendiente.Text = "Pendiente"
        btnPendiente.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 7)
        Panel1.TabIndex = 80
        ' 
        ' Pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Panel4)
        Controls.Add(Label1)
        Controls.Add(EliminarPedido)
        Controls.Add(EditarPedido)
        Controls.Add(AgregarPedido)
        Controls.Add(lblBusqueda)
        Controls.Add(Panel3)
        Controls.Add(txtCodigoPedidobusqueda)
        Controls.Add(GrillaPedidos)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pedidos"
        Text = "Pedidos"
        CType(GrillaPedidos, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GrillaPedidos As DataGridView
    Friend WithEvents txtCodigoPedidobusqueda As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents EliminarPedido As Button
    Friend WithEvents EditarPedido As Button
    Friend WithEvents AgregarPedido As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnTerminar As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnPreparar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPendiente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnAnular As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnFaltapagar As Button
    Friend WithEvents Panel9 As Panel
End Class
