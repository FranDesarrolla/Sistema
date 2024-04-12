<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Pedidos
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
        lblSeñalPedido = New Label()
        txtNroPedido = New TextBox()
        dpFechaPedido = New DateTimePicker()
        txtPedidoCliente = New TextBox()
        txtEmpleadoPedido = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblSeñalPedido
        ' 
        lblSeñalPedido.AutoSize = True
        lblSeñalPedido.Location = New Point(116, 25)
        lblSeñalPedido.Name = "lblSeñalPedido"
        lblSeñalPedido.Size = New Size(41, 15)
        lblSeñalPedido.TabIndex = 0
        lblSeñalPedido.Text = "Label1"
        ' 
        ' txtNroPedido
        ' 
        txtNroPedido.Location = New Point(183, 73)
        txtNroPedido.Name = "txtNroPedido"
        txtNroPedido.Size = New Size(62, 23)
        txtNroPedido.TabIndex = 1
        ' 
        ' dpFechaPedido
        ' 
        dpFechaPedido.Format = DateTimePickerFormat.Short
        dpFechaPedido.Location = New Point(748, 70)
        dpFechaPedido.Name = "dpFechaPedido"
        dpFechaPedido.Size = New Size(103, 23)
        dpFechaPedido.TabIndex = 2
        ' 
        ' txtPedidoCliente
        ' 
        txtPedidoCliente.Location = New Point(183, 143)
        txtPedidoCliente.Name = "txtPedidoCliente"
        txtPedidoCliente.Size = New Size(146, 23)
        txtPedidoCliente.TabIndex = 3
        ' 
        ' txtEmpleadoPedido
        ' 
        txtEmpleadoPedido.Location = New Point(445, 73)
        txtEmpleadoPedido.Name = "txtEmpleadoPedido"
        txtEmpleadoPedido.Size = New Size(146, 23)
        txtEmpleadoPedido.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 5
        Label1.Text = "Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(363, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 6
        Label2.Text = "Empleado:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(682, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 7
        Label3.Text = "Fecha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(130, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 15)
        Label4.TabIndex = 8
        Label4.Text = "Nro"
        ' 
        ' ABM_Pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEmpleadoPedido)
        Controls.Add(txtPedidoCliente)
        Controls.Add(dpFechaPedido)
        Controls.Add(txtNroPedido)
        Controls.Add(lblSeñalPedido)
        FormBorderStyle = FormBorderStyle.None
        Name = "ABM_Pedidos"
        Text = "ABM_Pedidos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSeñalPedido As Label
    Friend WithEvents txtNroPedido As TextBox
    Friend WithEvents dpFechaPedido As DateTimePicker
    Friend WithEvents txtPedidoCliente As TextBox
    Friend WithEvents txtEmpleadoPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
