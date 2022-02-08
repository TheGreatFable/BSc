Module Module1

    Sub Main()
        Dim a, c As String
        Dim b As String()

        a = "this morning is very cold"

        b = a.Split(" ")

        For Each c In b
            Console.WriteLine(c)
        Next

        MsgBox(":)")
    End Sub

End Module
