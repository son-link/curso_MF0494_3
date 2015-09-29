Public Class simon
    Dim pistas As New ArrayList
    Dim fallos As Integer
    Dim n As Integer
    Dim cerrando As Boolean = False
    Dim sequence_limit As Integer
    Dim sequenle_lengh As Integer = 420
    Dim bloquear = True

    Private Declare Function GetTickCount Lib "kernel32" () As Integer

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        iniciar()
    End Sub

    Private Sub iniciar()
        fallos = 3
        LabelTest.Text = "Te quedan " & fallos & " intentos"
        If Level1.Checked Then
            sequence_limit = 8
        ElseIf Level2.Checked Then
            sequence_limit = 14
        ElseIf Level3.Checked Then
            sequence_limit = 20
        ElseIf Level4.Checked Then
            sequence_limit = 31
        End If
        nuevoColor()
    End Sub

    Private Sub TocaBotones()
        bloquear = True
        For Each pista In pistas
            If cerrando Then
                Exit For
            End If
            If pista = 0 Then
                'btnVerde.BackColor = Color.LimeGreen
                btnVerde.Image = My.Resources.verde_encendido
                My.Computer.Audio.Play(My.Resources.verde, _
        AudioPlayMode.Background)
            ElseIf pista = 1 Then
                'btnRojo.BackColor = Color.Red
                btnRojo.Image = My.Resources.rojo_encendido
                My.Computer.Audio.Play(My.Resources.rojo, _
        AudioPlayMode.Background)
            ElseIf pista = 2 Then
                'btnAmarillo.BackColor = Color.Yellow
                btnAmarillo.Image = My.Resources.amarillo_encendido
                My.Computer.Audio.Play(My.Resources.amarillo, _
        AudioPlayMode.Background)
            ElseIf pista = 3 Then
                'btnAzul.BackColor = Color.Aqua
                btnAzul.Image = My.Resources.azul_encendido
                My.Computer.Audio.Play(My.Resources.azul, _
        AudioPlayMode.Background)
            End If
            If n <= 4 Then
                sequenle_lengh = 420
            ElseIf n <= 12 Then
                sequenle_lengh = 320
            Else
                sequenle_lengh = 220
            End If
            esperar(sequenle_lengh)
            'btnVerde.BackColor = Color.Green
            'btnRojo.BackColor = Color.DarkRed
            'btnAmarillo.BackColor = Color.DarkGoldenrod
            'btnAzul.BackColor = Color.Blue
            reseteaBotones()
            esperar(50)
        Next
        bloquear = False
    End Sub

    Private Sub comprobarColor(ByVal numero As Integer)
        If Not bloquear Then
            If pistas(n) = numero Then
                n = n + 1
                If n = sequence_limit Then
                    pistas.Clear()
                    If MsgBox("Has ganado" & vbNewLine & "¿Deseas volver a jugar?", MsgBoxStyle.OkCancel, "YOU WIN!") = vbOK Then
                        iniciar()
                    Else
                        End
                    End If
                End If
            Else
                fallos = fallos - 1
                'My.Computer.Audio.Play(My.Resources.fallo, _AudioPlayMode.Background)
                LabelTest.Text = "Te quedan " & fallos & " intentos"
                pistas.Clear()
                n = 0
                If fallos = 0 Then
                    If MsgBox("Has perdido" & vbNewLine & "¿Deseas volver a jugar?", MsgBoxStyle.OkCancel, "GAME OVER!") = vbOK Then
                        iniciar()
                    Else
                        End
                    End If
                End If
                esperar(50)
                TocaBotones()
            End If
            esperar(100)
            reseteaBotones()
            If n = pistas.Count Then
                n = 0
                esperar(500)
                nuevoColor()
            End If
        End If
        reseteaBotones()
    End Sub

    Private Sub esperar(ByVal time_whait As Integer)
        Dim retraso As Integer
        retraso = time_whait + GetTickCount
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

    Private Sub reseteaBotones()
        btnVerde.Image = My.Resources.verde_apagado
        btnRojo.Image = My.Resources.rojo_apagado
        btnAmarillo.Image = My.Resources.amarillo_apagado
        btnAzul.Image = My.Resources.azul_apagado
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

    Private Sub imgVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Image = My.Resources.verde_encendido
        My.Computer.Audio.Play(My.Resources.verde, _
        AudioPlayMode.Background)
        comprobarColor(0)
    End Sub
    Private Sub imgRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Image = My.Resources.rojo_encendido
        My.Computer.Audio.Play(My.Resources.rojo, _
        AudioPlayMode.Background)
        comprobarColor(1)
    End Sub
    Private Sub imgamarillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Image = My.Resources.amarillo_encendido
        My.Computer.Audio.Play(My.Resources.amarillo, _
        AudioPlayMode.Background)
        comprobarColor(2)
    End Sub
    Private Sub imgazul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Image = My.Resources.azul_encendido
        My.Computer.Audio.Play(My.Resources.azul, _
        AudioPlayMode.Background)
        comprobarColor(3)
    End Sub

    Private Sub btnVerde_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnVerde.MouseDown
        sender.Image = My.Resources.verde_encendido
    End Sub
    Private Sub btnrojo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRojo.MouseDown
        sender.Image = My.Resources.rojo_encendido
    End Sub
    Private Sub btnamarillo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAmarillo.MouseDown
        sender.Image = My.Resources.amarillo_encendido
    End Sub
    Private Sub btnazul_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAzul.MouseDown
        sender.Image = My.Resources.azul_encendido
    End Sub
End Class
