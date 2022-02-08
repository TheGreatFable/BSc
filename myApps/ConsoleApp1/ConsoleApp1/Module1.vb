Module Module1

    Sub Main()

        '--------------------------

        Dim sep, family, fullname As String
        fullname = "Ali Yazbek"
        sep = InStr(fullname, " ")
        family = Mid(fullname, sep + 1, Len(fullname) - sep)
        MsgBox(family)

        '--------------------------

        MsgBox(Asc("A"))
        MsgBox(AscW("Пиер Хорассанжиан"))


        '--------------------------

        Dim L As Integer
        L = 5
        L = L = 5
        MsgBox(L)



    End Sub

End Module
