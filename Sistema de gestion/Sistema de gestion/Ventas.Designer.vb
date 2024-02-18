<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        GrillaVentas = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CType(GrillaVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GrillaVentas
        ' 
        GrillaVentas.AllowUserToAddRows = False
        GrillaVentas.AllowUserToDeleteRows = False
        GrillaVentas.AllowUserToResizeColumns = False
        GrillaVentas.AllowUserToResizeRows = False
        GrillaVentas.BackgroundColor = Color.Silver
        GrillaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaVentas.Location = New Point(24, 120)
        GrillaVentas.MultiSelect = False
        GrillaVentas.Name = "GrillaVentas"
        GrillaVentas.ReadOnly = True
        GrillaVentas.RowHeadersVisible = False
        GrillaVentas.RowTemplate.Height = 25
        GrillaVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaVentas.ShowCellErrors = False
        GrillaVentas.ShowCellToolTips = False
        GrillaVentas.ShowEditingIcon = False
        GrillaVentas.ShowRowErrors = False
        GrillaVentas.Size = New Size(879, 398)
        GrillaVentas.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(919, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 55)
        Button1.TabIndex = 5
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(919, 181)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 55)
        Button2.TabIndex = 6
        Button2.Text = "Modificar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(919, 242)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 55)
        Button3.TabIndex = 7
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(24, 535)
        Button4.Name = "Button4"
        Button4.Size = New Size(176, 55)
        Button4.TabIndex = 8
        Button4.Text = "Emitir Factura"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(727, 535)
        Button5.Name = "Button5"
        Button5.Size = New Size(176, 55)
        Button5.TabIndex = 9
        Button5.Text = "Emitir Remito"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 611)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GrillaVentas)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ventas"
        Text = "Ventas"
        CType(GrillaVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GrillaVentas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
