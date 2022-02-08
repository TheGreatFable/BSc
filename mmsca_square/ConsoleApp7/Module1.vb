Module Module1
    'read a sequence of numbers, ending with 0, and output the maximum the minimum the sum the average and the variance
    Sub Main()
        Dim maxnum As Integer, minnum As Integer, sumnum As Integer, square As Integer, countnum As Integer, a As Single, avgvalue As Long, variancevalue As Single
        maxnum = -2 ^ 16
        minnum = (-1) * maxnum
        sumnum = 0
        square = 0
        countnum = 0
        Console.WriteLine("input numbers and 0 to end")
        a = Console.ReadLine
        While a <> 0
            If a > maxnum Then maxnum = a
            If a < minnum Then minnum = a
            sumnum = sumnum + a
            square = square + a ^ 2
            countnum = countnum + 1
            a = Console.ReadLine
        End While
        If countnum > 0 Then
            avgvalue = sumnum / countnum
            variancevalue = square / countnum - avgvalue ^ 2
            Console.WriteLine("the maximum is:")
            Console.WriteLine(maxnum)
            Console.WriteLine("the minimum is:")
            Console.WriteLine(minnum)
            Console.WriteLine("the sum is:")
            Console.WriteLine(sumnum)
            Console.WriteLine("the average is:")
            Console.WriteLine(avgvalue)
            Console.WriteLine("the variance is:")
            Console.WriteLine(variancevalue)
            MsgBox(":)")
        Else
            MsgBox("error")
        End If
    End Sub

End Module
