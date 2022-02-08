Module Module1

    Sub Main()
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
End Module
