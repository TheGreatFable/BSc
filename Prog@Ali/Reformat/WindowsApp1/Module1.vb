Module StringsOper

    Public CliID As Integer
    Public CliName As String
    Public CliAdress As String
    Public CliPhone As String
    Public CliCat As Integer
    Public CliFile As String = "C:\Users\Ali Yazbek\Desktop\MIS440 - Ali Yazbeck\Reformat\CliFile.dat"

    Sub names(fullname As String, firstname As String, lastname As String, sep As String, newname As String)


        Dim ps As Integer

        fullname = Trim(fullname) '---cleans unwanted spaces
        If sep = "" Then sep = " "
        If fullname = "" Then
            MsgBox("there is no name.")
        Else
            ps = InStr(fullname, sep)
            'MsgBox(ps)
            firstname = Mid(fullname, 1, ps - 1)
            lastname = Mid(fullname, ps + 1, Len(fullname) - ps)
        End If

        lastname = UCase(lastname)
        firstname = LCase(firstname)
        mid(firstname, 1, 1) = UCase(Mid(firstname, 1, 1))



        newname = lastname & " " & firstname


    End Sub

End Module
