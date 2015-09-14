<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ahorcado
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
        Me.labelAhorcado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelPalabra = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFallo1 = New System.Windows.Forms.Label()
        Me.LabelFallos2al4 = New System.Windows.Forms.Label()
        Me.LabelFallos5y6 = New System.Windows.Forms.Label()
        Me.TextBoxLetras = New System.Windows.Forms.RichTextBox()
        Me.LabelFinAhorcado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelAhorcado
        '
        Me.labelAhorcado.AutoSize = True
        Me.labelAhorcado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAhorcado.Location = New System.Drawing.Point(18, 17)
        Me.labelAhorcado.Name = "labelAhorcado"
        Me.labelAhorcado.Size = New System.Drawing.Size(97, 50)
        Me.labelAhorcado.TabIndex = 5
        Me.labelAhorcado.Text = " ______" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/        |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pulse una letra para saber si esta en la palabra."
        '
        'labelPalabra
        '
        Me.labelPalabra.AutoSize = True
        Me.labelPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPalabra.Location = New System.Drawing.Point(15, 180)
        Me.labelPalabra.Name = "labelPalabra"
        Me.labelPalabra.Size = New System.Drawing.Size(0, 20)
        Me.labelPalabra.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Palabra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Letras pulsadas:"
        '
        'LabelFallo1
        '
        Me.LabelFallo1.AutoSize = True
        Me.LabelFallo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFallo1.Location = New System.Drawing.Point(18, 67)
        Me.LabelFallo1.Name = "LabelFallo1"
        Me.LabelFallo1.Size = New System.Drawing.Size(18, 25)
        Me.LabelFallo1.TabIndex = 7
        Me.LabelFallo1.Text = "|"
        '
        'LabelFallos2al4
        '
        Me.LabelFallos2al4.AutoSize = True
        Me.LabelFallos2al4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFallos2al4.Location = New System.Drawing.Point(18, 92)
        Me.LabelFallos2al4.Name = "LabelFallos2al4"
        Me.LabelFallos2al4.Size = New System.Drawing.Size(25, 25)
        Me.LabelFallos2al4.TabIndex = 8
        Me.LabelFallos2al4.Text = "| "
        '
        'LabelFallos5y6
        '
        Me.LabelFallos5y6.AutoSize = True
        Me.LabelFallos5y6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFallos5y6.Location = New System.Drawing.Point(18, 117)
        Me.LabelFallos5y6.Name = "LabelFallos5y6"
        Me.LabelFallos5y6.Size = New System.Drawing.Size(18, 25)
        Me.LabelFallos5y6.TabIndex = 9
        Me.LabelFallos5y6.Text = "|"
        '
        'TextBoxLetras
        '
        Me.TextBoxLetras.AcceptsTab = True
        Me.TextBoxLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLetras.DetectUrls = False
        Me.TextBoxLetras.Location = New System.Drawing.Point(132, 53)
        Me.TextBoxLetras.Name = "TextBoxLetras"
        Me.TextBoxLetras.ReadOnly = True
        Me.TextBoxLetras.Size = New System.Drawing.Size(100, 96)
        Me.TextBoxLetras.TabIndex = 0
        Me.TextBoxLetras.Text = ""
        '
        'LabelFinAhorcado
        '
        Me.LabelFinAhorcado.AutoSize = True
        Me.LabelFinAhorcado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinAhorcado.Location = New System.Drawing.Point(18, 142)
        Me.LabelFinAhorcado.Name = "LabelFinAhorcado"
        Me.LabelFinAhorcado.Size = New System.Drawing.Size(18, 25)
        Me.LabelFinAhorcado.TabIndex = 10
        Me.LabelFinAhorcado.Text = "|"
        '
        'Ahorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 261)
        Me.Controls.Add(Me.LabelFinAhorcado)
        Me.Controls.Add(Me.TextBoxLetras)
        Me.Controls.Add(Me.LabelFallos5y6)
        Me.Controls.Add(Me.LabelFallos2al4)
        Me.Controls.Add(Me.LabelFallo1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelPalabra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelAhorcado)
        Me.Name = "Ahorcado"
        Me.Text = "Ahorcado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelAhorcado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelPalabra As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelFallo1 As System.Windows.Forms.Label
    Friend WithEvents LabelFallos2al4 As System.Windows.Forms.Label
    Friend WithEvents LabelFallos5y6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLetras As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelFinAhorcado As System.Windows.Forms.Label

End Class
