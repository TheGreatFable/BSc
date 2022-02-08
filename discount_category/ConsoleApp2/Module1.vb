Module Module1
    Dim amount As String
    Dim category As String
    Dim discount As String

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Input the total amount")
        amount = Console.ReadLine
        Console.WriteLine("Input category 1 or 2")
        category = Console.ReadLine
        If category = "1" Then
            If amount > 1000 Then
                discount = amount * 0.15
            Else
                discount = amount * 0.1
            End If
        Else
            If amount > 1000 Then
                discount = amount * 0.1
            End If
        End If
        MsgBox(discount)
    End Sub

End Module
