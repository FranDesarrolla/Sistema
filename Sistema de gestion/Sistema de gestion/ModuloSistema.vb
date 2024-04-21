Imports System.IO
Imports System.Reflection

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

    ' Paleta de colores para modo claro
    Public Const PrincipalClaro As String = "Tan"
    Public Const SecundarioClaro As String = "#DAE8C5"
    Public Const TerciarioClaro As String = "#E3EED4"
    Public Const AdicionalClaro As String = "#ffffff"

    ' Paleta de colores para modo oscuro
    Public Const PrincipalOscuro As String = "#000028"
    Public Const SecundarioOscuro As String = "#000a47"
    Public Const TerciarioOscuro As String = "#001465"
    Public Const AdicionalOscuro As String = "#000f56"

    Public Sub CambiarPaletaClaro()

        ' Login
        Login.BackColor = ColorTranslator.FromHtml(PrincipalClaro)
        Login.PBLogo.BackColor = ColorTranslator.FromHtml(PrincipalClaro)
        Login.PanelUsuario.BackColor = ColorTranslator.FromHtml(TerciarioClaro)
        Login.PanelContraseña.BackColor = ColorTranslator.FromHtml(TerciarioClaro)

        ' Modulo principal
        ModuloPrincipal.PanelContenedor.BackColor = ColorTranslator.FromHtml(ModuloSistema.PrincipalClaro)
        ModuloPrincipal.PanelSuperior.BackColor = ColorTranslator.FromHtml(ModuloSistema.TerciarioClaro)
        ModuloPrincipal.PanelLateral.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)

        ' Botones

        ModuloPrincipal.btnProductos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnProductos.ForeColor = Color.Black
        ModuloPrincipal.btnVentas.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnVentas.ForeColor = Color.Black
        ModuloPrincipal.btnClientes.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnClientes.ForeColor = Color.Black
        ModuloPrincipal.btnPedidos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnPedidos.ForeColor = Color.Black
        ModuloPrincipal.btnCompras.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnCompras.ForeColor = Color.Black
        ModuloPrincipal.btnPagos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnPagos.ForeColor = Color.Black
        ModuloPrincipal.btnReportes.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnReportes.ForeColor = Color.Black
        ModuloPrincipal.btnProveedores.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnProveedores.ForeColor = Color.Black
        ModuloPrincipal.btnSesion.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioClaro)
        ModuloPrincipal.btnSesion.ForeColor = Color.Black

        Dim rutaProyecto As String = "C:\Users\Francisco\Desktop\Sistema\Sistema\Sistema de gestion\Sistema de gestion\Resources\Icons"
        Dim productosW As String = "productos-b.png"

        Dim rutaImagen As String = Path.Combine(rutaProyecto, productosW)

        ModuloPrincipal.btnProductos.Image = Image.FromFile(rutaImagen)

    End Sub

    Public Sub CambiarPaletaOscuro()
        ' Login
        Login.BackColor = ColorTranslator.FromHtml(PrincipalOscuro)
        Login.PBLogo.BackColor = ColorTranslator.FromHtml(PrincipalOscuro)
        Login.PanelUsuario.BackColor = ColorTranslator.FromHtml(TerciarioOscuro)
        Login.PanelContraseña.BackColor = ColorTranslator.FromHtml(TerciarioOscuro)

        ' Modulo principal
        ModuloPrincipal.PanelContenedor.BackColor = ColorTranslator.FromHtml(ModuloSistema.PrincipalOscuro)
        ModuloPrincipal.PanelSuperior.BackColor = ColorTranslator.FromHtml(ModuloSistema.TerciarioOscuro)
        ModuloPrincipal.PanelLateral.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)

        ' Botones

        ModuloPrincipal.btnProductos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnProductos.ForeColor = Color.White
        ModuloPrincipal.btnVentas.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnVentas.ForeColor = Color.White
        ModuloPrincipal.btnClientes.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnClientes.ForeColor = Color.White
        ModuloPrincipal.btnPedidos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnPedidos.ForeColor = Color.White
        ModuloPrincipal.btnCompras.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnCompras.ForeColor = Color.White
        ModuloPrincipal.btnPagos.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnPagos.ForeColor = Color.White
        ModuloPrincipal.btnReportes.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnReportes.ForeColor = Color.White
        ModuloPrincipal.btnProveedores.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnProveedores.ForeColor = Color.White
        ModuloPrincipal.btnSesion.BackColor = ColorTranslator.FromHtml(ModuloSistema.SecundarioOscuro)
        ModuloPrincipal.btnSesion.ForeColor = Color.White

        Dim rutaProyecto As String = "C:\Users\Francisco\Desktop\Sistema\Sistema\Sistema de gestion\Sistema de gestion\Resources\Icons"
        Dim productosW As String = "productos-w.png"

        Dim rutaImagen As String = Path.Combine(rutaProyecto, productosW)

        ModuloPrincipal.btnProductos.Image = Image.FromFile(rutaImagen)

    End Sub

End Module
