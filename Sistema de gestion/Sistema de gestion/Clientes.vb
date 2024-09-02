Imports System.Data.SqlClient

Public Class Clientes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaClientes()

        If lblEdit.Text = "Ventas" Then
            btnEliminarCliente.Enabled = False
            btnEditarCliente.Enabled = False
        End If

    End Sub

    Private Sub txtBusquedaCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCliente.TextChanged
        llenarGrillaClientes(txtBusquedaCliente.Text.Trim())
    End Sub

    Public Sub llenarGrillaClientes(Optional ByVal terminoBusquedaCliente As String = "")
        ' Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtCliente") Then
            setdedatos.Tables("dtCliente").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT C.IDCliente, C.Cuenta, C.Nombre, C.Apellido, C.DNI, C.CUIT, C.Nacionalidad, P.Provincia, L.Localidad, C.CodigoPostal, C.Direccion, C.FechaDeNacimiento, C.Telefono, C.Email, C.CondicionIVA, C.FechaDeRegistro, C.EstadoDeCuenta 
                                      FROM Clientes C
                                      INNER JOIN Provincias P ON C.Provincia = P.IDProvincia
                                      INNER JOIN Localidades L ON C.Localidad = L.IDLocalidad"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusquedaCliente) Then
            ' Construir las condiciones de búsqueda para cada campo
            Dim condicionesBusqueda As String = " WHERE Cuenta LIKE '%" & terminoBusquedaCliente & "%'" &
                                         " OR Nombre LIKE '%" & terminoBusquedaCliente & "%'" &
                                         " OR Apellido LIKE '%" & terminoBusquedaCliente & "%'" &
                                         " OR DNI LIKE '%" & terminoBusquedaCliente & "%'" &
                                         " OR CUIT LIKE '%" & terminoBusquedaCliente & "%'" &
                                         " Or P.Provincia Like '%" & terminoBusquedaCliente & "%'" &
                                         " OR L.Localidad LIKE '%" & terminoBusquedaCliente & "%'"
            ' Añadir las condiciones a la consulta
            consultassql &= condicionesBusqueda
        End If

        consultassql &= " ORDER BY Cuenta ASC"

        ' Usa la conexión SQL proporcionada por ModuloPrincipal
        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtCliente As New DataTable
        adaptadorSql.Fill(setdedatos, "dtCliente")
        GrillaClientes.DataSource = setdedatos.Tables("dtCliente")
        GrillaClientes.Font = New Font("Yu Gothic UI", 10)

        ' CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        Dim columnasOcultas As Integer() = {0, 6, 9, 11, 13, 14, 15, 16}
        For Each col In columnasOcultas
            GrillaClientes.Columns(col).Visible = False
        Next

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES
        GrillaClientes.Columns(1).FillWeight = 7
        GrillaClientes.Columns(2).FillWeight = 10
        GrillaClientes.Columns(3).FillWeight = 10
        GrillaClientes.Columns(4).FillWeight = 8
        GrillaClientes.Columns(5).FillWeight = 11.5
        GrillaClientes.Columns(7).FillWeight = 10.5
        GrillaClientes.Columns(8).FillWeight = 15
        GrillaClientes.Columns(10).FillWeight = 15
        GrillaClientes.Columns(12).FillWeight = 15

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA
        For i As Integer = 0 To 16
            GrillaClientes.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

        'SI VIENE DESDE VENTAS, REALIZA LA PRIMER PARTE DEL IF

        If lblEdit.Text = "Ventas" Then

            ABM_Ventas.txtCuenta.Text = GrillaClientes.CurrentRow.Cells(1).Value
            lblEdit.Text = ""
            ABM_Ventas.txtCuenta.Focus()
            ABM_Ventas.ActualizarDatosCliente(ABM_Ventas.txtCuenta.Text)

            ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)

        Else 'SI VIENE DESDE CLIENTES, REALIZA ESTE ELSE

            ABM_Clientes.lblSeñalCliente.Text = "Agregar"

            'ACTIVO
            ABM_Clientes.chActivo.Checked = True

            'CARGA LOS COMBOBOX
            ABM_Clientes.Provincias()
            ABM_Clientes.Localidades()
            ABM_Clientes.CondicionesIva()

            'ABRE EL PANEL
            ModuloPrincipal.AbrirFormEnPanel(ABM_Clientes)

        End If
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click

        ABM_Clientes.lblSeñalCliente.Text = "Editar"

        'CARGA LOS COMBOBOX
        ABM_Clientes.Provincias()
        ABM_Clientes.Localidades()
        ABM_Clientes.CondicionesIva()

        'ACTIVO
        Dim activo As Integer = GrillaClientes.CurrentRow.Cells(16).Value

        ABM_Clientes.chActivo.Checked = (activo = 1)

        'LLEVO LOS DATOS PARA EDITAR
        ABM_Clientes.txtIDCliente.Text = GrillaClientes.CurrentRow.Cells(0).Value
        ABM_Clientes.txtCuenta.Text = GrillaClientes.CurrentRow.Cells(1).Value
        ABM_Clientes.txtNombre.Text = GrillaClientes.CurrentRow.Cells(2).Value
        ABM_Clientes.txtApellido.Text = GrillaClientes.CurrentRow.Cells(3).Value
        ABM_Clientes.txtDni.Text = GrillaClientes.CurrentRow.Cells(4).Value
        ABM_Clientes.txtCuit.Text = GrillaClientes.CurrentRow.Cells(5).Value
        ABM_Clientes.txtNacionalidad.Text = GrillaClientes.CurrentRow.Cells(6).Value
        ABM_Clientes.cbProvincia.Text = GrillaClientes.CurrentRow.Cells(7).Value
        ABM_Clientes.cbLocalidades.Text = GrillaClientes.CurrentRow.Cells(8).Value
        ABM_Clientes.txtCp.Text = GrillaClientes.CurrentRow.Cells(9).Value
        ABM_Clientes.txtDireccion.Text = GrillaClientes.CurrentRow.Cells(10).Value
        ABM_Clientes.dtFechaNacimiento.Value = GrillaClientes.CurrentRow.Cells(11).Value
        ABM_Clientes.txtTelefono.Text = GrillaClientes.CurrentRow.Cells(12).Value
        ABM_Clientes.txtEmail.Text = GrillaClientes.CurrentRow.Cells(13).Value
        ABM_Clientes.cbCondicionIva.Text = GrillaClientes.CurrentRow.Cells(14).Value
        ABM_Clientes.chActivo.Checked = activo

        ModuloPrincipal.AbrirFormEnPanel(ABM_Clientes)
    End Sub
End Class