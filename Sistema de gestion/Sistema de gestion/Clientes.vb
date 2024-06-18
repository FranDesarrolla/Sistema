Imports System.Data.SqlClient

Public Class Clientes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaClientes()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim terminoBusquedaCliente As String = txtBusquedaCliente.Text.Trim()
        llenarGrillaClientes(terminoBusquedaCliente) ' Llamada al método con el término de búsqueda ingresado
    End Sub

    Public Sub llenarGrillaClientes(Optional ByVal terminoBusquedaCliente As String = "")
        ' Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtCliente") Then
            setdedatos.Tables("dtCliente").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT IDCliente, Cuenta, Nombre, Apellido, DNI, CUIT, Nacionalidad, Provincia, Localidad, CodigoPostal, Direccion, FechaDeNacimiento, Telefono, Email, CondicionIVA, FechaDeRegistro, EstadoDeCuenta 
                                      FROM Clientes"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusquedaCliente) Then
            consultassql &= " WHERE Cuenta LIKE '%" & terminoBusquedaCliente & "%' OR Nombre LIKE '%" & terminoBusquedaCliente & "%'"
        End If

        consultassql &= " ORDER BY Cuenta ASC"

        ' Usa la conexión SQL proporcionada por ModuloPrincipal
        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtCliente As New DataTable
        adaptadorSql.Fill(setdedatos, "dtCliente")
        GrillaClientes.DataSource = setdedatos.Tables("dtCliente")
        GrillaClientes.Font = New Font("Arial", 10)

        ' CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        Dim columnasOcultas As Integer() = {0, 15}
        For Each col In columnasOcultas
            GrillaClientes.Columns(col).Visible = False
        Next
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        ABM_Clientes.lblSeñalCliente.Text = "AGREGAR"
        ModuloPrincipal.AbrirFormEnPanel(ABM_Clientes)
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        ABM_Clientes.lblSeñalCliente.Text = "EDITAR"

        ABM_Clientes.txtIDCliente.Text = GrillaClientes.CurrentRow.Cells(0).Value
        ABM_Clientes.txtCuentaCliente.Text = GrillaClientes.CurrentRow.Cells(1).Value
        ABM_Clientes.txtNombreCliente.Text = GrillaClientes.CurrentRow.Cells(2).Value
        ABM_Clientes.txtApellidoCliente.Text = GrillaClientes.CurrentRow.Cells(3).Value
        ABM_Clientes.txtDniClie.Text = GrillaClientes.CurrentRow.Cells(4).Value
        ABM_Clientes.txtCuitClie.Text = GrillaClientes.CurrentRow.Cells(5).Value
        ABM_Clientes.txtNacionalidadCliente.Text = GrillaClientes.CurrentRow.Cells(6).Value
        ABM_Clientes.txtProvinciaCliente.Text = GrillaClientes.CurrentRow.Cells(7).Value
        ABM_Clientes.txtLocalidadCliente.Text = GrillaClientes.CurrentRow.Cells(8).Value
        ABM_Clientes.txtCodPCliente.Text = GrillaClientes.CurrentRow.Cells(9).Value
        ABM_Clientes.txtDireccionCliente.Text = GrillaClientes.CurrentRow.Cells(10).Value
        ABM_Clientes.dtFechaNacimiento.Value = GrillaClientes.CurrentRow.Cells(11).Value
        ABM_Clientes.txtTelefonoCliente.Text = GrillaClientes.CurrentRow.Cells(12).Value
        ABM_Clientes.txtEmailCliente.Text = GrillaClientes.CurrentRow.Cells(13).Value
        ABM_Clientes.txtCondicionivaClie.Text = GrillaClientes.CurrentRow.Cells(14).Value
        ABM_Clientes.dtFechaRegistroCliente.Text = GrillaClientes.CurrentRow.Cells(15).Value
        ABM_Clientes.txtEstadoCuenta.Text = GrillaClientes.CurrentRow.Cells(16).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Clientes)
    End Sub

End Class