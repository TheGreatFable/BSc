Module Module1

    Sub Main()

        Dim fullname, middlename As String
        fullname = "Sami Mounir Chehab"
        middlename = Mid(fullname, 6, 6)
        middlename = UCase(middlename)
        MsgBox(middlename)

        Dim onespace As String
        onespace = "this   is  a bad   string"
        onespace = Trim(onespace)
        While InStr(onespace, "  ") > 0
            onespace = Replace(onespace, "  ", " ")
        End While
        While InStr(onespace, "   ") > 0
            onespace = Replace(onespace, "   ", " ")
        End While
        While InStr(onespace, "    ") > 0
            onespace = Replace(onespace, "    ", " ")
        End While
        MsgBox(onespace)

        Dim stringVal As String = "-123,456,277.50$"
        stringVal = Replace(stringVal, ",", "")
        stringVal = Replace(stringVal, ".50$", "")
        MsgBox(stringVal)

        Dim texti As String = "this  is a long string where many  words are  found"
        Dim l, b, n As Integer
        While InStr(texti, "  ") > 0
            texti = Replace(texti, "  ", " ")
        End While
        n = 1
        l = Len(texti)
        For b = 1 To l
            If (Mid(texti, b, 1)) = " " Then
                n = n + 1
            End If
        Next
        MsgBox(n)



    End Sub

End Module
