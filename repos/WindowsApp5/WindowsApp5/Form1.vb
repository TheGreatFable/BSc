Public Class Form1
    Dim myarray(50000) As Integer, lim As Integer
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        lim = CInt(txtLim.Text)
        For i = 0 To lim
            myarray(i) = Rnd() * 100000
        Next
    End Sub
    Private Sub cmdSelection_Click(sender As Object, e As EventArgs) Handles cmdSelection.Click
        Dim top, i, temp As Integer
        For top = 0 To lim - 1
            For i = top + 1 To lim
                If myarray(i) < myarray(top) Then
                    temp = myarray(top)
                    myarray(top) = myarray(i)
                    myarray(i) = temp
                End If
            Next
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim ss, i As Integer
        For i = 0 To lim
            Console.WriteLine(myarray(i))
        Next
        ss = Console.ReadLine()
    End Sub
End Class
