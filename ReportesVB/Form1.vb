Imports Microsoft.Office.Interop
Imports System.Globalization

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDiccionario()
        CargarCBOboxR22()
        CargarDTGR196()
        CargarCBOboxTeoricoICT()
        CargarCboFeriado()
        CargarFecha()

    End Sub

    Private Sub btnBuscarDocumento_Click(sender As Object, e As EventArgs) Handles btnBuscarDocumento.Click
        ofdAbrirDocumento.Filter = "Archivos csv (*.csv)|*.csv|Documentos Excel 2003 (*.xls)|*.xls|Documentos Excel 2007-2010 (*.xlsx)|*.xlsx"
        Dim dtReporte196 As New DataTable
        Dim dtReporte22 As New DataTable
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim intoption As Integer = 0
        ''
        ' Set title.
        title = "Ingrese opción 1 ó 2"
        Dim answer As Object
        ' Set prompt.
        prompt = "Hola. Cual es tu opción?" & vbCrLf & "1.-Cargar Reporte 1.96" & vbCrLf & "2.-Cargar Reporte 2.2"

        ' Set default value.
        defaultResponse = "1" ''mostrar un numero al comienzo que sale el cuadro de dialogo
        ''
        Do
            ' Display prompt, title, and default value.
            answer = InputBox(prompt, title, defaultResponse)
            ''
            If (ofdAbrirDocumento.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                '
                If Not IsNumeric(answer) And answer <> "" Then
                    MessageBox.Show("Solo deben ser numeros")
                ElseIf IsNumeric(answer) Then
                    If answer >= 1 And answer <= 2 Then
                        intoption = answer
                        answer = "ok"
                    End If
                End If
            End If


        Loop Until (answer = "" Or answer = "ok")

        If answer = "ok" Then
            'Validar opcion del usuario
            'dependiendo de cual sea ejecutas la funcion
            If intoption = 1 Then
                dtReporte196 = GetDataCSV196(ofdAbrirDocumento.FileName)
                dgvReporte196.DataSource = dtReporte196
                tabReportes.SelectedIndex = 0
            ElseIf intoption = 2 Then
                dtReporte22 = GetData2_2CSV(ofdAbrirDocumento.FileName)
                dgvReporte22.DataSource = dtReporte22
                tabReportes.SelectedIndex = 1
            ElseIf intoption = 3 Then

            End If

        Else
            MessageBox.Show("Cancelado")
        End If

        'dtReporte = GetDataCSV196(ofdAbrirDocumento.FileName)
        '' dtReporte = GetData2_2CSV(ofdAbrirDocumento.FileName)

        ''

        ''


        ''
        '' If dtReporte.Rows.Count > 0 Then
        'DataGridView1.DataSource = dtReporte
        ''dgvReporte1_96.DataSource = dtReporte
        ''End If
        ''Aqui se cargan los archivos al programa
    End Sub

    'obtener datos desde csv reporte 2.2
    Public Function GetData2_2CSV(ByVal ruta As String) As DataTable '' para que devuelva un data table 
        'tabla dias festivos
        Dim TextLine As String = String.Empty
        Dim nombre_archivo As String = Nothing
        '//
        Dim dtSource As New DataTable("Source")
        ''          Los nombres se toman desde el reporte                     
        dtSource.Columns.Add("fechagps", Type.GetType("System.DateTime")) 'fecha de gps
        dtSource.Columns.Add("fechagpsant", Type.GetType("System.DateTime")) ' fecha gps anterior
        dtSource.Columns.Add("posicionbus", Type.GetType("System.Double")) 'posicion bus
        dtSource.Columns.Add("posicionbusant", Type.GetType("System.Double")) ' posicion bus anterior
        dtSource.Columns.Add("patentebus", Type.GetType("System.String")) ' patente bus
        dtSource.Columns.Add("clidsc", Type.GetType("System.String")) 'clidsc
        dtSource.Columns.Add("idruta", Type.GetType("System.Int32")) ' identificador de ruta
        dtSource.Columns.Add("codigoruta", Type.GetType("System.String")) ' codigo de ruta
        dtSource.Columns.Add("nombreservasig", Type.GetType("System.String")) 'nombre de servicio asignado
        dtSource.Columns.Add("nombreservplan", Type.GetType("System.String")) ' nombre de servicio planificado
        dtSource.Columns.Add("distanciapc", Type.GetType("System.Double")) ' distancia pc
        dtSource.Columns.Add("fercharealinicio", Type.GetType("System.DateTime")) ' fecha real de inicio
        dtSource.Columns.Add("posicionrealinicio", Type.GetType("System.Double")) ' posicion real de inicio
        dtSource.Columns.Add("codigorutaconsola", Type.GetType("System.String")) ' codigo ruta de consola
        dtSource.Columns.Add("fechaoperacion", Type.GetType("System.DateTime")) 'fecha de opearcion - nueva columna
        ''
        Dim SplitLine() As String
        Dim contstring As Int32 = 0
        nombre_archivo = IO.Path.GetFileName(ruta) ''Aqui se obtiene el nombre del archivo
        ''
        Label1.Text = nombre_archivo
        ''
        If System.IO.File.Exists(ruta) = True Then
            Dim contcolums As Int32 = 0
            Dim objReader As New System.IO.StreamReader(ruta)
            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, ";")
                contcolums = SplitLine.Count
                If (True) Then

                    'obtener y formatear variables
                    ''
                    '' Dim value2 As Date = CDate(SplitLine(2)) '#3/1/2013 10:56:39 PM#
                    '' Dim value3 As Double = 0 ''CDbl(Replace(SplitLine(3), ",", ".")) / 100 '26.42
                    ' Dim value4 As Double = 0 ''CDbl(Replace(SplitLine(4), ",", ".")) / 100 '"   25,84"
                    'Dim value3 As String = Replace(SplitLine(3), ",", ".").Trim '26.42
                    'Dim value4 As String = Replace(SplitLine(4), ",", ".").Trim '"   25,84"
                    Dim value5 As String = SplitLine(5).Trim '"BJFR-74"
                    Dim value6 As String = SplitLine(6).Trim '"U3 - Vule"
                    Dim value7 As Integer = CInt(SplitLine(7)) '27759
                    Dim value8 As String = SplitLine(8).Trim '"T301 06I"
                    Dim value9 As String = SplitLine(9).Trim '"T301"
                    Dim value10 As String = SplitLine(10).Trim ' CDbl(Replace(SplitLine(10), ",", "."))'vacio

                    '  Dim value11 As Double = 0 '' SplitLine(11).Trim()

                    ' Dim value13 As Double = 0 ''Replace(SplitLine(14), ",", ".").Trim
                    Dim value14 As String = SplitLine(15).Trim
                    'Dim s_media_hora As String = ObtenerMediaHora(value1)
                    Dim newrow As DataRow = dtSource.NewRow()  'crear filas en datatable
                    ''
                    If IsDate(SplitLine(0)) Then ''Para validar si entran datos vacios de tipo fecha 
                        newrow(0) = CDate(SplitLine(0))
                    End If
                    ''
                    ''
                    If IsDate(SplitLine(2)) Then
                        newrow(1) = CDate(SplitLine(2))
                    End If
                    ''
                    If IsNumeric(SplitLine(3)) Then
                        newrow(2) = SplitLine(3)
                    End If
                    ''
                    ''
                    If IsNumeric(SplitLine(4)) Then
                        newrow(3) = SplitLine(4)
                    End If

                    ''

                    newrow(4) = value5
                    newrow(5) = value6
                    newrow(6) = value7
                    newrow(7) = value8
                    newrow(8) = value9
                    newrow(9) = value10
                    ''
                    If IsNumeric(SplitLine(11)) Then
                        newrow(10) = SplitLine(11)
                    End If
                    ''
                    If IsDate(SplitLine(12)) Then
                        newrow(11) = CDate(SplitLine(12))
                    End If
                    ''
                    If IsNumeric(SplitLine(14)) Then
                        newrow(12) = SplitLine(14)
                    End If

                    newrow(13) = value14
                    ''
                    If IsDate(SplitLine(0)) Then
                        Dim dteFechaOper As Date = SplitLine(0)
                        newrow(14) = dteFechaOper.ToShortDateString()
                    End If
                    ''
                    dtSource.Rows.Add(newrow)


                End If


                contstring += 1
            Loop

            objReader.Close()
        Else
            MessageBox.Show("No Existe el Archivo")
        End If
        'Dim dtResultado = dtSource
        Return dtSource
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Guardamos el cursor actual correspondiente
        ' al objeto donde actualmente se está ejecutando
        ' el código.
        '
        Dim c As Cursor = Me.Cursor
        Dim dtReporte_datos As New DataTable




        Try
            ' Mostramos el cursor de arena
            '
            Me.Cursor = Cursors.WaitCursor

            ' Cargamos los datos en el objeto DataTable
            '
            dtReporte_datos = DirectCast(dgvReporte22.DataSource, DataTable)
            ''
            If clsDatos.Existe_Nombre_Reporte(Label1.Text) Then ''Aqui manda el dato para saber si existe o no de la funcion "Existe_Nombre_Reporte" de la clase clsDatos

                Dim Cargar As Integer = MessageBox.Show("El archivo ya existe en la Base de Datos" & vbCrLf & "¿Deseas volver a cargar?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                ''

                ''
                If Cargar = 6 Then '6 es SI y 7 es NO
                    Carga_reporte(dtReporte_datos, Label1.Text)

                End If
            Else
                Carga_reporte(dtReporte_datos, Label1.Text)
            End If


            ''& vbCrLf & para Mostrar un mensaje debajo de otro


        Catch ex As Exception
            ' Se ha producido un error            '
            MessageBox.Show(ex.Message)
        Finally
            ' Restauramos el cursor
            Me.Cursor = c

        End Try
    End Sub

    Private Sub Carga_reporte(ByVal dtRepote As DataTable, ByVal nombre As String) ''Recibiendo los datos
        Dim intRespuesta As Integer = 0
        ''
        intRespuesta = clsDatos.GuardarParametrosPorTerminal(dtRepote, nombre) ''se llama desde la clase clsDatos
        ''
        If intRespuesta > 0 Then
            MessageBox.Show("Datos cargados con éxito", "Respuesta")
        ElseIf intRespuesta = 0 Then
            MessageBox.Show("No llegaron los datos", "Respuesta")
        Else
            MessageBox.Show("Error al intentar guardar", "Respuesta")
        End If

    End Sub

    ''obtener datos desde reporte 1.96
    Public Function GetDataCSV196(ByVal ruta196 As String) As DataTable
        Dim TextLine As String = String.Empty
        Dim nombre_archivo196 As String = Nothing
        Dim dtSource As New DataTable("Source")
        ''          Los nombres se toman desde el reporte
        dtSource.Columns.Add("Unidad de Negocio", GetType(String)) 'Unidad de Negocio
        dtSource.Columns.Add("Fecha", GetType(Date)) ' Fecha
        dtSource.Columns.Add("PPU", GetType(String)) ' PPU
        dtSource.Columns.Add("Tipo de GPS", GetType(String)) 'Tipo de GPS
        dtSource.Columns.Add("Servicio", GetType(String)) ' Servicio
        dtSource.Columns.Add("Sentido", GetType(String)) ' Sentido
        dtSource.Columns.Add("Intervalo", GetType(String)) 'Intervalo 
        dtSource.Columns.Add("Operativo", GetType(String)) ' Operativo
        dtSource.Columns.Add("KM Intervalo", GetType(Double)) ' KM Intervalo
        dtSource.Columns.Add("KM del viaje en intervalo", GetType(Double)) 'KM del viaje en intervalo
        dtSource.Columns.Add("Fecha Inicio Viaje", GetType(DateTime)) 'Fecha Inicio Viaje 
        dtSource.Columns.Add("Fecha Fin Viaje", GetType(DateTime)) 'Fecha Fin Viaje
        dtSource.Columns.Add("Tiempo de este viaje", GetType(Double)) '' Tiempo de este viaje
        dtSource.Columns.Add("Tiempo total de viaje del intervalo", GetType(Double)) ' Tiempo total de viaje del intervalo
        dtSource.Columns.Add("Tiempo de Viaje", GetType(String)) 'Tiempo de Viaje
        dtSource.Columns.Add("Inicio y Fin de Ruta", GetType(String)) ' Inicio y Fin de Ruta
        dtSource.Columns.Add("120 Minutos Antes", GetType(String)) ' 120 Minutos Antes
        dtSource.Columns.Add("120 Minutos Despues", GetType(String)) '120 Minutos Despues
        dtSource.Columns.Add("PC cada 2 Km", GetType(String)) ' PC cada 2 Km
        dtSource.Columns.Add("Igual Servicio", GetType(String)) ' Igual Servicio
        ''
        Dim SplitLine() As String '' poner los parentecis en el splitline(o Nombre cualquiera) se convierte un array
        Dim intContador As Int32 = 0
        nombre_archivo196 = IO.Path.GetFileName(ruta196) ''Aqui se obtiene el nombre del archivo
        ''
        Label1.Text = nombre_archivo196
        ''
        If System.IO.File.Exists(ruta196) = True Then
            Dim contcolums As Int32 = 0
            Dim objReader As New System.IO.StreamReader(ruta196)
            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, ";") ''????????? del ;
                contcolums = SplitLine.Count
                If (intContador > 7) Then
                    Dim diccionario1 As New Dictionary(Of String, String)
                    diccionario1.Add("I", "Ida")
                    diccionario1.Add("IDA", "Ida")
                    diccionario1.Add("R", "Ret")
                    diccionario1.Add("RETORNO", "Ret")
                    diccionario1.Add("REGRESO", "Ret")



                    'obtener y formatear variables
                    ''Splitline es un array
                    Dim unidad_negocio As String = SplitLine(0).Trim
                    '' Dim Fecha As String = SplitLine(1).Trim  
                    Dim PPU As String = SplitLine(2).Trim
                    Dim GPS As String = SplitLine(3).Trim
                    Dim Servicio As String = SplitLine(4).Replace(" ", "").ToUpper()
                    Dim Sentido As String = SplitLine(5).Trim.ToUpper()
                    Dim Intervalo As String = SplitLine(6).Trim
                    Dim Operativo As String = SplitLine(7).Trim
                    'Dim km_intervalo As Double = 0 'CDbl(SplitLine(8))

                    '  Dim km_viaje_intervalo As Double = CDbl(SplitLine(9))
                    '' Dim fecha_inicio_viaje As String = SplitLine(10).Trim
                    '' Dim fecha_fin_viaje As String = SplitLine(11).Trim
                    ' Dim tiempo_este_viaje As Double = CDbl(SplitLine(12))
                    ' Dim tiempo_total_viaje_intervalo As Double = CDbl(SplitLine(13))
                    Dim tiempos_viaje As String = SplitLine(14)
                    Dim Inicio_fin_ruta As String = SplitLine(15)
                    Dim min_120_antes As String = SplitLine(16)
                    Dim min_120_despues As String = SplitLine(17)
                    Dim pc_cada2km As String = SplitLine(18)
                    Dim igual_servicio As String = SplitLine(19)

                    Dim newrow As DataRow = dtSource.NewRow()  'crear filas en datatable
                    ''

                    newrow(0) = unidad_negocio
                    ''
                    If IsDate(SplitLine(1)) Then '' validar que entren datos vacios
                        newrow(1) = CDate(SplitLine(1)) ''Este es Fechad el reporte 196 en el exel
                    End If
                    ''

                    newrow(2) = PPU
                    newrow(3) = GPS
                    ''
                    If ModVariablesGlobales.dicIdServicios.ContainsKey(Servicio) Then
                        newrow(4) = Servicio
                        'newrow(4) = ModVariablesGlobales.dicIdServicios.Item(Servicio)
                    End If


                    ''
                    If diccionario1.ContainsKey(Sentido) Then
                        newrow(5) = Sentido
                        newrow(5) = diccionario1.Item(Sentido)
                    End If
                    ''

                    newrow(6) = Intervalo
                    newrow(7) = Operativo
                    ''
                    If IsNumeric(SplitLine(8)) Then
                        newrow(8) = SplitLine(8)
                    End If
                    ''
                    ''
                    If IsNumeric(SplitLine(9)) Then
                        newrow(9) = SplitLine(9)
                    End If

                    ''
                    If IsDate(SplitLine(10)) Then
                        newrow(10) = CDate(SplitLine(10))
                    End If

                    ''
                    If IsDate(SplitLine(11)) Then
                        newrow(11) = CDate(SplitLine(11))
                    End If

                    ''
                    If IsNumeric(SplitLine(12)) Then
                        newrow(12) = SplitLine(12)
                    End If
                    ''
                    If IsNumeric(SplitLine(13)) Then
                        newrow(13) = SplitLine(13)
                    End If


                    ''
                    newrow(14) = tiempos_viaje
                    newrow(15) = Inicio_fin_ruta
                    newrow(16) = min_120_antes
                    newrow(17) = min_120_despues
                    newrow(18) = pc_cada2km
                    newrow(19) = igual_servicio
                    ''

                    ''
                    dtSource.Rows.Add(newrow)



                End If
                intContador += 1

            Loop
            objReader.Close()
        Else
            MessageBox.Show("No Existe el Archivo")
        End If
        'Dim dtResultado = dtSource
        Return dtSource
    End Function

    Private Sub btnGuardar1_96_Click(sender As Object, e As EventArgs) Handles btnGuardar1_96.Click
        Dim c As Cursor = Me.Cursor
        Dim dtReporte196_datos As New DataTable

        Try
            ' Mostramos el cursor de arena
            '
            Me.Cursor = Cursors.WaitCursor

            ' Cargamos los datos en el objeto DataTable
            '
            dtReporte196_datos = DirectCast(dgvReporte196.DataSource, DataTable) ''obteniendo Datatable del DataGridView1
            ''
            If clsDatos.Existe_Nombre_Reporte196(Label1.Text) Then ''Aqui manda el dato para saber si existe o no de la funcion "Existe_Nombre_Reporte" de la clase clsDatos

                Dim Cargar As Integer = MessageBox.Show("El archivo ya existe en la Base de Datos" & vbCrLf & "¿Deseas volver a cargar?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                ''

                ''
                If Cargar = 6 Then '6 es SI y 7 es NO
                    Carga_reporte196(dtReporte196_datos, Label1.Text)

                End If
            Else
                Carga_reporte196(dtReporte196_datos, Label1.Text)
            End If


            ''& vbCrLf & para Mostrar un mensaje debajo de otro


        Catch ex As Exception
            ' Se ha producido un error            '
            MessageBox.Show(ex.Message)
        Finally
            ' Restauramos el cursor
            Me.Cursor = c

        End Try
    End Sub

    Private Sub Carga_reporte196(ByVal dtRepote196 As DataTable, ByVal nombre As String) ''Recibiendo los datos del reporte 1.96
        Dim intRespuesta196 As Integer = 0

        intRespuesta196 = clsDatos.GuardarReporte196(dtRepote196, nombre) ''se llama desde la clase clsDatos
        If intRespuesta196 > 0 Then
            MessageBox.Show("Datos cargados con éxito", "Respuesta")
        ElseIf intRespuesta196 = 0 Then
            MessageBox.Show("No llegaron los datos", "Respuesta")
        Else
            MessageBox.Show("Error al intentar guardar", "Respuesta")
        End If
    End Sub

    ''Obtener datos desde la grilla cboR2_2 (ComboBox del lado derecho)
    Private Sub CargarCBOboxR22() ''Proedimiento de visual basic
        Dim cboSourceCabecera As New Dictionary(Of Integer, String)()
        Dim dtSourCabe As New DataTable
        Try
            ''
            dtSourCabe = clsDatos.ObtenerDataGenerales(2, 0) ''Obtenemos los datos del procedimiento almacenado [ObtenerDatos] de la opcion 2 
            ''
            If dtSourCabe.Rows.Count > 0 Then
                For Each run In dtSourCabe.Rows
                    Dim intId As Integer = run("IdTbDatos")
                    Dim stgNombre As String = run("nombre_archivo")
                    ''
                    If Not cboSourceCabecera.ContainsKey(intId) Then
                        cboSourceCabecera.Add(intId, stgNombre)
                    End If
                Next
                ''
                cboR2_2.DataSource = New BindingSource(cboSourceCabecera, Nothing)
                cboR2_2.DisplayMember = "Value"
                cboR2_2.ValueMember = "Key"
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la aplicación contáctese con el administrador ", "SGPI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''Obtener datos desde la grilla dtgMostrar196(La que esta al lado derecho)
    Private Sub CargarDTGR196()

        Dim dtgSourCabecera196 As New DataTable
        Try
            ''
            dtgSourCabecera196 = clsDatos.ObtenerDataGenerales(1, 0) ''Obtenemos los datos del procedimiento almacenadoo [ObtenerDatos] de la opcion 1
            ''
            If dtgSourCabecera196.Rows.Count > 0 Then
                ''
                dtgMostrar196.DataSource = dtgSourCabecera196
                dtgMostrar196.Columns(0).Visible = False
                dtgMostrar196.Columns(1).Width = 195
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la aplicación contáctese con el administrador ", "SGPI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''Obtener datos desde la grilla cmbxTeoricoICT (ComboBox de la parte de abajo)
    Private Sub CargarCBOboxTeoricoICT() ''Proedimiento de visual basic
        Dim cboSourceCabeceraICT As New Dictionary(Of Integer, String)()
        Dim dtSourCabeICT As New DataTable
        Try
            ''
            dtSourCabeICT = clsDatos.ObtenerDataGenerales(5, 0) ''Obtenemos los datos del procedimiento almacenado [ObtenerDatos] de la opcion 2 
            ''
            If dtSourCabeICT.Rows.Count > 0 Then
                For Each run In dtSourCabeICT.Rows

                    Dim stgID As Integer = run("id_desde_hasta_cabecera")
                    Dim stgHasta As String = run("NombreColumna")

                    ''
                    If Not cboSourceCabeceraICT.ContainsKey(stgID) Then
                        cboSourceCabeceraICT.Add(stgID, stgHasta)
                    End If
                Next
                ''
                cboTeoricoICT.DataSource = New BindingSource(cboSourceCabeceraICT, Nothing)
                cboTeoricoICT.DisplayMember = "Value"
                cboTeoricoICT.ValueMember = "Key"


            End If

        Catch ex As Exception
            MessageBox.Show("Error en la aplicación contáctese con el administrador", "SGPI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDiccionario()
        Dim dtServicio As New DataTable
        Try
            dtServicio = clsDatos.ObtenerDataGenerales(10, 0)
            If dtServicio.Rows.Count > 0 Then
                For Each run In dtServicio.Rows
                    Dim ID_servicios As Integer = run("id_servicios")
                    Dim serSinoptico As String = run("servicio_sinoptico")


                    ''
                    If Not ModVariablesGlobales.dicIdServicios.ContainsKey(serSinoptico) Then
                        ModVariablesGlobales.dicIdServicios.Add(serSinoptico, ID_servicios)
                    End If
                Next
                ''
            End If
        Catch ex As Exception

        End Try

    End Sub

    ''Obtener el tipo_dia desde la base de datos para mostrarlo en el ComboBox "cboFeriado"
    Private Sub CargarCboFeriado()
        Dim cboFechaferiado As New Dictionary(Of Integer, String)()
        Dim dtFeriado As New DataTable

        Try
            dtFeriado = clsDatos.ObtenerDataGenerales(8, 0)

            If dtFeriado.Rows.Count > 0 Then
                For Each run In dtFeriado.Rows

                    Dim cboID As Integer = run("id_tipo_dia")
                    Dim cboDia As String = run("dia")
                    ''
                    If Not cboFechaferiado.ContainsKey(cboID) Then
                        cboFechaferiado.Add(cboID, cboDia)
                    End If
                Next
                ''
                cboFeriado.DataSource = New BindingSource(cboFechaferiado, Nothing)
                cboFeriado.DisplayMember = "Value"
                cboFeriado.ValueMember = "Key"
            End If


        Catch ex As Exception
            MessageBox.Show("Error en la aplicación contáctese con el administrador", "SGPI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''Mostrar los datos de la PLAZA en la grilla 
    Private Sub btnMostrarPlaza_Click(sender As Object, e As EventArgs) Handles btnMostrarPlaza.Click
        Dim dtPlaza As New DataTable
        dtPlaza = clsDatos.ObtenerDataGenerales(7, 0) ''El 7 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el 0 significa que no le pasamos nada 
        dgvPlaza.DataSource = dtPlaza ''Almacenamos los datos en la grilla de Plaza
        dgvPlaza.Columns(0).Visible = False 'Ocular columna del datagridView
        tabReportes.SelectedIndex = 3 ''nomas manda para la grilla del dgvPlaza

    End Sub

    ''Boton ver de la del Teorico ICT para ver un archivo subido a la base de datos
    Private Sub btnVerICT_Click(sender As Object, e As EventArgs) Handles btnVerICT.Click
        If cboTeoricoICT IsNot Nothing Then ''Si no es vacio entonces ingresa al comboBox
            Dim id_TeoricoICT As Integer = 0
            Dim dtTeoricoICT As New DataTable
            id_TeoricoICT = DirectCast(cboTeoricoICT.SelectedItem, KeyValuePair(Of Integer, String)).Key
            dtTeoricoICT = clsDatos.ObtenerDataGenerales(6, id_TeoricoICT) ''El 6 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el id_desde_hasta_cabecera es el id que le estamos pasando desde el repositorio
            dgvIndice.DataSource = dtTeoricoICT ''Almacenamos los datos en la grilla del TeoricoICT
            tabReportes.SelectedIndex = 2 ''nomas manda para la grilla del TeoricoICT
        Else
            Exit Sub
        End If
    End Sub

    ''Boton de "ver" del reporte2.2
    Private Sub btnVerRepo22_Click(sender As Object, e As EventArgs) Handles btnVerRepo22.Click

        If cboR2_2 IsNot Nothing Then ''Si no es vacio entonces ingresa al comboBox
            Dim id_Repo22 As Integer = 0
            Dim dtRepo22 As New DataTable
            id_Repo22 = DirectCast(cboR2_2.SelectedItem, KeyValuePair(Of Integer, String)).Key
            dtRepo22 = clsDatos.ObtenerDataGenerales(3, id_Repo22) ''El 3 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el id_repo es el id que le estamos pasando desde el repositorio
            dgvReporte22.DataSource = dtRepo22 ''Almacenamos los datos en la grilla del Reporte22
            tabReportes.SelectedIndex = 1 ''nomas manda para la grilla del Reporte 22
        Else
            Exit Sub
        End If
    End Sub

    ''Grila del reporte 1.96 (del lado derecho, la pequeña), se abre con un doble click
    Private Sub dtgMostrar196_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgMostrar196.CellDoubleClick
        Dim dtRepo196 As New DataTable
        Dim id_reporte196 As Integer = dtgMostrar196.Rows(e.RowIndex).Cells(0).Value ''Obtenemos el id del reporte desde la grilla dtgMostrar196
        dtRepo196 = clsDatos.ObtenerDataGenerales(4, id_reporte196) ''Alamcenamos los datos que traemos desde el procedimiento almacenado de la opcion 4 con el nombre del procedimiento [ObtenerDatos]
        dgvReporte196.DataSource = dtRepo196 ''Muestra los datos en la grilla
        tabReportes.SelectedIndex = 0 '' nos Manda para la grilla del Reporte 196

    End Sub

    ''Aqui se comienzaa buscar por fecha de DESDE a HASTA del boton "ICT" del reporte 1.96
    Private Sub btnAbrirICT_Click(sender As Object, e As EventArgs) Handles btnAbrirICT.Click
        Dim desde As DateTime = dtpDesdeIct.Value

        If clsDatos.ExisteCalculoICT(desde) Then
            Dim Cargar As Integer = MessageBox.Show("El calculo ya esta generado en la Base de Datos" & vbCrLf & "¿Deseas volver a cargarlo?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'PREGUNTAR SI DESEA GUARDAR
            If Cargar = 6 Then
                'Carga_TeoricoICT(dtTeoricoICT_datos)
                Dim frm As Form = GetFormByName("frmICT") ''[frmICT] es el nombre del formulario 
                ''
                If (frm Is Nothing) Then
                    Dim frmObj As New frmICT
                    frmObj.reciveDesde = desde
                    ' frmObj.reciveHasta = hasta
                    frmObj.ShowDialog()
                Else
                    frm.Select()
                End If

            Else
                MessageBox.Show("Operación cancelada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Else
            'GUARDAR
            'Carga_TeoricoICT(dtTeoricoICT_datos)
            Dim frm As Form = GetFormByName("frmICT") ''[frmICT] es el nombre del formulario 
            ''
            If (frm Is Nothing) Then
                Dim frmObj As New frmICT
                frmObj.reciveDesde = desde
                ' frmObj.reciveHasta = hasta
                frmObj.ShowDialog()
            Else
                frm.Select()
            End If
        End If



    End Sub

    Public Function GetFormByName(ByVal formName As String) As Form ''No vuelve a abrir otro formulario si ya se esta ejecutando
        If (formName = String.Empty) Then Return Nothing
        For Each frm As Form In System.Windows.Forms.Application.OpenForms
            If (frm.Name.ToUpperInvariant() = formName.ToUpperInvariant()) Then
                ' Devolvemos la referencia del formulario.
                '
                Return frm
            End If
        Next
        ' No está abierto el formulario especificado
        '
        Return Nothing

    End Function

    Private Function LeerDocumentoExel(ByVal nombre_exel As String) As DataTable
        Dim xlApp As Excel.Application ' PRoviene del SO que contiene los DLL que necesitamos para abrir el archiv excel 
        Dim xlWorkBook As Excel.Workbook 'Aqui declara el libro  
        Dim xlWorkSheet As Excel.Worksheet 'Aqui declara la hoja

        Dim dtContar As New DataTable("Source") ''es una especie de tabla virtual(se almacena en el cache osea solo cuando se trabaja o ejecutando) donde se almacenan datos 

        dtContar.Columns.Add("TIPO_DIA", GetType(String)) 'aqui agregamos las columnas al datatable
        dtContar.Columns.Add("ZONA", GetType(String))
        dtContar.Columns.Add("SERVICIO", GetType(String))
        dtContar.Columns.Add("SENTIDO", GetType(String))
        dtContar.Columns.Add("MEDIA_HORA", GetType(String))
        dtContar.Columns.Add("PK_TEORICO", GetType(Double))
        dtContar.Columns.Add("DESDE", GetType(Date))
        dtContar.Columns.Add("HASTA", GetType(Date)) ''
        Try
            ''
            xlApp = New Excel.Application ''Aqui levanta la aplicacion y la deja en la cache
            xlWorkBook = xlApp.Workbooks.Open(nombre_exel) 'Aqui levanta el libro
            ''
            xlWorkSheet = xlWorkBook.Worksheets(1) ''Aqui declaramos la hoja 1 que vamos a trabajar
            ''

            Dim intCantFilas As Integer = xlWorkSheet.Rows.Count
            Dim intContador As Int32 = 0
            For index = 2 To intCantFilas

                'xlWorkSheet.Cells(29, 3).value = dou_max_dist_inte_ida
                'xlWorkSheet.Cells(29, 4).value = dou_max_dist_inte_ret
                Dim stg_TipoDia As String = Trim(xlWorkSheet.Cells(index, 1).value) ''obtiene el dato de la celda
                Dim stg_Zona As String = Trim(xlWorkSheet.Cells(index, 2).value) 'Fila, Columna
                Dim stg_servicio As String = Trim(xlWorkSheet.Cells(index, 3).value)
                Dim stg_sentido As String = Trim(xlWorkSheet.Cells(index, 4).value)
                ''

                'Dim stg_media_hora As String = Trim(xlWorkSheet.Cells(index, 5).value)
                'Dim stg_media_hora_parseado As Date = Date.FromOADate(stg_media_hora)''Aqui esta cambiad a formato hora
                'Dim hora As String = Format(stg_media_hora_parseado, "hh:mm:ss")
                Dim stg_media_hora As String = Trim(xlWorkSheet.Cells(index, 5).value)

                ''
                Dim stg_pk_teorico As String = Trim(xlWorkSheet.Cells(index, 6).value)
                Dim stg_desde As String = Trim(xlWorkSheet.Cells(index, 7).value)
                Dim stg_hasta As String = Trim(xlWorkSheet.Cells(index, 8).value)
                ''
                Dim nueva_fila As DataRow = dtContar.NewRow() ''Tamos creando una nueva fila para el data table
                ''
                ''
                If (xlWorkSheet.Cells(index, 1).value) <> String.Empty Then
                    nueva_fila("TIPO_DIA") = stg_TipoDia ''pasando el dato a la fila
                End If
                ''
                If (xlWorkSheet.Cells(index, 2).value) <> String.Empty Then
                    nueva_fila("ZONA") = stg_Zona
                End If
                ''
                If stg_servicio <> String.Empty Then
                    nueva_fila("SERVICIO") = stg_servicio
                End If
                ''
                If stg_sentido <> String.Empty Then
                    nueva_fila("SENTIDO") = stg_sentido
                End If
                ''
                If IsNumeric(Trim(xlWorkSheet.Cells(index, 5).value)) Then
                    Dim stg_media_hora_parseado As Date
                    stg_media_hora_parseado = Date.FromOADate(stg_media_hora)
                    Dim hora As String = stg_media_hora_parseado.TimeOfDay.ToString
                    nueva_fila("MEDIA_HORA") = hora
                End If
                ''
                If IsNumeric(stg_pk_teorico) Then 'el isnumeric solo dejara ingresar numeros numericos
                    nueva_fila("PK_TEORICO") = stg_pk_teorico
                End If
                ''
                If IsDate(stg_desde) Then
                    nueva_fila("DESDE") = CDate(stg_desde)
                End If
                ''
                If IsDate(stg_hasta) Then
                    nueva_fila("HASTA") = CDate(stg_hasta)
                End If
                ''
                If Not IsDBNull(nueva_fila("TIPO_DIA")) And Not IsDBNull(nueva_fila("ZONA")) And Not IsDBNull(nueva_fila("SERVICIO")) And Not IsDBNull(nueva_fila("SENTIDO")) And Not IsDBNull(nueva_fila("MEDIA_HORA")) And Not IsDBNull(nueva_fila("PK_TEORICO")) And Not IsDBNull(nueva_fila("DESDE")) And Not IsDBNull(nueva_fila("HASTA")) Or Not IsDBNull(nueva_fila("TIPO_DIA")) And IsDBNull(nueva_fila("ZONA")) And Not IsDBNull(nueva_fila("SERVICIO")) And Not IsDBNull(nueva_fila("SENTIDO")) And Not IsDBNull(nueva_fila("MEDIA_HORA")) And Not IsDBNull(nueva_fila("PK_TEORICO")) And Not IsDBNull(nueva_fila("DESDE")) And Not IsDBNull(nueva_fila("HASTA")) Or IsDBNull(nueva_fila("TIPO_DIA")) And Not IsDBNull(nueva_fila("ZONA")) And Not IsDBNull(nueva_fila("SERVICIO")) And Not IsDBNull(nueva_fila("SENTIDO")) And Not IsDBNull(nueva_fila("MEDIA_HORA")) And Not IsDBNull(nueva_fila("PK_TEORICO")) And Not IsDBNull(nueva_fila("DESDE")) And Not IsDBNull(nueva_fila("HASTA")) Then

                    dtContar.Rows.Add(nueva_fila) 'Aqui agregamos fila al data table
                Else
                    intContador += 1 'Contamos la cantidad de filas vacias

                    If intContador >= 2 Then 'Si las filas vacias se repiten 2 veces entonces que salga del siclo
                        Exit For
                    End If

                End If

            Next
            ''
            'edit the cell with new value
            xlApp.Visible = False
            xlWorkBook.Save()
            xlWorkBook.Close()
            xlApp.Quit()
            ''
        Catch ex As Exception
            'edit the cell with new value
            'xlApp.Visible = False
            'xlWorkBook.Save()
            'xlWorkBook.Close()
            'xlApp.Quit()
            Throw
        End Try
        Return dtContar
    End Function

    ''Boton CARGAR para abrir los archivos excel del TeoricoICT
    Private Sub btnCargarIndice_Click(sender As Object, e As EventArgs) Handles btnCargarIndice.Click
        Dim dtExcel As New DataTable
        ''
        dgvIndice.DataSource = Nothing
        ''
        Try
            ofdExcel.Filter = "Archivos Excel |*.xls;*.xlsx" ''OpenFileDialog es ofdExcel para buscar el archivo
            If ofdExcel.ShowDialog = DialogResult.OK Then 'Aqui se obtiene la ruta del archivo
                dtExcel = LeerDocumentoExel(ofdExcel.FileName) ''Aqui se llama la funcion que obtiene los datos del excel
                dgvIndice.DataSource = dtExcel
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnTeoricoICT_Click(sender As Object, e As EventArgs) Handles btnTeoricoICT.Click
        Dim c As Cursor = Me.Cursor
        Dim dtTeoricoICT_datos As New DataTable
        Try
            Me.Cursor = Cursors.WaitCursor
            dtTeoricoICT_datos = DirectCast(dgvIndice.DataSource, DataTable) 'Obteniendo el dato de la grilla
            ''
            ''Validar si Grilla contiene datos
            If Me.dgvIndice.RowCount = 0 Then
                MessageBox.Show("No hay datos para inserta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                'Conectart con funcion que valida y genera una respuesta en la base de datos
                If clsDatos.Existe_teoricoICT(dtTeoricoICT_datos) Then
                    Dim Cargar As Integer = MessageBox.Show("El archivo ya existe en la Base de Datos" & vbCrLf & "¿Deseas volver a cargar?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    'PREGUNTAR SI DESEA GUARDAR
                    If Cargar = 6 Then
                        Carga_TeoricoICT(dtTeoricoICT_datos)
                    Else
                        MessageBox.Show("Operación cancelada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                Else
                    'GUARDAR
                    Carga_TeoricoICT(dtTeoricoICT_datos)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' Restauramos el cursor
            Me.Cursor = c
        End Try

    End Sub

    Private Sub Carga_TeoricoICT(ByVal dtTeoricoICT As DataTable) ''Recibiendo los datos del TeoricoICT
        ''PRIVATE SUB es un procedimiento
        Dim dtRespuesta As New DataTable
        Dim msje As String = Nothing


        ''
        dtRespuesta = clsDatos.GuardarTeoricoICT(dtTeoricoICT)
        ''
        If dtRespuesta.Rows.Count > 0 Then

            Dim ResBoolean As Boolean = False 'Creamos una variable tipo Boolean

            For Each row In dtRespuesta.Rows
                Dim nmroRespuesta As Integer = Convert.ToInt32(row("NumError"))
                Dim stgTipoResta As String = Convert.ToString(row("TipoError"))
                Dim stgRespuesta As String = Convert.ToString(row("Error"))
                ''
                If nmroRespuesta = 1 Then ' Si numero Que esta en el procedimiento Almacenado(NumError) es igual a 1
                    ResBoolean = True 'Cambiamos la respuesta a verdadero para que inserte datos
                End If
                ''
                msje += stgRespuesta & " - " & stgTipoResta & vbCrLf

            Next
            '
            MessageBox.Show(msje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '
            ''Validar respuesta para limpiar los datos
            If ResBoolean = True Then 'Si la respuesta del boolean es verdadera
                dgvIndice.Columns.Clear() 'Entoncesque borre el DataGribview
            End If

        End If

    End Sub

    ''Cargar Archivo Plaza
    Private Function LeerExcelPlaza(ByVal nombre_exel_plaza As String) As DataTable

        Dim xlApp As Excel.Application ' PRoviene del SO que contiene los DLL que necesitamos para abrir el archiv excel 
        Dim xlWorkBook As Excel.Workbook 'Aqui declara el libro  
        Dim xlWorkSheet As Excel.Worksheet 'Aqui declara la hoja

        Dim dtContar As New DataTable("Source")
        dtContar.Columns.Add("NUMERO_INTERNO", GetType(String)) 'aqui agregamos las columnas al datatable
        dtContar.Columns.Add("PPU", GetType(String))
        dtContar.Columns.Add("PLAZAS", GetType(Integer))

        Try

            xlApp = New Excel.Application ''Aqui levanta la aplicacion y la deja en la cache
            xlWorkBook = xlApp.Workbooks.Open(nombre_exel_plaza) 'Aqui levanta el libro
            xlWorkSheet = xlWorkBook.Worksheets(1) ''Aqui declaramos la hoja 1 que vamos a trabajar

            Dim intCantFilas As Integer = xlWorkSheet.Rows.Count
            Dim intContador As Int32 = 0

            For index = 2 To intCantFilas

                Dim stg_nmro_interno As String = Trim(xlWorkSheet.Cells(index, 1).value) ''obtiene el dato de la celda
                Dim stg_ppu As String = Trim(xlWorkSheet.Cells(index, 2).value) 'Fila, Columna
                Dim stg_plazas As Integer = 0 ' Trim(xlWorkSheet.Cells(index, 3).value)

                Dim nueva_fila As DataRow = dtContar.NewRow() ''Tamos creando una nueva fila para el data table
                ''
                'If Trim(xlWorkSheet.Cells(index, 1).value) <> String.Empty Then
                '    nueva_fila("NUMERO_INTERNO") = stg_nmro_interno
                'End If
                ' ''
                'If Trim(xlWorkSheet.Cells(index, 2).value) <> String.Empty Then
                '    nueva_fila("PPU") = stg_ppu
                'End If
                ' ''
                If IsNumeric(Trim(xlWorkSheet.Cells(index, 3).value)) Then
                    stg_plazas = Trim(xlWorkSheet.Cells(index, 3).value)
                    nueva_fila("PLAZAS") = stg_plazas
                End If
                ' ''
                If stg_nmro_interno <> String.Empty Then
                    nueva_fila("NUMERO_INTERNO") = stg_nmro_interno ''pasando el dato a la fila
                End If
                ''
                If stg_ppu <> String.Empty Then
                    nueva_fila("PPU") = stg_ppu ''pasando el dato a la fila
                End If
                ''
                'If (xlWorkSheet.Cells(index, 3).value) <> String.Empty Then
                '    nueva_fila("PLAZAS") = stg_plazas ''pasando el dato a la fila
                'End If
                ''
                If Not IsDBNull(nueva_fila("NUMERO_INTERNO")) And Not IsDBNull(nueva_fila("PPU")) And Not IsDBNull(nueva_fila("PLAZAS")) Then
                    dtContar.Rows.Add(nueva_fila) 'Aqui agregamos fila al data table
                Else
                    Exit For
                End If



            Next
            ''
            xlApp.Visible = False
            xlWorkBook.Save()
            xlWorkBook.Close()
            xlApp.Quit()

        Catch ex As Exception
            Throw
            xlWorkBook.Close()
            xlApp.Quit()
        End Try
        Return dtContar
    End Function

    Private Sub btnCargarPlaza_Click(sender As Object, e As EventArgs) Handles btnCargarPlaza.Click
        Dim dtExcel As New DataTable
        Dim c As Cursor = Me.Cursor

        dgvPlaza.DataSource = Nothing

        Try

            'dtReportePlaza_datos = DirectCast(dgvPlaza.DataSource, DataTable)

            ofdExcel.Filter = "Archivos Excel |*.xls;*.xlsx" ''OpenFileDialog es ofdExcel para buscar el archivo
            ''
            Dim Cargar As Integer = MessageBox.Show("leer documento excel plazas kilometros " & vbCrLf & "¿Desea cargar datos?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            '
            'PREGUNTAR SI DESEA GUARDAR
            If Cargar = 7 Then
                Exit Try
            End If

            '
            If ofdExcel.ShowDialog = DialogResult.OK Then 'Aqui se obtiene la ruta del archivo
                dtExcel = LeerExcelPlaza(ofdExcel.FileName) ''Aqui se llama la funcion que obtiene los datos del excel

                'Validar que allan datos para guardar osea que no este vacio el exel
                If dtExcel.Rows.Count = 0 Then

                    MessageBox.Show("El exel no tiene datos", "Cuidado")

                Else
                    'GUARDAR
                    Carga_reportePlaza(dtExcel)

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' Restauramos el cursor
            Me.Cursor = c
        End Try

    End Sub

    Private Sub Carga_reportePlaza(ByVal dtRepotePlaza As DataTable) ''Recibiendo los datos del reporte 1.96
        Dim intRespuestaPlaza As Integer = 0
        ''
        intRespuestaPlaza = clsDatos.GuardarReportePlaza(dtRepotePlaza) ''se llama desde la clase clsDatos
        ''
        If intRespuestaPlaza > 0 Then
            MessageBox.Show("Datos cargados con éxito", "Respuesta")
        ElseIf intRespuestaPlaza = 0 Then
            MessageBox.Show("No llegaron los datos", "Respuesta")
        Else
            MessageBox.Show("Error al intentar guardar", "Respuesta")
        End If
    End Sub

    ''Ve si hay otro formulario en ejecucion
    Public Function GetForm(ByVal formName As String) As Form ''No vuelve a abrir otro formulario si ya se esta ejecutando
        If (formName = String.Empty) Then Return Nothing
        For Each form As Form In System.Windows.Forms.Application.OpenForms
            If (form.Name.ToUpperInvariant() = formName.ToUpperInvariant()) Then
                ' Devolvemos la referencia del formulario.
                '
                Return form
            End If
        Next
        ' No está abierto el formulario especificado
        '
        Return Nothing

    End Function

    Private Sub btnActualizaDatos_Click(sender As Object, e As EventArgs) Handles btnActualizaDatos.Click
        Dim dtPlaza As New DataTable

        If dgvPlaza.RowCount > 0 And dgvPlaza.CurrentRow IsNot Nothing Then
            ''
            Dim form As Form = GetForm("frmActualizarPlaza")
            ''
            ModVariablesGlobales.intRespuetaPatente = 0
            ''
            If (form Is Nothing) Then
                Dim frmObj As New frmActualizarPlaza
                frmObj.recibeIDPlaza = dgvPlaza.CurrentRow.Cells(0).Value.ToString()
                frmObj.recibeNmro = dgvPlaza.CurrentRow.Cells(1).Value.ToString()
                frmObj.recibePPU = dgvPlaza.CurrentRow.Cells(2).Value.ToString()
                frmObj.recibePlaza = dgvPlaza.CurrentRow.Cells(3).Value.ToString()
                frmObj.ShowDialog()
                ''
                If ModVariablesGlobales.intRespuetaPatente > 0 Then
                    ''Aqui actualiza el DataGrib Plaza (dgvPlaza)
                    dtPlaza = clsDatos.ObtenerDataGenerales(7, 0) ''El 7 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el 0 significa que no le pasamos nada 
                    dgvPlaza.DataSource = dtPlaza ''Almacenamos los datos en la grilla de Plaza
                End If
            Else
                form.Select()
            End If

        End If

    End Sub

    ''Aqui abrimos el nuevo formulario para insertar nuevos datos
    Private Sub btnInsertarPlaza_Click(sender As Object, e As EventArgs) Handles btnInsertarPlaza.Click
        Dim dtPlaza As New DataTable
        ''
        Dim frm As Form = GetFormByName("frmInsertarPlaza") ''[frmInsertarPlaza] es el nombre del formulario 
        ''
        ModVariablesGlobales.intRespuetaPatente = 0
        ''
        If (frm Is Nothing) Then
            Dim frmObj As New frmInsertarPlaza
            ''
            frmObj.ShowDialog()
            ''
            If ModVariablesGlobales.intRespuetaPatente > 0 Then
                ''Aqui actualiza el DataGrib Plaza (dgvPlaza)
                dtPlaza = clsDatos.ObtenerDataGenerales(7, 0) ''El 7 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el 0 significa que no le pasamos nada 
                dgvPlaza.DataSource = dtPlaza ''Almacenamos los datos en la grilla de Plaza
                dgvPlaza.Columns(0).Visible = False 'Ocular columna del datagridView
            End If
        Else
            frm.Select()
        End If


    End Sub

    ''Ve si hay otro formulario en ejecucion
    Public Function GetFormInsertarPlaza(ByVal formName As String) As Form ''No vuelve a abrir otro formulario si ya se esta ejecutando
        If (formName = String.Empty) Then Return Nothing
        For Each form As Form In System.Windows.Forms.Application.OpenForms
            If (form.Name.ToUpperInvariant() = formName.ToUpperInvariant()) Then
                ' Devolvemos la referencia del formulario.
                '
                Return form
            End If
        Next
        ' No está abierto el formulario especificado
        '
        Return Nothing

    End Function

    ''Eliminar el dato en la GRILLA de Plaza
    Private Sub btnEliminarPlaza_Click(sender As Object, e As EventArgs) Handles btnEliminarPlaza.Click
        Dim dtPlaza As New DataTable
        Dim idPlaza As Integer
        ''
        Try
            If dgvPlaza.RowCount > 0 And dgvPlaza.CurrentRow IsNot Nothing Then
                ''
                idPlaza = dgvPlaza.CurrentRow.Cells(0).Value.ToString()
                ''
                'ModVariablesGlobales.intRespuetaPatente = 0
                ''
                ModVariablesGlobales.intRespuetaPatente = clsDatos.CRUDPlaza(3, idPlaza, 0, 0, 0)
                ''
                If ModVariablesGlobales.intRespuetaPatente > 0 Then
                    ''Aqui actualiza el DataGrib Plaza (dgvPlaza)
                    MessageBox.Show("Datos Borrados con exito ", "Cantidad")
                    dtPlaza = clsDatos.ObtenerDataGenerales(7, 0) ''El 7 es la opcion que se almacena en el procedimiento almacenado [ObtenerDatos] y el 0 significa que no le pasamos nada 
                    dgvPlaza.DataSource = dtPlaza ''Almacenamos los datos en la grilla de Plaza
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnferiados_Click(sender As Object, e As EventArgs) Handles btnferiados.Click
        'txtFeriado.Text = dtpferiado.Value.ToString("dddd")
        Dim dtferiados As DataTable
        Try
            ModVariablesGlobales.intRespuetaFeriado = 0
            If cboFeriado IsNot Nothing Then
                Dim dtpFechaFeriado As Date = dtpferiado.Value
                Dim id_tipo_dia As Integer = 0
                id_tipo_dia = DirectCast(cboFeriado.SelectedItem, KeyValuePair(Of Integer, String)).Key ''Tomamos El ID del ComboBox del item que seleccionamos
                ModVariablesGlobales.intRespuetaFeriado = clsDatos.Feriados(1, 0, dtpFechaFeriado, id_tipo_dia)

                If ModVariablesGlobales.intRespuetaFeriado = 0 Then
                    MessageBox.Show("La fecha ya existe en la base de datos", "Cantidad")
                ElseIf ModVariablesGlobales.intRespuetaFeriado < 0 Then
                    MessageBox.Show("No llearon los datos", "Cantidad")
                Else
                    MessageBox.Show("Fecha insertada con exito", "Cantidad")
                    dtferiados = clsDatos.ObtenerDataGenerales(9, 0)
                    dgvferiados.DataSource = dtferiados
                    dgvferiados.Columns(0).Visible = False
                    tabReportes.SelectedIndex = 4
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''Ver fechas de Feriados tomados
    Private Sub btnVerFechas_Click(sender As Object, e As EventArgs) Handles btnVerFechas.Click

        Dim dtFeriados As DataTable
        dtFeriados = clsDatos.ObtenerDataGenerales(9, 0)
        dgvferiados.DataSource = dtFeriados
        dgvferiados.Columns(0).Visible = False
        tabReportes.SelectedIndex = 4

    End Sub

    ''Elminar Fechas de feriados
    Private Sub btnEliminarFeriado_Click(sender As Object, e As EventArgs) Handles btnEliminarFeriado.Click
        Dim dtferiados As DataTable
        Dim id_feriado As Integer
        Dim dtpFechaFeriado As Date = dtpferiado.Value
        Try
            ModVariablesGlobales.intRespuetaFeriado = 0
            If dgvferiados.RowCount > 0 And dgvferiados.CurrentRow IsNot Nothing Then

                id_feriado = dgvferiados.CurrentRow.Cells(0).Value.ToString()
                ModVariablesGlobales.intRespuetaFeriado = clsDatos.Feriados(2, id_feriado, dtpFechaFeriado, 0)

                If ModVariablesGlobales.intRespuetaFeriado > 0 Then
                    MessageBox.Show("Dato borrado con exito", "Cantidad")
                    dtferiados = clsDatos.ObtenerDataGenerales(9, 0)
                    dgvferiados.DataSource = dtferiados
                Else
                    MessageBox.Show("No llegaron los datos", "Cantidad")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CargarFecha()
        txtFeriado.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpferiado.Value.ToString("dddd"))

    End Sub

    Private Sub dtpferiado_ValueChanged(sender As Object, e As EventArgs) Handles dtpferiado.ValueChanged
        txtFeriado.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpferiado.Value.ToString("dddd"))

    End Sub

    Private Sub txtFeriado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeriado.KeyPress
        e.Handled = Char.IsWhiteSpace(e.KeyChar)
    End Sub

End Class
