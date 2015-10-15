Module Module1
    Private rng As New Random()
    Public cartas = New ArrayList
    Public cartas2 = New ArrayList
    Dim arrayNumeros = New ArrayList

    Public Function ShuffleArray(Of T)(ByVal arr() As T) As T()
        Dim left = Enumerable.Range(0, arr.Length).ToList()
        Dim result(arr.Length - 1) As T

        For i = 0 To arr.Length - 1
            Dim nextIndex = rng.Next(left.Count)
            result(i) = arr(left(nextIndex))
            left.RemoveAt(nextIndex)
        Next

        Return result
    End Function

    Public Function RandomOrder(ByVal arrList As ArrayList)
        Dim r As Random = New Random()
        For cnt As Integer = 0 To arrList.Count - 1
            Dim tmp As Object = arrList(cnt)
            Dim idx As Integer = r.Next(arrList.Count - cnt) + cnt
            arrList(cnt) = arrList(idx)
            arrList(idx) = tmp
        Next cnt
        Return arrList
    End Function

    Public Sub CartasRandom(ByVal limit As Integer)
        For i As Integer = 0 To 17
            arrayNumeros.Add(i)
        Next
        Dim cartasN = RandomOrder(arrayNumeros)
        Dim cartasRnd As New ArrayList
        For i As Integer = 0 To limit - 1
            cartasRnd.Add(cartasN(i))
            cartasRnd.Add(cartasN(i))
        Next
        cartas = RandomOrder(cartasRnd)
    End Sub
End Module
