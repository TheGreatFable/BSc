Module Module1
    Dim x As Integer
    Dim y As Integer
    Function maxi(a As Integer, b As Integer) As Integer
        x = Console.ReadLine
        y = Console.ReadLine
        If a > b Then
            Return a
        Else
            Return b
        End If
        Console.WriteLine(maxi(x, y))
    End Function
End Module
