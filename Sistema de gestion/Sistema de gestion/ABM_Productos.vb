﻿Imports System.Data.SqlClient
Imports System.IO
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
                            Dim imageStream As New MemoryStream()
                            picProducto.Image.Save(imageStream, Imaging.ImageFormat.Png)
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
                MsgBox("Error al agregar el producto: " & ex.Message)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Productos)

        ElseIf lblSeñalProducto.Text = "EDITAR" Then
            Try
                If String.IsNullOrWhiteSpace(id_producto.Text) Then
                    Throw New Exception("ID del producto no puede estar vacío.")
                End If

                Dim idProducto As Integer = Val(id_producto.Text)

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
                        command.Parameters.AddWithValue("@IDProducto", idProducto)

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Verifica si el producto existe antes de actualizar la imagen
                        If rowsAffected = 0 Then
                            Throw New Exception("El producto con el ID especificado no existe.")
                        End If

                        ' Si hay una imagen en el PictureBox, actualiza o inserta la nueva imagen
                        If picProducto.Image IsNot Nothing Then
                            ' Elimina la imagen existente si la hay
                            Using delImgCommand As New SqlCommand("DELETE FROM dbo.ProductosImagenes WHERE IDProducto = @IDProducto", connection)
                                delImgCommand.Parameters.AddWithValue("@IDProducto", idProducto)
                                delImgCommand.ExecuteNonQuery()
                            End Using

                            ' Inserta la nueva imagen
                            Dim imageStream As New MemoryStream()
                            picProducto.Image.Save(imageStream, Imaging.ImageFormat.Png)
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
                MsgBox("Error al editar el producto: " & ex.Message)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Productos)
        End If
    End Sub

    Private Sub btnVolverABMP_Click(sender As Object, e As EventArgs) Handles btnVolverABMP.Click
        ModuloPrincipal.AbrirFormEnPanel(Productos)
        LimpiarFormularioABMProducto()
    End Sub

    Private Sub btnCargaImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
            openFileDialog.Title = "Seleccionar imagen del producto"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Cargar la imagen seleccionada en el PictureBox
                Dim selectedImagePath As String = openFileDialog.FileName
                Using originalImage As Image = Image.FromFile(selectedImagePath)
                    picProducto.Image = New Bitmap(originalImage)
                End Using
            End If
        End Using
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        If Not String.IsNullOrWhiteSpace(id_producto.Text) Then
            Dim idProducto As Integer = Val(id_producto.Text)

            ' Limpiar la imagen del PictureBox
            picProducto.Image = Nothing

            ' Eliminar la imagen de la base de datos si existe
            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    Using command As New SqlCommand("DELETE FROM dbo.ProductosImagenes WHERE IDProducto = @IDProducto", connection)
                        command.Parameters.AddWithValue("@IDProducto", idProducto)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Imagen eliminada", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox("Error al eliminar la imagen: " & ex.Message)
            End Try
        Else
            MsgBox("El ID del producto está vacío. No se puede eliminar la imagen.", vbOKOnly + vbExclamation)
        End If
    End Sub

End Class