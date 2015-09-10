<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioEasy = New System.Windows.Forms.RadioButton()
        Me.radioNormal = New System.Windows.Forms.RadioButton()
        Me.radioHard = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione una dificultad"
        '
        'radioEasy
        '
        Me.radioEasy.AutoSize = True
        Me.radioEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioEasy.Location = New System.Drawing.Point(23, 36)
        Me.radioEasy.Name = "radioEasy"
        Me.radioEasy.Size = New System.Drawing.Size(60, 20)
        Me.radioEasy.TabIndex = 1
        Me.radioEasy.Text = "Fácil"
        Me.radioEasy.UseVisualStyleBackColor = True
        '
        'radioNormal
        '
        Me.radioNormal.AutoSize = True
        Me.radioNormal.Checked = True
        Me.radioNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNormal.Location = New System.Drawing.Point(89, 36)
        Me.radioNormal.Name = "radioNormal"
        Me.radioNormal.Size = New System.Drawing.Size(76, 20)
        Me.radioNormal.TabIndex = 2
        Me.radioNormal.TabStop = True
        Me.radioNormal.Text = "Normal"
        Me.radioNormal.UseVisualStyleBackColor = True
        '
        'radioHard
        '
        Me.radioHard.AutoSize = True
        Me.radioHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioHard.Location = New System.Drawing.Point(171, 36)
        Me.radioHard.Name = "radioHard"
        Me.radioHard.Size = New System.Drawing.Size(65, 20)
        Me.radioHard.TabIndex = 3
        Me.radioHard.Text = "Difícil"
        Me.radioHard.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(89, 62)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 28)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Jugar"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 101)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.radioHard)
        Me.Controls.Add(Me.radioNormal)
        Me.Controls.Add(Me.radioEasy)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radioEasy As System.Windows.Forms.RadioButton
    Friend WithEvents radioNormal As System.Windows.Forms.RadioButton
    Friend WithEvents radioHard As System.Windows.Forms.RadioButton
    Friend WithEvents btnPlay As System.Windows.Forms.Button
End Class
