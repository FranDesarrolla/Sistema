Imports System.Data.SqlClient

Public Class ABM_Ventas
    Private Sub ABM_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaMovVentas()
    End Sub

    Public Sub ActivarBotones()
        If GrillaMovVentas.Rows.Count > 0 Then
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Public Sub llenarGrillaMovVentas()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtmovventas") Then
            setdedatos.Tables("dtmovventas").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT IDNotasDeVentasMov as ID, Producto, Cantidad, PrecioUnitario as Unitario, Descuento, Impuestos, SubTotal as Subtotal FROM NotasDeVentasMov
                                      WHERE IDNotaDeVenta = " & lblID.Text

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtmovventas As New DataTable
        adaptadorSql.Fill(setdedatos, "dtmovventas")
        GrillaMovVentas.DataSource = setdedatos.Tables("dtmovventas")
        GrillaMovVentas.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {0}

        For Each columna As Integer In columnasOcultar
            GrillaMovVentas.Columns(columna).Visible = False
        Next

        GrillaMovVentas.Columns(1).FillWeight = 25
        GrillaMovVentas.Columns(2).FillWeight = 15
        GrillaMovVentas.Columns(3).FillWeight = 15
        GrillaMovVentas.Columns(4).FillWeight = 15
        GrillaMovVentas.Columns(5).FillWeight = 15
        GrillaMovVentas.Columns(6).FillWeight = 15

        For i As Integer = 0 To 6
            GrillaMovVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

        ActivarBotones()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        llenarGrillaMovVentas()
        LimpiaMovVentas()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As Integer = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Try
                adaptadorSql.SelectCommand = acciones
                adaptadorSql.SelectCommand.Connection = conexionSql
                acciones.CommandText = "DELETE FROM NotasDeVentasMov WHERE IDNotasDeVentasMov = " & GrillaMovVentas.CurrentRow.Cells(0).Value & ""
                acciones.ExecuteNonQuery()

                MessageBox.Show("El registro se ha eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            llenarGrillaMovVentas()
            ActivarBotones()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If lblMov.Text = "Editar" Then
            Try
                Dim precioFormateado As String = txtUnitario.Text.Replace(",", ".")
                Dim descFormateado As String = txtDescuento.Text.Replace(",", ".")
                Dim ivaFormateado As String = txtIVA.Text.Replace(",", ".")
                Dim subconFormateado As String = txtSubtotalCon.Text.Replace(",", ".")

                adaptadorSql.SelectCommand = acciones
                adaptadorSql.SelectCommand.Connection = conexionSql
                acciones.CommandText = "UPDATE dbo.NotasDeVentasMov
                                        SET Producto = '" & GrillaMovVentas.CurrentRow.Cells(1).Value & "', Cantidad = " & GrillaMovVentas.CurrentRow.Cells(2).Value & ", PrecioUnitario = " & precioFormateado & ", Descuento = " & descFormateado & ", Impuestos = " & ivaFormateado & ", SubTotal = " & subconFormateado & "
                                        WHERE IDNotasDeVentasMov = " & GrillaMovVentas.CurrentRow.Cells(0).Value

                acciones.ExecuteNonQuery()

                LimpiaMovVentas()
                MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            llenarGrillaMovVentas()
        Else
            Try
                adaptadorSql.SelectCommand = acciones
                adaptadorSql.SelectCommand.Connection = conexionSql
                acciones.CommandText = "INSERT INTO dbo.NotasDeVentasMov (IDNotaDeVenta, Producto, Cantidad, PrecioUnitario, Descuento, Impuestos, SubTotal)
                                VALUES ('" & lblID.Text & "','" & txtCodigo.Text & "','" & txtCantidad.Text & "','" & txtUnitario.Text & "', '" & txtDescuento.Text & "', '" & txtIVA.Text & "', '" & txtSubtotalCon.Text & "')"
                acciones.ExecuteNonQuery()

                LimpiaMovVentas()
                MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            llenarGrillaMovVentas()
        End If
    End Sub

    Public Sub LimpiaMovVentas()
        Me.txtCodigo.Text = ""
        Me.txtProducto.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtUnitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIVAP.Text = ""
        Me.txtIVA.Text = ""
        Me.txtSubtotalSin.Text = ""
        Me.txtSubtotalCon.Text = ""

        btnAgregar.Text = "Agregar"
        lblMov.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Me.txtCodigo.Text = GrillaMovVentas.CurrentRow.Cells(1).Value
        Me.txtProducto.Text = ""
        Me.txtCantidad.Text = GrillaMovVentas.CurrentRow.Cells(2).Value
        Me.txtUnitario.Text = GrillaMovVentas.CurrentRow.Cells(3).Value
        Me.txtDescuento.Text = GrillaMovVentas.CurrentRow.Cells(4).Value
        Me.txtIVAP.Text = 21
        Me.txtIVA.Text = GrillaMovVentas.CurrentRow.Cells(5).Value
        Me.txtSubtotalSin.Text = ""
        Me.txtSubtotalCon.Text = GrillaMovVentas.CurrentRow.Cells(6).Value

        lblMov.Text = "Editar"
        btnAgregar.Text = "Aceptar"

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaMovVentas()
    End Sub
End Class