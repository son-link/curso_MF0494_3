Module Module1
    Public numero As Integer
    Public turnos As Integer
    Public Function iniciar(ByVal t As Integer) As Boolean
        AdivinaNumero.labelMayorMenor.Text = ""
        Randomize()
        numero = 200 * Rnd() + 1
        turnos = t
        AdivinaNumero.txtIntentos.Text = "Le quedan " & turnos & " intentos"
    End Function

    Public Function compNumero() As Boolean
        Dim N As Integer
        If IsNumeric(AdivinaNumero.txtNumero.Text) Then
            N = CInt(AdivinaNumero.txtNumero.Text)
            If N > 0 And N <= 200 Then
                If AdivinaNumero.txtNumero.Text = numero Then
                    If MsgBox("HAS ACERTADO" & vbNewLine & "¿Quieres jugar otra vez?", MsgBoxStyle.RetryCancel, "HAS ACERTADO") = vbRetry Then
                        inicio.Show()
                    Else
                        salir()
                    End If
                ElseIf N < numero Then
                    AdivinaNumero.labelMayorMenor.Text = "Más alto"
                    turnos = turnos - 1
                ElseIf N > numero Then
                    AdivinaNumero.labelMayorMenor.Text = "Más bajo"
                    turnos = turnos - 1
                End If
                AdivinaNumero.txtIntentos.Text = "Le quedan " & turnos & " intentos"
                If turnos = 0 Then
                    If MsgBox("HAS PERDIDO" & vbNewLine & "¿Quieres jugar otra vez?", MsgBoxStyle.RetryCancel, "HAS PERDIDO") = vbRetry Then
                        inicio.Show()
                    Else
                        salir()
                    End If
                End If
            End If
        Else
            AdivinaNumero.txtNumero.Text = ""
        End If
        
    End Function

    Public Function salir() As Boolean
        End
    End Function
End Module
