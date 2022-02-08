Module Module1
    '2 ex
    Sub Main()
        Dim w As Integer
        Console.WriteLine(fibo(w))
        temperature()
        MsgBox(":)")
    End Sub
    Sub temperature()
        Dim t As Single
        Console.WriteLine("input t")
        t = Console.ReadLine
        If t < 0 Then
            Console.WriteLine("ICE")
        Else
            If t <= 100 Then
                Console.WriteLine("LIQUID")
            Else
                Console.WriteLine("STEAM")
            End If
        End If
    End Sub
    Function fibo(n As Integer) As Integer
        Dim s1 As Integer, s2 As Integer, i As Integer, result As Integer
        result = 0
        s1 = 1
        s2 = 1
        Console.WriteLine("input n")
        n = Console.ReadLine
        For i = 3 To n
            result = s1 + s2
            s1 = s2
            s2 = result
        Next
        Console.WriteLine("result:")
        Return result
    End Function
End Module
