Public Class ABM_Productos
    Private Sub ABM_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSistema.conexionSql.Open()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ModuloPrincipal.AbrirFormEnPanel(Productos)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub btnAceptarABMP_Click(sender As Object, e As EventArgs) Handles btnAceptarABMP.Click



        'Para agregar datos
        If lblSeñalProducto.Text = "AGREGAR" Then ' Verifica si la etiqueta es "AGREGAR"

            Try
                ' Establece la conexión y configura la consulta de inserción
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO dbo.Productos (Codigo, Descripcion, Especificaciones, Unidad, Rubro, Categoria, Stock, PrecioUnitario) 
                                        VALUES ('" & codProducto.Text & "', '" & descripProducto.Text & "', '" & especifiProducto.Text & "', '" & UnidadProducto.Text & "', '" & RubroProducto.Text & "', '" & CategoriaProducto.Text & "', '" & StockProducto.Text & "', '" & PrecioUnitarioProducto.Text & "')"

                ' Ejecuta la consulta de inserción
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                'ModuloSistema.conexionSql.Close()

                ' Muestra un mensaje de éxito
                MsgBox("Datos Guardados")
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox(ex.ToString)
            End Try


            ' Abre el formulario "Productos" en un panel dentro del formulario principal
            ModuloPrincipal.AbrirFormEnPanel(Productos)
        End If


        'PARA MODIFICAR LOS DATOS
        If lblSeñalProducto.Text = "MODIFICAR" Then
            Try
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
	                                        PrecioUnitario = '" & PrecioUnitarioProducto.Text & "'
                                            WHERE IDProducto = " & Val(id_producto.Text) & ""
                acciones.ExecuteNonQuery()

                ' Cierra la conexión después de ejecutar la consulta
                'ModuloSistema.conexionSql.Open()
                MsgBox("DATOS GUARDADOS")

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            ' Abre el formulario "Productos" en un panel dentro del formulario principal
            ModuloPrincipal.AbrirFormEnPanel(Productos)
        End If
        'PARA REFRESCAR LA GRILLA



    End Sub
End Class