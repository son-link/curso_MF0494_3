Public Class Ahorcado

    Private Sub Ahorcado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Timer1.Stop()
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openFile()
        iniciar()
    End Sub

    Private Sub TextBoxLetras_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxLetras.KeyDown
        compLetra(e.KeyCode)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        blink()
    End Sub
End Class
