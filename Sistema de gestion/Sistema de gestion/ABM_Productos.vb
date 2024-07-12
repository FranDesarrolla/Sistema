Imports System.Data.SqlClient
Imports System.Transactions

Public Class ABM_Productos

    Public Sub LimpiarFormularioABMProducto()

        ' Limpiar los campos de texto
        Me.id_producto.Text = ""
        Me.codProducto.Text = ""
        Me.descripProducto.Text = ""
        Me.especifiProducto.Text = ""
        Me.UnidadProducto.Text = ""
        Me.RubroProducto.Text = ""
        Me.CategoriaProducto.Text = ""
        Me.StockProducto.Text = ""
        Me.PrecioUnitarioProducto.Text = ""
        Me.txtIvaProducto.Text = ""

        ' Limpiar el PictureBox
        Me.picProducto.Image = Nothing

    End Sub

    Private Sub btnAceptarABMP_Click(sender As Object, e As EventArgs) Handles btnAceptarABMP.Click
        If lblSeñalProducto.Text = "AGREGAR" Then ' Verifica si la etiqueta es "AGREGAR"
            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    Dim precioFormateado As Decimal = Decimal.Parse(PrecioUnitarioProducto.Text)
                    Dim ivaFormateado As Decimal = Decimal.Parse(txtIvaProducto.Text)
                    Dim stockFormateado As Decimal = Decimal.Parse(StockProducto.Text)

                    Using command As New SqlCommand("INSERT INTO dbo.Productos (Codigo, Descripcion, Especificaciones, Unidad, Rubro, Categoria, Stock, PrecioUnitario, Iva) 
                                              VALUES (@Codigo, @Descripcion, @Especificaciones, @Unidad, @Rubro, @Categoria, @Stock, @PrecioUnitario, @Iva); SELECT SCOPE_IDENTITY()", connection)
                        command.Parameters.AddWithValue("@Codigo", codProducto.Text)
                        command.Parameters.AddWithValue("@Descripcion", descripProducto.Text)
                        command.Parameters.AddWithValue("@Especificaciones", especifiProducto.Text)
                        command.Parameters.AddWithValue("@Unidad", UnidadProducto.Text)
                        command.Parameters.AddWithValue("@Rubro", RubroProducto.Text)
                        command.Parameters.AddWithValue("@Categoria", CategoriaProducto.Text)
                        command.Parameters.AddWithValue("@Stock", stockFormateado)
                        command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                        command.Parameters.AddWithValue("@Iva", ivaFormateado)

                        ' Ejecuta la consulta de inserción y obtiene el ID del producto insertado
                        Dim idProducto As Integer = Convert.ToInt32(command.ExecuteScalar())

                        ' Si hay una imagen en el PictureBox, la inserta en la tabla ProductosImagenes
                        If picProducto.Image IsNot Nothing Then
                            Dim imageStream As New IO.MemoryStream()
                            picProducto.Image.Save(imageStream, picProducto.Image.RawFormat)
                            Dim imageData As Byte() = imageStream.ToArray()

                            Using imgCommand As New SqlCommand("INSERT INTO dbo.ProductosImagenes (IDProducto, Imagen) VALUES (@IDProducto, @Imagen)", connection)
                                imgCommand.Parameters.AddWithValue("@IDProducto", idProducto)
                                imgCommand.Parameters.AddWithValue("@Imagen", imageData)
                                imgCommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using

                ' Muestra un mensaje de éxito
                MsgBox("Datos Guardados", vbOKOnly + vbInformation)
                Productos.llenarGrillaProductos()
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox(ex.ToString)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Productos)

        ElseIf lblSeñalProducto.Text = "EDITAR" Then
            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    Dim precioFormateado As Decimal = Decimal.Parse(PrecioUnitarioProducto.Text)
                    Dim ivaFormateado As Decimal = Decimal.Parse(txtIvaProducto.Text)
                    Dim stockFormateado As Decimal = Decimal.Parse(StockProducto.Text)

                    Using command As New SqlCommand("UPDATE dbo.Productos
                                             SET Codigo = @Codigo, Descripcion = @Descripcion, Especificaciones = @Especificaciones, Unidad = @Unidad, Rubro = @Rubro, Categoria = @Categoria, Stock = @Stock, PrecioUnitario = @PrecioUnitario, Iva = @Iva
                                             WHERE IDProducto = @IDProducto", connection)
                        command.Parameters.AddWithValue("@Codigo", codProducto.Text)
                        command.Parameters.AddWithValue("@Descripcion", descripProducto.Text)
                        command.Parameters.AddWithValue("@Especificaciones", especifiProducto.Text)
                        command.Parameters.AddWithValue("@Unidad", UnidadProducto.Text)
                        command.Parameters.AddWithValue("@Rubro", RubroProducto.Text)
                        command.Parameters.AddWithValue("@Categoria", CategoriaProducto.Text)
                        command.Parameters.AddWithValue("@Stock", stockFormateado)
                        command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                        command.Parameters.AddWithValue("@Iva", ivaFormateado)
                        command.Parameters.AddWithValue("@IDProducto", Val(id_producto.Text))

                        command.ExecuteNonQuery()

                        ' Si hay una imagen en el PictureBox, la actualiza en la tabla ProductosImagenes
                        If picProducto.Image IsNot Nothing Then
                            Dim imageStream As New IO.MemoryStream()
                            picProducto.Image.Save(imageStream, picProducto.Image.RawFormat)
                            Dim imageData As Byte() = imageStream.ToArray()

                            Using imgCommand As New SqlCommand("IF EXISTS (SELECT 1 FROM dbo.ProductosImagenes WHERE IDProducto = @IDProducto)
                                                       UPDATE dbo.ProductosImagenes SET Imagen = @Imagen WHERE IDProducto = @IDProducto
                                                       ELSE
                                                       INSERT INTO dbo.ProductosImagenes (IDProducto, Imagen) VALUES (@IDProducto, @Imagen)", connection)
                                imgCommand.Parameters.AddWithValue("@IDProducto", Val(id_producto.Text))
                                imgCommand.Parameters.AddWithValue("@Imagen", imageData)
                                imgCommand.ExecuteNonQuery()
                            End Using
                        Else
                            ' Si no hay imagen en el PictureBox, elimina la imagen de la base de datos
                            Using deleteImgCommand As New SqlCommand("DELETE FROM dbo.ProductosImagenes WHERE IDProducto = @IDProducto", connection)
                                deleteImgCommand.Parameters.AddWithValue("@IDProducto", Val(id_producto.Text))
                                deleteImgCommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using

                ' Cierra la conexión después de ejecutar la consulta
                MsgBox("Datos Guardados", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Productos.llenarGrillaProductos()
            ModuloPrincipal.AbrirFormEnPanel(Productos)
        End If
    End Sub


    Private Sub btnVolverABMP_Click(sender As Object, e As EventArgs) Handles btnVolverABMP.Click
        ModuloPrincipal.AbrirFormEnPanel(Productos)
        LimpiarFormularioABMProducto()
        ' Cierra la conexión después de ejecutar la consulta
    End Sub

    Private Sub btnCargaImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picProducto.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        picProducto.Image = Nothing
    End Sub
End Class