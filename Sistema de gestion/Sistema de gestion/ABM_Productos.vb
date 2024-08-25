Imports System.Data.SqlClient
Imports System.IO

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
        Me.lblCategoria.Text = ""
        Me.lblRubro.Text = ""
        Me.lblUnidad.Text = ""

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

                    ' Determinar el estado del producto según el estado del CheckBox
                    Dim estado As String = If(CB_Activo.Checked, "A", "I")

                    Using command As New SqlCommand("INSERT INTO dbo.Productos (Codigo, Descripcion, Especificaciones, Unidad, Rubro, Categoria, Stock, PrecioUnitario, Iva, Estado) 
                                  VALUES (@Codigo, @Descripcion, @Especificaciones, @Unidad, @Rubro, @Categoria, @Stock, @PrecioUnitario, @Iva, @Estado); SELECT SCOPE_IDENTITY()", connection)
                        command.Parameters.AddWithValue("@Codigo", codProducto.Text)
                        command.Parameters.AddWithValue("@Descripcion", descripProducto.Text)
                        command.Parameters.AddWithValue("@Especificaciones", especifiProducto.Text)
                        command.Parameters.AddWithValue("@Unidad", UnidadProducto.Text)
                        command.Parameters.AddWithValue("@Rubro", RubroProducto.Text)
                        command.Parameters.AddWithValue("@Categoria", CategoriaProducto.Text)
                        command.Parameters.AddWithValue("@Stock", stockFormateado)
                        command.Parameters.AddWithValue("@PrecioUnitario", precioFormateado)
                        command.Parameters.AddWithValue("@Iva", ivaFormateado)
                        command.Parameters.AddWithValue("@Estado", estado)

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
                MsgBox("Producto creado con éxito", vbOKOnly + vbInformation, "Gesnet")
                Productos.llenarGrillaProductos()
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox("Error al agregar el producto: " & ex.Message)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Productos)
            LimpiarFormularioABMProducto()

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

                    ' Determinar el estado del producto según el estado del CheckBox
                    Dim estado As String = If(CB_Activo.Checked, "A", "I")

                    Using command As New SqlCommand("UPDATE dbo.Productos
                                     SET Codigo = @Codigo, Descripcion = @Descripcion, Especificaciones = @Especificaciones, Unidad = @Unidad, Rubro = @Rubro,
                                     Categoria = @Categoria, Stock = @Stock, PrecioUnitario = @PrecioUnitario, Iva = @Iva, Estado = @Estado
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
                        command.Parameters.AddWithValue("@Estado", estado)
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
                MsgBox("Producto modificado con éxito", vbOKOnly + vbInformation, "Gesnet")
                Productos.llenarGrillaProductos()
            Catch ex As Exception
                ' Muestra un mensaje de error en caso de excepción
                MsgBox("Error al editar el producto: " & ex.Message)
            End Try

            ModuloPrincipal.AbrirFormEnPanel(Productos)
            LimpiarFormularioABMProducto()
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

    Private Sub RubroProducto_Leave(sender As Object, e As EventArgs) Handles RubroProducto.Leave
        ' Verificar si el campo de RubroProducto no está vacío
        If Not String.IsNullOrWhiteSpace(RubroProducto.Text) Then
            ' Verificar si el rubro ingresado existe en la base de datos
            Dim rubro As String = RubroProducto.Text.Trim()

            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    ' Consulta para verificar la existencia del rubro y obtener la descripción
                    Dim consultaSQL As String = "SELECT Descripcion FROM Rubros WHERE Rubro = @Rubro"

                    Using command As New SqlCommand(consultaSQL, connection)
                        command.Parameters.AddWithValue("@Rubro", rubro)

                        ' Ejecutar la consulta y obtener la descripción
                        Dim descripcionRubro As Object = command.ExecuteScalar()

                        If descripcionRubro IsNot Nothing Then
                            ' Actualizar lblRubro con la descripción del rubro
                            lblRubro.Text = descripcionRubro.ToString()
                        Else
                            ' Mostrar mensaje si el rubro no existe y evitar que el usuario salga del campo
                            MsgBox("El rubro ingresado no existe. Por favor, ingrese un rubro válido.", vbOKOnly + vbExclamation)
                            RubroProducto.Focus() ' Volver a enfocar el campo RubroProducto
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al verificar el rubro: " & ex.Message, vbOKOnly + vbExclamation)
            End Try
        Else
            MessageBox.Show("El campo rubro no puede estar vacío.")
            RubroProducto.Focus()
        End If
    End Sub

    ' VALIDACIONES POR CAMPO

    Private Sub CategoriaProducto_Leave(sender As Object, e As EventArgs) Handles CategoriaProducto.Leave
        ' Verificar si el campo de categoriaProducto no está vacío
        If Not String.IsNullOrWhiteSpace(CategoriaProducto.Text) Then
            ' Verificar si el Categoria ingresado existe en la base de datos
            Dim categoria As String = CategoriaProducto.Text.Trim()

            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    ' Consulta para verificar la existencia del categoria y obtener la descripción
                    Dim consultaSQL As String = "SELECT Descripcion FROM Categorias WHERE Categoria = @Categoria"

                    Using command As New SqlCommand(consultaSQL, connection)
                        command.Parameters.AddWithValue("@Categoria", categoria)

                        ' Ejecutar la consulta y obtener la descripción
                        Dim descripcionCategoria As Object = command.ExecuteScalar()

                        If descripcionCategoria IsNot Nothing Then
                            ' Actualizar lblcategoria con la descripción del Categoria
                            lblCategoria.Text = descripcionCategoria.ToString()
                        Else
                            ' Mostrar mensaje si el categoria no existe y evitar que el usuario salga del campo
                            MsgBox("La categoria ingresado no existe. Por favor, ingrese una categoria válida.", vbOKOnly + vbExclamation)
                            CategoriaProducto.Focus() ' Volver a enfocar el campo CategoriaProducto
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al verificar la categoria: " & ex.Message, vbOKOnly + vbExclamation)
            End Try
        Else
            MessageBox.Show("El campo categoria no puede estar vacío.")
            CategoriaProducto.Focus()
        End If
    End Sub

    Private Sub UnidadProducto_Leave(sender As Object, e As EventArgs) Handles UnidadProducto.Leave
        ' Verificar si el campo de UnidadProducto no está vacío
        If Not String.IsNullOrWhiteSpace(UnidadProducto.Text) Then
            ' Verificar si el Unidad ingresado existe en la base de datos
            Dim Unidad As String = UnidadProducto.Text.Trim()

            Try
                Using connection As New SqlConnection(conexionSql.ConnectionString)
                    connection.Open()

                    ' Consulta para verificar la existencia del Unidad y obtener la descripción
                    Dim consultaSQL As String = "SELECT Descripcion FROM Unidades WHERE Unidad = @Unidad"

                    Using command As New SqlCommand(consultaSQL, connection)
                        command.Parameters.AddWithValue("@Unidad", Unidad)

                        ' Ejecutar la consulta y obtener la descripción
                        Dim descripcionUnidad As Object = command.ExecuteScalar()

                        If descripcionUnidad IsNot Nothing Then
                            ' Convertir el texto de UnidadProducto a mayúsculas
                            UnidadProducto.Text = Unidad.ToUpper()

                            ' Actualizar lblUnidad con la descripción del Unidad
                            lblUnidad.Text = descripcionUnidad.ToString()
                        Else
                            ' Mostrar mensaje si el Unidad no existe y evitar que el usuario salga del campo
                            MsgBox("La Unidad ingresada no existe. Por favor, ingrese una Unidad válida.", vbOKOnly + vbExclamation, "Gesnet")
                            UnidadProducto.Focus() ' Volver a enfocar el campo UnidadProducto
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al verificar la Unidad: " & ex.Message, vbOKOnly + vbExclamation, "Gesnet")
            End Try
        Else
            MessageBox.Show("El campo unidad no puede ser vacío.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UnidadProducto.Focus()
        End If
    End Sub

    ' Función para ver si contiene caracteres especiales
    Private Function ContieneCaracteresEspeciales(texto As String) As Boolean

        Dim caracteresEspeciales As String = "#%$&=()<>[]{}!@^*~`+|\\;:'"",?/\\"

        For Each ch As Char In texto
            If caracteresEspeciales.Contains(ch) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub codProducto_Leave(sender As Object, e As EventArgs) Handles codProducto.Leave

        If String.IsNullOrWhiteSpace(codProducto.Text) Then
            MessageBox.Show("El campo código no puede estar vacío.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            codProducto.Focus()
            Return
        End If

        If ContieneCaracteresEspeciales(codProducto.Text) Then
            MessageBox.Show("El campo código no puede contener caracteres especiales.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            codProducto.Focus()
            Return
        End If

        Dim codigo As String = codProducto.Text.Trim()

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                Dim consultaSQL As String = "SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo"

                Using command As New SqlCommand(consultaSQL, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)

                    Dim conteo As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If conteo > 0 Then

                        MessageBox.Show("El código de producto ya existe en la base de datos. Por favor, ingrese un código de producto único.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        codProducto.Focus()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar el código de producto: " & ex.Message, "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub descripProducto_Leave(sender As Object, e As EventArgs) Handles descripProducto.Leave
        If String.IsNullOrWhiteSpace(descripProducto.Text) Then

            MessageBox.Show("El campo descripción no puede estar vacío.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            descripProducto.Focus()

        ElseIf ContieneCaracteresEspeciales(descripProducto.Text) Then

            MessageBox.Show("El campo descripción no puede contener caracteres especiales.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            descripProducto.Focus()

        End If
    End Sub

    Private Sub PrecioUnitarioProducto_Leave(sender As Object, e As EventArgs) Handles PrecioUnitarioProducto.Leave
        If String.IsNullOrWhiteSpace(PrecioUnitarioProducto.Text) Then
            PrecioUnitarioProducto.Text = "0,00"
        Else
            Dim precio As Decimal
            If Decimal.TryParse(PrecioUnitarioProducto.Text, precio) Then

                If precio < 0 Then
                    MessageBox.Show("El campo precio unitario no puede contener valores negativos.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrecioUnitarioProducto.Focus()
                ElseIf precio > 99999999.99 Then
                    MessageBox.Show("El campo precio unitario no puede ser mayor a 99.999.999,99$", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrecioUnitarioProducto.Focus()
                Else
                    ' Formatear el precio con separadores de miles y dos decimales
                    PrecioUnitarioProducto.Text = precio.ToString("N2")
                End If
            Else
                MessageBox.Show("El campo precio unitario debe contener solo números.", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrecioUnitarioProducto.Focus()
            End If
        End If
    End Sub

    Private Sub txtIvaProducto_Leave(sender As Object, e As EventArgs) Handles txtIvaProducto.Leave

        If String.IsNullOrWhiteSpace(txtIvaProducto.Text) Then
            txtIvaProducto.Text = "21,0"
        Else

            Dim valoresPermitidos As New List(Of String)({"21", "21,0", "10.5", "0", "0,0"})

            If Not valoresPermitidos.Contains(txtIvaProducto.Text) Then
                MessageBox.Show("Solo se permite IVA 21, 10,5 o 0 en caso de producto exento", "Gesnet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIvaProducto.Focus()
            End If
        End If

    End Sub
End Class