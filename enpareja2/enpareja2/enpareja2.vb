Public Class enpareja2
    Public totalCartas As Integer
    Dim cartasIguales = New ArrayList
    Dim clicks As Integer = 0
    Dim cartasSelect(2) As Integer
    Dim limiteLinea As Integer
    Private Declare Function GetTickCount Lib "kernel32" () As Integer

    Private Sub enpareja2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If totalCartas = 12 Then
            Me.Width = (4 * 80) + 20
            Me.Height = (3 * 105) + 45
            limiteLinea = 4
        ElseIf totalCartas = 24 Then
            Me.Width = (8 * 80) + 20
            Me.Height = (3 * 105) + 45
            limiteLinea = 8
        Else
            Me.Width = (9 * 80) + 20
            Me.Height = (4 * 105) + 45
            limiteLinea = 9
        End If
        generarCartas()
    End Sub

    Private Sub compPareja(ByVal index As Integer)
        If Not cartasIguales.Contains(index) Then
            cartasSelect(clicks) = index
            If clicks = 1 Then
                If Not cartas(cartasSelect(0)) = cartas(cartasSelect(1)) Then
                    esperar(1000)
                    Dim img As PictureBox = CType(Controls("carta" & cartasSelect(0)), PictureBox)
                    img.Image = My.Resources.trasero
                    Dim img2 As PictureBox = CType(Controls("carta" & cartasSelect(1)), PictureBox)
                    img2.Image = My.Resources.trasero
                Else
                    cartasIguales.Add(cartasSelect(0))
                    cartasIguales.Add(cartasSelect(1))
                    If cartasIguales.Count = totalCartas Then
                        If MsgBox("¡Has ganado!" & vbNewLine & "¿Deseas volver a jugar?", MsgBoxStyle.OkCancel, "¡HAS GANADO!") = vbOK Then
                            generarCartas()
                        Else
                            Me.Hide()
                            inicio.Show()
                        End If
                    End If
                End If
                clicks = 0
                Exit Sub
            End If
            clicks = clicks + 1
        End If
    End Sub

    Private Sub generarCartas()
        Dim x As Integer = 5
        Dim y As Integer = 5
        Me.Controls.Clear()
        cartasIguales.Clear()
        For i As Integer = 0 To totalCartas - 1
            If i = limiteLinea Then
                y = y + 105
                x = 5
            ElseIf i = limiteLinea * 2 Then
                y = y + 105
                x = 5
            ElseIf i = limiteLinea * 3 Then
                y = y + 105
                x = 5
            End If
            Dim MyPictureBox As New Windows.Forms.PictureBox()
            MyPictureBox.Location = New System.Drawing.Point(x, y)
            MyPictureBox.Name = "carta" & i
            MyPictureBox.Size = New System.Drawing.Size(75, 100)
            MyPictureBox.Image = My.Resources.trasero
            MyPictureBox.TabIndex = i + 10
            Me.Controls.Add(MyPictureBox)
            AddHandler MyPictureBox.Click, AddressOf MyPictureBox_Click
            x = x + 80

        Next
    End Sub

    Private Sub MyPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim id As Integer = Val(Replace(sender.Name, "carta", ""))
        Console.WriteLine(cartas(id))
        sender.Image = CType(My.Resources.ResourceManager.GetObject("img" & cartas(id)), Image)
        compPareja(id)
    End Sub

    Private Sub esperar(ByVal time_whait As Integer)
        Dim retraso As Integer
        retraso = time_whait + GetTickCount
        While retraso >= GetTickCount
            Application.DoEvents()
        End While
    End Sub

End Class
