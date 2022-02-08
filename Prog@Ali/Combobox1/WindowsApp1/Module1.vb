Module Reformat
    Public CliID As Integer
    Public CliName As String
    Public CliAdress As String
    Public CliPhone As String
    Public CliCat As Integer
    Public CliFile As String = "C:\Users\Ali Yazbek\Desktop\MIS440 - Ali Yazbeck\ComboBox\employee.csv"
    Dim LiD As String
    Sub reformat(oldfile As String, newfile As String)
        FileOpen(5, oldfile, OpenMode.Input)
        FileOpen(6, newfile, OpenMode.Output)
        While Not EOF(5)
            Input(5, CliID)
            Input(9, CliName)
            Input(9, CliAdress)
            Input(9, CliPhone)
            Input(9, CliCat)
            '-----end of record
            '--format id
            CliID = Trim(CliID)
            LiD = Len(CliID)
            If LiD > 6 Then
                LiD = Mid(CliID, 1, 6)
            Else
                CliID = ""
            End If
            Write(6, CliID)
            '---remarque:writing a record
            File class(5)
                file class(6)

        End While
    End Sub


End Module
