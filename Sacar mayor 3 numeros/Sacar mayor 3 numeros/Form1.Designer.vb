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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.numero3 = New System.Windows.Forms.TextBox()
        Me.btnComp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero 3"
        '
        'numero1
        '
        Me.numero1.Location = New System.Drawing.Point(106, 12)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(100, 20)
        Me.numero1.TabIndex = 3
        '
        'numero2
        '
        Me.numero2.Location = New System.Drawing.Point(106, 44)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(100, 20)
        Me.numero2.TabIndex = 4
        '
        'numero3
        '
        Me.numero3.Location = New System.Drawing.Point(106, 72)
        Me.numero3.Name = "numero3"
        Me.numero3.Size = New System.Drawing.Size(100, 20)
        Me.numero3.TabIndex = 5
        '
        'btnComp
        '
        Me.btnComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComp.Location = New System.Drawing.Point(17, 113)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(100, 28)
        Me.btnComp.TabIndex = 6
        Me.btnComp.Text = "Comparar"
        Me.btnComp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnComp)
        Me.Controls.Add(Me.numero3)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numero1 As System.Windows.Forms.TextBox
    Friend WithEvents numero2 As System.Windows.Forms.TextBox
    Friend WithEvents numero3 As System.Windows.Forms.TextBox
    Friend WithEvents btnComp As System.Windows.Forms.Button

End Class
