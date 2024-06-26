﻿Public Class ABM_Clientes
    Private Sub btnVolverCliente_Click(sender As Object, e As EventArgs) Handles btnVolverCliente.Click
        ModuloPrincipal.AbrirFormEnPanel(Clientes)
        LimpiarFormularioABMCliente()
    End Sub

    Public Sub LimpiarFormularioABMCliente()

        ' Limpiar los campos de texto
        Me.txtIDCliente.Text = ""
        Me.txtCuentaCliente.Text = ""
        Me.txtNombreCliente.Text = ""
        Me.txtApellidoCliente.Text = ""
        Me.txtDniClie.Text = ""
        Me.txtCuitClie.Text = ""
        Me.txtNacionalidadCliente.Text = ""
        Me.txtProvinciaCliente.Text = ""
        Me.txtLocalidadCliente.Text = ""
        Me.txtCodPCliente.Text = ""
        Me.txtDireccionCliente.Text = ""
        Me.dtFechaNacimiento.Value = "01/01/1999"  ' Asigna una fecha nula o vacía según corresponda
        Me.txtTelefonoCliente.Text = ""
        Me.txtEmailCliente.Text = ""
        Me.txtCondicionivaClie.Text = ""
        Me.dtFechaRegistroCliente.Value = "01/01/1999"
        Me.txtEstadoCuenta.Text = ""

        ' Desactivar el botón "Guardar" (si existe)
        'If Not BtnAceptarCliente Is Nothing Then
        'BtnAceptarCliente.Enabled = False
        'End If

    End Sub

    Private Sub BtnAceptarCliente_Click(sender As Object, e As EventArgs) Handles BtnAceptarCliente.Click
        'Para agregar datos
        If lblSeñalCliente.Text = "AGREGAR" Then ' Verifica si la etiqueta es "AGREGAR"

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO dbo.Clientes (Cuenta, Nombre, Apellido, DNI, CUIT, Nacionalidad, Provincia, Localidad, CodigoPostal, Direccion, FechaDeNacimiento, Telefono, Email, CondicionIVA, FechaDeRegistro, EstadoDeCuenta)
                                        VALUES ('" & txtCuentaCliente.Text & "', '" & txtNombreCliente.Text & "', '" & txtApellidoCliente.Text & "', '" & txtDniClie.Text & "', '" & txtCuitClie.Text & "', '" & txtNacionalidadCliente.Text & "', '" & txtProvinciaCliente.Text & "', '" & txtLocalidadCliente.Text & "', '" & txtCodPCliente.Text & "', '" & txtDireccionCliente.Text & "', '" & dtFechaNacimiento.Value & "', '" & txtTelefonoCliente.Text & "', '" & txtEmailCliente.Text & "', '" & txtCondicionivaClie.Text & "', '" & dtFechaRegistroCliente.Value & "', '" & txtEstadoCuenta.Text & "')"
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


            ModuloPrincipal.AbrirFormEnPanel(Clientes)

        ElseIf lblSeñalCliente.Text = "EDITAR" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "
                                            UPDATE dbo.Clientes
                                            SET 
	                                            Cuenta = '" & txtCuentaCliente.Text & "',
	                                            Nombre = '" & txtNombreCliente.Text & "',
	                                            Apellido = '" & txtApellidoCliente.Text & "',
                                                DNI = '" & txtDniClie.Text & "',
                                                CUIT = '" & txtCuitClie.Text & "',
	                                            Nacionalidad = '" & txtNacionalidadCliente.Text & "',
	                                            Provincia = '" & txtProvinciaCliente.Text & "',
	                                            Localidad = '" & txtLocalidadCliente.Text & "',
	                                            CodigoPostal = '" & txtCodPCliente.Text & "',
	                                            Direccion = '" & txtDireccionCliente.Text & "',
	                                            FechaDeNacimiento = " & dtFechaNacimiento.Value & ",
	                                            Telefono = '" & txtTelefonoCliente.Text & "',
	                                            Email = '" & txtEmailCliente.Text & "',
                                                CondicionIVA = '" & txtCondicionivaClie.Text & "',
	                                            FechaDeRegistro = '" & dtFechaRegistroCliente.Text & "',
	                                            EstadoDeCuenta = '" & txtEstadoCuenta.Text & "'
                                                WHERE IDCliente = " & Val(txtIDCliente.Text) & ""
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                MsgBox("Datos Guardados", +vbOKOnly + vbInformation)



            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            Clientes.llenarGrillaClientes()
            ModuloPrincipal.AbrirFormEnPanel(Clientes)

        End If
    End Sub

    Private Sub ABM_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class