Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class ABM_Ventas
    Private cambiosRealizados As New List(Of Cambio)

    Private Class Cambio
        Public TipoOperacion As String
        Public DatosAntes As String()
    End Class

    Private Sub ABM_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaMovVentas()
        llenarGrillaMovVentas()
        LlenarComboBoxMetodos()
        ConfigurarComboBoxComprobante()
        lblTotal.Left = lblTitotal.Right
    End Sub

    Private Sub ConfigurarComboBoxComprobante()
        boxComprobante.Items.AddRange({"Factura", "Nota de Crédito", "Nota de Débito"})
        boxComprobante.SelectedItem = "Factura"
    End Sub


    Private Sub txtUnitario_Leave(sender As Object, e As EventArgs) Handles txtUnitario.Leave
        ' Reemplazar puntos por comas
        txtUnitario.Text = txtUnitario.Text.Replace(".", ",")

        ' Verificar si el cuadro de texto está vacío
        If String.IsNullOrEmpty(txtUnitario.Text) Then
            ' Si está vacío, establecer el valor en "0,00"
            txtUnitario.Text = "0,00"
        Else
            ' Si no está vacío, verificar si tiene decimales
            If Not txtUnitario.Text.Contains(",") Then
                ' Si no tiene decimales, agregar ",00"
                txtUnitario.Text &= ",00"
            Else
                ' Separar la parte decimal
                Dim partes As String() = txtUnitario.Text.Split(","c)
                ' Verificar si la parte decimal tiene solo un dígito
                If partes.Length = 2 AndAlso partes(1).Length = 1 Then
                    ' Si solo tiene un dígito, agregar un 0 adicional
                    txtUnitario.Text &= "0"
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave

        ' Reemplazar puntos por comas
        txtCantidad.Text = txtCantidad.Text.Replace(".", ",")

        ' Verificar si el cuadro de texto está vacío
        If String.IsNullOrEmpty(txtCantidad.Text) Then
            ' Si está vacío, establecer el valor en "0,00"
            txtCantidad.Text = "0,00"
        Else
            ' Si no está vacío, verificar si tiene decimales
            If Not txtCantidad.Text.Contains(",") Then
                ' Si no tiene decimales, agregar ",00"
                txtCantidad.Text &= ",00"
            Else
                ' Separar la parte decimal
                Dim partes As String() = txtCantidad.Text.Split(","c)
                ' Verificar si la parte decimal tiene solo un dígito
                If partes.Length = 2 AndAlso partes(1).Length = 1 Then
                    ' Si solo tiene un dígito, agregar un 0 adicional
                    txtCantidad.Text &= "0"
                End If
            End If
        End If
    End Sub

    Private Sub txtIVAP_Leave(sender As Object, e As EventArgs) Handles txtIVAP.Leave

        ' Reemplazar puntos por comas
        txtIVAP.Text = txtIVAP.Text.Replace(".", ",")

        ' Verificar si el cuadro de texto está vacío
        If String.IsNullOrEmpty(txtIVAP.Text) Then
            ' Si está vacío, establecer el valor en "0,00"
            txtIVAP.Text = "0,00"
        Else
            ' Si no está vacío, verificar si tiene decimales
            If Not txtIVAP.Text.Contains(",") Then
                ' Si no tiene decimales, agregar ",00"
                txtIVAP.Text &= ",00"
            Else
                ' Separar la parte decimal
                Dim partes As String() = txtIVAP.Text.Split(","c)
                ' Verificar si la parte decimal tiene solo un dígito
                If partes.Length = 2 AndAlso partes(1).Length = 1 Then
                    ' Si solo tiene un dígito, agregar un 0 adicional
                    txtIVAP.Text &= "0"
                End If
            End If
        End If
    End Sub

    Private Sub txtDescuento_Leave(sender As Object, e As EventArgs) Handles txtDescuento.Leave

        ' Reemplazar puntos por comas
        txtDescuento.Text = txtDescuento.Text.Replace(".", ",")

        ' Verificar si el cuadro de texto está vacío
        If String.IsNullOrEmpty(txtDescuento.Text) Then
            ' Si está vacío, establecer el valor en "0,00"
            txtDescuento.Text = "0,00"
        Else
            ' Si no está vacío, verificar si tiene decimales
            If Not txtDescuento.Text.Contains(",") Then
                ' Si no tiene decimales, agregar ",00"
                txtDescuento.Text &= ",00"
            Else
                ' Separar la parte decimal
                Dim partes As String() = txtDescuento.Text.Split(","c)
                ' Verificar si la parte decimal tiene solo un dígito
                If partes.Length = 2 AndAlso partes(1).Length = 1 Then
                    ' Si solo tiene un dígito, agregar un 0 adicional
                    txtDescuento.Text &= "0"
                End If
            End If
        End If

        If Not String.IsNullOrEmpty(txtUnitario.Text) AndAlso Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso Not String.IsNullOrEmpty(txtDescuento.Text) AndAlso Not String.IsNullOrEmpty(txtIVAP.Text) Then
            Dim unitario As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim cantidad As Decimal = Decimal.Parse(txtCantidad.Text)
            Dim descuento As Decimal = Decimal.Parse(txtDescuento.Text)
            Dim iva As Decimal = Decimal.Parse(txtIVAP.Text)

            Dim subtotalSinIva As Decimal = unitario * cantidad
            Dim descuentoAplicado As Decimal = subtotalSinIva * (descuento / 100)
            Dim subtotalConDescuento As Decimal = subtotalSinIva - descuentoAplicado

            Dim importeIVA As Decimal = subtotalConDescuento * (iva / 100)
            Dim subtotalConDescuentoConIVA As Decimal = subtotalConDescuento + importeIVA

            ' Utilizamos String.Format para limitar la cantidad de decimales a 2
            txtSubtotalCon.Text = String.Format("{0:0.00}", subtotalConDescuentoConIVA)

            ' Verificar si el cuadro de texto está vacío
            If String.IsNullOrEmpty(txtDescuento.Text) Then
                ' Si está vacío, establecer el valor en "0,00"
                txtDescuento.Text = "0,00"
            Else
                ' Si no está vacío, verificar si tiene decimales
                If Not txtDescuento.Text.Contains(",") Then
                    ' Si no tiene decimales, agregar ",00"
                    txtDescuento.Text = txtDescuento.Text & ",00"
                ElseIf txtDescuento.Text.IndexOf(",") = txtDescuento.Text.Length - 1 Then
                    ' Si solo tiene un decimal, agregar un 0 adicional
                    txtDescuento.Text = txtDescuento.Text & "0"
                End If
            End If
        End If
    End Sub

    Private Sub SumarSubtotalesYActualizarTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In GrillaMovVentas.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("Subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If
        Next

        lblTotal.Text = "$" & total.ToString()
    End Sub

    Private Sub GrillaMovVentas_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GrillaMovVentas.RowsAdded
        SumarSubtotalesYActualizarTotal()
    End Sub

    Public Sub llenarGrillaMovVentas()
        LimpiarGrilla()


        Dim consultassql As String = "SELECT NDM.IDNotasDeVentasMov as ID, NDM.Producto, P.Descripcion, NDM.Cantidad as 'Cant.', NDM.PrecioUnitario as Unitario, NDM.Descuento, NDM.Impuestos, NDM.SubTotal as Subtotal, P.Iva, P.Descripcion FROM NotasDeVentasMov NDM INNER JOIN Productos P ON P.Codigo = NDM.Producto WHERE NDM.IDNotaDeVenta = " & lblID.Text

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        adaptadorSql.Fill(setdedatos, "dtmovventas")
        GrillaMovVentas.DataSource = setdedatos.Tables("dtmovventas")

        ConfigurarColumnasGrilla()
        ActivarBotones()
    End Sub

    Private Sub LimpiarGrilla()
        If setdedatos.Tables.Contains("dtmovventas") Then
            setdedatos.Tables("dtmovventas").Rows.Clear()
        End If
    End Sub

    Private Sub ConfigurarColumnasGrilla()
        Dim columnasOcultar() As Integer = {0, 8, 9}

        For Each columna As Integer In columnasOcultar
            GrillaMovVentas.Columns(columna).Visible = False
        Next

        Dim columnasFillWeight() As Integer = {1, 2, 3, 4, 5, 6, 7}

        For Each columna As Integer In columnasFillWeight
            GrillaMovVentas.Columns(columna).FillWeight = 12
            GrillaMovVentas.Columns(columna).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Public Sub ActivarBotones()
        Dim enableButtons As Boolean = (GrillaMovVentas.Rows.Count > 0)

        btnEditar.Enabled = enableButtons
        btnEliminar.Enabled = enableButtons
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As Integer = MessageBox.Show("¿Está seguro de eliminar este registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Try
                Dim id = Convert.ToInt32(GrillaMovVentas.CurrentRow.Cells(0).Value)
                Dim query = "DELETE FROM NotasDeVentasMov WHERE IDNotasDeVentasMov = @ID"
                Using connection As New SqlConnection(conexionSql.ConnectionString),
                      command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", id)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("El registro se ha eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            llenarGrillaMovVentas()
            ActivarBotones()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If lblMov.Text = "Editar" Then
            EditarMovimiento()
        Else
            AgregarMovimiento()
        End If
    End Sub

    Private Sub EditarMovimiento()
        Try
            Dim precioFormateado As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim descFormateado As Decimal = Decimal.Parse(txtDescuento.Text)
            Dim subconFormateado As Decimal = Decimal.Parse(txtSubtotalCon.Text)

            Dim id As Integer = Convert.ToInt32(GrillaMovVentas.CurrentRow.Cells(0).Value)
            Dim query As String = "UPDATE dbo.NotasDeVentasMov
                                SET Producto = @Producto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Descuento = @Descuento, Impuestos = 0, SubTotal = @SubTotal
                                WHERE IDNotasDeVentasMov = @ID"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Producto", txtCodprod.Text)
                command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txtCantidad.Text))
                command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                command.Parameters.AddWithValue("@Descuento", descFormateado)
                command.Parameters.AddWithValue("@SubTotal", subconFormateado)
                command.Parameters.AddWithValue("@ID", id)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiaMovVentas()
            MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenarGrillaMovVentas()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarMovimiento()
        Try
            Dim precioFormateado As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim descFormateado As Decimal = Decimal.Parse(txtDescuento.Text)
            Dim subconFormateado As Decimal = Decimal.Parse(txtSubtotalCon.Text)

            Dim query As String = "INSERT INTO dbo.NotasDeVentasMov (IDNotaDeVenta, Producto, Cantidad, PrecioUnitario, Descuento, Impuestos, SubTotal)
                                VALUES (@IDNotaDeVenta, @Producto, @Cantidad, @PrecioUnitario, @Descuento, 0, @SubTotal)"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDNotaDeVenta", lblID.Text)
                command.Parameters.AddWithValue("@Producto", txtCodprod.Text)
                command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txtCantidad.Text))
                command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                command.Parameters.AddWithValue("@Descuento", descFormateado)
                command.Parameters.AddWithValue("@SubTotal", subconFormateado)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiaMovVentas()
            MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenarGrillaMovVentas()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditarRegistro()
        Try
            ' Obtener el índice seleccionado en boxComprobante (se le suma 1 para obtener el valor deseado)
            Dim tipoFactura As Integer = boxComprobante.SelectedIndex + 1

            ' Obtener el valor seleccionado en boxMetodo
            Dim metodoPago As String = DirectCast(boxMetodo.SelectedItem, DataRowView)("Metodo").ToString()

            Dim id As Integer = Convert.ToInt32(lblID.Text)
            Dim query As String = "UPDATE dbo.NotasDeVentasMov
                                SET IDNotaDeVenta = @idnotadeventa, Cliente = @cliente, Empleado = @empleado, FechaDeVenta = @fechadeventa, PuntoDeVenta = @puntodeventa, NroComprobante = @nrocomprobante, MetodoDePago = @metododepago, Letra = @letra, TipoFactura = @tipofactura, Total = @total
                                WHERE IDNotasDeVentasMov = @ID"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cliente", txtCuenta.Text)
                command.Parameters.AddWithValue("@fechadeventa", dateTime.Value)
                command.Parameters.AddWithValue("@metododepago", metodoPago)
                command.Parameters.AddWithValue("@tipofactura", tipoFactura)
                command.Parameters.AddWithValue("@total", 0)
                command.Parameters.AddWithValue("@ID", id)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Cabecera actualizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarRegistro()
        Try
            ' Obtener el índice seleccionado en boxComprobante (se le suma 1 para obtener el valor deseado)
            Dim tipoFactura As Integer = boxComprobante.SelectedIndex + 1

            ' Obtener el valor seleccionado en boxMetodo
            Dim metodoPago As String = DirectCast(boxMetodo.SelectedItem, DataRowView)("Metodo").ToString()

            Dim query As String = "INSERT INTO dbo.NotasDeVentas (Cliente, Empleado, FechaDeVenta, PuntoDeVenta, NroComprobante, MetodoDePago, Letra, TipoFactura, Total)
                               VALUES (@cliente, @empleado, @fechadeventa, @puntodeventa, @nrocomprobante, @metododepago, @letra, @tipofactura, @total);
                               SELECT SCOPE_IDENTITY();"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cliente", txtCuenta.Text)
                command.Parameters.AddWithValue("@fechadeventa", dateTime.Value)
                command.Parameters.AddWithValue("@metododepago", metodoPago)
                command.Parameters.AddWithValue("@tipofactura", tipoFactura)
                command.Parameters.AddWithValue("@total", lblTotal.Text)
                connection.Open()

                ' Ejecutar la consulta y obtener el último ID insertado
                Dim nuevoID As Integer = Convert.ToInt32(command.ExecuteScalar())
                lblID.Text = nuevoID.ToString()
            End Using

            MessageBox.Show("Cabecera creada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub LimpiaMovVentas()
        Me.txtDescripcion.Text = ""
        Me.txtCodprod.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtUnitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIVAP.Text = ""
        Me.txtSubtotalCon.Text = ""

        btnAgregar.Text = "Agregar"
        lblMov.Text = ""
    End Sub

    Private Function ObtenerDatosAntesDeOperacion() As String()
        Return {txtDescripcion.Text, txtCodprod.Text, txtCantidad.Text, txtUnitario.Text, txtDescuento.Text, txtIVAP.Text, txtSubtotalCon.Text}
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        CargarDatosParaEditar()
    End Sub

    Private Sub CargarDatosParaEditar()
        Me.txtDescripcion.Text = GrillaMovVentas.CurrentRow.Cells(9).Value
        Me.txtCodprod.Text = GrillaMovVentas.CurrentRow.Cells(1).Value
        Me.txtCantidad.Text = GrillaMovVentas.CurrentRow.Cells(3).Value
        Me.txtUnitario.Text = GrillaMovVentas.CurrentRow.Cells(4).Value
        Me.txtDescuento.Text = GrillaMovVentas.CurrentRow.Cells(5).Value
        Me.txtIVAP.Text = GrillaMovVentas.CurrentRow.Cells(8).Value
        Me.txtSubtotalCon.Text = GrillaMovVentas.CurrentRow.Cells(7).Value

        lblMov.Text = "Editar"
        btnAgregar.Text = "Aceptar"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaMovVentas()
    End Sub

    Public Sub LlenarComboBoxMetodos()
        Dim query As String = "SELECT IDMetodoPago, Metodo, ValDescAgregado FROM MetodosDePago"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim dtMetodos As New DataTable
        adaptadorSql.Fill(dtMetodos)
        boxMetodo.DataSource = dtMetodos
        boxMetodo.DisplayMember = "Metodo"
        boxMetodo.ValueMember = "IDMetodoPago"
    End Sub


    'Private Sub boxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxProductos.SelectedIndexChanged
    '    Dim filaSeleccionada As DataRowView = DirectCast(boxProductos.SelectedItem, DataRowView)

    '    If filaSeleccionada IsNot Nothing AndAlso filaSeleccionada.Row IsNot Nothing Then
    '        txtCodigo.Text = filaSeleccionada.Row("Codigo").ToString()
    '        txtUnitario.Text = filaSeleccionada.Row("PrecioUnitario").ToString()
    '        txtIVAP.Text = filaSeleccionada.Row("IVA").ToString()
    '    End If
    'End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        llenarGrillaMovVentas()
        LimpiaMovVentas()
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click

        If lblABM.Text = "Agregar" Then
            AgregarRegistro()
        ElseIf lblABM.Text = "Editar" Then
            EditarRegistro()
        End If

        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        llenarGrillaMovVentas()
        LimpiaMovVentas()
    End Sub

    ' Validaciones

    Private Sub txtCodprod_Leave(sender As Object, e As EventArgs) Handles txtCodprod.Leave
        If txtCodprod IsNot Nothing Then
            If txtCodprod.Text.Contains("%") Or txtCodprod.Text.Contains("#") Or txtCodprod.Text.Contains("$") Or txtCodprod.Text.Contains("""") Or txtCodprod.Text.Contains("'") Or txtCodprod.Text.Contains("/") Then
                MessageBox.Show("El campo no puede contener los caracteres especiales", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodprod.Focus()
            End If
        Else
            MessageBox.Show("TxtCodprod no esta inicializado", "Error de inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class