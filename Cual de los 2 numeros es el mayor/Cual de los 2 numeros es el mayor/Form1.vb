Public Class Form1
    Dim total As Integer
    Dim n1 As Integer
    Dim n2 As Integer

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        If numero1.Text = "" And numero2.Text = "" Then
            MsgBox("Los campos Numero 1 y 2 no pueden estar vacios", MsgBoxStyle.Exclamation, "")
        ElseIf numero1.Text = "" Then
            MsgBox("El campo Numero 1 no puede estar vacio", MsgBoxStyle.Exclamation, "")
        ElseIf numero2.Text = "" Then
            MsgBox("El campo Numero 2 no puede estar vacio", MsgBoxStyle.Exclamation, "")
        Else
            n1 = numero1.Text
            n2 = numero2.Text
            If n1 > n2 Then
                MsgBox("Numero 1 (" & n1 & ") es mayor que Numero 2: (" & n2 & ")", MsgBoxStyle.OkOnly, "")
            ElseIf n1 = n2 Then
                MsgBox("Ambos numeros son iguales: " & n1, MsgBoxStyle.OkOnly, "")
            Else
                MsgBox("Numero 2 (" & n2 & ") es mayor que Numero 1: (" & n1 & ")", MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub
End Class
