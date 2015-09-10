<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParImpar
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnComp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(13, 13)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 0
        '
        'btnComp
        '
        Me.btnComp.Location = New System.Drawing.Point(119, 13)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(75, 20)
        Me.btnComp.TabIndex = 1
        Me.btnComp.Text = "Comprobar"
        Me.btnComp.UseVisualStyleBackColor = True
        '
        'ParImpar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 46)
        Me.Controls.Add(Me.btnComp)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "ParImpar"
        Me.Text = "Comprobar Par/Impar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents btnComp As System.Windows.Forms.Button

End Class
