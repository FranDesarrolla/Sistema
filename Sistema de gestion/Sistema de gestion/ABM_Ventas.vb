Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class ABM_Ventas
    Private cambiosRealizados As New List(Of Cambio)

    Private Class Cambio
        Public TipoOperacion As String
        Public DatosAntes As String()
    End Class

    Private Sub ABM_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrillaMovVentas()
        LlenarComboBoxMetodos()
        ConfigurarComboBoxComprobante()
        ActualizarDatosCliente(txtCuenta.Text)
        lblTotal.Left = lblTitotal.Right
        dateTime.Focus()
    End Sub

    Private Sub ConfigurarComboBoxComprobante()
        boxComprobante.Items.AddRange({"Factura", "Nota de Crédito", "Nota de Débito"})
        boxComprobante.SelectedItem = "Factura"
    End Sub

    Private isCabeceraCreada As Boolean = False

    Private Sub CrearCabeceraNotaDeVenta()
        If lblABM.Text = "Agregar" AndAlso Not isCabeceraCreada Then
            Try
                ' Obtener los valores de los controles
                Dim cliente As String = txtCuenta.Text
                Dim empleado As String = "EM0001" ' Asigna el empleado según la lógica de tu aplicación
                Dim fechaDeVenta As DateTime = dateTime.Value
                Dim tipoFactura As Integer = boxComprobante.SelectedIndex + 1
                Dim puntoDeVenta As String = "00001" ' Ajusta según sea necesario
                Dim metodoDePago As String = "EFECTIVO" ' Obtener del combo si es necesario
                Dim total As Decimal = 0 ' Se puede ajustar si es necesario calcular el total
                Dim letra As String = ObtenerLetraCondicionIVA() ' Obtener la letra según el CondicionIVA

                ' Consulta SQL para insertar la cabecera y obtener el ID insertado
                Dim query As String = "INSERT INTO dbo.NotasDeVentas (Cliente, Empleado, FechaDeVenta, PuntoDeVenta, MetodoDePago, TipoFactura, Letra, Total) 
                                   VALUES (@cliente, @empleado, @fechadeventa, @puntodeventa, @metododepago, @tipofactura, @letra, @total);
                                   SELECT SCOPE_IDENTITY();"

                Using connection As New SqlConnection(conexionSql.ConnectionString),
                  command As New SqlCommand(query, connection)
                    ' Agregar los parámetros a la consulta
                    command.Parameters.AddWithValue("@cliente", cliente)
                    command.Parameters.AddWithValue("@empleado", empleado)
                    command.Parameters.AddWithValue("@fechadeventa", fechaDeVenta)
                    command.Parameters.AddWithValue("@puntodeventa", puntoDeVenta)
                    command.Parameters.AddWithValue("@metododepago", metodoDePago)
                    command.Parameters.AddWithValue("@tipofactura", tipoFactura)
                    command.Parameters.AddWithValue("@letra", letra)
                    command.Parameters.AddWithValue("@total", total)

                    ' Ejecutar la consulta y obtener el ID de la nueva cabecera
                    connection.Open()
                    Dim nuevoID As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblID.Text = nuevoID.ToString()

                    ' Actualizar la interfaz de usuario
                    isCabeceraCreada = True
                    txtCuenta.Enabled = False
                    picBuscar.Enabled = False
                    GrillaMovVentas.Enabled = True
                    pnlInferior.Enabled = True
                    btnFin.Enabled = True

                    MessageBox.Show("Cabecera creada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al guardar la cabecera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf lblABM.Text <> "Agregar" Then
            MessageBox.Show("La cabecera no puede ser creada en modo edición.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ObtenerLetraCondicionIVA() As String
        Dim letra As String = "A" ' Valor predeterminado en caso de error

        Try
            ' Obtener la condicion IVA de la empresa
            Dim condicionIvaEmpresa As String = ""
            Dim queryCondicionIvaEmpresa As String = "SELECT CondicionIva FROM Empresa WHERE IdEmpresa = 1" ' Ajusta el IdEmpresa según sea necesario

            Using connection As New SqlConnection(conexionSql.ConnectionString),
                  command As New SqlCommand(queryCondicionIvaEmpresa, connection)
                connection.Open()
                condicionIvaEmpresa = Convert.ToString(command.ExecuteScalar())
            End Using

            ' Obtener la condicion IVA del cliente
            Dim condicionIvaCliente As String = ""
            Dim queryCondicionIvaCliente As String = "SELECT CondicionIVA FROM Clientes WHERE Cuenta = @Cuenta"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
                  command As New SqlCommand(queryCondicionIvaCliente, connection)
                command.Parameters.AddWithValue("@Cuenta", txtCuenta.Text)
                connection.Open()
                condicionIvaCliente = Convert.ToString(command.ExecuteScalar())
            End Using

            ' Determinar la letra según las condiciones IVA
            Select Case condicionIvaCliente
                Case "RI" ' Responsable Inscripto
                    letra = "A"
                Case "RM" ' Responsable Monotributo
                    letra = "B"
                Case "CF" ' Consumidor Final
                    letra = "B"
                Case "EX" ' Exento
                    letra = "C"
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al obtener la letra del comprobante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return letra
    End Function

    Private Function FormatearDecimal(valor As Decimal) As String
        ' Formatear el decimal con separadores de miles y dos decimales
        Dim culture As CultureInfo = New CultureInfo("es-AR") ' Ajusta el código de cultura si es necesario
        Return valor.ToString("N2", culture)
    End Function

    Private Sub txtUnitario_Leave(sender As Object, e As EventArgs) Handles txtUnitario.Leave
        Dim valorDecimal As Decimal
        ' Intenta convertir el texto del campo a Decimal, usa 0 si no es válido
        If Decimal.TryParse(txtUnitario.Text, NumberStyles.Any, New CultureInfo("es-AR"), valorDecimal) Then
            txtUnitario.Text = FormatearDecimal(valorDecimal)
        Else
            txtUnitario.Text = FormatearDecimal(0)
        End If
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        Dim valorDecimal As Decimal
        ' Intenta convertir el texto del campo a Decimal, usa 0 si no es válido
        If Decimal.TryParse(txtCantidad.Text, NumberStyles.Any, New CultureInfo("es-AR"), valorDecimal) Then
            txtCantidad.Text = FormatearDecimal(valorDecimal)
        Else
            txtCantidad.Text = FormatearDecimal(0)
        End If
    End Sub

    Private Sub txtIVAP_Leave(sender As Object, e As EventArgs) Handles txtIVAP.Leave
        Dim valorDecimal As Decimal
        ' Intenta convertir el texto del campo a Decimal, usa 0 si no es válido
        If Decimal.TryParse(txtIVAP.Text, NumberStyles.Any, New CultureInfo("es-AR"), valorDecimal) Then
            txtIVAP.Text = FormatearDecimal(valorDecimal)
        Else
            txtIVAP.Text = FormatearDecimal(0)
        End If
    End Sub

    Private Sub txtDescuento_Leave(sender As Object, e As EventArgs) Handles txtDescuento.Leave
        Dim valorDecimal As Decimal
        ' Intenta convertir el texto del campo a Decimal, usa 0 si no es válido
        If Decimal.TryParse(txtDescuento.Text, NumberStyles.Any, New CultureInfo("es-AR"), valorDecimal) Then
            txtDescuento.Text = FormatearDecimal(valorDecimal)
        Else
            txtDescuento.Text = FormatearDecimal(0)
        End If

        ' Realizar cálculos solo si todos los campos tienen valor
        Dim culture As CultureInfo = New CultureInfo("es-AR")
        Dim unitario As Decimal
        Dim cantidad As Decimal
        Dim descuento As Decimal
        Dim iva As Decimal

        ' Intenta convertir los valores de los campos a Decimal, usa 0 si no es válido
        If Decimal.TryParse(txtUnitario.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture, unitario) AndAlso
       Decimal.TryParse(txtCantidad.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture, cantidad) AndAlso
       Decimal.TryParse(txtDescuento.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture, descuento) AndAlso
       Decimal.TryParse(txtIVAP.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture, iva) Then

            Dim subtotalSinIva As Decimal = unitario * cantidad
            Dim descuentoAplicado As Decimal = subtotalSinIva * (descuento / 100)
            Dim subtotalConDescuento As Decimal = subtotalSinIva - descuentoAplicado

            Dim importeIVA As Decimal = subtotalConDescuento * (iva / 100)
            Dim subtotalConDescuentoConIVA As Decimal = subtotalConDescuento + importeIVA

            ' Formatear el resultado con dos decimales
            txtSubtotalCon.Text = FormatearDecimal(subtotalConDescuentoConIVA)
        Else
            ' Si alguna conversión falla, limpiar el resultado
            txtSubtotalCon.Text = FormatearDecimal(0)
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

        Dim consultassql As String = "SELECT NDM.IDNotasDeVentasMov as ID, NDM.Producto, P.Descripcion, NDM.Cantidad as 'Cant.', NDM.PrecioUnitario as Unitario, NDM.Descuento, NDM.Impuestos, NDM.SubTotal as Subtotal, P.Iva, P.Descripcion FROM NotasDeVentasMov NDM INNER JOIN Productos P ON P.Codigo = NDM.Producto
                                      WHERE NDM.IDNotaDeVenta = " & lblID.Text

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
        Dim columnasOcultar() As Integer = {0, 2, 8, 9}

        For Each columna As Integer In columnasOcultar
            GrillaMovVentas.Columns(columna).Visible = False
        Next

        GrillaMovVentas.Columns(1).FillWeight = 20
        GrillaMovVentas.Columns(3).FillWeight = 10
        GrillaMovVentas.Columns(4).FillWeight = 20
        GrillaMovVentas.Columns(5).FillWeight = 10
        GrillaMovVentas.Columns(6).FillWeight = 15
        GrillaMovVentas.Columns(7).FillWeight = 25


        'COLOCAR QUE SE HAGA .FILL LA GRILLA PARA DELIMITAR EL ESPACIO AL TOTAL DE LA GRILLA

        For i As Integer = 0 To 9
            GrillaMovVentas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next i

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

            Dim puntoVenta As Integer = ModuloPrincipal.boxPV.SelectedIndex + 1

            ' Obtener el valor seleccionado en boxMetodo
            Dim metodoPago As String = DirectCast(boxMetodo.SelectedItem, DataRowView)("Metodo").ToString()

            ' Limpiar el texto de lblTotal.Text eliminando el símbolo de moneda y otros caracteres no numéricos
            Dim cleanedTotalText As String = lblTotal.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "")
            cleanedTotalText = Regex.Replace(cleanedTotalText, "[^\d.,-]", "")

            ' Convertir el texto limpio a Decimal
            Dim total As Decimal
            If Not Decimal.TryParse(cleanedTotalText, NumberStyles.Currency, CultureInfo.CurrentCulture, total) Then
                MessageBox.Show("El valor total no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim id As Integer = Convert.ToInt32(lblID.Text)
            Dim query As String = "UPDATE dbo.NotasDeVentas
                                SET FechaDeVenta = @fechadeventa, PuntoDeVenta = @puntodeventa, MetodoDePago = @metododepago, TipoFactura = @tipofactura, Total = @total
                                WHERE IDNotaDeVenta = " & lblID.Text

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idnotadeventa", lblID.Text)
                command.Parameters.AddWithValue("@fechadeventa", dateTime.Value)
                command.Parameters.AddWithValue("@puntodeventa", "00001") ' Ajusta según sea necesario
                command.Parameters.AddWithValue("@metododepago", metodoPago)
                command.Parameters.AddWithValue("@tipofactura", tipoFactura)
                command.Parameters.AddWithValue("@total", total)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LimpiaMovVentas()

        Me.txtCuenta.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCodprod.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtUnitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIVAP.Text = ""
        Me.txtSubtotalCon.Text = ""

        Me.lblDatos.Text = ""
        Me.lblDni.Text = ""
        Me.lblProvincia.Text = ""
        Me.lblLocalidad.Text = ""
        Me.lblTelefono.Text = ""
        Me.lblDireccion.Text = ""
        Me.lblCondiva.Text = ""
        Me.lblCuit.Text = ""

        lblMov.Text = ""
        Me.lblTotal.Text = "0"

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

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        llenarGrillaMovVentas()
        LimpiaMovVentas()
        Ventas.llenarGrillaVentas()
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        Dim operacion As String = lblABM.Text

        If operacion = "Agregar" Then
            EditarRegistro()
        ElseIf operacion = "Editar" Then
            EditarRegistro()
        End If

        ' Mostrar mensaje de confirmación
        MessageBox.Show("La nota de ventas se cargó correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        llenarGrillaMovVentas()
        Ventas.llenarGrillaVentas()
        LimpiaMovVentas()
    End Sub

    ' Validaciones

    Private Sub txtCodprod_Leave(sender As Object, e As EventArgs) Handles txtCodprod.Leave
        If String.IsNullOrWhiteSpace(txtCodprod.Text) Then
            ' Si txtCuenta está vacío, llama al evento Click de picBuscar manualmente.
            picBuscarProd_Click(picBuscarProd, EventArgs.Empty)
        Else
            BuscarProducto(txtCodprod.Text)
        End If
    End Sub

    Public Sub BuscarProducto(codigoProducto As String)
        Dim consultaSQL As String = "SELECT Descripcion, PrecioUnitario, IVA FROM Productos WHERE Codigo = @Codigo"

        Using connection As New SqlConnection(conexionSql.ConnectionString),
          command As New SqlCommand(consultaSQL, connection)
            command.Parameters.AddWithValue("@Codigo", codigoProducto)

            connection.Open()

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txtDescripcion.Text = reader("Descripcion").ToString()
                    txtUnitario.Text = FormatearDecimal(CDec(reader("PrecioUnitario")))
                    txtIVAP.Text = FormatearDecimal(CDec(reader("IVA")))

                    ' Inicializar los campos txtDescuento y txtCantidad con valores predeterminados
                    txtDescuento.Text = FormatearDecimal(0D) ' Descuento inicial en 0,00
                    txtCantidad.Text = FormatearDecimal(1D) ' Cantidad inicial en 1,00

                    ' Calcular y actualizar txtTotal después de buscar el producto
                    CalcularTotal()
                Else
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDescripcion.Text = ""
                    txtUnitario.Text = ""
                    txtIVAP.Text = ""
                    txtDescuento.Text = ""
                    txtCantidad.Text = ""
                    txtSubtotalCon.Text = ""
                End If
            End Using
        End Using
    End Sub

    Private Sub CalcularTotal()
        If Not String.IsNullOrEmpty(txtUnitario.Text) AndAlso
       Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso
       Not String.IsNullOrEmpty(txtDescuento.Text) AndAlso
       Not String.IsNullOrEmpty(txtIVAP.Text) Then

            Dim culture As CultureInfo = New CultureInfo("es-AR") ' Ajusta el código de cultura si es necesario
            Dim unitario As Decimal = Decimal.Parse(txtUnitario.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture)
            Dim cantidad As Decimal = Decimal.Parse(txtCantidad.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture)
            Dim descuento As Decimal = Decimal.Parse(txtDescuento.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture)
            Dim iva As Decimal = Decimal.Parse(txtIVAP.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, culture)

            Dim subtotalSinIva As Decimal = unitario * cantidad
            Dim descuentoAplicado As Decimal = subtotalSinIva * (descuento / 100)
            Dim subtotalConDescuento As Decimal = subtotalSinIva - descuentoAplicado

            Dim importeIVA As Decimal = subtotalConDescuento * (iva / 100)
            Dim subtotalConDescuentoConIVA As Decimal = subtotalConDescuento + importeIVA

            ' Actualizar el campo txtTotal con el valor calculado
            txtSubtotalCon.Text = FormatearDecimal(subtotalConDescuentoConIVA)
        End If
    End Sub

    Private Sub LimpiarCamposProducto()
        txtDescripcion.Text = ""
        txtUnitario.Text = "0,00"
        txtCantidad.Text = ""
    End Sub

    ' Maneja el clic en picBuscar para abrir el formulario Clientes.
    Private Sub picBuscar_Click(sender As Object, e As EventArgs) Handles picBuscar.Click
        Clientes.lblEdit.Text = "Ventas"
        ModuloPrincipal.AbrirFormEnPanel(Clientes)
    End Sub

    ' Maneja el evento Leave del campo txtCuenta.
    Private Sub txtCuenta_Leave(sender As Object, e As EventArgs) Handles txtCuenta.Leave
        If String.IsNullOrWhiteSpace(txtCuenta.Text) Then
            ' Si txtCuenta está vacío, llama al evento Click de picBuscar manualmente.
            picBuscar_Click(picBuscar, EventArgs.Empty)
        Else
            ' Verifica si lblABM es igual a "AGREGAR"
            If lblABM.Text = "Agregar" Then
                panelProducto.Enabled = True
                Dim resultado As DialogResult = MessageBox.Show("¿Desea crear la cabecera de la nota de venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultado = DialogResult.Yes Then
                    CrearCabeceraNotaDeVenta()
                End If
            Else

            End If
        End If

        ActualizarDatosCliente(txtCuenta.Text)

    End Sub

    Public Sub ActualizarDatosCliente(Cuenta As String)
        Dim consultaSQL As String = "SELECT C.Nombre + ' ' + C.Apellido AS Cliente, C.Direccion, C.CUIT, C.DNI, P.Provincia, L.Localidad, CI.CondicionIva, C.Telefono FROM Clientes C
                                    INNER JOIN Provincias P ON C.Provincia = P.IDProvincia
                                    INNER JOIN Localidades L ON C.Localidad = L.IDLocalidad
                                    INNER JOIN CondicionIVA CI ON C.CondicionIva = CI.Abreviatura
                                    WHERE C.Cuenta = @Cuenta"

        Using connection As New SqlConnection(conexionSql.ConnectionString),
          command As New SqlCommand(consultaSQL, connection)
            command.Parameters.AddWithValue("@Cuenta", Cuenta)

            Try
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Asignar los valores a los lbl
                        lblDatos.Text = reader("Cliente").ToString()
                        lblDireccion.Text = reader("Direccion").ToString()
                        lblCuit.Text = reader("CUIT").ToString()
                        lblDni.Text = reader("DNI").ToString()
                        lblProvincia.Text = reader("Provincia").ToString()
                        lblLocalidad.Text = reader("Localidad").ToString()
                        lblCondiva.Text = reader("CondicionIva").ToString()
                        lblTelefono.Text = reader("Telefono").ToString()

                        lblDatos.Visible = True
                        lblDireccion.Visible = True
                        lblCuit.Visible = True
                        lblDni.Visible = True
                        lblProvincia.Visible = True
                        lblLocalidad.Visible = True
                        lblCondiva.Visible = True
                        lblTelefono.Visible = True

                    Else

                        ' Si no se encuentra el cliente, limpiar los lbl
                        lblDatos.Text = ""
                        lblDireccion.Text = ""
                        lblCuit.Text = ""
                        lblDni.Text = ""
                        lblProvincia.Text = ""
                        lblLocalidad.Text = ""
                        lblCondiva.Text = ""
                        lblTelefono.Text = ""

                        lblDatos.Visible = False
                        lblDireccion.Visible = False
                        lblCuit.Visible = False
                        lblDni.Visible = False
                        lblProvincia.Visible = False
                        lblLocalidad.Visible = False
                        lblCondiva.Visible = False
                        lblTelefono.Visible = False

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub picBuscarProd_Click(sender As Object, e As EventArgs) Handles picBuscarProd.Click
        Productos.lblEdit.Text = "Ventas"
        ModuloPrincipal.AbrirFormEnPanel(Productos)
    End Sub
End Class