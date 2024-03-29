﻿Imports System.Data.SqlClient

Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaVentas()
    End Sub
    Public Sub llenarGrillaVentas()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtventa") Then
            setdedatos.Tables("dtventa").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT NDV.IDNotaDeVenta AS ID, C.Nombre + ' ' + C.Apellido AS Cliente, E.Nombre + ' ' + E.Apellido AS Empleado, NDV.Cliente, NDV.Empleado, NDV.FechaDeVenta AS Fecha, 
		                            NDV.PuntoDeVenta as Sucursal, NDV.NroComprobante as Comprobante, NDV.Letra, NDV.MetodoDePago as Metodo, NDV.TipoFactura as Tipo, NDV.Total, C.Nombre, C.Apellido, C.Direccion, C.DNI, C.CUIT, C.CondicionIVA
                                    FROM NotasDeVentas NDV
                                    INNER JOIN Clientes C ON C.Cuenta = NDV.Cliente
                                    INNER JOIN Empleados E ON E.Cuenta = NDV.Empleado"

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtventa As New DataTable
        adaptadorSql.Fill(setdedatos, "dtventa")
        GrillaVentas.DataSource = setdedatos.Tables("dtventa")
        GrillaVentas.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {3, 4, 10, 11, 12, 13, 14, 15, 16, 17}

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

        For i As Integer = 0 To 17
            GrillaVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

        ABM_Ventas.llenarGrillaMovVentas()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        ABM_Ventas.lblABM.Text = "Editar"

        ABM_Ventas.lblID.Text = GrillaVentas.CurrentRow.Cells(0).Value
        ABM_Ventas.txtCuenta.Text = GrillaVentas.CurrentRow.Cells(3).Value
        ABM_Ventas.lblNombreCliente.Text = GrillaVentas.CurrentRow.Cells(12).Value
        ABM_Ventas.lblApellidoCliente.Text = GrillaVentas.CurrentRow.Cells(13).Value
        ABM_Ventas.lblDireccion.Text = GrillaVentas.CurrentRow.Cells(14).Value
        ABM_Ventas.lblDNII.Text = GrillaVentas.CurrentRow.Cells(15).Value
        ABM_Ventas.lblCUITT.Text = GrillaVentas.CurrentRow.Cells(16).Value
        ABM_Ventas.txtFecha.Text = GrillaVentas.CurrentRow.Cells(5).Value
        ABM_Ventas.txtSucursal.Text = GrillaVentas.CurrentRow.Cells(6).Value
        ABM_Ventas.txtComprobante.Text = GrillaVentas.CurrentRow.Cells(7).Value
        ABM_Ventas.lblLetra.Text = GrillaVentas.CurrentRow.Cells(8).Value

        ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)
        ABM_Ventas.llenarGrillaMovVentas()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ABM_Ventas.lblABM.Text = "Agregar"
        ModuloPrincipal.AbrirFormEnPanel(ABM_Ventas)

    End Sub
End Class