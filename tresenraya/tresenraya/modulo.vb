Module modulo
    Public TurnoDe As String
    Public TurnoNumero As Integer
    Public casillas(2, 2)

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

    'Public Function 

    Public Function compGanador() As Boolean
        Dim ganador As Boolean
        Dim campos_vacios As Integer = 9
        ganador = False
        Dim x As Integer = 0
        Dim y As Integer = 0
        For i As Integer = 1 To 9
            Dim name As String = "Button" & i
            Console.WriteLine(name)
            Console.WriteLine("X vale " & x & " e Y vale " & y)
            casillas(x, y) = tresenraya.Panel1.Controls(name).Text
            If casillas(x, y) <> "" Then
                campos_vacios = campos_vacios - 1
            End If
            If x = 2 Then
                y = y + 1
                x = 0
            Else
                x = x + 1
            End If
        Next
        If campos_vacios > 0 Then
            If TurnoNumero = 2 Then
                tresenraya.btnReiniciar.Enabled = True
            ElseIf TurnoNumero >= 5 Then
                If casillas(0, 0) <> "" And casillas(1, 0) <> "" And casillas(2, 0) <> "" And casillas(0, 0) = casillas(1, 0) And casillas(1, 0) = casillas(2, 0) Then
                    ganador = True
                ElseIf casillas(0, 1) <> "" And casillas(1, 1) <> "" And casillas(2, 1) <> "" And casillas(0, 1) = casillas(1, 1) And casillas(1, 1) = casillas(2, 1) Then
                    ganador = True
                ElseIf casillas(0, 2) <> "" And casillas(1, 2) <> "" And casillas(2, 2) <> "" And casillas(0, 2) = casillas(1, 2) And casillas(1, 2) = casillas(2, 2) Then
                    ganador = True
                ElseIf casillas(0, 0) <> "" And casillas(0, 1) <> "" And casillas(0, 2) <> "" And casillas(0, 0) = casillas(0, 1) And casillas(0, 1) = casillas(0, 2) Then
                    ganador = True
                ElseIf casillas(1, 0) <> "" And casillas(1, 1) <> "" And casillas(1, 2) <> "" And casillas(1, 0) = casillas(1, 1) And casillas(1, 1) = casillas(1, 2) Then
                    ganador = True
                ElseIf casillas(2, 0) <> "" And casillas(2, 1) <> "" And casillas(2, 2) <> "" And casillas(2, 0) = casillas(2, 1) And casillas(2, 1) = casillas(2, 2) Then
                    ganador = True
                ElseIf casillas(0, 0) <> "" And casillas(1, 1) <> "" And casillas(2, 2) <> "" And casillas(0, 0) = casillas(1, 1) And casillas(1, 1) = casillas(2, 2) Then
                    ganador = True
                ElseIf casillas(0, 2) <> "" And casillas(1, 1) <> "" And casillas(0, 2) <> "" And casillas(0, 2) = casillas(1, 1) And casillas(1, 1) = casillas(0, 2) Then
                    ganador = True
                End If
            End If
            'End If
            If ganador Then
                If MsgBox("El ganador es " & TurnoDe & vbNewLine & "¿Quereis volver a jugar?", MsgBoxStyle.YesNo, "Tenemos ganador/a") = 6 Then
                    Inicio.Show()
                Else
                    salir()
                End If
            End If
        Else
            If MsgBox("Ha habido un empate." & vbNewLine & "¿Quereis volver a jugar?", MsgBoxStyle.RetryCancel, "Empate") = vbRetry Then
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
        For Each boton In tresenraya.Panel1.Controls
            boton.text = ""
        Next
        TurnoNumero = 1
        tresenraya.btnReiniciar.Enabled = False
    End Function
End Module
