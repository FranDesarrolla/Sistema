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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        GrillaPedidos = New DataGridView()
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Tan
        DataGridViewCellStyle4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Beige
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        GrillaPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        GrillaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaPedidos.Cursor = Cursors.Hand
        GrillaPedidos.EditMode = DataGridViewEditMode.EditOnEnter
        GrillaPedidos.EnableHeadersVisualStyles = False
        GrillaPedidos.GridColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        GrillaPedidos.Location = New Point(92, 84)
        GrillaPedidos.MultiSelect = False
        GrillaPedidos.Name = "GrillaPedidos"
        GrillaPedidos.ReadOnly = True
        GrillaPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        GrillaPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        GrillaPedidos.RowHeadersVisible = False
        GrillaPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        GrillaPedidos.RowsDefaultCellStyle = DataGridViewCellStyle6
        GrillaPedidos.RowTemplate.Height = 25
        GrillaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaPedidos.ShowCellErrors = False
        GrillaPedidos.ShowCellToolTips = False
        GrillaPedidos.ShowEditingIcon = False
        GrillaPedidos.ShowRowErrors = False
        GrillaPedidos.Size = New Size(879, 464)
        GrillaPedidos.TabIndex = 12
        ' 
        ' Pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
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
End Class
