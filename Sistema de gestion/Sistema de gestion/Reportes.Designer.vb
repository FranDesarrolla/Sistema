<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        reporteVentas = New Panel()
        reporteProductos = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        reporteVentas.SuspendLayout()
        reporteProductos.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' reporteVentas
        ' 
        reporteVentas.BackColor = Color.Khaki
        reporteVentas.BorderStyle = BorderStyle.Fixed3D
        reporteVentas.Controls.Add(Label1)
        reporteVentas.Location = New Point(40, 44)
        reporteVentas.Name = "reporteVentas"
        reporteVentas.Size = New Size(467, 100)
        reporteVentas.TabIndex = 0
        ' 
        ' reporteProductos
        ' 
        reporteProductos.BackColor = Color.CornflowerBlue
        reporteProductos.BorderStyle = BorderStyle.Fixed3D
        reporteProductos.Controls.Add(Label2)
        reporteProductos.Location = New Point(558, 44)
        reporteProductos.Name = "reporteProductos"
        reporteProductos.Size = New Size(482, 100)
        reporteProductos.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSalmon
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(40, 469)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 100)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(167, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Reporte Ventas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 15)
        Label2.TabIndex = 1
        Label2.Text = "Reporte Proveedores"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(425, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 2
        Label3.Text = "Reporte Envios"
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(244), CByte(226))
        ClientSize = New Size(1069, 611)
        Controls.Add(Panel1)
        Controls.Add(reporteProductos)
        Controls.Add(reporteVentas)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reportes"
        Text = "Reportes"
        reporteVentas.ResumeLayout(False)
        reporteVentas.PerformLayout()
        reporteProductos.ResumeLayout(False)
        reporteProductos.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents reporteVentas As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents reporteProductos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
