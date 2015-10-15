<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PixelRacing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PixelRacing))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelGame = New System.Windows.Forms.Panel()
        Me.LabelGame = New System.Windows.Forms.Label()
        Me.pbExplosion = New System.Windows.Forms.PictureBox()
        Me.ene1 = New System.Windows.Forms.PictureBox()
        Me.ene3 = New System.Windows.Forms.PictureBox()
        Me.pbPlayer = New System.Windows.Forms.PictureBox()
        Me.ene2 = New System.Windows.Forms.PictureBox()
        Me.pbBorder = New System.Windows.Forms.PictureBox()
        Me.pbBG = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLives = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PanelGame.SuspendLayout()
        CType(Me.pbExplosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ene1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ene3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ene2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 70
        '
        'PanelGame
        '
        Me.PanelGame.Controls.Add(Me.LabelGame)
        Me.PanelGame.Controls.Add(Me.pbExplosion)
        Me.PanelGame.Controls.Add(Me.ene1)
        Me.PanelGame.Controls.Add(Me.ene3)
        Me.PanelGame.Controls.Add(Me.pbPlayer)
        Me.PanelGame.Controls.Add(Me.ene2)
        Me.PanelGame.Controls.Add(Me.pbBorder)
        Me.PanelGame.Controls.Add(Me.pbBG)
        Me.PanelGame.Controls.Add(Me.Label8)
        Me.PanelGame.Controls.Add(Me.Label7)
        Me.PanelGame.Controls.Add(Me.Label6)
        Me.PanelGame.Controls.Add(Me.Label5)
        Me.PanelGame.Controls.Add(Me.Label4)
        Me.PanelGame.Location = New System.Drawing.Point(12, 12)
        Me.PanelGame.Name = "PanelGame"
        Me.PanelGame.Size = New System.Drawing.Size(208, 320)
        Me.PanelGame.TabIndex = 0
        '
        'LabelGame
        '
        Me.LabelGame.BackColor = System.Drawing.Color.White
        Me.LabelGame.ForeColor = System.Drawing.Color.Black
        Me.LabelGame.Location = New System.Drawing.Point(0, 161)
        Me.LabelGame.Name = "LabelGame"
        Me.LabelGame.Size = New System.Drawing.Size(208, 23)
        Me.LabelGame.TabIndex = 32
        Me.LabelGame.Text = "Press P to start game"
        Me.LabelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbExplosion
        '
        Me.pbExplosion.Location = New System.Drawing.Point(88, 247)
        Me.pbExplosion.Name = "pbExplosion"
        Me.pbExplosion.Size = New System.Drawing.Size(32, 32)
        Me.pbExplosion.TabIndex = 29
        Me.pbExplosion.TabStop = False
        Me.pbExplosion.Visible = False
        '
        'ene1
        '
        Me.ene1.BackColor = System.Drawing.Color.Transparent
        Me.ene1.Image = Global.WindowsApplication1.My.Resources.Resources.ene1
        Me.ene1.Location = New System.Drawing.Point(41, 5)
        Me.ene1.Name = "ene1"
        Me.ene1.Size = New System.Drawing.Size(28, 52)
        Me.ene1.TabIndex = 31
        Me.ene1.TabStop = False
        Me.ene1.Tag = "enemy"
        Me.ene1.Visible = False
        '
        'ene3
        '
        Me.ene3.BackColor = System.Drawing.Color.Transparent
        Me.ene3.Image = Global.WindowsApplication1.My.Resources.Resources.ene3
        Me.ene3.Location = New System.Drawing.Point(137, 5)
        Me.ene3.Name = "ene3"
        Me.ene3.Size = New System.Drawing.Size(28, 52)
        Me.ene3.TabIndex = 30
        Me.ene3.TabStop = False
        Me.ene3.Tag = "enemy"
        Me.ene3.Visible = False
        '
        'pbPlayer
        '
        Me.pbPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pbPlayer.Image = CType(resources.GetObject("pbPlayer.Image"), System.Drawing.Image)
        Me.pbPlayer.Location = New System.Drawing.Point(90, 261)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(28, 52)
        Me.pbPlayer.TabIndex = 28
        Me.pbPlayer.TabStop = False
        '
        'ene2
        '
        Me.ene2.BackColor = System.Drawing.Color.Transparent
        Me.ene2.Image = Global.WindowsApplication1.My.Resources.Resources.ene2
        Me.ene2.Location = New System.Drawing.Point(89, 5)
        Me.ene2.Name = "ene2"
        Me.ene2.Size = New System.Drawing.Size(28, 52)
        Me.ene2.TabIndex = 27
        Me.ene2.TabStop = False
        Me.ene2.Tag = "enemy"
        Me.ene2.Visible = False
        '
        'pbBorder
        '
        Me.pbBorder.Image = Global.WindowsApplication1.My.Resources.Resources.border
        Me.pbBorder.Location = New System.Drawing.Point(0, -96)
        Me.pbBorder.Name = "pbBorder"
        Me.pbBorder.Size = New System.Drawing.Size(208, 416)
        Me.pbBorder.TabIndex = 26
        Me.pbBorder.TabStop = False
        '
        'pbBG
        '
        Me.pbBG.BackColor = System.Drawing.Color.Transparent
        Me.pbBG.Image = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.pbBG.Location = New System.Drawing.Point(0, 0)
        Me.pbBG.Name = "pbBG"
        Me.pbBG.Size = New System.Drawing.Size(208, 320)
        Me.pbBG.TabIndex = 25
        Me.pbBG.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 39)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "How to play:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left and Right keys: Move car" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P: Play/Pause game"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Lives"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(262, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Tag = "label"
        Me.Label6.Text = "4"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "    Score"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(214, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Tag = "label"
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelScore
        '
        Me.labelScore.AutoSize = True
        Me.labelScore.Location = New System.Drawing.Point(226, 35)
        Me.labelScore.Name = "labelScore"
        Me.labelScore.Size = New System.Drawing.Size(13, 13)
        Me.labelScore.TabIndex = 1
        Me.labelScore.Tag = "label"
        Me.labelScore.Text = "0"
        Me.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Press Start 2P", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score"
        '
        'LabelLives
        '
        Me.LabelLives.AutoSize = True
        Me.LabelLives.Location = New System.Drawing.Point(226, 67)
        Me.LabelLives.Name = "LabelLives"
        Me.LabelLives.Size = New System.Drawing.Size(13, 13)
        Me.LabelLives.TabIndex = 4
        Me.LabelLives.Tag = "label"
        Me.LabelLives.Text = "4"
        Me.LabelLives.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lives:"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'PixelRacing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 348)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelLives)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelScore)
        Me.Controls.Add(Me.PanelGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PixelRacing"
        Me.Text = "PixelRacing"
        Me.PanelGame.ResumeLayout(False)
        Me.PanelGame.PerformLayout()
        CType(Me.pbExplosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ene1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ene3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ene2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelGame As System.Windows.Forms.Panel
    Friend WithEvents labelScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelLives As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbBG As System.Windows.Forms.PictureBox
    Friend WithEvents pbExplosion As System.Windows.Forms.PictureBox
    Friend WithEvents ene1 As System.Windows.Forms.PictureBox
    Friend WithEvents ene3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents ene2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBorder As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents LabelGame As System.Windows.Forms.Label

End Class
