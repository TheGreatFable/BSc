Module Module1
    Sub main()
        Console.WriteLine("Discount on total amount in invoices...rules: clients are divided... 1and 2 ...")
        Dim x As Integer
        Dim y As Integer
        Console.WriteLine("the discount is:")
        Console.WriteLine(disc(x, y))
        MsgBox(":)")
    End Sub
    Function disc(amount As Single, clientcode As Integer) As Single
        Dim discount As Single
        amount = InputBox("input the amount")
        clientcode = InputBox("input the client code 1 or 2")
        If clientcode = "1" Then
            If amount > 1000 Then
                discount = amount * 0.15
            Else
                discount = amount * 0.1
            End If
        Else
            If amount > 1000 Then
                discount = amount * 0.1
            Else
                discount = 0
            End If
        End If
        Return discount
    End Function


End Module
