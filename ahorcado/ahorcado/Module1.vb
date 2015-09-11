Module Module1
    Public palabra As String
    Public palabras As New ArrayList
    Public palabra2 As String
    Public letras As New ArrayList
    Public posiciones As New ArrayList
    Public fallos As Integer

    Public Function compLetra(ByVal letra As String)
        MsgBox(letra)
        If letra >= 65 And letra <= 90 Then
            palabra2 = ""
            letra = Chr(letra)
            letra = letra.ToLower
            letras.Add(letra)
            For i As Integer = 0 To letras.Count - 1
                Ahorcado.Label7.Text = letras(i) & " "
            Next
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
                        palabra2 = palabra2 & "_"
                    End If
                Next
                Ahorcado.labelPalabra.Text = palabra2
                If palabra = palabra2 Then
                    MsgBox("HAS ACERTADO")
                End If
            Else
                If fallos >= 1 Then
                    fallos = fallos - 1
                    Ahorcado.LabelIntentos.Text = "Te quedan " & fallos & " intentos"
                Else
                    MsgBox("HAS PERDIDO")
                End If
            End If
        End If
    End Function
End Module
