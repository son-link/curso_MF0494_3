Module Module1
    Public palabra As String
    Public palabras As New ArrayList
    Public palabra2 As String
    Public letras As New ArrayList
    Public posiciones As New ArrayList
    Public fallos As Integer

    Public Function compLetra(ByVal letra As String)
        If letra >= 65 And letra <= 90 Then
            palabra2 = ""
            letra = Chr(letra)
            letra = letra.ToLower
            If letras.Contains(letra) Then
                compFallos()
            Else
                letras.Add(letra)
                If palabra.IndexOf(letra) > -1 Then
                    For n As Integer = 0 To palabra.Length - 1
                        If palabra(n) = letra Then
                            posiciones.Add(n)
                        End If
                    Next
                    posiciones.Sort()
                    For i As Integer = 0 To palabra.Length - 1
                        If posiciones.Contains(i) Then
                            palabra2 = palabra2 & palabra(i)
                        Else
                            palabra2 = palabra2 & "-"
                        End If
                    Next
                    Ahorcado.labelPalabra.Text = palabra2
                    If palabra = palabra2 Then
                        MsgBox("HAS ACERTADO")
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
                Ahorcado.LabelFallo1.Text = "|       O"
            Case 2
                Ahorcado.LabelFallos2al4.Text = "|        |"
            Case 3
                Ahorcado.LabelFallos2al4.Text = "|       /|"
            Case 4
                Ahorcado.LabelFallos2al4.Text = "|       /|\"
            Case 5
                Ahorcado.LabelFallos5y6.Text = "|       /"
            Case 6
                Ahorcado.LabelFallos5y6.Text = "|       / \"
                Ahorcado.labelAhorcado.ForeColor = Color.Red
                Ahorcado.LabelFallo1.ForeColor = Color.Red
                Ahorcado.LabelFallos2al4.ForeColor = Color.Red
                Ahorcado.LabelFallos5y6.ForeColor = Color.Red
                Ahorcado.LabelFinAhorcado.ForeColor = Color.Red
                Ahorcado.labelPalabra.ForeColor = Color.Red
                If MsgBox("Has fallado" & vbNewLine & "¿Desea volver a jugar?", MsgBoxStyle.YesNo, "Has perdido") = 6 Then
                    iniciar()
                Else
                    System.Windows.Forms.Application.Exit()
                End If
        End Select
    End Function
    Public Function openFile() As Boolean
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("palabras.txt")

        Do While fileReader.Peek() <> -1
            palabras.Add(fileReader.ReadLine())
        Loop
    End Function
    Public Function iniciar() As Boolean
        Randomize()
        palabra = palabras(CInt((palabras.Count - 1) * Rnd()))
        For i As Integer = 0 To palabra.Length - 1
            palabra2 = palabra2 & "-"
        Next
        Ahorcado.labelPalabra.Text = palabra2
        fallos = 0
        Ahorcado.labelAhorcado.ForeColor = SystemColors.ControlText
        Ahorcado.LabelFallo1.ForeColor = SystemColors.ControlText
        Ahorcado.LabelFallos2al4.ForeColor = SystemColors.ControlText
        Ahorcado.LabelFallos5y6.ForeColor = SystemColors.ControlText
        Ahorcado.LabelFinAhorcado.ForeColor = SystemColors.ControlText
        Ahorcado.labelPalabra.ForeColor = SystemColors.ControlText
    End Function
End Module
