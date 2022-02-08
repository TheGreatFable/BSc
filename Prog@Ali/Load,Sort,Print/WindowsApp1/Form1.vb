Public Class Form1
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        LoadNum()



    End Sub

    Private Sub cmdSortPrint_Click(sender As Object, e As EventArgs) Handles cmdSortPrint.Click

        Dim top, i, temp As Long
        For top = 0 To nLim - 1
            For i = top + 1 To nLim
                If nArray(i) < nArray(top) Then
                    temp = nArray(top)
                    nArray(top) = nArray(i)
                    nArray(i) = temp
                End If
            Next
        Next

        FileOpen(2, outFile, OpenMode.Output)
        For i = 0 To nLim
            WriteLine(2, nArray(i))
        Next
        MsgBox("done")
        FileClose(2)
    End Sub
End Class
