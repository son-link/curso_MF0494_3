Module Module1
    Public TurnoDe As String
    Public TurnoNumero As Integer

    Public Function compTurno(ByVal button As Object) As String
        If TurnoDe = "X" Then
            TurnoDe = "O"
            tresenraya.txtTurnoDe.Text = "O"
            button.Text = "O"
            button.ForeColor = Color.Red
        Else
            TurnoDe = "X"
            tresenraya.txtTurnoDe.Text = "X"
            button.Text = "X"
            button.ForeColor = Color.Green
        End If
        TurnoNumero = TurnoNumero + 1
    End Function

    Public Function compGanador() As Boolean
        Dim ganador As Boolean
        ganador = False
        If TurnoNumero >= 5 And TurnoNumero <= 9 Then
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
            End If
        End If
        If ganador Then
            If MsgBox("El ganador es " & TurnoDe & "\n¿Quereis volver a jugar?", MsgBoxStyle.YesNo, "Tenemos ganador/a") = 6 Then
                limpiar()
            Else
                End
            End If
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
        TurnoDe = "0"
        TurnoNumero = 1
    End Function
End Module
