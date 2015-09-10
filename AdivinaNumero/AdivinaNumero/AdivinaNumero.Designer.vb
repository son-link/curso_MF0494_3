<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdivinaNumero
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnAdivina = New System.Windows.Forms.Button()
        Me.txtIntentos = New System.Windows.Forms.Label()
        Me.labelMayorMenor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adivine el numero del 1 al 200"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(16, 32)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        '
        'btnAdivina
        '
        Me.btnAdivina.Location = New System.Drawing.Point(122, 32)
        Me.btnAdivina.Name = "btnAdivina"
        Me.btnAdivina.Size = New System.Drawing.Size(75, 20)
        Me.btnAdivina.TabIndex = 2
        Me.btnAdivina.Text = "Adivinar"
        Me.btnAdivina.UseVisualStyleBackColor = True
        '
        'txtIntentos
        '
        Me.txtIntentos.AutoSize = True
        Me.txtIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntentos.Location = New System.Drawing.Point(13, 60)
        Me.txtIntentos.Name = "txtIntentos"
        Me.txtIntentos.Size = New System.Drawing.Size(151, 16)
        Me.txtIntentos.TabIndex = 3
        Me.txtIntentos.Text = "Le quedan 6 intentos"
        '
        'labelMayorMenor
        '
        Me.labelMayorMenor.AutoSize = True
        Me.labelMayorMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMayorMenor.Location = New System.Drawing.Point(203, 33)
        Me.labelMayorMenor.Name = "labelMayorMenor"
        Me.labelMayorMenor.Size = New System.Drawing.Size(67, 16)
        Me.labelMayorMenor.TabIndex = 4
        Me.labelMayorMenor.Text = "Más alto"
        '
        'AdivinaNumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 85)
        Me.Controls.Add(Me.labelMayorMenor)
        Me.Controls.Add(Me.txtIntentos)
        Me.Controls.Add(Me.btnAdivina)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdivinaNumero"
        Me.Text = "Adivina Numero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents btnAdivina As System.Windows.Forms.Button
    Friend WithEvents txtIntentos As System.Windows.Forms.Label
    Friend WithEvents labelMayorMenor As System.Windows.Forms.Label

End Class
