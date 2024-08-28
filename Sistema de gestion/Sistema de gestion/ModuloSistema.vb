Imports System.IO

Module ModuloSistema
    'para poder generar una cadena de conexión
    Public conexionSql As New SqlClient.SqlConnection
    'para la recepcion de datos
    Public adaptadorSql As New SqlClient.SqlDataAdapter
    'para la ejecucion de los comandos de sql
    Public consultasSql As New SqlClient.SqlCommand
    'para realizar las acciones de ejecución 
    Public acciones As New SqlClient.SqlCommand
    'para ser un repositorio de datos de la consulta 
    Public lectordatos As New SqlClient.SqlDataAdapter
    'para setear datos
    Public setdedatos As New DataSet

    ' Método para cargar la cadena de conexión desde el archivo Sistema.ini
    Public Sub CargarCadenaConexion()
        Dim directorio As String = Path.Combine(Directory.GetCurrentDirectory(), "Sistema.ini")

        If File.Exists(directorio) Then
            Try
                ' Lee el contenido del archivo Sistema.ini
                Dim lines As String() = File.ReadAllLines(directorio)

                ' Procesa las líneas y construye la cadena de conexión
                Dim connectionString As String = String.Join(";", lines)

                ' Asigna la cadena de conexión al objeto SqlConnection
                conexionSql.ConnectionString = connectionString
            Catch ex As Exception
                Console.WriteLine("Error al leer el archivo: " & ex.ToString())
            End Try
        Else
            Console.WriteLine("El archivo Sistema.ini no existe en la ruta actual del sistema.")
        End If
    End Sub

    ' Paletas de colores
    Public Const PrincipalClaro As String = "Tan"
    Public Const SecundarioClaro As String = "#DAE8C5"
    Public Const TerciarioClaro As String = "#E3EED4"
    Public Const AdicionalClaro As String = "#ffffff"

    Public Const PrincipalOscuro As String = "#000028"
    Public Const SecundarioOscuro As String = "#000a47"
    Public Const TerciarioOscuro As String = "#001465"
    Public Const AdicionalOscuro As String = "#000f56"

    ' Método para cambiar a modo claro
    Public Sub CambiarPaletaClaro()
        CambiarColores(ModuloPrincipal, PrincipalClaro, SecundarioClaro, TerciarioClaro, AdicionalClaro, Color.Black,
                       My.Resources.productos_b, My.Resources.proveedores_b, My.Resources.ventas_b, My.Resources.clientes_b,
                       My.Resources.pedidos_b, My.Resources.compras_b, My.Resources.pagos_b, My.Resources.reportes_b, My.Resources.cerrarsesion_b,
                       My.Resources.usuario_b)
    End Sub

    ' Método para cambiar a modo oscuro
    Public Sub CambiarPaletaOscuro()
        CambiarColores(ModuloPrincipal, PrincipalOscuro, SecundarioOscuro, TerciarioOscuro, AdicionalOscuro, Color.White,
                       My.Resources.productos_w, My.Resources.proveedores_w, My.Resources.ventas_w, My.Resources.clientes_w,
                       My.Resources.pedidos_w, My.Resources.compras_w, My.Resources.pagos_w, My.Resources.reportes_w, My.Resources.cerrarsesion_w,
                       My.Resources.usuario_w)
    End Sub

    ' Método para cambiar colores en base a la paleta seleccionada
    Private Sub CambiarColores(modulo As Object, principal As String, secundario As String, terciario As String, adicional As String, textoColor As Color,
                               iconoProducto As Image, iconoProveedores As Image, iconoVentas As Image, iconoClientes As Image,
                               iconoPedidos As Image, iconoCompras As Image, iconoPagos As Image, iconoReportes As Image, iconoSesion As Image,
                               iconoUsuario As Image)
        ' Login
        Login.BackColor = ColorTranslator.FromHtml(principal)
        Login.PBLogo.BackColor = ColorTranslator.FromHtml(principal)
        Login.PanelUsuario.BackColor = ColorTranslator.FromHtml(terciario)
        Login.PanelContraseña.BackColor = ColorTranslator.FromHtml(terciario)

        ' Módulo principal
        modulo.PanelContenedor.BackColor = ColorTranslator.FromHtml(principal)
        modulo.PanelSuperior.BackColor = ColorTranslator.FromHtml(terciario)
        modulo.PanelLateral.BackColor = ColorTranslator.FromHtml(secundario)

        ' Botones
        CambiarColorBotones(modulo, secundario, textoColor, iconoProducto, iconoProveedores, iconoVentas, iconoClientes,
                            iconoPedidos, iconoCompras, iconoPagos, iconoReportes, iconoSesion, iconoUsuario)
    End Sub

    ' Método para cambiar los colores de los botones
    Private Sub CambiarColorBotones(modulo As Object, fondoColor As String, textoColor As Color,
                                    iconoProducto As Image, iconoProveedores As Image, iconoVentas As Image, iconoClientes As Image,
                                    iconoPedidos As Image, iconoCompras As Image, iconoPagos As Image, iconoReportes As Image, iconoSesion As Image,
                                    iconoUsuario As Image)
        modulo.btnProductos.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnProductos.ForeColor = textoColor
        modulo.btnProductos.Image = iconoProducto

        modulo.btnProveedores.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnProveedores.ForeColor = textoColor
        modulo.btnProveedores.Image = iconoProveedores

        modulo.btnVentas.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnVentas.ForeColor = textoColor
        modulo.btnVentas.Image = iconoVentas

        modulo.btnClientes.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnClientes.ForeColor = textoColor
        modulo.btnClientes.Image = iconoClientes

        modulo.btnPedidos.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnPedidos.ForeColor = textoColor
        modulo.btnPedidos.Image = iconoPedidos

        modulo.btnCompras.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnCompras.ForeColor = textoColor
        modulo.btnCompras.Image = iconoCompras

        modulo.btnPagos.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnPagos.ForeColor = textoColor
        modulo.btnPagos.Image = iconoPagos

        modulo.btnReportes.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnReportes.ForeColor = textoColor
        modulo.btnReportes.Image = iconoReportes

        modulo.btnSesion.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.btnSesion.ForeColor = textoColor
        modulo.btnSesion.Image = iconoSesion

        modulo.lblUsuario.ForeColor = textoColor
        modulo.btnUser.Image = iconoUsuario

        modulo.cbModo.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.cbModo.ForeColor = textoColor

        modulo.boxPV.BackColor = ColorTranslator.FromHtml(fondoColor)
        modulo.boxPV.ForeColor = textoColor
    End Sub

End Module
