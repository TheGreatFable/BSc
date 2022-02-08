Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myArray() As String
        Dim strLine As String
        Dim Num As Integer
        Dim Separ As String


        strLine = Trim(txtLine.Text)
        Separ = txtSepar.Text
        myArray = Split(strLine, Separ)
        Num = UBound(myArray)
        MsgBox(Num)
        '--Show my Array
        For i = 0 To Num
            Console.BackgroundColor = ConsoleColor.White
            Console.WriteLine(myArray(i))
        Next
        MsgBox("done")
        If Separ = "" Then Separ = Space(1)


    End Sub
End Class
