Public Class frmInsertarPlaza

    Private Sub frmInsertarPlaza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInsertarPlaza_Click(sender As Object, e As EventArgs) Handles btnInsertarPlaza.Click
        Dim ok As Boolean = True
        Dim nmro As String
        Dim ppu As String
        Dim plaza As Integer
        ''
        If txtInsertarNumeroInterno.TextLength > 0 Then
            nmro = txtInsertarNumeroInterno.Text
        Else
            Exit Sub
        End If
        ''
        If txtPPUInsert.TextLength > 0 Then
            ppu = txtPPUInsert.Text
        Else
            Exit Sub
        End If
        ''
        If txtPlazaInsertar.TextLength > 0 Then
            plaza = txtPlazaInsertar.Text
        Else
            Exit Sub
        End If


        Try
            ModVariablesGlobales.intRespuetaPatente = InsertarDatosPlaza(nmro, ppu, plaza)
            If ModVariablesGlobales.intRespuetaPatente > 0 Then
                Me.Close()

                MessageBox.Show("Datos Insertados con exito ", "Cuidado")
            Else
                MessageBox.Show("No se pudo Insertar los datos ", "Cuidado")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Function InsertarDatosPlaza(ByVal numero As String, ByVal ppu As String, ByVal plaza As Integer)
        Dim intResultado As Integer

        Try

            intResultado = clsDatos.CRUDPlaza(2, 0, numero, ppu, plaza)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return intResultado

    End Function

    Private Sub txtPlazaInsertar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlazaInsertar.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtPlazaInsertar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPlazaInsertar.Validating
        If txtPlazaInsertar.Text.Length = 0 Then
            Me.ErrorInsertarPlaza.SetError(txtPlazaInsertar, "El campo esta vacio")
            e.Cancel = True

        ElseIf txtPlazaInsertar.Text > 250 Then
            Me.ErrorInsertarPlaza.SetError(txtPlazaInsertar, "El numero no puede ser mayor a 250")
            e.Cancel = True

        Else
            Me.ErrorInsertarPlaza.SetError(txtPlazaInsertar, "")

        End If

    End Sub

    Private Sub txtInsertarNuevo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtInsertarNumeroInterno.Validating
        If txtInsertarNumeroInterno.Text.Length = 0 Then
            Me.ErrorInsertarPlaza.SetError(txtInsertarNumeroInterno, "El campo esta vacio")
            e.Cancel = True
        Else
            Me.ErrorInsertarPlaza.SetError(txtInsertarNumeroInterno, "")
        End If
    End Sub

    Private Sub txtPPUInsert_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPPUInsert.Validating
        If txtPPUInsert.Text.Length = 0 Then
            Me.ErrorInsertarPlaza.SetError(txtPPUInsert, "El campo esta vacio")
            e.Cancel = True
        Else
            Me.ErrorInsertarPlaza.SetError(txtPPUInsert, "")

        End If

    End Sub


    ''Evitar que ingrecen espacios en blancos
    Private Sub txtInsertarNumeroInterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInsertarNumeroInterno.KeyPress
        e.Handled = Char.IsWhiteSpace(e.KeyChar)
    End Sub
    ''Evitar que ingrecen espacios en blancos
    Private Sub txtPPUInsert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPUInsert.KeyPress
        e.Handled = Char.IsWhiteSpace(e.KeyChar)
    End Sub


End Class