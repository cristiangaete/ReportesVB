Public Class frmActualizarPlaza

    Public recibeNmro As String
    Public recibePPU As String
    Public recibePlaza As Integer
    Public recibeIDPlaza As Integer
    'la variable public se puede usar en cualquier clase

    Private Sub frmActualizarPlaza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumeroInterno.Text = recibeNmro
        txtPPU.Text = recibePPU
        txtPlaza.Text = recibePlaza

    End Sub
    Private Function TraerDatosPlaza(ByVal idplaza As Integer, ByVal numero As String, ByVal ppu As String, ByVal plaza As Integer)
        Dim intResultado As Integer

        Try

            intResultado = clsDatos.CRUDPlaza(1, idplaza, numero, ppu, plaza)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return intResultado
    End Function

    Private Sub btnActualizarPlaza_Click(sender As Object, e As EventArgs) Handles btnActualizarPlaza.Click

        Dim nmro As String
        Dim ppu As String
        Dim plaza As Integer
        Dim idplaza As Integer
        ''
        If txtNumeroInterno.TextLength > 0 Then
            nmro = txtNumeroInterno.Text
        Else
            Exit Sub
        End If
        ''
        If txtPPU.TextLength > 0 Then
            ppu = txtPPU.Text
        Else
            Exit Sub
        End If
        ''
        If txtPlaza.TextLength > 0 Then
            plaza = txtPlaza.Text
        Else
            Exit Sub
        End If

        idplaza = recibeIDPlaza
        '
        Try
            ModVariablesGlobales.intRespuetaPatente = TraerDatosPlaza(idplaza, nmro, ppu, plaza)
            ''
            If ModVariablesGlobales.intRespuetaPatente > 0 Then
                Me.Close()
                ''
                MessageBox.Show("Datos actualizados con exito ", "Cantidad")
            Else
                MessageBox.Show("No se pudo actualizar los datos ", "Cantidad")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''Validar que solo Entren Numeros y permita borrar
    Private Sub txtPlaza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlaza.KeyPress ''Se produce cuando se presiona una tecla de espacio o retroceso mientras el control tiene el foco.

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)


    End Sub

    ''Validar que no ingresen espacion en blancos
    Private Sub txtPPU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPU.KeyPress ''Se produce cuando se presiona una tecla de espacio o retroceso mientras el control tiene el foco.
        e.Handled = Char.IsWhiteSpace(e.KeyChar)
    End Sub

    ''Validar que no ingresen espacion en blancos
    Private Sub txtNumeroInterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroInterno.KeyPress
        ' Me.tbxNumeroInterno.CharacterCasing = CharacterCasing.Upper ''PARA ingresar solo mayusculas
        'If Char.IsLetter(e.KeyChar) Then

        '    e.KeyChar = Char.ToUpper(e.KeyChar)
        'End If
        e.Handled = Char.IsWhiteSpace(e.KeyChar)
    End Sub

    Private Sub txtPlaza_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPlaza.Validating
        If txtPlaza.Text.Length = 0 Then
            Me.ErrorActualizarPlaza.SetError(txtPlaza, "El campo no tiene datos") ''muestra el icono
            e.Cancel = True
        ElseIf txtPlaza.Text > 250 Then
            Me.ErrorActualizarPlaza.SetError(txtPlaza, "El numero no puede ser mayor a 250") ''muestra el icono
            e.Cancel = True
        Else
            Me.ErrorActualizarPlaza.SetError(txtPlaza, "") ''No muestra el icono
        End If

    End Sub

    Private Sub txtNumeroInterno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroInterno.Validating
        If txtNumeroInterno.Text.Length = 0 Then
            Me.ErrorActualizarPlaza.SetError(txtNumeroInterno, "El campo no tiene datos") ''muestra el icono
            e.Cancel = True
        Else
            Me.ErrorActualizarPlaza.SetError(txtNumeroInterno, "")
        End If

    End Sub
End Class