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
        Label1 = New Label()
        GrillaProductos = New DataGridView()
        DataGridView2 = New DataGridView()
        Label2 = New Label()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnAgregarProducto = New Button()
        txtCodigoPbusqueda = New TextBox()
        btnBuscar = New Button()
        CType(GrillaProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(506, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 0
        Label1.Text = "Productos"
        ' 
        ' GrillaProductos
        ' 
        GrillaProductos.AllowUserToAddRows = False
        GrillaProductos.AllowUserToDeleteRows = False
        GrillaProductos.AllowUserToResizeColumns = False
        GrillaProductos.AllowUserToResizeRows = False
        GrillaProductos.BackgroundColor = Color.Silver
        GrillaProductos.BorderStyle = BorderStyle.Fixed3D
        GrillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaProductos.Location = New Point(12, 148)
        GrillaProductos.MultiSelect = False
        GrillaProductos.Name = "GrillaProductos"
        GrillaProductos.RowHeadersVisible = False
        GrillaProductos.RowTemplate.Height = 25
        GrillaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaProductos.Size = New Size(811, 289)
        GrillaProductos.TabIndex = 3
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(829, 148)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(231, 289)
        DataGridView2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1016, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        Label2.Visible = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(325, 494)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(138, 55)
        btnEditar.TabIndex = 13
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(524, 494)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(138, 55)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarProducto
        ' 
        btnAgregarProducto.BackColor = Color.White
        btnAgregarProducto.ForeColor = Color.Black
        btnAgregarProducto.Location = New Point(138, 494)
        btnAgregarProducto.Name = "btnAgregarProducto"
        btnAgregarProducto.Size = New Size(138, 55)
        btnAgregarProducto.TabIndex = 11
        btnAgregarProducto.Text = "Agregar"
        btnAgregarProducto.UseVisualStyleBackColor = False
        ' 
        ' txtCodigoPbusqueda
        ' 
        txtCodigoPbusqueda.Location = New Point(107, 106)
        txtCodigoPbusqueda.Name = "txtCodigoPbusqueda"
        txtCodigoPbusqueda.Size = New Size(100, 23)
        txtCodigoPbusqueda.TabIndex = 14
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(265, 106)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(34, 23)
        btnBuscar.TabIndex = 15
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(114), CByte(34), CByte(52))
        ClientSize = New Size(1069, 611)
        Controls.Add(btnBuscar)
        Controls.Add(txtCodigoPbusqueda)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregarProducto)
        Controls.Add(Label2)
        Controls.Add(DataGridView2)
        Controls.Add(GrillaProductos)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(GrillaProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaProductos As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtCodigoPbusqueda As TextBox
    Friend WithEvents btnBuscar As Button
End Class
