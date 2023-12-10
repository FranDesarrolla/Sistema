Module ModuloSistema
    'para poder generar una cadena de conexion
    Public conexionSql As New SqlClient.SqlConnection
    'para la recepcion de datos
    Public aadaptadorSql As New SqlClient.SqlDataAdapter
    ' para la ejecucion de los comandos de sql
    Public consultasSql As New SqlClient.SqlCommand
    'para realizar las acciones de ejecucicon 
    Public acciones As New SqlClient.SqlCommand
    'para ser un repositorio de datos de la consulta 
    Public lectordatos As New SqlClient.SqlDataAdapter
    'para setear datos
    Public setdedatos As New DataSet
End Module
