Module Module1

    Sub Main()
        ' The file system path we need to split.
        Dim s As String = "C:\Users\Sam\Documents\Perls\Main"

        ' Split the string on the backslash character.
        Dim parts As String() = s.Split(New Char() {"\"c})

        ' Loop through result strings with For Each.
        Dim part As String
        For Each part In parts
            Console.WriteLine(part)
        Next
        MsgBox(":)")
    End Sub

End Module
