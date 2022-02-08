Module Module1

    Sub Main()

        Dim pp1, pp2, a, b, c As String
        pp1 = InStr("what is this string?", "is")
        pp2 = InStr(8, "what is this string?", "is")
        MsgBox(pp1)

        a = "hello world!"
        a = Left(a, 11)
        MsgBox(a)

        b = "i want to break free!"
        b = Mid(b, 3, 4)
        MsgBox(b)

        c = "                        immm halleen in lovveeee                 "
        c = Trim(c)
        MsgBox(c)

        Dim i As Integer

        For i = 0 To 5
            Console.WriteLine(i)
        Next
        MsgBox(":)")





    End Sub


End Module
