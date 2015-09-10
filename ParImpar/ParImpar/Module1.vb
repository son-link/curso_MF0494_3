Module Module1
    Public resto As Integer
    Public Function compParImpar(ByVal num1 As Integer) As Boolean
        resto = num1 Mod 2
        If resto = 0 Then
            compParImpar = True
        Else
            compParImpar = False
        End If
    End Function
End Module
