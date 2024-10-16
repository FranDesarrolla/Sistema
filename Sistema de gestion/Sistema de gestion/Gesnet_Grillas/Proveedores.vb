Imports System.Data.SqlClient

Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaProveedores()
    End Sub

    Private Sub txtBusquedaProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaProveedor.TextChanged
        llenarGrillaProveedores(txtBusquedaProveedor.Text.Trim())
    End Sub

    Public Sub llenarGrillaProveedores(Optional ByVal terminoBusquedaProveedor As String = "")
        'Limpiar datos de la grilla
        If setdedatos.Tables.Contains("dtProveedor") Then
            setdedatos.Tables("dtProveedor").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT P.ID, P.Cuenta, P.Nombre, P.Firma, P.Nacionalidad, Pr.Provincia, L.Localidad, P.CodigoPostal, P.Direccion, P.FechaDeNacimiento, P.Telefono, P.Email, P.FechaDeRegistro, P.EstadoDeCuenta 
                              FROM Proveedores P
                              INNER JOIN Provincias Pr ON P.Provincia = Pr.ID
                              INNER JOIN Localidades L ON P.Localidad = L.ID"

        ' Agregar la lógica de búsqueda si se proporciona un término de búsqueda
        If Not String.IsNullOrEmpty(terminoBusquedaProveedor) Then
            ' Construir las condiciones de búsqueda para cada campo
            Dim condicionesBusqueda As String = " WHERE P.Cuenta LIKE '%" & terminoBusquedaProveedor & "%'" &
                                         " OR P.Nombre LIKE '%" & terminoBusquedaProveedor & "%'" &
                                         " OR P.Firma LIKE '%" & terminoBusquedaProveedor & "%'" &
                                         " OR P.CUIT LIKE '%" & terminoBusquedaProveedor & "%'" &
                                         " OR Pr.Provincia LIKE '%" & terminoBusquedaProveedor & "%'" &
                                         " OR L.Localidad LIKE '%" & terminoBusquedaProveedor & "%'"
            ' Añadir las condiciones a la consulta
            consultassql &= condicionesBusqueda
        End If

        consultassql &= " ORDER BY Cuenta ASC"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtCliente As New DataTable
        adaptadorSql.Fill(setdedatos, "dtProveedor")
        GrillaProveedores.DataSource = setdedatos.Tables("dtProveedor")
        GrillaProveedores.Font = New Font("Yu Gothic UI", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES
        Dim columnasOcultas As Integer() = {0, 4, 10}
        For Each col In columnasOcultas
            GrillaProveedores.Columns(col).Visible = False
        Next

    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ABM_Proveedores.lblSeñalProveedor.Text = "AGREGAR"

        ModuloPrincipal.AbrirFormEnPanel(ABM_Proveedores)
    End Sub

    Private Sub btnEditarProveedor_Click(sender As Object, e As EventArgs) Handles btnEditarProveedor.Click
        ABM_Proveedores.lblSeñalProveedor.Text = "EDITAR"

        ABM_Proveedores.txtIdProv.Text = GrillaProveedores.CurrentRow.Cells(0).Value
        ABM_Proveedores.txtCuentaProv.Text = GrillaProveedores.CurrentRow.Cells(1).Value
        ABM_Proveedores.txtNombreProv.Text = GrillaProveedores.CurrentRow.Cells(2).Value
        ABM_Proveedores.txtFirmaProv.Text = GrillaProveedores.CurrentRow.Cells(3).Value
        ABM_Proveedores.txtNacionalidadProv.Text = GrillaProveedores.CurrentRow.Cells(4).Value
        ABM_Proveedores.txtProvinciaProv.Text = GrillaProveedores.CurrentRow.Cells(5).Value
        ABM_Proveedores.txtLocalidadProv.Text = GrillaProveedores.CurrentRow.Cells(6).Value
        ABM_Proveedores.txtCodigoPostalProv.Text = GrillaProveedores.CurrentRow.Cells(7).Value
        ABM_Proveedores.txtDireccionProv.Text = GrillaProveedores.CurrentRow.Cells(8).Value
        ABM_Proveedores.DpFechaNaProv.Value = GrillaProveedores.CurrentRow.Cells(9).Value
        ABM_Proveedores.txtTelefonoProv.Text = GrillaProveedores.CurrentRow.Cells(10).Value
        ABM_Proveedores.txtEmailProv.Text = GrillaProveedores.CurrentRow.Cells(11).Value
        ABM_Proveedores.DpFechaRegistroProv.Value = GrillaProveedores.CurrentRow.Cells(12).Value
        ABM_Proveedores.txtEstadoCuentaProv.Text = GrillaProveedores.CurrentRow.Cells(13).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Proveedores)

    End Sub
End Class