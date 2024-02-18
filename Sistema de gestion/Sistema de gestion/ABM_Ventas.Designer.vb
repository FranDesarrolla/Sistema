<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Ventas
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
        ABM = New Label()
        SuspendLayout()
        ' 
        ' ABM
        ' 
        ABM.AutoSize = True
        ABM.Location = New Point(1016, 9)
        ABM.Name = "ABM"
        ABM.Size = New Size(41, 15)
        ABM.TabIndex = 0
        ABM.Text = "Label1"
        ABM.Visible = False
        ' 
        ' ABM_Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(ABM)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "ABM_Ventas"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ABM_Ventas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ABM As Label
End Class
