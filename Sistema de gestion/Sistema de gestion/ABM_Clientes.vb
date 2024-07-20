Imports System.Data.SqlClient

Public Class ABM_Clientes

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
        Me.txtEstadoCuenta.Text = ""

        ' Desactivar el botón "Guardar" (si existe)
        'If Not BtnAceptarCliente Is Nothing Then
        'BtnAceptarCliente.Enabled = False
        'End If

    End Sub

    Private Sub BtnAceptarCliente_Click(sender As Object, e As EventArgs) Handles btnAceptarABMP.Click
        Dim fechaHoy As DateTime = DateTime.Today

        If lblSeñalCliente.Text = "AGREGAR" Then
            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    Using command As New SqlCommand("INSERT INTO dbo.Clientes (Cuenta, Nombre, Apellido, DNI, CUIT, Nacionalidad, Provincia, Localidad, CodigoPostal, Direccion, FechaDeNacimiento, Telefono, Email, CondicionIVA, FechaDeRegistro, EstadoDeCuenta)
                                                 VALUES (@Cuenta, @Nombre, @Apellido, @DNI, @CUIT, @Nacionalidad, @Provincia, @Localidad, @CodigoPostal, @Direccion, @FechaDeNacimiento, @Telefono, @Email, @CondicionIVA, @FechaDeRegistro, @EstadoDeCuenta)", connection)
                        command.Parameters.AddWithValue("@Cuenta", txtCuentaCliente.Text)
                        command.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text)
                        command.Parameters.AddWithValue("@Apellido", txtApellidoCliente.Text)
                        command.Parameters.AddWithValue("@DNI", txtDniClie.Text)
                        command.Parameters.AddWithValue("@CUIT", txtCuitClie.Text)
                        command.Parameters.AddWithValue("@Nacionalidad", txtNacionalidadCliente.Text)
                        command.Parameters.AddWithValue("@Provincia", txtProvinciaCliente.Text)
                        command.Parameters.AddWithValue("@Localidad", txtLocalidadCliente.Text)
                        command.Parameters.AddWithValue("@CodigoPostal", txtCodPCliente.Text)
                        command.Parameters.AddWithValue("@Direccion", txtDireccionCliente.Text)
                        command.Parameters.AddWithValue("@FechaDeNacimiento", dtFechaNacimiento.Value)
                        command.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text)
                        command.Parameters.AddWithValue("@Email", txtEmailCliente.Text)
                        command.Parameters.AddWithValue("@CondicionIVA", txtCondicionivaClie.Text)
                        command.Parameters.AddWithValue("@FechaDeRegistro", fechaHoy)
                        command.Parameters.AddWithValue("@EstadoDeCuenta", txtEstadoCuenta.Text)

                        command.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Datos Guardados", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox("Error al guardar los datos: " & ex.Message)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Clientes)

        ElseIf lblSeñalCliente.Text = "EDITAR" Then
            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    Using command As New SqlCommand("UPDATE dbo.Clientes
                                                 SET Cuenta = @Cuenta, Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, CUIT = @CUIT, Nacionalidad = @Nacionalidad, Provincia = @Provincia, Localidad = @Localidad, CodigoPostal = @CodigoPostal, Direccion = @Direccion, FechaDeNacimiento = @FechaDeNacimiento, Telefono = @Telefono, Email = @Email, CondicionIVA = @CondicionIVA, EstadoDeCuenta = @EstadoDeCuenta
                                                 WHERE IDCliente = @IDCliente", connection)
                        command.Parameters.AddWithValue("@Cuenta", txtCuentaCliente.Text)
                        command.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text)
                        command.Parameters.AddWithValue("@Apellido", txtApellidoCliente.Text)
                        command.Parameters.AddWithValue("@DNI", txtDniClie.Text)
                        command.Parameters.AddWithValue("@CUIT", txtCuitClie.Text)
                        command.Parameters.AddWithValue("@Nacionalidad", txtNacionalidadCliente.Text)
                        command.Parameters.AddWithValue("@Provincia", txtProvinciaCliente.Text)
                        command.Parameters.AddWithValue("@Localidad", txtLocalidadCliente.Text)
                        command.Parameters.AddWithValue("@CodigoPostal", txtCodPCliente.Text)
                        command.Parameters.AddWithValue("@Direccion", txtDireccionCliente.Text)
                        command.Parameters.AddWithValue("@FechaDeNacimiento", dtFechaNacimiento.Value)
                        command.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text)
                        command.Parameters.AddWithValue("@Email", txtEmailCliente.Text)
                        command.Parameters.AddWithValue("@CondicionIVA", txtCondicionivaClie.Text)
                        command.Parameters.AddWithValue("@EstadoDeCuenta", txtEstadoCuenta.Text)
                        command.Parameters.AddWithValue("@IDCliente", Val(txtIDCliente.Text))

                        command.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Datos Guardados", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox("Error al editar los datos: " & ex.Message)
            End Try

            Clientes.llenarGrillaClientes()
            ModuloPrincipal.AbrirFormEnPanel(Clientes)
        End If
    End Sub

    Private Sub btnVolverCliente_Click(sender As Object, e As EventArgs) Handles btnVolverABMP.Click
        ModuloPrincipal.AbrirFormEnPanel(Clientes)
        LimpiarFormularioABMCliente()
    End Sub

End Class