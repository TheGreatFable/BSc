Module Module1
    Dim n As Integer
    Dim maxNum As Single
    Dim r As Single
    Sub Main()
        Console.Title = "Ali program"
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Green
        maxNum1()
        maxNum2()
        maxNum3()
        positive()
    End Sub
    Sub maxNum1()
        Console.WriteLine("Hello!")
        Console.WriteLine("input 2 numbers")
        maxNum = -9999999
        For i = 1 To 2
            n = Console.ReadLine
            If n > maxNum Then
                maxNum = n
            End If
        Next
        MsgBox("First maxNum is:")
        MsgBox(maxNum)
    End Sub
    Sub maxNum2()
        maxNum = -99999999
        Console.WriteLine("input 3 numbers")
        For i = 1 To 3
            n = Console.ReadLine
            If n > maxNum Then
                maxNum = n
            End If
        Next
        MsgBox("Second maxNum is:")
        MsgBox(maxNum)
    End Sub
    Sub maxNum3()
        maxNum = -9999999
        Console.WriteLine("input 4 numbers")
        For i = 1 To 4
            n = Console.ReadLine
            If n > maxNum Then
                maxNum = n
            End If
        Next
        MsgBox("Third maxNum is:")
        MsgBox(maxNum)
    End Sub
    Sub positive()
        r = 1
        Console.WriteLine("input a positive number")
        n = Console.ReadLine
        If n > 0 Then
            For i = 1 To n
                r = r * i
            Next
            MsgBox("the result is:")
            MsgBox(r)
        Else
            MsgBox("number inputed is negative")
        End If
    End Sub
End Module
