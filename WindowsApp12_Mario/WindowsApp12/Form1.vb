Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aWord As String, found As Boolean
        Dim strInput As String
        Dim strSplit() As String
        Dim ll As Integer
        Dim j As Integer
        FileOpen(99, "C:\Users\User\Desktop\progp.txt", OpenMode.Input)
        Do While Not EOF(99)
            strInput = LineInput(99)
            cleanLine(strInput)
            strSplit = Split(strInput, " ")
            ll = UBound(strSplit)
            '-- numberofwords.Text = ll + 1
            For i = 0 To ll
                Myword(i) = strSplit(i)
                aWord = Trim(strSplit(i))
                If aWord = "" Then GoTo nxi
                '--now check if exist

                j = 0 : found = False
                Do While Not found And j <= wCount
                    If Myword(j) = aWord Then
                        MyFreq(j) = MyFreq(j) + 1
                        found = True
                    End If
                    j = j + 1
                Loop
                If Not found Then
                    wCount = wCount + 1
                    Myword(wCount) = aWord
                    MyFreq(wCount) = 1
                End If
                '-- MsgBox(i & "  " & wCount)
nxi:

            Next '--i to ll

        Loop '--file99
        MsgBox(wCount)
        ReDim Preserve Myword(wCount)
        ReDim Preserve MyFreq(wCount)
        Array.Sort(MyFreq, Myword)
        For w = wCount To wCount - 10 Step -1
            Console.WriteLine(Myword(w) & " " & MyFreq(w))
        Next









    End Sub
    Sub cleanLine(lineIn As String)
        Dim ee As String
        Dim l1 As String
        l1 = lineIn
        lineIn = ""
        For i = 1 To Len(lineIn)
            ee = Mid(lineIn, i, 1)
            If InStr("(),;-.", ee) = 0 Then
                lineIn = lineIn & ee

            End If
        Next

    End Sub


End Class
