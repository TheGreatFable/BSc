Module Module1

    Sub Main()
        Dim x As Integer
        x = InputBox("input a number")
        Console.WriteLine("the result is:")
        Console.WriteLine(Facto(x))
        If x < 10 Then
            Console.WriteLine("value of Facto is:")
            Console.WriteLine(x)
        End If
        MsgBox(":)")
    End Sub
    Function Facto(n As Integer) As Integer
        Dim i As Integer, r As Integer
        r = 1
        If n >= 0 Then
            For i = 1 To n
                r = r * i
            Next
            Return r
        Else
            Return ("0")
        End If
    End Function
End Module
