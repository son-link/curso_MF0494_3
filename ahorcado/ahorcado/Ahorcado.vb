Public Class Ahorcado
    Private Sub ListLetras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListLetras.KeyDown
        compLetra(e.KeyCode)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("palabras.txt")

        Do While fileReader.Peek() <> -1
            palabras.Add(fileReader.ReadLine())
        Loop

        Randomize()
        palabra = palabras(CInt((palabras.Count - 1) * Rnd()))
        For i As Integer = 0 To palabra.Length - 1
            palabra2 = palabra2 & "_"
        Next
        labelPalabra.Text = palabra2
        fallos = 10
        LabelIntentos.Text = "Te quedan " & fallos & " intentos"
        Label7.Text = ""
    End Sub
End Class
