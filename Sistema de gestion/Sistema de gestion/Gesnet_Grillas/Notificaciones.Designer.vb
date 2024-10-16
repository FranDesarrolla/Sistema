<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificaciones
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
        GrillaNotificaciones = New DataGridView()
        btnCerrarNotificaciones = New PictureBox()
        CType(GrillaNotificaciones, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrarNotificaciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(159, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 0
        Label1.Text = "Notificaciones"
        ' 
        ' GrillaNotificaciones
        ' 
        GrillaNotificaciones.AllowUserToAddRows = False
        GrillaNotificaciones.AllowUserToDeleteRows = False
        GrillaNotificaciones.AllowUserToResizeColumns = False
        GrillaNotificaciones.AllowUserToResizeRows = False
        GrillaNotificaciones.BackgroundColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        GrillaNotificaciones.BorderStyle = BorderStyle.Fixed3D
        GrillaNotificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        GrillaNotificaciones.Location = New Point(0, 63)
        GrillaNotificaciones.MultiSelect = False
        GrillaNotificaciones.Name = "GrillaNotificaciones"
        GrillaNotificaciones.RowHeadersVisible = False
        GrillaNotificaciones.RowTemplate.Height = 25
        GrillaNotificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GrillaNotificaciones.Size = New Size(391, 363)
        GrillaNotificaciones.TabIndex = 4
        ' 
        ' btnCerrarNotificaciones
        ' 
        btnCerrarNotificaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrarNotificaciones.Location = New Point(366, -1)
        btnCerrarNotificaciones.Name = "btnCerrarNotificaciones"
        btnCerrarNotificaciones.Size = New Size(25, 25)
        btnCerrarNotificaciones.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrarNotificaciones.TabIndex = 5
        btnCerrarNotificaciones.TabStop = False
        ' 
        ' Notificaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 425)
        Controls.Add(btnCerrarNotificaciones)
        Controls.Add(GrillaNotificaciones)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Notificaciones"
        Text = "Notificaciones"
        CType(GrillaNotificaciones, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrarNotificaciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaNotificaciones As DataGridView
    Friend WithEvents btnCerrarNotificaciones As PictureBox
End Class
