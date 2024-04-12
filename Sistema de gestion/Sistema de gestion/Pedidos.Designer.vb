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
        Label1 = New Label()
        GrillaPedidos = New DataGridView()
        AgregarPedido = New Button()
        EditarPedido = New Button()
        EliminarPedido = New Button()
        txtCodigoPedidobusqueda = New TextBox()
        btnBuscarPedido = New Button()
        CType(GrillaPedidos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(512, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "PEDIDOS"
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
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaPedidos.Location = New Point(127, 113)
        GrillaPedidos.MultiSelect = False
        GrillaPedidos.Name = "GrillaPedidos"
        GrillaPedidos.ReadOnly = True
        GrillaPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
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
        GrillaPedidos.RowTemplate.Height = 25
        GrillaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaPedidos.ShowCellErrors = False
        GrillaPedidos.ShowCellToolTips = False
        GrillaPedidos.ShowEditingIcon = False
        GrillaPedidos.ShowRowErrors = False
        GrillaPedidos.Size = New Size(825, 341)
        GrillaPedidos.TabIndex = 12
        ' 
        ' AgregarPedido
        ' 
        AgregarPedido.Location = New Point(156, 471)
        AgregarPedido.Name = "AgregarPedido"
        AgregarPedido.Size = New Size(121, 46)
        AgregarPedido.TabIndex = 13
        AgregarPedido.Text = "Agregar"
        AgregarPedido.UseVisualStyleBackColor = True
        ' 
        ' EditarPedido
        ' 
        EditarPedido.Location = New Point(310, 471)
        EditarPedido.Name = "EditarPedido"
        EditarPedido.Size = New Size(121, 46)
        EditarPedido.TabIndex = 14
        EditarPedido.Text = "Editar"
        EditarPedido.UseVisualStyleBackColor = True
        ' 
        ' EliminarPedido
        ' 
        EliminarPedido.Location = New Point(466, 471)
        EliminarPedido.Name = "EliminarPedido"
        EliminarPedido.Size = New Size(121, 46)
        EliminarPedido.TabIndex = 15
        EliminarPedido.Text = "Eliminar"
        EliminarPedido.UseVisualStyleBackColor = True
        ' 
        ' txtCodigoPedidobusqueda
        ' 
        txtCodigoPedidobusqueda.BackColor = Color.White
        txtCodigoPedidobusqueda.BorderStyle = BorderStyle.None
        txtCodigoPedidobusqueda.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigoPedidobusqueda.ForeColor = Color.Black
        txtCodigoPedidobusqueda.Location = New Point(137, 80)
        txtCodigoPedidobusqueda.Margin = New Padding(0)
        txtCodigoPedidobusqueda.Name = "txtCodigoPedidobusqueda"
        txtCodigoPedidobusqueda.Size = New Size(409, 20)
        txtCodigoPedidobusqueda.TabIndex = 19
        txtCodigoPedidobusqueda.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnBuscarPedido
        ' 
        btnBuscarPedido.BackgroundImage = My.Resources.Resources.cuadrado
        btnBuscarPedido.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscarPedido.FlatAppearance.BorderSize = 0
        btnBuscarPedido.FlatStyle = FlatStyle.Flat
        btnBuscarPedido.Location = New Point(566, 80)
        btnBuscarPedido.Name = "btnBuscarPedido"
        btnBuscarPedido.Size = New Size(21, 20)
        btnBuscarPedido.TabIndex = 20
        btnBuscarPedido.UseVisualStyleBackColor = True
        btnBuscarPedido.Visible = False
        ' 
        ' Pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnBuscarPedido)
        Controls.Add(txtCodigoPedidobusqueda)
        Controls.Add(EliminarPedido)
        Controls.Add(EditarPedido)
        Controls.Add(AgregarPedido)
        Controls.Add(GrillaPedidos)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pedidos"
        Text = "Pedidos"
        CType(GrillaPedidos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaPedidos As DataGridView
    Friend WithEvents AgregarPedido As Button
    Friend WithEvents EditarPedido As Button
    Friend WithEvents EliminarPedido As Button
    Friend WithEvents txtCodigoPedidobusqueda As TextBox
    Friend WithEvents btnBuscarPedido As Button
End Class
