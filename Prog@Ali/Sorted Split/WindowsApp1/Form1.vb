Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myArray(), strLine, Separ As String
        Dim Num, i As Integer

        strLine = Trim(txtLine.Text)
        Separ = txtSepar.Text
        myArray = Split(strLine, Separ)
        Num = UBound(myArray)
        MsgBox(Num)

        Array.Sort(myArray)

        '--Show my Array
        For i = 0 To Num
            Console.WriteLine(myArray(i))
        Next
        MsgBox("done")
        If Separ = "" Then Separ = Space(1)


    End Sub
End Class
