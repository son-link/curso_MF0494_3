Public Class Form1
    ' Subrutina de saludo
    Private Sub btn_saludo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saludo.Click
        Dim nombre As String
        nombre = InputBox("Introduce un nombre: ", "Nombre", "")
        MsgBox("Hola holita " & nombre, MsgBoxStyle.OkOnly, "Saludos")
    End Sub

    ' Subrutina de salida del programa
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
