﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        btnUser = New PictureBox()
        txtUsuario = New TextBox()
        txtPatron = New TextBox()
        txtPassword = New TextBox()
        btnCrear = New Button()
        btnEliminar = New Button()
        CType(btnUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnUser
        ' 
        btnUser.Image = CType(resources.GetObject("btnUser.Image"), Image)
        btnUser.Location = New Point(507, 12)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(32, 32)
        btnUser.TabIndex = 5
        btnUser.TabStop = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(351, 155)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(161, 23)
        txtUsuario.TabIndex = 6
        ' 
        ' txtPatron
        ' 
        txtPatron.Location = New Point(412, 184)
        txtPatron.Name = "txtPatron"
        txtPatron.Size = New Size(100, 23)
        txtPatron.TabIndex = 7
        txtPatron.Visible = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(351, 213)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(161, 23)
        txtPassword.TabIndex = 8
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(566, 155)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(167, 23)
        btnCrear.TabIndex = 9
        btnCrear.Text = "Crear usuario"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(566, 213)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(167, 23)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar usuario"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(232), CByte(197))
        ClientSize = New Size(1069, 611)
        ControlBox = False
        Controls.Add(btnEliminar)
        Controls.Add(btnCrear)
        Controls.Add(txtPassword)
        Controls.Add(txtPatron)
        Controls.Add(txtUsuario)
        Controls.Add(btnUser)
        FormBorderStyle = FormBorderStyle.None
        Name = "Usuarios"
        Text = "Usuarios"
        CType(btnUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUser As PictureBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPatron As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnEliminar As Button
End Class
