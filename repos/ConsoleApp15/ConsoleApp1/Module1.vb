Module Module1

    Sub Main()
        Dim maxnum, minnum, sumnum, countnum, a, avgvalue As Integer
        maxnum = -2 ^ 16
        minnum = (-1) * maxnum
        sumnum = 0
        countnum = 0
        a = InputBox("input numbers or 0 to end")
        While a <> 0
            If a > maxnum Then maxnum = a
            If a < minnum Then minnum = a
            sumnum = sumnum + a
            countnum = countnum + 1
            a = InputBox("input numbers or 0 to end")
        End While
        If countnum > 0 Then
            avgvalue = sumnum / countnum
            Console.WriteLine("the average is:")
            Console.WriteLine(avgvalue)
            Console.WriteLine("the maximum is:")
            Console.WriteLine(maxnum)
            Console.WriteLine("the minimum is:")
            Console.WriteLine(minnum)
            MsgBox(":)")
        Else
            MsgBox("error")
        End If
    End Sub

End Module
