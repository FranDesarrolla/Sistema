Imports System.Data.SqlClient

Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaVentas()
        ModuloSistema.conexionSql.Open()
    End Sub
    Public Sub llenarGrillaVentas()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtventa") Then
            setdedatos.Tables("dtventa").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT NDV.idventa as ID, C.Nombre + ' ' + C.Apellido AS Cliente, E.Nombre + ' ' + E.Apellido AS Empleado, NDV.idcliente, NDV.idempleado, NDV.FechaDeVenta AS Fecha, 
		                                    NDV.PuntoDeVenta as Sucursal, NDV.NroComprobante as Comprobante, NDV.Letra, NDV.MetodoDePago as Metodo, NDV.TipoFactura as Tipo, NDV.Total, C.Nombre, C.Apellido
                                    FROM NotasDeVentas NDV
                                    INNER JOIN Clientes C ON C.idcliente = NDV.idcliente
                                    INNER JOIN Empleados E ON E.idempleado = NDV.idempleado"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtventa As New DataTable
        adaptadorSql.Fill(setdedatos, "dtventa")
        GrillaVentas.DataSource = setdedatos.Tables("dtventa")
        GrillaVentas.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {3, 4, 10, 11, 12, 13}

        For Each columna As Integer In columnasOcultar
            GrillaVentas.Columns(columna).Visible = False
        Next

        'CONFIGURAR ANCHOS DE LAS COLUMNAS VISIBLES

        GrillaVentas.Columns(0).FillWeight = 5
        GrillaVentas.Columns(1).FillWeight = 20
        GrillaVentas.Columns(2).FillWeight = 20
        GrillaVentas.Columns(5).FillWeight = 10
        GrillaVentas.Columns(6).FillWeight = 10
        GrillaVentas.Columns(7).FillWeight = 15
        GrillaVentas.Columns(8).FillWeight = 6
        GrillaVentas.Columns(9).FillWeight = 14

        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 13
            GrillaVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        ABM_Ventas.ABM.Text = "Editar"

        ABM_Ventas.lblLetra.Text = GrillaVentas.CurrentRow.Cells(8).Value
        ABM_Ventas.txtCuenta.Text = GrillaVentas.CurrentRow.Cells(3).Value
        ABM_Ventas.lblNombreCliente.Text = GrillaVentas.CurrentRow.Cells(12).Value
        ABM_Ventas.lblApellidoCliente.Text = GrillaVentas.CurrentRow.Cells(13).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)
        ModuloSistema.conexionSql.Close()

    End Sub
End Class