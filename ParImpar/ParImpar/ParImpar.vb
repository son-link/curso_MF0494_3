Public Class ParImpar
    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        If txtNumero.Text = "" Then
            MsgBox("Introducza un numero", MsgBoxStyle.Exclamation, "Aviso")
        Else
            If compParImpar(txtNumero.Text) Then
                MsgBox("El numero " & txtNumero.Text & " es par")
            Else
                MsgBox("El numero " & txtNumero.Text & " es impar")
            End If
        End If
    End Sub
End Class
