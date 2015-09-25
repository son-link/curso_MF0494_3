Public Class Form1
    Dim pistas As New ArrayList
    Dim fallos As Integer
    Dim n As Integer
    Dim cerrando As Boolean = False
    Private Declare Function GetTickCount Lib "kernel32" () As Integer

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        iniciar()
    End Sub

    Private Sub iniciar()
        fallos = 3
        LabelTest.Text = "Te quedan " & fallos & " intentos"
        nuevoColor()
    End Sub

    Private Sub TocaBotones()
        panelBtns.Enabled = False
        For Each pista In pistas
            If cerrando Then
                Exit For
            End If
            If pista = 0 Then
                btnVerde.BackColor = Color.LimeGreen
                My.Computer.Audio.Play(My.Resources.verde, _
        AudioPlayMode.Background)
            ElseIf pista = 1 Then
                btnRojo.BackColor = Color.Red
                My.Computer.Audio.Play(My.Resources.rojo, _
        AudioPlayMode.Background)
            ElseIf pista = 2 Then
                btnAmarillo.BackColor = Color.Yellow
                My.Computer.Audio.Play(My.Resources.amarillo, _
        AudioPlayMode.Background)
            ElseIf pista = 3 Then
                btnAzul.BackColor = Color.Aqua
                My.Computer.Audio.Play(My.Resources.azul, _
        AudioPlayMode.Background)
            End If
            esperar()
            btnVerde.BackColor = Color.Green
            btnRojo.BackColor = Color.DarkRed
            btnAmarillo.BackColor = Color.DarkGoldenrod
            btnAzul.BackColor = Color.Blue
            'esperar()
        Next
        panelBtns.Enabled = True
    End Sub

    Private Sub comprobarColor(ByVal numero As Integer)

        If pistas(n) = numero Then
            n = n + 1
        Else
            fallos = fallos - 1
            My.Computer.Audio.Play(My.Resources.fallo, _
        AudioPlayMode.Background)
            LabelTest.Text = "Te quedan " & fallos & " intentos"
            pistas.Clear()
            n = 0
            If fallos = 0 Then
                MsgBox("GAME OVER")
                End
            End If
            esperar()
            TocaBotones()
        End If
        If n = pistas.Count Then
            n = 0
            esperar()
            nuevoColor()
        End If
    End Sub

    Private Sub esperar()
        Dim retraso As Integer
        retraso = 1000 + GetTickCount
        While retraso >= GetTickCount
            Application.DoEvents()
        End While
    End Sub

    Private Sub nuevoColor()
        Randomize()
        Dim numero As Integer = CInt(3 * Rnd())
        pistas.Add(numero)
        TocaBotones()
    End Sub

    Private Sub btnVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerde.Click
        My.Computer.Audio.Play(My.Resources.verde, _
        AudioPlayMode.Background)
        comprobarColor(0)
    End Sub

    Private Sub btnRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRojo.Click
        My.Computer.Audio.Play(My.Resources.rojo, _
        AudioPlayMode.Background)
        comprobarColor(1)
    End Sub

    Private Sub btnAmarillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmarillo.Click
        My.Computer.Audio.Play(My.Resources.amarillo, _
        AudioPlayMode.Background)
        comprobarColor(2)
    End Sub

    Private Sub btnAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAzul.Click
        My.Computer.Audio.Play(My.Resources.azul, _
        AudioPlayMode.Background)
        comprobarColor(3)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        cerrando = True
    End Sub
End Class
