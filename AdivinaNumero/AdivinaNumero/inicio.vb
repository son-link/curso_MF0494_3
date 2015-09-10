Public Class inicio

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If radioEasy.Checked Then
            iniciar(15)
        ElseIf radioNormal.Checked Then
            iniciar(10)
        ElseIf radioHard.Checked Then
            iniciar(5)
        End If
        Me.Hide()
        AdivinaNumero.Show()
    End Sub
End Class