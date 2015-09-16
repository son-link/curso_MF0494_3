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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ahorcado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelPalabra = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLetras = New System.Windows.Forms.RichTextBox()
        Me.imgAhorcado = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgAhorcado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.labelPalabra.Location = New System.Drawing.Point(14, 215)
        Me.labelPalabra.Name = "labelPalabra"
        Me.labelPalabra.Size = New System.Drawing.Size(19, 20)
        Me.labelPalabra.TabIndex = 2
        Me.labelPalabra.Text = "_"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Palabra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Letras pulsadas:"
        '
        'TextBoxLetras
        '
        Me.TextBoxLetras.AcceptsTab = True
        Me.TextBoxLetras.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLetras.DetectUrls = False
        Me.TextBoxLetras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxLetras.Location = New System.Drawing.Point(173, 53)
        Me.TextBoxLetras.Name = "TextBoxLetras"
        Me.TextBoxLetras.ReadOnly = True
        Me.TextBoxLetras.Size = New System.Drawing.Size(100, 96)
        Me.TextBoxLetras.TabIndex = 0
        Me.TextBoxLetras.Text = ""
        '
        'imgAhorcado
        '
        Me.imgAhorcado.Image = Global.WindowsApplication1.My.Resources.Resources.imgInicio
        Me.imgAhorcado.InitialImage = Global.WindowsApplication1.My.Resources.Resources.imgInicio
        Me.imgAhorcado.Location = New System.Drawing.Point(18, 25)
        Me.imgAhorcado.Name = "imgAhorcado"
        Me.imgAhorcado.Size = New System.Drawing.Size(146, 178)
        Me.imgAhorcado.TabIndex = 5
        Me.imgAhorcado.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Ahorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(286, 261)
        Me.Controls.Add(Me.imgAhorcado)
        Me.Controls.Add(Me.TextBoxLetras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelPalabra)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ahorcado"
        Me.Text = "Ahorcado"
        CType(Me.imgAhorcado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelPalabra As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLetras As System.Windows.Forms.RichTextBox
    Friend WithEvents imgAhorcado As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
