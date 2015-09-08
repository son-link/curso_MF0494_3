<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculadora
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
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDivi = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtOperador = New System.Windows.Forms.Label()
        Me.ListResultados = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numero1
        '
        Me.numero1.Location = New System.Drawing.Point(13, 13)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(70, 20)
        Me.numero1.TabIndex = 0
        '
        'numero2
        '
        Me.numero2.Location = New System.Drawing.Point(114, 13)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(70, 20)
        Me.numero2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "="
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(215, 12)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(70, 20)
        Me.txtResultado.TabIndex = 3
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(13, 50)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(32, 32)
        Me.btnSuma.TabIndex = 4
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(51, 50)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(32, 32)
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(89, 50)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(32, 32)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDivi
        '
        Me.btnDivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivi.Location = New System.Drawing.Point(127, 50)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(32, 32)
        Me.btnDivi.TabIndex = 7
        Me.btnDivi.Text = "/"
        Me.btnDivi.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(165, 50)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(120, 32)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtOperador
        '
        Me.txtOperador.AutoSize = True
        Me.txtOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperador.Location = New System.Drawing.Point(89, 13)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(21, 20)
        Me.txtOperador.TabIndex = 9
        Me.txtOperador.Text = "N"
        '
        'ListResultados
        '
        Me.ListResultados.FormattingEnabled = True
        Me.ListResultados.Location = New System.Drawing.Point(13, 88)
        Me.ListResultados.Name = "ListResultados"
        Me.ListResultados.Size = New System.Drawing.Size(272, 95)
        Me.ListResultados.TabIndex = 10
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(13, 189)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 222)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.ListResultados)
        Me.Controls.Add(Me.txtOperador)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnDivi)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Name = "calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numero1 As System.Windows.Forms.TextBox
    Friend WithEvents numero2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnResta As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnDivi As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtOperador As System.Windows.Forms.Label
    Friend WithEvents ListResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button

End Class
