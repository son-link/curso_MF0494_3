<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.panelBtns = New System.Windows.Forms.Panel()
        Me.LabelTest = New System.Windows.Forms.Label()
        Me.panelBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.Green
        Me.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerde.Location = New System.Drawing.Point(3, 3)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(80, 80)
        Me.btnVerde.TabIndex = 0
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.DarkRed
        Me.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRojo.Location = New System.Drawing.Point(89, 3)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(80, 80)
        Me.btnRojo.TabIndex = 1
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.Color.Blue
        Me.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAzul.Location = New System.Drawing.Point(89, 89)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(80, 80)
        Me.btnAzul.TabIndex = 2
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnAmarillo
        '
        Me.btnAmarillo.BackColor = System.Drawing.Color.Goldenrod
        Me.btnAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmarillo.Location = New System.Drawing.Point(3, 89)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(80, 80)
        Me.btnAmarillo.TabIndex = 3
        Me.btnAmarillo.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(54, 184)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(80, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Jugar"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'panelBtns
        '
        Me.panelBtns.Controls.Add(Me.btnVerde)
        Me.panelBtns.Controls.Add(Me.btnRojo)
        Me.panelBtns.Controls.Add(Me.btnAmarillo)
        Me.panelBtns.Controls.Add(Me.btnAzul)
        Me.panelBtns.Enabled = False
        Me.panelBtns.Location = New System.Drawing.Point(12, 6)
        Me.panelBtns.Name = "panelBtns"
        Me.panelBtns.Size = New System.Drawing.Size(173, 172)
        Me.panelBtns.TabIndex = 5
        '
        'LabelTest
        '
        Me.LabelTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTest.ForeColor = System.Drawing.Color.White
        Me.LabelTest.Location = New System.Drawing.Point(15, 235)
        Me.LabelTest.Name = "LabelTest"
        Me.LabelTest.Size = New System.Drawing.Size(166, 23)
        Me.LabelTest.TabIndex = 6
        Me.LabelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(204, 292)
        Me.Controls.Add(Me.LabelTest)
        Me.Controls.Add(Me.panelBtns)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Form1"
        Me.Text = "Simon"
        Me.panelBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents btnAmarillo As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents panelBtns As System.Windows.Forms.Panel
    Friend WithEvents LabelTest As System.Windows.Forms.Label

End Class
