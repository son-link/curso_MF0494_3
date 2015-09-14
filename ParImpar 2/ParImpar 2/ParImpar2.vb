Public Class ParImpar2

    Private Sub txtNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum.KeyDown
        If e.KeyCode = Keys.Enter And btnAdd.Enabled = True Then
            ParImpar()
        End If
    End Sub

    Private Sub txtNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNum.TextChanged
        compNumero(sender.Text)
    End Sub

    Private Sub ParImpar2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("¿Realmente desea salir?", MsgBoxStyle.YesNo, "Salir") = vbYes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ParImpar2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'Timer1.Interval = 1000
        Timer1.Start()
        iniciar()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ParImpar()
    End Sub

    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        iniciar()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Realmente desea salir?", MsgBoxStyle.YesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cambiaTitulo()
    End Sub
End Class
