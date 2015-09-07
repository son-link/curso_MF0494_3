Public Class Form1
    Dim n1 As Integer
    Dim n2 As Integer
    Dim n3 As Integer
    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        If numero1.Text = "" And numero2.Text = "" And numero3.Text = "" Then
            MsgBox("Los campos Numero 1, 2 y 3 no pueden estar vacios", MsgBoxStyle.Exclamation, "")
        ElseIf numero1.Text = "" Then
            MsgBox("El campo Numero 1 no puede estar vacio", MsgBoxStyle.Exclamation, "")
        ElseIf numero2.Text = "" Then
            MsgBox("El campo Numero 2 no puede estar vacio", MsgBoxStyle.Exclamation, "")
        ElseIf numero3.Text = "" Then
            MsgBox("El campo Numero 3 no puede estar vacio", MsgBoxStyle.Exclamation, "")
        Else
            n1 = numero1.Text
            n2 = numero2.Text
            n3 = numero3.Text

            If n1 = n2 And n2 = n3 And n1 = n3 Then
                MsgBox("Todos los numeros son iguales: " & n1, MsgBoxStyle.OkOnly, "")
            ElseIf n1 > n2 And n1 > n3 Then
                MsgBox("Numero 1 (" & n1 & ") es mayor que Numero 2: (" & n2 & ") y Numero 3: (" & n3 & ")", MsgBoxStyle.OkOnly, "")
            ElseIf n2 > n3 Then
                MsgBox("Numero 2 (" & n2 & ") es mayor que Numero 1: (" & n1 & ") y Numero 3: (" & n3 & ")", MsgBoxStyle.OkOnly, "")
            Else
                MsgBox("Numero 3 (" & n3 & ") es mayor que Numero 1: (" & n1 & ") y Numero 2: (" & n2 & ")", MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub
End Class
