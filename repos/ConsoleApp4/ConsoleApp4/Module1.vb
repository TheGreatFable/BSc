Module Module1

    Sub maximum(n_count As Integer)
        '..init
        Dim i As Integer
        Dim maxi As Integer
        Dim a As Integer
        maxi = -2 ^ 16
        Console.Clear()
        Console.WriteLine("enter " & n_count & " numbers")
        '...
        If n_count < 2 Then
            MsgBox(0)
        Else
            For i = 1 To n_count
                a = Console.ReadLine()
                If a > maxi Then maxi = a
            Next
            '..output
            Console.WriteLine("the largest is " & maxi)
            MsgBox("ok?")
        End If
    End Sub
    Sub main()
        '..maxi...
        Dim n As Integer
        n = InputBox("enter the number of items ")
        maximum(n)
        maximum(5)
    End Sub
End Module
