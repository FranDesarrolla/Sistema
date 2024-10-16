Imports System.Data.SqlClient

Public Class ABM_Clientes

    Private Sub BtnAceptarCliente_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If lblSeñalCliente.Text = "Agregar" Then
            AgregarCliente()
        ElseIf lblSeñalCliente.Text = "Editar" Then
            EditarCliente()
        End If
    End Sub

    Private Sub btnVolverCliente_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        'LIMPIAR DATOS DE LA VENTANA
        txtCuenta.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDni.Text = ""
        txtCuit.Text = ""
        txtNacionalidad.Text = ""
        txtCp.Text = ""
        txtDireccion.Text = ""
        dtFechaNacimiento.Value = "01-01-1900"
        txtTelefono.Text = ""
        txtEmail.Text = ""

        ModuloPrincipal.AbrirFormEnPanel(Clientes)
    End Sub

    Public Sub AgregarCliente()
        'VARIABLES
        Dim fechaHoy As DateTime = DateTime.Today

        'ACTIVO ("1" SI, "0" NO)
        Dim activo As Integer = If(chActivo.Checked, "1", "0")

        Try
            Using connection As New SqlConnection(ModuloSistema.conexionSql.ConnectionString)
                connection.Open()

                Using command As New SqlCommand("INSERT INTO dbo.Clientes (Cuenta, Nombre, Apellido, DNI, CUIT, Nacionalidad, Provincia, Localidad, CodigoPostal, Direccion, FechaDeNacimiento, Telefono, Email, CondicionIVA, FechaDeRegistro, EstadoDeCuenta) 
                                                 VALUES (@Cuenta, @Nombre, @Apellido, @DNI, @CUIT, @Nacionalidad, @Provincia, @Localidad, @CodigoPostal, @Direccion, @FechaDeNacimiento, @Telefono, @Email, @CondicionIVA, @FechaDeRegistro, @EstadoDeCuenta)", connection)

                    command.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = txtCuenta.Text
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text
                    command.Parameters.Add("@DNI", SqlDbType.VarChar).Value = txtDni.Text
                    command.Parameters.Add("@CUIT", SqlDbType.VarChar).Value = txtCuit.Text
                    command.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = txtNacionalidad.Text
                    command.Parameters.Add("@Provincia", SqlDbType.NVarChar, 1).Value = cbProvincia.SelectedValue.ToString()
                    command.Parameters.Add("@Localidad", SqlDbType.Int).Value = cbLocalidades.SelectedValue
                    command.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = txtCp.Text
                    command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
                    command.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = dtFechaNacimiento.Value
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text
                    command.Parameters.Add("@CondicionIVA", SqlDbType.VarChar).Value = cbCondicionIva.SelectedValue
                    command.Parameters.Add("@FechaDeRegistro", SqlDbType.DateTime).Value = fechaHoy
                    command.Parameters.Add("@EstadoDeCuenta", SqlDbType.VarChar).Value = activo

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Datos Guardados", vbOKOnly + vbInformation)
        Catch ex As Exception
            MsgBox("Error al guardar los datos: " & ex.Message)
        End Try

        ModuloPrincipal.AbrirFormEnPanel(Clientes)
    End Sub

    Public Sub EditarCliente()
        'VARIABLES
        Dim fechaHoy As DateTime = DateTime.Today

        'ACTIVO ("1" SI, "0" NO)
        Dim activo As Integer = If(chActivo.Checked, "1", "0")

        Try
            Using connection As New SqlConnection(ModuloSistema.conexionSql.ConnectionString)
                connection.Open()

                Using command As New SqlCommand("UPDATE dbo.Clientes 
                                                 SET Cuenta = @Cuenta,
                                                     Nombre = @Nombre,
                                                     Apellido = @Apellido,
                                                     DNI = @DNI,
                                                     CUIT = @CUIT,
                                                     Nacionalidad = @Nacionalidad,
                                                     Provincia = @Provincia,
                                                     Localidad = @Localidad,
                                                     CodigoPostal = @CodigoPostal,
                                                     Direccion = @Direccion,
                                                     FechaDeNacimiento = @FechaDeNacimiento,
                                                     Telefono = @Telefono,
                                                     Email = @Email,
                                                     CondicionIVA = @CondicionIVA,
                                                     EstadoDeCuenta = @EstadoDeCuenta
                                                 WHERE ID = @IDCliente", connection)

                    command.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = txtCuenta.Text
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text
                    command.Parameters.Add("@DNI", SqlDbType.VarChar).Value = txtDni.Text
                    command.Parameters.Add("@CUIT", SqlDbType.VarChar).Value = txtCuit.Text
                    command.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = txtNacionalidad.Text
                    command.Parameters.Add("@Provincia", SqlDbType.NVarChar, 1).Value = cbProvincia.SelectedValue.ToString()
                    command.Parameters.Add("@Localidad", SqlDbType.Int).Value = cbLocalidades.SelectedValue
                    command.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = txtCp.Text
                    command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
                    command.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = dtFechaNacimiento.Value
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text
                    command.Parameters.Add("@CondicionIVA", SqlDbType.VarChar).Value = cbCondicionIva.SelectedValue
                    command.Parameters.Add("@EstadoDeCuenta", SqlDbType.VarChar).Value = activo
                    command.Parameters.Add("@IDCliente", SqlDbType.Int).Value = Val(txtIDCliente.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Datos Guardados", vbOKOnly + vbInformation)
        Catch ex As Exception
            MsgBox("Error al editar los datos: " & ex.Message)
        End Try

        ModuloPrincipal.AbrirFormEnPanel(Clientes)
    End Sub

    ' CUANDO MODIFICO UNA PROVINCIA, SE EJECUTA LA FUNCION Localidades() PARA LLAMAR LAS CORRESPONDIENTES

    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        Localidades()
    End Sub

    'COMBOBOXS

    Public Sub Provincias()

        'SELECT A LAS PROVINCIAS Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Provincia FROM Provincias"
        Using adaptadorSql As New SqlDataAdapter(query, ModuloSistema.conexionSql)
            Dim dtProvincias As New DataTable()
            adaptadorSql.Fill(dtProvincias)

            'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
            cbProvincia.DataSource = dtProvincias
            cbProvincia.DisplayMember = "Provincia"
            cbProvincia.ValueMember = "ID"
        End Using
    End Sub

    Public Sub Localidades()

        'SELECT A LAS LOCALIDADES Y SEGUN LA PROVINCIA SELECCIONADA, MOSTRAR LO GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Localidad FROM Localidades WHERE IDProvincia = @IDProvincia"
        Using adaptadorSql As New SqlDataAdapter(query, ModuloSistema.conexionSql)
            adaptadorSql.SelectCommand.Parameters.Add("@IDProvincia", SqlDbType.NVarChar, 1).Value = cbProvincia.SelectedValue.ToString()
            Dim dtLocalidades As New DataTable()
            adaptadorSql.Fill(dtLocalidades)

            'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
            cbLocalidades.DataSource = dtLocalidades
            cbLocalidades.DisplayMember = "Localidad"
            cbLocalidades.ValueMember = "ID"
        End Using
    End Sub

    Public Sub CondicionesIva()

        'SELECT A LAS CONDICIONES IVA Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT Abreviatura, CondicionIVA FROM CondicionIva"
        Using adaptadorSql As New SqlDataAdapter(query, ModuloSistema.conexionSql)
            Dim dtCondicionesIva As New DataTable()
            adaptadorSql.Fill(dtCondicionesIva)

            'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
            cbCondicionIva.DataSource = dtCondicionesIva
            cbCondicionIva.DisplayMember = "CondicionIVA"
            cbCondicionIva.ValueMember = "Abreviatura"
        End Using
    End Sub

End Class