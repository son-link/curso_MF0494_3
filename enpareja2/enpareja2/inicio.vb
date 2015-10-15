Public Class inicio
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rbFacil.Checked Then
            CartasRandom(6)
            enpareja2.totalCartas = 12
        ElseIf rbNormal.Checked Then
            CartasRandom(12)
            enpareja2.totalCartas = 24
        Else
            CartasRandom(18)
            enpareja2.totalCartas = 36
        End If
        Me.Hide()
        enpareja2.Show()
    End Sub
End Class