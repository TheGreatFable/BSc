Module Module1
    'Ali Yazbek
    '---
    'A commercial firm grants a discount for special clients according to the following: "For the first $1000 bracket, a 10% discount; then 20% for the backet above 1000."
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
