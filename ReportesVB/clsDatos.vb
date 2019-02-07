Imports System.Data.SqlClient
Imports System.Configuration


Public Class clsDatos
    Public Shared Function GuardarParametrosPorTerminal(ByVal dtReporte As DataTable, ByVal nombre_reporte As String) As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "Guardar_Reporte2_2" ''-> procedimiento almacenado en la base de datos
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.StoredProcedure ''Stored(procedimiento) puede eliminar, guardar osea de todo con un procedimiento
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@nombre_archivo", SqlDbType.VarChar).Value = nombre_reporte ''@nombre_archivo se encuentra creado en el procedimiento almacenado en la base de datos
                sqlCmd.Parameters.Add("@Reportes", SqlDbType.Structured).Value = dtReporte ''@Reportes se encuentra creado en el procedimiento almacenado en la base de datos y el dato que enviaremos 
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                'Dim da As New SqlDataAdapter(sqlCmd)
                'da.Fill(dt)

                conn.Close()
                Return retornoValor
            End Using
        End Using
    End Function

    Public Shared Function Existe_Nombre_Reporte(ByVal reporte_nombre As String) As Boolean
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim sql As String = "SELECT COUNT([IdTbDatos]) AS [Cantidad] FROM [tblReportes2_2Cabecera] WHERE [nombre_archivo] = @nombre_repo" ''@ reemplaza las comillas simples
            Using sqlCmd As New SqlCommand(sql, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.Text
                sqlCmd.CommandTimeout = 180
                sqlCmd.Parameters.Add("@nombre_repo", SqlDbType.VarChar, 30).Value = reporte_nombre ''Aqui cramos el @nombre_repo que va a ser igual a reporte_nombre
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                conn.Close()
                If retornoValor > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Shared Function GuardarReporte196(ByVal dtReporte196 As DataTable, ByVal nombre_reporte196 As String) As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "Guardar_Reporte196" ''-> procedimiento almacenado en la base de datos
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.StoredProcedure ''Stored(procedimiento) puede eliminar, guardar osea de todo con un procedimiento
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@nombre_archivo196", SqlDbType.VarChar).Value = nombre_reporte196 ''@nombre_archivo se encuentra creado en el procedimiento almacenado en la base de datos
                sqlCmd.Parameters.Add("@Reportes196", SqlDbType.Structured).Value = dtReporte196 ''@Reportes se encuentra creado en el procedimiento almacenado en la base de datos y el dato que enviaremos 
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                'Dim da As New SqlDataAdapter(sqlCmd)
                'da.Fill(dt)

                conn.Close()
                Return retornoValor
            End Using
        End Using
    End Function

    Public Shared Function Existe_Nombre_Reporte196(ByVal reporte_nombre196 As String) As Boolean
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim sql As String = "SELECT COUNT([id_reportes1_96_cabecera]) AS [Cantidad] FROM [tblReportes1_96Cabecera] WHERE [nombre_archivo] = @nombre_repo196" ''@ reemplaza las comillas simples
            Using sqlCmd As New SqlCommand(sql, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.Text
                sqlCmd.CommandTimeout = 180
                sqlCmd.Parameters.Add("@nombre_repo196", SqlDbType.VarChar, 30).Value = reporte_nombre196 ''Aqui cramos el @nombre_repo que va a ser igual a reporte_nombre
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                conn.Close()
                If retornoValor > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Shared Function ObtenerDataGenerales(ByVal Intoption As Integer, ByVal id_reporte As Integer) As DataTable
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "ObtenerDatos"
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.StoredProcedure
                sqlCmd.CommandTimeout = 120 'tiempo de respuesta
                sqlCmd.Parameters.Add("@id_reporte", SqlDbType.Int).Value = id_reporte
                sqlCmd.Parameters.Add("@Option", SqlDbType.TinyInt).Value = Intoption
                Dim da As New SqlDataAdapter(sqlCmd)
                da.Fill(dt)
                conn.Close()
                Return dt
            End Using
        End Using
    End Function

    ''AQUI GUARDAMOS LOS DATOS DEL TEORICOICT
    Public Shared Function GuardarTeoricoICT(ByVal dtTeoricoICT As DataTable) As DataTable
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "Guardar_TeoricoICT" ''-> procedimiento almacenado en la base de datos
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.StoredProcedure ''Stored(procedimiento) puede eliminar, guardar osea de todo con un procedimiento
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@teorico_ict", SqlDbType.Structured).Value = dtTeoricoICT ''@teorico_ict se encuentra creado en el procedimiento almacenado en la base de datos y el dato que enviaremos 
                'Dim retVal As Integer = sqlCmd.ExecuteScalar()
                Dim da As New SqlDataAdapter(sqlCmd)
                da.Fill(dt)
                conn.Close()
                Return dt
            End Using
        End Using
    End Function

    Public Shared Function CalculoPkReal(ByVal Desde As Date) As DataTable
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "GenerarICTPkReal"
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open() ''Abre la conexion a la base de datos de propiedad que especifica el ConnectionString
                sqlCmd.CommandType = CommandType.StoredProcedure ''El comando ejecuta este procedimiento almacenado cuando se llama a uno de los métodos Execute
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@FechaUsuario", SqlDbType.Date).Value = Desde
                'sqlCmd.Parameters.Add("@hasta", SqlDbType.Date).Value = Hasta
                'sqlCmd.Parameters.Add("@OptionFecha", SqlDbType.TinyInt).Value = Intoption
                Dim da As New SqlDataAdapter(sqlCmd)
                da.Fill(dt)
                conn.Close() '' cerramos la conexion
                Return dt
            End Using
        End Using
    End Function

    Public Shared Function Existe_teoricoICT(ByVal dtTeoricoICT_existe As DataTable) As Boolean
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "Existe_Archivo_teoricoICT" ''-> procedimiento almacenado en la base de datos
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open() 'Leer diferencia entre CommandType Text y CommandType StoredProcedure
                sqlCmd.CommandType = CommandType.StoredProcedure ''Stored(procedimiento) puede eliminar, guardar osea de todo con un procedimiento 
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@teorico_ictExis", SqlDbType.Structured).Value = dtTeoricoICT_existe ''@teorico_ict se encuentra creado en el procedimiento almacenado en la base de datos y el dato que enviaremos 
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar() 'Leer las respuestas de la base de datos
                conn.Close()
                If retornoValor > 0 Then
                    Return True
                Else
                    Return False

                End If
                'Return retVal
            End Using
        End Using
    End Function

    Public Shared Function GuardarReportePlaza(ByVal dtReportePlaza As DataTable) As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "Guardar_plaza" ''-> procedimiento almacenado en la base de datos
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.StoredProcedure ''Stored(procedimiento) puede eliminar, guardar osea de todo con un procedimiento
                sqlCmd.CommandTimeout = 600
                sqlCmd.Parameters.Add("@Plaza", SqlDbType.Structured).Value = dtReportePlaza ''@Reportes se encuentra creado en el procedimiento almacenado en la base de datos y el dato que enviaremos 
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                'Dim da As New SqlDataAdapter(sqlCmd)
                'da.Fill(dt)

                conn.Close()
                Return retornoValor
            End Using
        End Using
    End Function

    Public Shared Function CRUDPlaza(ByVal Intoption As Integer, ByVal idplaza As Integer, ByVal NumeroInterno As String, ByVal ppu As String, ByVal plaza As String) As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "InsertarActualizarPlaza"
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open() ''Abre la conexion a la base de datos de propiedad que especifica el ConnectionString
                sqlCmd.CommandType = CommandType.StoredProcedure ''El comando ejecuta este procedimiento almacenado cuando se llama a uno de los métodos Execute
                sqlCmd.CommandTimeout = 120
                sqlCmd.Parameters.Add("@idPlaza", SqlDbType.Int).Value = idplaza
                sqlCmd.Parameters.Add("@nmroInterno", SqlDbType.VarChar, 20).Value = NumeroInterno
                sqlCmd.Parameters.Add("@ppu", SqlDbType.VarChar, 20).Value = ppu
                sqlCmd.Parameters.Add("@plazas", SqlDbType.TinyInt).Value = plaza
                sqlCmd.Parameters.Add("@Option", SqlDbType.TinyInt).Value = Intoption
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()

                conn.Close() '' cerramos la conexion
                Return retornoValor
            End Using
        End Using
    End Function

    Public Shared Function Feriados(ByVal Intoption As Integer, ByVal id_feriado As Integer, ByVal Feriado As Date, ByVal id_tio_dia As Integer) As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim SqlQuery As String = "GuardarFeriados"
            Dim dt As New DataTable
            Using sqlCmd As New SqlCommand(SqlQuery, conn)
                conn.Open() ''Abre la conexion a la base de datos de propiedad que especifica el ConnectionString
                sqlCmd.CommandType = CommandType.StoredProcedure ''El comando ejecuta este procedimiento almacenado cuando se llama a uno de los métodos Execute
                sqlCmd.CommandTimeout = 120
                sqlCmd.Parameters.Add("@id_fecha", SqlDbType.Int).Value = id_feriado
                sqlCmd.Parameters.Add("@FechaFeriado", SqlDbType.Date).Value = Feriado
                sqlCmd.Parameters.Add("@id_laboral", SqlDbType.Int).Value = id_tio_dia
                sqlCmd.Parameters.Add("@Option", SqlDbType.TinyInt).Value = Intoption
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()

                conn.Close() '' cerramos la conexion
                Return retornoValor
            End Using
        End Using
    End Function

    Public Shared Function ExisteCalculoICT(ByVal FechaCalculo As Date) As Boolean
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionRepositorio").ToString())
            Dim sql As String = "SELECT COUNT(id_calculoICT_cabecera) AS [Cantidad] FROM tblCalculoICT_Cabecera WHERE fecha_generada = @FechaUsuario" ''@ reemplaza las comillas simples
            Using sqlCmd As New SqlCommand(sql, conn)
                conn.Open()
                sqlCmd.CommandType = CommandType.Text
                sqlCmd.CommandTimeout = 180
                sqlCmd.Parameters.Add("@FechaUsuario", SqlDbType.Date).Value = FechaCalculo ''Aqui cramos el @nombre_repo que va a ser igual a reporte_nombre
                Dim retornoValor As Integer = sqlCmd.ExecuteScalar()
                conn.Close()
                If retornoValor > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
