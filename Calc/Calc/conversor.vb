Public Class conversor
    Dim dinero As Integer
    Dim resultado As Integer

    Private Sub btnConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConv.Click
        txtDolar.Text = Math.Round(txtEuro.Text * 1.11825, 2)
        txtLibra.Text = Math.Round(txtEuro.Text * 1.37517, 2)
        txtYen.Text = Math.Round(txtEuro.Text * 133.890086, 2)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpieza("conversor")
    End Sub
    Private Sub conversor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        Inicio.Visible = True
    End Sub
End Class