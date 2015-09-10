Public Class tresenraya

    Private Sub tresenraya_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        salir()
    End Sub

    Private Sub tresenraya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If sender.Text = "" Then
            compTurno(sender)
        End If
    End Sub

    Private Sub btnVolverJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        If MsgBox("¿Realmente quiere reiniciar el juego?", MsgBoxStyle.RetryCancel, "Reiniciar") = vbRetry Then
            Inicio.Visible = True
            'limpiar()
        End If
    End Sub

End Class
