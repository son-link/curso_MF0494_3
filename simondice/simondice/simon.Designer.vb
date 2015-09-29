<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(simon))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.panelBtns = New System.Windows.Forms.Panel()
        Me.LabelTest = New System.Windows.Forms.Label()
        Me.Level1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Level2 = New System.Windows.Forms.RadioButton()
        Me.Level3 = New System.Windows.Forms.RadioButton()
        Me.Level4 = New System.Windows.Forms.RadioButton()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.panelBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.ForeColor = System.Drawing.Color.Black
        Me.btnPlay.Location = New System.Drawing.Point(12, 298)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(43, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'panelBtns
        '
        Me.panelBtns.BackColor = System.Drawing.Color.Transparent
        Me.panelBtns.Controls.Add(Me.btnAzul)
        Me.panelBtns.Controls.Add(Me.btnRojo)
        Me.panelBtns.Controls.Add(Me.btnAmarillo)
        Me.panelBtns.Controls.Add(Me.btnVerde)
        Me.panelBtns.ForeColor = System.Drawing.Color.Transparent
        Me.panelBtns.Location = New System.Drawing.Point(12, 12)
        Me.panelBtns.Name = "panelBtns"
        Me.panelBtns.Size = New System.Drawing.Size(274, 280)
        Me.panelBtns.TabIndex = 5
        '
        'LabelTest
        '
        Me.LabelTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTest.ForeColor = System.Drawing.Color.White
        Me.LabelTest.Location = New System.Drawing.Point(66, 352)
        Me.LabelTest.Name = "LabelTest"
        Me.LabelTest.Size = New System.Drawing.Size(166, 23)
        Me.LabelTest.TabIndex = 6
        Me.LabelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Level1
        '
        Me.Level1.AutoSize = True
        Me.Level1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Level1.Checked = True
        Me.Level1.ForeColor = System.Drawing.Color.White
        Me.Level1.Location = New System.Drawing.Point(120, 303)
        Me.Level1.Name = "Level1"
        Me.Level1.Size = New System.Drawing.Size(17, 30)
        Me.Level1.TabIndex = 7
        Me.Level1.TabStop = True
        Me.Level1.Text = "1"
        Me.Level1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Level1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Level:"
        '
        'Level2
        '
        Me.Level2.AutoSize = True
        Me.Level2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Level2.ForeColor = System.Drawing.Color.White
        Me.Level2.Location = New System.Drawing.Point(143, 303)
        Me.Level2.Name = "Level2"
        Me.Level2.Size = New System.Drawing.Size(17, 30)
        Me.Level2.TabIndex = 9
        Me.Level2.Text = "2"
        Me.Level2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Level2.UseVisualStyleBackColor = True
        '
        'Level3
        '
        Me.Level3.AutoSize = True
        Me.Level3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Level3.ForeColor = System.Drawing.Color.White
        Me.Level3.Location = New System.Drawing.Point(166, 303)
        Me.Level3.Name = "Level3"
        Me.Level3.Size = New System.Drawing.Size(17, 30)
        Me.Level3.TabIndex = 10
        Me.Level3.Text = "3"
        Me.Level3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Level3.UseVisualStyleBackColor = True
        '
        'Level4
        '
        Me.Level4.AutoSize = True
        Me.Level4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Level4.ForeColor = System.Drawing.Color.White
        Me.Level4.Location = New System.Drawing.Point(189, 303)
        Me.Level4.Name = "Level4"
        Me.Level4.Size = New System.Drawing.Size(17, 30)
        Me.Level4.TabIndex = 11
        Me.Level4.Text = "4"
        Me.Level4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Level4.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.Location = New System.Drawing.Point(243, 298)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(43, 23)
        Me.btnLast.TabIndex = 12
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.Color.Transparent
        Me.btnAzul.FlatAppearance.BorderSize = 0
        Me.btnAzul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAzul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAzul.ForeColor = System.Drawing.Color.Black
        Me.btnAzul.Image = Global.WindowsApplication1.My.Resources.Resources.azul_apagado
        Me.btnAzul.Location = New System.Drawing.Point(137, 140)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(128, 128)
        Me.btnAzul.TabIndex = 2
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Transparent
        Me.btnRojo.FlatAppearance.BorderSize = 0
        Me.btnRojo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRojo.ForeColor = System.Drawing.Color.Black
        Me.btnRojo.Image = Global.WindowsApplication1.My.Resources.Resources.rojo_apagado
        Me.btnRojo.Location = New System.Drawing.Point(137, 3)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(128, 128)
        Me.btnRojo.TabIndex = 1
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnAmarillo
        '
        Me.btnAmarillo.BackColor = System.Drawing.Color.Transparent
        Me.btnAmarillo.FlatAppearance.BorderSize = 0
        Me.btnAmarillo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAmarillo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmarillo.ForeColor = System.Drawing.Color.Black
        Me.btnAmarillo.Image = Global.WindowsApplication1.My.Resources.Resources.amarillo_apagado
        Me.btnAmarillo.Location = New System.Drawing.Point(3, 140)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(128, 128)
        Me.btnAmarillo.TabIndex = 3
        Me.btnAmarillo.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.Transparent
        Me.btnVerde.FlatAppearance.BorderSize = 0
        Me.btnVerde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVerde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerde.ForeColor = System.Drawing.Color.Black
        Me.btnVerde.Image = Global.WindowsApplication1.My.Resources.Resources.verde_apagado
        Me.btnVerde.Location = New System.Drawing.Point(3, 6)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(128, 128)
        Me.btnVerde.TabIndex = 0
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'simon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(300, 384)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.Level4)
        Me.Controls.Add(Me.Level3)
        Me.Controls.Add(Me.Level2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Level1)
        Me.Controls.Add(Me.LabelTest)
        Me.Controls.Add(Me.panelBtns)
        Me.Controls.Add(Me.btnPlay)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "simon"
        Me.Text = "Simon"
        Me.panelBtns.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents btnAmarillo As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents panelBtns As System.Windows.Forms.Panel
    Friend WithEvents LabelTest As System.Windows.Forms.Label
    Friend WithEvents Level1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Level2 As System.Windows.Forms.RadioButton
    Friend WithEvents Level3 As System.Windows.Forms.RadioButton
    Friend WithEvents Level4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnLast As System.Windows.Forms.Button

End Class
