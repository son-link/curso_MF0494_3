Module Module1
    Public totalPares As Integer
    Public totalImpares As Integer
    Public totalNumeros As Integer
    Private titulo As String
    Private MyTimer As New System.Windows.Forms.Timer()
    Private contador As Integer

    Public Function iniciar() As Boolean
        totalImpares = 0
        totalPares = 0
        totalNumeros = 0
        ParImpar2.LabelImpares.Text = 0
        ParImpar2.LabelPares.Text = 0
        ParImpar2.LabelTotal.Text = 0
        ParImpar2.btnAdd.Enabled = False
        ParImpar2.ListBoxNumeros.Items.Clear()
        titulo = "Par Impar 2.0"
        contador = 1
        'cambiaTitulo()
    End Function

    Public Function compNumero(ByVal numero) As Boolean
        If IsNumeric(numero) And numero <> "" Then
            ParImpar2.btnAdd.Enabled = True
        Else
            ParImpar2.btnAdd.Enabled = False
        End If
    End Function

    Public Function ParImpar() As Boolean
        ' Dim resto As Integer
        Dim resto As Integer
        resto = ParImpar2.txtNum.Text Mod 2
        If resto = 0 Then
            ' El numero dado es par
            totalPares = totalPares + 1
            ParImpar2.LabelPares.Text = totalPares
        Else
            totalImpares = totalImpares + 1
            ParImpar2.LabelImpares.Text = totalImpares
        End If
        ParImpar2.ListBoxNumeros.Items.Add(ParImpar2.txtNum.Text)
        totalNumeros = totalNumeros + 1
        ParImpar2.LabelTotal.Text = totalNumeros
        ParImpar2.txtNum.Text = ""
        ParImpar2.txtNum.Focus()
        
    End Function
       

    Public Function cambiaTitulo() As Boolean
        ' AddHandler MyTimer.Tick, AddressOf TimerEventProcessor
        ' MyTimer.Enabled = True
        ' MyTimer.Interval = 1000
        ' MyTimer.Start()
        ParImpar2.Text = Mid(titulo, 1, contador)
        ' While True
        If contador < titulo.Length Then
            contador = contador + 1
        Else
            contador = 0
        End If
        ' End While
    End Function
End Module
