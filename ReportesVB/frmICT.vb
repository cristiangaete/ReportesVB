Public Class frmICT

    Public reciveDesde As DateTime
    Private listIntervalos As New List(Of String)

    Private Sub frmICT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtDatos As New DataTable
        Dim traer_desde As DateTime

        traer_desde = reciveDesde
        ''
        listIntervalos.Add("00:00:00")
        listIntervalos.Add("00:30:00")
        listIntervalos.Add("01:00:00")
        listIntervalos.Add("01:30:00")
        listIntervalos.Add("02:00:00")
        listIntervalos.Add("02:30:00")
        listIntervalos.Add("03:00:00")
        listIntervalos.Add("03:30:00")
        listIntervalos.Add("04:00:00")
        listIntervalos.Add("04:30:00")
        listIntervalos.Add("05:00:00")
        listIntervalos.Add("05:30:00")
        listIntervalos.Add("06:00:00")
        listIntervalos.Add("06:30:00")
        listIntervalos.Add("07:00:00")
        listIntervalos.Add("07:30:00")
        listIntervalos.Add("08:00:00")
        listIntervalos.Add("08:30:00")
        listIntervalos.Add("09:00:00")
        listIntervalos.Add("09:30:00")
        listIntervalos.Add("10:00:00")
        listIntervalos.Add("10:30:00")
        listIntervalos.Add("11:00:00")
        listIntervalos.Add("11:30:00")
        listIntervalos.Add("12:00:00")
        listIntervalos.Add("12:30:00")
        listIntervalos.Add("13:00:00")
        listIntervalos.Add("13:30:00")
        listIntervalos.Add("14:00:00")
        listIntervalos.Add("14:30:00")
        listIntervalos.Add("15:00:00")
        listIntervalos.Add("15:30:00")
        listIntervalos.Add("16:00:00")
        listIntervalos.Add("16:30:00")
        listIntervalos.Add("17:00:00")
        listIntervalos.Add("17:30:00")
        listIntervalos.Add("18:00:00")
        listIntervalos.Add("18:30:00")
        listIntervalos.Add("19:00:00")
        listIntervalos.Add("19:30:00")
        listIntervalos.Add("20:00:00")
        listIntervalos.Add("20:30:00")
        listIntervalos.Add("21:00:00")
        listIntervalos.Add("21:30:00")
        listIntervalos.Add("22:00:00")
        listIntervalos.Add("22:30:00")
        listIntervalos.Add("23:00:00")
        listIntervalos.Add("23:30:00")
        ''
        dtDatos = Traer_DatosFecha(traer_desde) ''Almacenamos las fechas en el DataTable
        ' dtDatos = DirectCast(dtgFrmICT.DataSource, DataTable)

    End Sub

    Private Function Traer_DatosFecha(ByVal Desde As Date) As DataTable
        Dim dtResultado As New DataTable

        Try

            dtResultado = clsDatos.CalculoPkReal(Desde)
            '' Dim row As DataRow = dtResultado.Rows(dtResultado.Rows.Count - 1)
            If dtResultado.Columns.Count > 0 Then


                'For Each columna In dtResultado.Columns

                '    '    If row.Item("neteado").ToString() = "" Then
                '    '    Else
                '    '        Dim neteado As Double = CDbl(row("neteado")).ToString("0.00")
                '    '        row(3) = neteado
                '    '    End If
                'Next

            End If

            dgvFrmICT.DataSource = dtResultado
            dgvFrmICT.Columns(2).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(3).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(4).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(5).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(6).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(7).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(8).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(9).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(10).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(11).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(12).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(13).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(14).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(15).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(16).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(17).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(18).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(19).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(20).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(21).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(22).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(23).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(24).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(25).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(26).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(27).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(28).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(29).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(30).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(31).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(32).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(33).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(34).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(35).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(36).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(37).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(38).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(39).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(40).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(41).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(42).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(43).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(44).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(45).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(46).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(47).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(48).DefaultCellStyle.Format = "0.00%"
            dgvFrmICT.Columns(49).DefaultCellStyle.Format = "0.00%"


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dtResultado
    End Function

    Private Sub dgvFrmICT_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvFrmICT.CellFormatting
        Try
            If listIntervalos.Contains(dgvFrmICT.Columns(e.ColumnIndex).Name) Then 'dgvFrmICT.Columns(e.ColumnIndex).Name = "neteado"
                If Not IsDBNull(e.Value) Then 'Not IsDBNull(e.Value.GetType())

                    If Convert.ToDouble(e.Value) >= 0.98 Then
                        e.CellStyle.ForeColor = Color.Green
                    ElseIf Convert.ToDouble(e.Value) >= 0.94 And Convert.ToDouble(e.Value) < 0.98 Then
                        e.CellStyle.ForeColor = Color.Yellow
                        e.CellStyle.ForeColor = Color.Orange
                    Else
                        e.CellStyle.ForeColor = Color.Red
                    End If

                End If

            End If

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        llenarExcel(dgvFrmICT)
    End Sub
End Class