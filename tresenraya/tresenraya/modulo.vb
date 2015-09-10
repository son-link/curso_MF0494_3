Module modulo
    Public TurnoDe As String
    Public TurnoNumero As Integer

    Public Function compTurno(ByVal button As Object) As String
        If TurnoDe = "X" Then
            button.Text = "X"
            If Not compGanador() Then
                TurnoDe = "O"
                tresenraya.txtTurnoDe.Text = "O"
            End If
        ElseIf TurnoDe = "O" Then
            button.Text = "O"
            If Not compGanador() Then
                TurnoDe = "X"
                tresenraya.txtTurnoDe.Text = "X"
            End If
        End If
        TurnoNumero = TurnoNumero + 1
    End Function

    Public Function compGanador() As Boolean
        Dim ganador As Boolean
        ganador = False
        If TurnoNumero = 2 Then
            tresenraya.btnReiniciar.Enabled = True
        ElseIf TurnoNumero >= 5 Then
            If tresenraya.Button1.Text <> "" And tresenraya.Button2.Text <> "" And tresenraya.Button3.Text <> "" And tresenraya.Button1.Text = tresenraya.Button2.Text And tresenraya.Button2.Text = tresenraya.Button3.Text Then
                ganador = True
            ElseIf tresenraya.Button4.Text <> "" And tresenraya.Button5.Text <> "" And tresenraya.Button6.Text <> "" And tresenraya.Button4.Text = tresenraya.Button5.Text And tresenraya.Button5.Text = tresenraya.Button6.Text Then
                ganador = True
            ElseIf tresenraya.Button7.Text <> "" And tresenraya.Button8.Text <> "" And tresenraya.Button9.Text <> "" And tresenraya.Button7.Text = tresenraya.Button8.Text And tresenraya.Button8.Text = tresenraya.Button9.Text Then
                ganador = True
            ElseIf tresenraya.Button1.Text <> "" And tresenraya.Button4.Text <> "" And tresenraya.Button7.Text <> "" And tresenraya.Button1.Text = tresenraya.Button4.Text And tresenraya.Button4.Text = tresenraya.Button7.Text Then
                ganador = True
            ElseIf tresenraya.Button2.Text <> "" And tresenraya.Button5.Text <> "" And tresenraya.Button8.Text <> "" And tresenraya.Button2.Text = tresenraya.Button5.Text And tresenraya.Button5.Text = tresenraya.Button8.Text Then
                ganador = True
            ElseIf tresenraya.Button3.Text <> "" And tresenraya.Button6.Text <> "" And tresenraya.Button9.Text <> "" And tresenraya.Button3.Text = tresenraya.Button6.Text And tresenraya.Button6.Text = tresenraya.Button9.Text Then
                ganador = True
            ElseIf tresenraya.Button1.Text <> "" And tresenraya.Button5.Text <> "" And tresenraya.Button9.Text <> "" And tresenraya.Button1.Text = tresenraya.Button5.Text And tresenraya.Button5.Text = tresenraya.Button9.Text Then
                ganador = True
            ElseIf tresenraya.Button3.Text <> "" And tresenraya.Button5.Text <> "" And tresenraya.Button7.Text <> "" And tresenraya.Button3.Text = tresenraya.Button5.Text And tresenraya.Button5.Text = tresenraya.Button7.Text Then
                ganador = True
            ElseIf tresenraya.Button1.Text <> "" And tresenraya.Button2.Text <> "" And tresenraya.Button3.Text <> "" And tresenraya.Button4.Text <> "" And tresenraya.Button5.Text <> "" And tresenraya.Button6.Text <> "" And tresenraya.Button7.Text <> "" And tresenraya.Button8.Text <> "" And tresenraya.Button9.Text <> "" Then
                If MsgBox("Ha habido un empate." & vbNewLine & "¿Quereis volver a jugar?", MsgBoxStyle.RetryCancel, "Empate") = vbRetry Then
                    Inicio.Show()
                Else
                    salir()
                End If
            End If
        End If
        If ganador Then
            If MsgBox("El ganador es " & TurnoDe & vbNewLine & "¿Quereis volver a jugar?", MsgBoxStyle.YesNo, "Tenemos ganador/a") = 6 Then
                Inicio.Show()
            Else
                salir()
            End If
        End If
    End Function

    Public Function salir() As Boolean
        If MsgBox("¿Realmente deseas salir?", MsgBoxStyle.OkCancel, "¿Salir?") = vbOK Then
            End
        End If
    End Function

    Public Function limpiar() As Boolean
        tresenraya.Button1.Text = ""
        tresenraya.Button2.Text = ""
        tresenraya.Button3.Text = ""
        tresenraya.Button4.Text = ""
        tresenraya.Button5.Text = ""
        tresenraya.Button6.Text = ""
        tresenraya.Button7.Text = ""
        tresenraya.Button8.Text = ""
        tresenraya.Button9.Text = ""
        TurnoNumero = 1
        tresenraya.btnReiniciar.Enabled = False
    End Function
End Module
