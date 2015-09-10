<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonO = New System.Windows.Forms.RadioButton()
        Me.RadioButtonX = New System.Windows.Forms.RadioButton()
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Quien empieza?"
        '
        'RadioButtonO
        '
        Me.RadioButtonO.AutoSize = True
        Me.RadioButtonO.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonO.Location = New System.Drawing.Point(16, 45)
        Me.RadioButtonO.Name = "RadioButtonO"
        Me.RadioButtonO.Size = New System.Drawing.Size(63, 43)
        Me.RadioButtonO.TabIndex = 1
        Me.RadioButtonO.TabStop = True
        Me.RadioButtonO.Text = "O"
        Me.RadioButtonO.UseVisualStyleBackColor = True
        '
        'RadioButtonX
        '
        Me.RadioButtonX.AutoSize = True
        Me.RadioButtonX.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonX.Location = New System.Drawing.Point(127, 45)
        Me.RadioButtonX.Name = "RadioButtonX"
        Me.RadioButtonX.Size = New System.Drawing.Size(59, 43)
        Me.RadioButtonX.TabIndex = 2
        Me.RadioButtonX.TabStop = True
        Me.RadioButtonX.Text = "X"
        Me.RadioButtonX.UseVisualStyleBackColor = True
        '
        'btnEmpezar
        '
        Me.btnEmpezar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnEmpezar.FlatAppearance.BorderSize = 0
        Me.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpezar.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnEmpezar.Location = New System.Drawing.Point(52, 94)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(86, 36)
        Me.btnEmpezar.TabIndex = 3
        Me.btnEmpezar.Text = "Jugar"
        Me.btnEmpezar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(189, 141)
        Me.Controls.Add(Me.btnEmpezar)
        Me.Controls.Add(Me.RadioButtonX)
        Me.Controls.Add(Me.RadioButtonO)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.GreenYellow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonO As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonX As System.Windows.Forms.RadioButton
    Friend WithEvents btnEmpezar As System.Windows.Forms.Button
End Class
