Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Public Class ABM_Pedidos
    Private cambiosRealizados As New List(Of Cambio)

    Private Class Cambio
        Public TipoOperacion As String
        Public DatosAntes As String()
    End Class

    Private Sub ABM_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaMovPedidos()
        llenarGrillaMovPedidos()
        LlenarComboBoxProductos()
        LlenarComboBoxMetodos()
        'ConfigurarComboBoxComprobante()
        lblTotal.Left = lblTitotal.Right
    End Sub

    'Private Sub ConfigurarComboBoxComprobante()
    'boxComprobante.Items.AddRange({"Factura", "Nota de Crédito", "Nota de Débito"})
    'boxComprobante.SelectedItem = "Factura"
    'End Sub


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
            txtSubtotalSin.Text = String.Format("{0:0.00}", subtotalConDescuento)
            txtIVA.Text = String.Format("{0:0.00}", importeIVA)
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

        For Each fila As DataGridViewRow In GrillaMovPedidos.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("Subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If
        Next

        lblTotal.Text = "$" & total.ToString()
    End Sub

    Private Sub GrillaMovPedidos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GrillaMovPedidos.RowsAdded
        SumarSubtotalesYActualizarTotal()
    End Sub



    Public Sub llenarGrillaMovPedidos()
        LimpiarGrilla()


        Dim consultassql As String = "SELECT PDM.IDPedido as ID, PDM.Producto AS 'Producto', P.Descripcion, PDM.Cantidad as 'Cant.', PDM.PrecioUnitario as Unitario, PDM.Descuento, PDM.Impuestos, PDM.SubTotal as Subtotal, P.Iva, P.Descripcion 
                                      FROM PedidosMov PDM 
                                      INNER JOIN Productos P ON P.Codigo = PDM.Producto WHERE PDM.IDPedido = " & lblID.Text

        Dim adaptadorSql As New SqlDataAdapter(consultassql, conexionSql)
        adaptadorSql.Fill(setdedatos, "dtmovpedidos")
        GrillaMovPedidos.DataSource = setdedatos.Tables("dtmovpedidos")

        ConfigurarColumnasGrilla()
        ActivarBotones()
    End Sub

    Private Sub LimpiarGrilla()
        If setdedatos.Tables.Contains("dtmovpedidos") Then
            setdedatos.Tables("dtmovpedidos").Rows.Clear()
        End If
    End Sub

    Private Sub ConfigurarColumnasGrilla()
        Dim columnasOcultar() As Integer = {0, 8, 9}

        For Each columna As Integer In columnasOcultar
            GrillaMovPedidos.Columns(columna).Visible = False
        Next

        Dim columnasFillWeight() As Integer = {1, 2, 3, 4, 5, 6, 7}

        For Each columna As Integer In columnasFillWeight
            GrillaMovPedidos.Columns(columna).FillWeight = 12
            GrillaMovPedidos.Columns(columna).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Public Sub ActivarBotones()
        Dim enableButtons As Boolean = (GrillaMovPedidos.Rows.Count > 0)

        btnEditar.Enabled = enableButtons
        btnEliminar.Enabled = enableButtons
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As Integer = MessageBox.Show("¿Está seguro de eliminar este registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Try
                Dim id As Integer = Convert.ToInt32(GrillaMovPedidos.CurrentRow.Cells(0).Value)
                Dim query As String = "DELETE FROM PedidosMov WHERE IDPedido = @ID"
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

            llenarGrillaMovPedidos()
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
            Dim ivaFormateado As Decimal = Decimal.Parse(txtIVA.Text)
            Dim subconFormateado As Decimal = Decimal.Parse(txtSubtotalCon.Text)

            Dim id As Integer = Convert.ToInt32(GrillaMovPedidos.CurrentRow.Cells(0).Value)
            Dim query As String = "UPDATE dbo.PedidosMov
                                SET CodigoProducto = @Producto, 
                                    Cantidad = @Cantidad,
                                    PrecioUnitario = @PrecioUnitario,
                                    Descuento = @Descuento,
                                    Impuestos = @Impuestos,
                                    SubTotal = @SubTotal
                                WHERE IDPedido = @ID"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Producto", txtCodigo.Text)
                command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txtCantidad.Text))
                command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                command.Parameters.AddWithValue("@Descuento", descFormateado)
                command.Parameters.AddWithValue("@Impuestos", ivaFormateado)
                command.Parameters.AddWithValue("@SubTotal", subconFormateado)
                command.Parameters.AddWithValue("@ID", id)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiaMovPedidos()
            MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenarGrillaMovPedidos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarMovimiento()
        Try
            Dim precioFormateado As Decimal = Decimal.Parse(txtUnitario.Text)
            Dim descFormateado As Decimal = Decimal.Parse(txtDescuento.Text)
            Dim ivaFormateado As Decimal = Decimal.Parse(txtIVA.Text)
            Dim subconFormateado As Decimal = Decimal.Parse(txtSubtotalCon.Text)

            Dim query As String = "INSERT INTO dbo.PedidosMov (IDPedido, Producto, Cantidad, PrecioUnitario, Descuento, Impuestos, SubTotal)
                                   VALUES (@idpedido, @producto, @cantidad, @preciounitario, @descuento, @impuestos, @subtotal)"

            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDPedido", lblID.Text)
                command.Parameters.AddWithValue("@Producto", txtCodigo.Text)
                command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txtCantidad.Text))
                command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                command.Parameters.AddWithValue("@Descuento", descFormateado)
                command.Parameters.AddWithValue("@Impuestos", ivaFormateado)
                command.Parameters.AddWithValue("@SubTotal", subconFormateado)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiaMovPedidos()
            MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenarGrillaMovPedidos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditarRegistro()
        Try
            ' Obtain the selected value in boxMetodo
            Dim metodoPago As String = DirectCast(boxMetodo.SelectedItem, DataRowView)("Estado").ToString()
            Dim id As Integer = Convert.ToInt32(lblID.Text)
            Dim query As String = "UPDATE dbo.PedidosMov
                            SET IDPedido = @idpedido,
                                Cliente = @cliente,
                                Empleado = @empleado,
                                FechaPedido = @FechaPedido,
                                PuntoDeVenta = @puntodeventa,
                                MetodoDePago = @metododepago
                            WHERE IDDetalle = @ID"
            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cliente", txtCuenta.Text)
                command.Parameters.AddWithValue("@empleado", txtQuien.Text)
                command.Parameters.AddWithValue("@FechaPedido", dateTime.Value)
                command.Parameters.AddWithValue("@puntodeventa", txtSucursal.Text)
                command.Parameters.AddWithValue("@metododepago", metodoPago)
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
            Dim estadopedido As String = DirectCast(boxMetodo.SelectedItem, DataRowView)("estado").ToString()

            Dim query As String = "INSERT INTO dbo.Pedidos (Cliente, Empleado, FechaPedido, EstadoPedido, PuntoDeVenta, NroPedido)
                                   VALUES (@cliente, @empleado, @fechapedido, @estadopedido, @puntodeventa, @nropedido);
;                                  SELECT SCOPE_IDENTITY();"


            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cliente", txtCuenta.Text)
                command.Parameters.AddWithValue("@empleado", txtQuien.Text)
                command.Parameters.AddWithValue("@fechapedido", dateTime.Value)
                command.Parameters.AddWithValue("@puntodeventa", txtSucursal.Text)
                command.Parameters.AddWithValue("@nropedido", txtNroPedido.Text)
                command.Parameters.AddWithValue("@estadopedido", estadopedido)
                'command.Parameters.AddWithValue("@letra", lblLetra.Text)
                'command.Parameters.AddWithValue("@tipofactura", tipoFactura)
                'command.Parameters.AddWithValue("@total", lblTotal.Text)
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


    Public Sub LimpiaMovPedidos()
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

    Private Function ObtenerDatosAntesDeOperacion() As String()
        Return {txtCodigo.Text, boxProductos.Text, txtCantidad.Text, txtUnitario.Text, txtDescuento.Text, txtIVAP.Text, txtIVA.Text, txtSubtotalSin.Text, txtSubtotalCon.Text}
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        CargarDatosParaEditar()
    End Sub

    Private Sub CargarDatosParaEditar()
        Me.txtCodigo.Text = GrillaMovPedidos.CurrentRow.Cells(1).Value
        Me.boxProductos.Text = GrillaMovPedidos.CurrentRow.Cells(9).Value
        Me.txtCantidad.Text = GrillaMovPedidos.CurrentRow.Cells(3).Value
        Me.txtUnitario.Text = GrillaMovPedidos.CurrentRow.Cells(4).Value
        Me.txtDescuento.Text = GrillaMovPedidos.CurrentRow.Cells(5).Value
        Me.txtIVAP.Text = GrillaMovPedidos.CurrentRow.Cells(8).Value
        Me.txtIVA.Text = GrillaMovPedidos.CurrentRow.Cells(6).Value
        Me.txtSubtotalSin.Text = GrillaMovPedidos.CurrentRow.Cells(3).Value
        Me.txtSubtotalCon.Text = GrillaMovPedidos.CurrentRow.Cells(7).Value

        lblMov.Text = "Editar"
        btnAgregar.Text = "Aceptar"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaMovPedidos()
    End Sub

    Public Sub LlenarComboBoxProductos()
        Dim query As String = "SELECT Codigo, Descripcion, PrecioUnitario, IVA FROM Productos"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim dtProductos As New DataTable
        adaptadorSql.Fill(dtProductos)
        boxProductos.DataSource = dtProductos
        boxProductos.DisplayMember = "Descripcion"
        boxProductos.ValueMember = "Codigo"
    End Sub

    Public Sub LlenarComboBoxMetodos()
        Dim query As String = "SELECT IDEstadoPedido, Estado FROM EstadoPedidos"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim dtEstados As New DataTable
        adaptadorSql.Fill(dtEstados)
        boxMetodo.DataSource = dtEstados
        boxMetodo.DisplayMember = "Estado"
        boxMetodo.ValueMember = "IDEstadoPedido"
    End Sub


    Private Sub boxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxProductos.SelectedIndexChanged
        Dim filaSeleccionada As DataRowView = DirectCast(boxProductos.SelectedItem, DataRowView)

        If filaSeleccionada IsNot Nothing AndAlso filaSeleccionada.Row IsNot Nothing Then
            txtCodigo.Text = filaSeleccionada.Row("Codigo").ToString()
            txtUnitario.Text = filaSeleccionada.Row("PrecioUnitario").ToString()
            txtIVAP.Text = filaSeleccionada.Row("IVA").ToString()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModuloPrincipal.AbrirFormEnPanel(Pedidos)
        llenarGrillaMovPedidos()
        LimpiaMovPedidos()
    End Sub

    Private Sub btnCabecera_Click(sender As Object, e As EventArgs) Handles btnCabecera.Click
        If lblSeñalPedido.Text = "Agregar" Then
            AgregarRegistro()
            btnCabecera.Text = "Actualizar Cabecera"
            lblSeñalPedido.Text = "Editar"
            btnFin.Enabled = True

            'Activar paneles
            panelProducto.Enabled = True
            panelAdd.Enabled = True
            GrillaMovPedidos.Enabled = True

        Else
            EditarRegistro()
        End If
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        EditarRegistro()
        ModuloPrincipal.AbrirFormEnPanel(Pedidos)
        llenarGrillaMovPedidos()
        LimpiaMovPedidos()
    End Sub


End Class