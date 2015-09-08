Public Class calculadora
    Dim n1 As Integer
    Dim n2 As Integer
    Dim operador As String
    Dim resultado As Integer

    Private Sub btnSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuma.Click
        txtOperador.Text = "+"
    End Sub

    Private Sub btnResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResta.Click
        txtOperador.Text = "-"
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        txtOperador.Text = "*"
    End Sub

    Private Sub btnDivi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivi.Click
        txtOperador.Text = "/"
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If numero1.Text = "" And numero2.Text = "" And txtOperador.Text = "" Then
            MsgBox("Los campos estan vacios y/o no se a selecciona el tipo de calculo", MsgBoxStyle.Exclamation, "")
        ElseIf numero1.Text = "" Then
            MsgBox("El primer numero no puede estar vacio", MsgBoxStyle.Exclamation, "")
        ElseIf numero2.Text = "" Then
            MsgBox("El segundo numero no puede estar vacio", MsgBoxStyle.Exclamation, "")
        ElseIf txtOperador.Text = "" Then
            MsgBox("Tiene que seleccionar un operador", MsgBoxStyle.Exclamation, "")
        Else
            n1 = numero1.Text
            n2 = numero2.Text
            operador = txtOperador.Text

            Select Case operador
                Case "+"
                    resultado = n1 + n2
                Case "-"
                    resultado = n1 - n2
                Case "*"
                    resultado = n1 * n2
                Case "/"
                    resultado = n1 / n2
            End Select
            txtResultado.Text = resultado
            ListResultados.Items.Add(n1 & " " & operador & " " & n2 & " = " & resultado)
        End If
    End Sub

    Private Sub calculadora_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        Inicio.Visible = True
    End Sub

    Private Sub calculadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOperador.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpieza("calculadora")
    End Sub
End Class
