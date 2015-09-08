Public Class Inicio
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Me.Visible = False
        calculadora.Visible = True
    End Sub
    Public Sub limpiaCalc()
        calculadora.txtOperador.Text = ""
        calculadora.numero1.Text = ""
        calculadora.numero2.Text = ""
        calculadora.txtResultado.Text = ""
        calculadora.ListResultados.Items.Clear()
    End Sub

    Private Sub btnConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConv.Click
        Me.Visible = False
        conversor.Visible = True
    End Sub
End Class