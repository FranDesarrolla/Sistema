Public Class ABM_Productos
    Private Sub ABM_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub LimpiarFormularioABMProducto()

        ' Limpiar los campos de texto
        Me.id_producto.Text = ""  ' Suponemos que se quiere limpiar el campo
        Me.codProducto.Text = ""
        Me.descripProducto.Text = ""
        Me.especifiProducto.Text = ""
        Me.UnidadProducto.Text = ""
        Me.RubroProducto.Text = ""
        Me.CategoriaProducto.Text = ""
        Me.StockProducto.Text = ""
        Me.PrecioUnitarioProducto.Text = ""
        Me.txtIvaProducto.Text = ""

        ' Desactivar el botón "Guardar" (si existe)
        'If Not btnAceptarABMP Is Nothing Then
        'btnAceptarABMP.Enabled = False
        'End If


    End Sub

    Private Sub btnAceptarABMP_Click_1(sender As Object, e As EventArgs) Handles btnAceptarABMP.Click
        'Para agregar datos
        If lblSeñalProducto.Text = "AGREGAR" Then ' Verifica si la etiqueta es "AGREGAR"

            Try
                ' Establece la conexión y configura la consulta de inserción
                Dim precioFormateado = PrecioUnitarioProducto.Text.Replace(",", ".") ' Reemplazar la coma por punto

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO dbo.Productos (Codigo, Descripcion, Especificaciones, Unidad, Rubro, Categoria, Stock, PrecioUnitario,Iva) 
                        VALUES ('" & codProducto.Text & "', '" & descripProducto.Text & "', '" & especifiProducto.Text & "', '" & UnidadProducto.Text & "', '" & RubroProducto.Text & "', '" & CategoriaProducto.Text & "', '" & StockProducto.Text & "', '" & precioFormateado & "','" & txtIvaProducto.Text & "')"

                ' Ejecuta la consulta de inserción
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                conexionSql.Close()

                ' Muestra un mensaje de éxito
                MsgBox("Datos Guardados", +vbOKOnly + vbInformation)
                Productos.llenarGrillaProductos()
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox(ex.ToString)
            End Try

            ' Abre el formulario "Productos" en un panel dentro del formulario principal
            ModuloPrincipal.AbrirFormEnPanel(Productos)

        ElseIf lblSeñalProducto.Text = "EDITAR" Then
            Try
                Dim precioFormateado = PrecioUnitarioProducto.Text.Replace(",", ".") ' Reemplazar la coma por punto

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE dbo.Productos
                                        SET	Codigo = '" & codProducto.Text & "',
	                                        Descripcion = '" & descripProducto.Text & "',
	                                        Especificaciones = '" & especifiProducto.Text & "',
	                                        Unidad = '" & UnidadProducto.Text & "',
	                                        Rubro = '" & RubroProducto.Text & "',
	                                        Categoria = '" & CategoriaProducto.Text & "',
	                                        Stock = '" & StockProducto.Text & "',
	                                        PrecioUnitario = '" & precioFormateado & "',
                                            Iva = '" & txtIvaProducto.Text & "'
                                            WHERE IDProducto = " & Val(id_producto.Text) & ""
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                MsgBox("Datos Guardados", +vbOKOnly + vbInformation)


            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            ' Abre el formulario "Productos" en un panel dentro del formulario principal

            Productos.llenarGrillaProductos()
            ModuloPrincipal.AbrirFormEnPanel(Productos)

        End If
    End Sub

    Private Sub btnVolverABMP_Click(sender As Object, e As EventArgs) Handles btnVolverABMP.Click
        ModuloPrincipal.AbrirFormEnPanel(Productos)
        LimpiarFormularioABMProducto()
        ' Cierra la conexión después de ejecutar la consulta
    End Sub
End Class