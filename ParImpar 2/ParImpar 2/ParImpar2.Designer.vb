<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParImpar2
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
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.ListBoxNumeros = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelImpares = New System.Windows.Forms.Label()
        Me.LabelPares = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(126, 6)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(59, 20)
        Me.txtNum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduce un numero:"
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(191, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(191, 34)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "Limpiar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'ListBoxNumeros
        '
        Me.ListBoxNumeros.FormattingEnabled = True
        Me.ListBoxNumeros.Location = New System.Drawing.Point(15, 34)
        Me.ListBoxNumeros.Name = "ListBoxNumeros"
        Me.ListBoxNumeros.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxNumeros.Size = New System.Drawing.Size(170, 121)
        Me.ListBoxNumeros.TabIndex = 4
        Me.ListBoxNumeros.TabStop = False
        Me.ListBoxNumeros.UseTabStops = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(191, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(191, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Impares:"
        '
        'LabelImpares
        '
        Me.LabelImpares.AutoSize = True
        Me.LabelImpares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImpares.ForeColor = System.Drawing.Color.Red
        Me.LabelImpares.Location = New System.Drawing.Point(265, 84)
        Me.LabelImpares.Name = "LabelImpares"
        Me.LabelImpares.Size = New System.Drawing.Size(16, 16)
        Me.LabelImpares.TabIndex = 7
        Me.LabelImpares.Text = "0"
        '
        'LabelPares
        '
        Me.LabelPares.AutoSize = True
        Me.LabelPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPares.ForeColor = System.Drawing.Color.Green
        Me.LabelPares.Location = New System.Drawing.Point(265, 64)
        Me.LabelPares.Name = "LabelPares"
        Me.LabelPares.Size = New System.Drawing.Size(16, 16)
        Me.LabelPares.TabIndex = 8
        Me.LabelPares.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(191, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Blue
        Me.LabelTotal.Location = New System.Drawing.Point(265, 104)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(16, 16)
        Me.LabelTotal.TabIndex = 10
        Me.LabelTotal.Text = "0"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(191, 132)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'ParImpar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 166)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelPares)
        Me.Controls.Add(Me.LabelImpares)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxNumeros)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Name = "ParImpar2"
        Me.Text = "Par Impar 2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents ListBoxNumeros As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelImpares As System.Windows.Forms.Label
    Friend WithEvents LabelPares As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
