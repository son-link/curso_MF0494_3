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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbFacil = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.rbDificil = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enpareja2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nivel:"
        '
        'rbFacil
        '
        Me.rbFacil.AutoSize = True
        Me.rbFacil.Checked = True
        Me.rbFacil.Location = New System.Drawing.Point(66, 64)
        Me.rbFacil.Name = "rbFacil"
        Me.rbFacil.Size = New System.Drawing.Size(100, 17)
        Me.rbFacil.TabIndex = 2
        Me.rbFacil.TabStop = True
        Me.rbFacil.Text = "Fácil (12 cartas)"
        Me.rbFacil.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Location = New System.Drawing.Point(66, 87)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(111, 17)
        Me.rbNormal.TabIndex = 3
        Me.rbNormal.Text = "Normal (24 cartas)"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'rbDificil
        '
        Me.rbDificil.AutoSize = True
        Me.rbDificil.Location = New System.Drawing.Point(66, 110)
        Me.rbDificil.Name = "rbDificil"
        Me.rbDificil.Size = New System.Drawing.Size(103, 17)
        Me.rbDificil.TabIndex = 5
        Me.rbDificil.Text = "Dificil (36 cartas)"
        Me.rbDificil.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(55, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Jugar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 173)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbDificil)
        Me.Controls.Add(Me.rbNormal)
        Me.Controls.Add(Me.rbFacil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inicio"
        Me.Text = "Enpareja2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbFacil As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbDificil As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
