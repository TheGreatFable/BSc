Module mdbNumbers

    Public nArray(100000) As Long
    Public nLim As Long 'array limit
    Public homeDir As String = "C:\MIS440\data\"
    Public inFile As String = "C:\MIS440\data\numbers.txt"
    Public outFile As String = "C:\MIS440\data\SortedNumbers.txt"

    Sub LoadNum()
        FileOpen(1, inFile, OpenMode.Input)
        Dim xn As Long
        Dim count As Long = 0
        While Not EOF(1)
            Input(1, xn)
            nArray(count) = xn
            count = count + 1
        End While
        MsgBox("loaded " & count)
        nLim = count - 1
        FileClose(1)
    End Sub


End Module
