Module Module1
    'Ali Yazbek
    '---
    'Write a function which accepts a number and returns the name of the day in englsih. Using a public array of the names filled in the init sub called in the main sub.
    Public day_Names(7) As String
    Sub Main()
        init()
        Dim nn As Integer
        For i = 1 To 7
            Console.WriteLine(day_Names(i))
        Next
        Console.WriteLine("input a number between 1 and 7")
        nn = Console.ReadLine
        MsgBox(day_Names(nn))
    End Sub
    Sub init()
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
End Module
