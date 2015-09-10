Public Class AdivinaNumero

    Private Sub btnAdivina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdivina.Click
        compNumero()
    End Sub

    Private Sub txtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            compNumero()
        End If
    End Sub
End Class
