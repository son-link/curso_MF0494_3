Module Module1
    Public palabra As String
    Public palabras As New ArrayList
    Public palabra2 As String
    Public letras As New ArrayList
    Public posiciones As New ArrayList
    Public fallos As Integer
    Public ifwin As Boolean = False
    Dim _textStreamReader As System.IO.StreamReader
    'Dim _assembly As System.Reflection.Assembly
    Dim _assembly = System.Reflection.Assembly.GetExecutingAssembly()

    Public Function compLetra(ByVal letra As String)
        If letra >= 65 And letra <= 90 Then
            letra = Chr(letra)
            letra = letra.ToLower
            If letras.Contains(letra) Then
                compFallos()
            Else
                letras.Add(letra)
                For n As Integer = 0 To palabra.Length - 1
                    If palabra(n) = letra Then
                        posiciones.Add(n)
                    End If
                Next
                posiciones.Sort()
                If palabra.Contains(letra) Then
                    palabra2 = ""
                    For i As Integer = 0 To palabra.Length - 1
                        If posiciones.Contains(i) Then
                            palabra2 = palabra2 & palabra(i)
                        Else
                            If palabra(i) = " " Then
                                palabra2 = palabra2 & " "
                            Else
                                palabra2 = palabra2 & "_"
                            End If
                        End If
                    Next
                    Ahorcado.labelPalabra.Text = palabra2
                    If palabra = palabra2 Then
                        Ahorcado.Timer1.Start()
                        Ahorcado.Timer1.Enabled = True
                        ifwin = True
                        If MsgBox("Has ganado" & vbNewLine & "¿Desea volver a jugar?", MsgBoxStyle.YesNo, "Has ganado") = 6 Then
                            iniciar()
                        Else
                            System.Windows.Forms.Application.Exit()
                        End If
                    End If
                Else
                    compFallos()
                End If
            End If
            Ahorcado.TextBoxLetras.Clear()
            letras.Sort()
            For i As Integer = 0 To letras.Count - 1
                Ahorcado.TextBoxLetras.AppendText(letras(i) & " ")
            Next
        End If
    End Function

    Private Function compFallos() As Boolean
        fallos = fallos + 1
        Select Case fallos
            Case 1
                Ahorcado.imgAhorcado.Image = My.Resources.fallo1
            Case (2)
                Ahorcado.imgAhorcado.Image = My.Resources.fallo2
            Case 3
                Ahorcado.imgAhorcado.Image = My.Resources.fallo3
            Case 4
                Ahorcado.imgAhorcado.Image = My.Resources.fallo4
            Case 5
                Ahorcado.imgAhorcado.Image = My.Resources.fallo5
            Case 6
                Ahorcado.imgAhorcado.Image = My.Resources.imgFinal
                Ahorcado.Timer1.Start()
                Ahorcado.Timer1.Enabled = True
                ifwin = False
                If MsgBox("Has fallado" & vbNewLine & "¿Desea volver a jugar?", MsgBoxStyle.YesNo, "Has perdido") = 6 Then
                    iniciar()
                Else
                    System.Windows.Forms.Application.Exit()
                End If

        End Select
    End Function

    Public Function openFile() As Boolean
        Dim file As String = My.Resources.palabras.ToString()
        For Each p In file.Split(Chr(13))
            palabras.Add(p.TrimStart)
        Next
    End Function

    Public Function iniciar() As Boolean
        Ahorcado.labelPalabra.Text = ""
        palabra2 = ""
        fallos = 0
        Ahorcado.imgAhorcado.Image = My.Resources.imgInicio
        Ahorcado.labelPalabra.ForeColor = SystemColors.ControlText
        Ahorcado.Timer1.Stop()
        Ahorcado.Timer1.Enabled = False
        Randomize()
        palabra = palabras(CInt((palabras.Count - 1) * Rnd()))
        For i As Integer = 0 To palabra.Length - 1
            If palabra(i) = " " Then
                palabra2 = palabra2 & " "
            Else
                palabra2 = palabra2 & "_"
            End If
        Next
        letras.Clear()
        posiciones.Clear()
        Ahorcado.labelPalabra.Text = palabra2
    End Function

    Public Function blink() As Boolean
        Dim txtWin As String = "HAS GANADO"
        Dim txtLose As String = "HAS PERDIDO"
        If Ahorcado.labelPalabra.Text = palabra2 Then
            If ifwin Then
                Ahorcado.labelPalabra.Text = txtWin
                Ahorcado.labelPalabra.ForeColor = Color.Green
            Else
                Ahorcado.labelPalabra.Text = txtLose
                Ahorcado.labelPalabra.ForeColor = Color.Red
            End If
        Else
            Ahorcado.labelPalabra.Text = palabra2
        End If
    End Function
End Module
