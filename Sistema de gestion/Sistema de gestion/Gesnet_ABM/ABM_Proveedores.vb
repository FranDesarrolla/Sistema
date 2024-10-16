Public Class ABM_Proveedores
    Private Sub ABM_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LimpiarFormularioABMProveedores()

        ' Limpiar los campos de texto
        Me.txtIdProv.Text = ""
        Me.txtCuentaProv.Text = ""
        Me.txtNombreProv.Text = ""
        Me.txtApellidoProv.Text = ""
        Me.txtFirmaProv.Text = ""
        Me.txtNacionalidadProv.Text = ""
        Me.txtProvinciaProv.Text = ""
        Me.txtLocalidadProv.Text = ""
        Me.txtCodigoPostalProv.Text = ""
        Me.txtDireccionProv.Text = ""
        Me.DpFechaNaProv.Value = "01/01/1999" ' Asigna una fecha nula o vacía según corresponda
        Me.txtTelefonoProv.Text = ""
        Me.txtEmailProv.Text = ""
        Me.DpFechaRegistroProv.Value = "01/01/1999"
        Me.txtEstadoCuentaProv.Text = ""

        ' Desactivar el botón "Guardar" (si existe)
        'If Not BtnAceptarProveedor Is Nothing Then
        'BtnAceptarProveedor.Enabled = False
        'End If

    End Sub

    Private Sub BtnAceptarProveedor_Click(sender As Object, e As EventArgs) Handles BtnAceptarProveedor.Click
        'Para agregar datos
        If lblSeñalProveedor.Text = "AGREGAR" Then ' Verifica si la etiqueta es "AGREGAR"

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO dbo.Proveedores (Cuenta, Nombre, Apellido, Firma, Nacionalidad, Provincia, Localidad, CodigoPostal, Direccion, FechaDeNacimiento, Telefono, Email, FechaDeRegistro, EstadoDeCuenta)
                                        VALUES ('" & txtCuentaProv.Text & "', '" & txtNombreProv.Text & "', '" & txtApellidoProv.Text & "', '" & txtFirmaProv.Text & "', '" & txtNacionalidadProv.Text & "','" & txtProvinciaProv.Text & "','" & txtLocalidadProv.Text & "', '" & txtCodigoPostalProv.Text & "', '" & txtDireccionProv.Text & "', '" & DpFechaNaProv.Value & "', '" & txtTelefonoProv.Text & "', '" & txtEmailProv.Text & "', '" & DpFechaRegistroProv.Value & "','" & txtEstadoCuentaProv.Text & "')"

                ' Ejecuta la consulta de inserción
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                ModuloSistema.conexionSql.Close()

                ' Muestra un mensaje de éxito
                MsgBox("Datos Guardados", +vbOKOnly + vbInformation)
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox(ex.ToString)
            End Try


            ModuloPrincipal.AbrirFormEnPanel(Proveedores)

        ElseIf lblSeñalProveedor.Text = "EDITAR" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "
                                          UPDATE dbo.Proveedores
                                            SET Cuenta = '" & txtCuentaProv.Text & "',
	                                            Nombre = '" & txtNombreProv.Text & "',
	                                            Apellido = '" & txtApellidoProv.Text & "',
	                                            Firma = '" & txtFirmaProv.Text & "',
	                                            Nacionalidad = '" & txtNacionalidadProv.Text & "',
	                                            Provincia = '" & txtProvinciaProv.Text & "',
	                                            Localidad = '" & txtLocalidadProv.Text & "',
	                                            CodigoPostal = '" & txtCodigoPostalProv.Text & "',
	                                            Direccion = '" & txtDireccionProv.Text & "',
	                                            FechaDeNacimiento = " & DpFechaNaProv.Value & ",
	                                            Telefono = '" & txtTelefonoProv.Text & "',
	                                            Email = '" & txtEmailProv.Text & "',
	                                            FechaDeRegistro = " & DpFechaRegistroProv.Value & ",
	                                            EstadoDeCuenta = '" & txtEstadoCuentaProv.Text & "'
                                                WHERE ID = " & Val(txtIdProv.Text) & ""
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                MsgBox("Datos Guardados", +vbOKOnly + vbInformation)



            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            Proveedores.llenarGrillaProveedores()
            ModuloPrincipal.AbrirFormEnPanel(Proveedores)

        End If
        LimpiarFormularioABMProveedores()
    End Sub

    Private Sub btnVolverProveedor_Click(sender As Object, e As EventArgs) Handles btnVolverProveedor.Click
        ModuloPrincipal.AbrirFormEnPanel(Proveedores)
        LimpiarFormularioABMProveedores()
    End Sub
End Class