Public Class Form1
    Dim myArray(999) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        init()
        lookup()
    End Sub
    Sub init()
        For i = 0 To 999
            myArray(i) = Int(Rnd() * 10000)
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Sub lookup()
        Dim myvalue As Integer
        Dim location As String
        myvalue = 1
        While myvalue <> 0
            Console.WriteLine("input a number from the list above or 0 to end")
            myvalue = Console.ReadLine
            If myvalue <> 0 Then
                location = find(myvalue)
                Console.WriteLine(myvalue & " is found in " & location)
            End If
        End While
        MsgBox(":)")
    End Sub
    Function find(avalue As Integer) As String
        Dim j As Integer
        Dim found As Boolean
        Dim location2 As Integer
        j = 0
        found = False
        While (j <= 999) And found = False
            If myArray(j) = avalue Then
                found = True
                location2 = j
            End If
            j = j + 1
        End While
        If found Then
            Return location2
        Else
            Return "another universe, not in here"
        End If
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
    Dim day_Names(7) As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        init2()
        Dim nn As Integer
        For i = 1 To 7
            Console.WriteLine(day_Names(i))
        Next
        Console.WriteLine("input a number between 1 and 7")
        nn = Console.ReadLine
        MsgBox(day_Names(nn))
    End Sub
    Sub init2()
        '---fill the names of days
        day_Names(1) = "Monday"
        day_Names(2) = "Tuesday"
        day_Names(3) = "Wednesday"
        day_Names(4) = "Thursday"
        day_Names(5) = "Friday"
        day_Names(6) = "Saturday"
        day_Names(7) = "Sunday"
        '---
    End Sub
    Function NameOfDay(Num As Integer) As String
        If (Num > 7) Or (Num < 1) Then
            Return ""
        Else
            Return day_Names(Num)
        End If
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer
        x = InputBox("input an amount")
        Console.WriteLine("the discount is:")
        Console.WriteLine(Disc(x))
        MsgBox(":)")
    End Sub
    Function Disc(amount As Integer) As Single
        Dim discount As Integer
        If amount <= 1000 Then
            discount = amount * 0.1
        Else
            discount = 100 + (amount - 1000) * 0.2
        End If
        Return discount
    End Function
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
End Class
