Public Class PixelRacing
    Dim playerPos As Integer = 1
    Dim explosionPos As Integer = 48
    Dim cont As Integer = 0
    Dim score As Integer = 0
    Dim hitScore As Integer
    Dim ifHitScore As Boolean = False
    Dim lives As Integer = 4
    Dim level As Integer = 1
    Dim block As Boolean = False
    Dim speed As Integer = 70
    Dim upSpeed As Integer = 2000
    Dim newLiveAt As Integer = 5000
    Dim gameState As Integer = 0 ' 0: no play, 1: play/pause, 2: game over
    Private Declare Function GetTickCount Lib "kernel32" () As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Not block Then
            If e.KeyCode = Keys.Left And pbPlayer.Location.X > 36 Then
                pbPlayer.Location = New Point(pbPlayer.Location.X - 6, 256)
            ElseIf e.KeyCode = Keys.Right And pbPlayer.Location.X < 142 Then
                pbPlayer.Location = New Point(pbPlayer.Location.X + 6, 256)
            ElseIf e.KeyCode = Keys.P Then
                If gameState = 1 Then
                    pauseResume()
                ElseIf gameState = 0 Then
                    StartGame()
                    gameState = 1
                End If
            ElseIf e.KeyCode = Keys.Y And gameState = 2 Then
                StartGame()
                gameState = 0
            ElseIf e.KeyCode = Keys.N And gameState = 2 Then
                End
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile("PixelOperator.ttf")
        For Each label In Me.Controls
            If TypeOf label Is Label Then
                label.Font = New Font(privateFonts.Families(0), 14, FontStyle.Regular)
            End If
        Next
        LabelGame.Font = New Font(privateFonts.Families(0), 14, FontStyle.Regular)
        pbPlayer.Location = New Point(90, 256)
        Try
            FileOpen(1, "hitscore.txt", OpenMode.Input)
            hitScore = Val(LineInput(1))
            FileClose(1)
        Catch ex As Exception
            hitScore = 0
        End Try
        pbBG.Controls.Add(pbPlayer)
        pbBG.Controls.Add(pbBorder)
        pbBG.Controls.Add(ene1)
        pbBG.Controls.Add(ene2)
        pbBG.Controls.Add(ene3)
        pbBG.Controls.Add(pbExplosion)
        ene1.BringToFront()
        ene2.BringToFront()
        ene3.BringToFront()
        pbExplosion.BringToFront()
    End Sub

    Private Sub StartGame()
        pbPlayer.Location = New Point(90, 256)
        pbPlayer.Show()
        lives = 4
        LabelLives.Text = 4
        LabelGame.Hide()
        resetGame()
        AxWindowsMediaPlayer1.URL = "bg_music.mp3"
        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        'newEnemy()
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If cont = 20 Then
            cont = 0
            newEnemy()
        Else
            cont = cont + 1
        End If
        For Each enemy In pbBG.Controls
            If TypeOf enemy Is PictureBox Then
                If enemy.Tag = "enemy" Then
                    If enemy.Location.Y < 320 Then
                        enemy.Location = New Point(enemy.Location.X, enemy.Location.Y + 8)
                    Else
                        score = score + 100
                        labelScore.Text = score
                        enemy.Location = New Point(16, 0)
                        enemy.Visible = False
                        If score > hitScore Then
                            Label1.Text = "Hit score"
                            ifHitScore = True
                        End If
                        If score = upSpeed And Timer1.Interval > 20 Then
                            Timer1.Interval = Timer1.Interval - 10
                            upSpeed = upSpeed + 2000
                        End If
                        If score = newLiveAt Then
                            lives = lives + 1
                            LabelLives.Text = lives
                            newLiveAt = newLiveAt + 5000
                        End If
                    End If
                End If
                Me.Refresh()
            End If
        Next

        For Each PictureBox In pbBG.Controls
            If PictureBox IsNot pbPlayer AndAlso pbPlayer.Bounds.IntersectsWith(PictureBox.Bounds) And PictureBox IsNot pbExplosion And PictureBox IsNot pbBorder And PictureBox.Visible Then
                If lives > 0 Then
                    block = True
                    Timer1.Stop()
                    Timer1.Enabled = False
                    pbExplosion.Location = New Point(pbPlayer.Location.X - 2, pbPlayer.Location.Y - 16)
                    pbPlayer.Visible = False
                    PictureBox.Visible = False
                    pbExplosion.Visible = True
                    pbExplosion.Image = My.Resources.explosion_ani
                    My.Computer.Audio.Play(My.Resources.explosion, AudioPlayMode.Background)
                    esperar(2000)
                    cont = 0
                    lives = lives - 1
                    LabelLives.Text = lives
                    resetGame()
                    Exit Sub
                Else
                    Timer1.Stop()
                    Timer1.Enabled = False
                    If ifHitScore Then
                        FileOpen(1, "hitscore.txt", OpenMode.Output)
                        WriteLine(1, score)
                        FileClose(1)
                    End If
                    pbExplosion.Location = New Point(pbPlayer.Location.X - 2, pbPlayer.Location.Y - 16)
                    pbPlayer.Visible = False
                    PictureBox.Visible = False
                    pbExplosion.Visible = True
                    pbExplosion.Image = My.Resources.explosion_ani
                    My.Computer.Audio.Play(My.Resources.explosion, AudioPlayMode.Background)
                    esperar(2000)
                    pbExplosion.Visible = False
                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                    My.Computer.Audio.Play(My.Resources.game_over, AudioPlayMode.Background)
                    gameState = 2
                    LabelGame.Text = "GAME OVER! Continue? Yes/No"
                    LabelGame.Show()
                End If
            End If
        Next
        If pbBorder.Location.Y <= -4 Then
            pbBorder.Location = New Point(0, pbBorder.Location.Y + 4)
        Else
            pbBorder.Location = New Point(0, -96)
        End If
    End Sub

    Private Sub newEnemy()
        Randomize()
        Dim pos = CInt(2 * Rnd())
        Dim x = 0
        If pos = 0 Then
            x = 41
        ElseIf pos = 1 Then
            x = 90
        Else
            x = 138
        End If
        For Each enemy In pbBG.Controls
            If TypeOf enemy Is PictureBox Then
                If enemy.Tag = "enemy" And Not enemy.Visible Then
                    Randomize()
                    Dim color As Integer = CInt(2 * Rnd())
                    If color = 0 Then
                        enemy.Image = My.Resources.ene1
                    ElseIf color = 1 Then
                        enemy.Image = My.Resources.ene2
                    Else
                        enemy.Image = My.Resources.ene3
                    End If
                    enemy.Visible = True
                    enemy.Location = New System.Drawing.Point(x, -48)
                    Me.Refresh()
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub pauseResume()
        If Timer1.Enabled Then
            Timer1.Stop()
            Timer1.Enabled = False
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            Timer1.Start()
            Timer1.Enabled = True
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub resetGame()
        cont = 0
        pbExplosion.Visible = False
        pbPlayer.Location = New Point(90, 256)
        explosionPos = 48
        ene1.Location = New Point(-32, -48)
        ene2.Location = New Point(-32, -48)
        ene3.Location = New Point(-32, -48)
        ene1.Visible = False
        ene2.Visible = False
        ene3.Visible = False
        pbPlayer.Visible = True
        esperar(2000)
        Me.Refresh()
        block = False
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        newEnemy()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub esperar(ByVal time_whait As Integer)
        Dim retraso As Integer
        retraso = time_whait + GetTickCount
        While retraso >= GetTickCount
            Application.DoEvents()
        End While
    End Sub
End Class
