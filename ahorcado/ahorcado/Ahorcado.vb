Public Class Ahorcado
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openFile()
        iniciar()
    End Sub

    Private Sub TextBoxLetras_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxLetras.KeyDown
        compLetra(e.KeyCode)
    End Sub
End Class
