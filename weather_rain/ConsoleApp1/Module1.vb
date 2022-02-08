Module Module1
    Dim i As Integer
    Dim t As Single
    Sub Main()
        Console.Title = "Ali program"
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Green
        rain()
        mini()
    End Sub
    Sub rain()
        t = Console.ReadLine
        Console.WriteLine("========= the weather is:")
        If t < 0 Then
            Console.WriteLine("ice")
        Else
            If t < 100 Then
                Console.WriteLine("liquid")
            Else
                Console.WriteLine("steam")
            End If
        End If
        t = Console.ReadLine()
    End Sub
    Sub mini()
        Dim n As Integer, minNum As Integer
        minNum = 2 ^ 16
        n = minNum
        '----- read numbers, the last one 0 to find the minimum
        While n <> 0
            If n < minNum Then
                minNum = n
            End If
            n = Console.ReadLine
        End While
        MsgBox(minNum)
    End Sub
End Module
