Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient

Public Class ABM_Ventas
    Private Sub ABM_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaMovVentas()
        LlenarComboBoxProductos()
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

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        ' Verificar si los campos txtUnitario y txtCantidad no están vacíos
        If Not String.IsNullOrEmpty(txtUnitario.Text) AndAlso Not String.IsNullOrEmpty(txtCantidad.Text) Then
            ' Convertir los valores de txtUnitario y txtCantidad a números
            Dim unitario As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim cantidad As Decimal = Decimal.Parse(txtCantidad.Text)

            ' Calcular el subtotal sin impuestos
            Dim subtotalSin As Decimal = unitario * cantidad

            ' Mostrar el subtotal sin impuestos en el TextBox correspondiente
            txtSubtotalSin.Text = subtotalSin.ToString()
        End If
    End Sub

    Private Sub txtIVAP_Leave(sender As Object, e As EventArgs) Handles txtIVAP.Leave
        ' Verificar si los campos txtUnitario, txtCantidad y txtIVAP no están vacíos
        If Not String.IsNullOrEmpty(txtUnitario.Text) AndAlso Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso Not String.IsNullOrEmpty(txtIVAP.Text) Then
            ' Convertir los valores de txtUnitario, txtCantidad y txtIVAP a números
            Dim unitario As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim cantidad As Decimal = Decimal.Parse(txtCantidad.Text)
            Dim iva As Decimal = Decimal.Parse(txtIVAP.Text)

            ' Calcular el subtotal con impuestos
            Dim subtotalCon As Decimal = (unitario * cantidad) * (iva / 100 + 1)
            Dim importeIVA As Decimal = subtotalCon - (unitario * cantidad)

            ' Mostrar el subtotal con impuestos en el TextBox correspondiente
            txtSubtotalCon.Text = subtotalCon.ToString()
            txtIVA.Text = importeIVA.ToString()
        End If
    End Sub

    Private Sub SumarSubtotalesYActualizarTotal()
        Dim total As Decimal = 0

        ' Iterar a través de todas las filas de la grilla
        For Each fila As DataGridViewRow In GrillaMovVentas.Rows
            ' Verificar si la fila no es la fila de encabezado y si tiene datos en la columna de subtotal
            If Not fila.IsNewRow AndAlso fila.Cells("Subtotal").Value IsNot Nothing Then
                ' Convertir el valor de la columna Subtotal a Decimal y sumarlo al total
                total += Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If
        Next

        ' Mostrar el total en el Label lblTotal
        lblTotal.Text = "$" & total.ToString()
    End Sub

    Private Sub GrillaMovVentas_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GrillaMovVentas.RowsAdded
        ' Llamar a la función para sumar los subtotales y actualizar el total
        SumarSubtotalesYActualizarTotal()
    End Sub

    Public Sub llenarGrillaMovVentas()
        'LIMPIAR DATOS DE LA GRILLA

        If setdedatos.Tables.Contains("dtmovventas") Then
            setdedatos.Tables("dtmovventas").Rows.Clear()
        End If

        Dim consultassql As String = "SELECT NDM.IDNotasDeVentasMov as ID, NDM.Producto, P.Descripcion, NDM.Cantidad as 'Cant.', NDM.PrecioUnitario as Unitario, NDM.Descuento, NDM.Impuestos, NDM.SubTotal as Subtotal, P.Iva, P.Descripcion FROM NotasDeVentasMov NDM
                                      INNER JOIN Productos P ON P.Codigo = NDM.Producto
                                      WHERE NDM.IDNotaDeVenta = " & lblID.Text

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        Dim dtmovventas As New DataTable
        adaptadorSql.Fill(setdedatos, "dtmovventas")
        GrillaMovVentas.DataSource = setdedatos.Tables("dtmovventas")
        GrillaMovVentas.Font = New Font("Arial", 10)

        'CONFIGURAR QUE COLUMNAS SERAN VISIBLES

        Dim columnasOcultar() As Integer = {0, 8, 9}

        For Each columna As Integer In columnasOcultar
            GrillaMovVentas.Columns(columna).Visible = False
        Next

        GrillaMovVentas.Columns(1).FillWeight = 15
        GrillaMovVentas.Columns(2).FillWeight = 25
        GrillaMovVentas.Columns(3).FillWeight = 7
        GrillaMovVentas.Columns(4).FillWeight = 12
        GrillaMovVentas.Columns(5).FillWeight = 12
        GrillaMovVentas.Columns(6).FillWeight = 12
        GrillaMovVentas.Columns(7).FillWeight = 12

        For i As Integer = 0 To 9
            GrillaMovVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

        ActivarBotones()
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
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

        Dim precioFormateado As String = txtUnitario.Text.Replace(",", ".")
        Dim descFormateado As String = txtDescuento.Text.Replace(",", ".")
        Dim ivaFormateado As String = txtIVA.Text.Replace(",", ".")
        Dim subconFormateado As String = txtSubtotalCon.Text.Replace(",", ".")

        If lblMov.Text = "Editar" Then
            Try

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
                                VALUES ('" & lblID.Text & "','" & txtCodigo.Text & "','" & txtCantidad.Text & "','" & precioFormateado & "', '" & descFormateado & "', '" & ivaFormateado & "', '" & subconFormateado & "')"
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
        Me.boxProductos.Text = ""
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
        Me.boxProductos.Text = GrillaMovVentas.CurrentRow.Cells(9).Value
        Me.txtCantidad.Text = GrillaMovVentas.CurrentRow.Cells(3).Value
        Me.txtUnitario.Text = GrillaMovVentas.CurrentRow.Cells(4).Value
        Me.txtDescuento.Text = GrillaMovVentas.CurrentRow.Cells(5).Value
        Me.txtIVAP.Text = GrillaMovVentas.CurrentRow.Cells(8).Value
        Me.txtIVA.Text = GrillaMovVentas.CurrentRow.Cells(6).Value
        Me.txtSubtotalSin.Text = GrillaMovVentas.CurrentRow.Cells(3).Value
        Me.txtSubtotalCon.Text = GrillaMovVentas.CurrentRow.Cells(7).Value

        lblMov.Text = "Editar"
        btnAgregar.Text = "Aceptar"

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaMovVentas()
    End Sub

    Public Sub LlenarComboBoxProductos()
        'Select para el Combobox Productos

        adaptadorSql.SelectCommand = acciones
        adaptadorSql.SelectCommand.Connection = conexionSql
        acciones.CommandText = "SELECT Codigo, Descripcion, PrecioUnitario, IVA FROM Productos"
        adaptadorSql.Fill(setdedatos, "dtproductos")
        boxProductos.DataSource = setdedatos.Tables("dtproductos")

        'Datos a visualizar en el Combobox Productos

        boxProductos.DisplayMember = "Descripcion"
        boxProductos.ValueMember = "Codigo"
        acciones.ExecuteNonQuery()
    End Sub

    Private Sub boxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxProductos.SelectedIndexChanged
        ' Obtiene la fila seleccionada del ComboBox
        Dim filaSeleccionada As DataRowView = DirectCast(boxProductos.SelectedItem, DataRowView)

        ' Verifica si se ha seleccionado una fila y si los datos son válidos
        If filaSeleccionada IsNot Nothing AndAlso filaSeleccionada.Row IsNot Nothing Then
            ' Asigna los valores de los campos correspondientes a los TextBox
            txtCodigo.Text = filaSeleccionada.Row("Codigo").ToString()
            txtUnitario.Text = filaSeleccionada.Row("PrecioUnitario").ToString()
            txtIVAP.Text = filaSeleccionada.Row("IVA").ToString()
        End If
    End Sub

    Public Sub LlenarComboBoxTipoComprobante()
        'Select para el Combobox Productos

        adaptadorSql.SelectCommand = acciones
        adaptadorSql.SelectCommand.Connection = conexionSql
        acciones.CommandText = "SELECT Codigo, Descripcion, PrecioUnitario, IVA FROM Productos"
        adaptadorSql.Fill(setdedatos, "dtproductos")
        boxProductos.DataSource = setdedatos.Tables("dtproductos")

        'Datos a visualizar en el Combobox Productos

        boxProductos.DisplayMember = "Descripcion"
        boxProductos.ValueMember = "Codigo"
        acciones.ExecuteNonQuery()
    End Sub

End Class