Public Class Form1
    Dim myarray(50000) As Integer
    Dim lim As Integer

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        lim = CInt(txtLimit.Text)
        If lim < 1 Then
            MsgBox("please fill in the limit textbox")
            Exit Sub
        End If
        For i = 0 To lim
            myarray(i) = Rnd() * 100000
        Next

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Console.Clear()
        For i = 1 To lim
            Console.WriteLine(myarray(i))
        Next
    End Sub

    Private Sub cmdSelection_Click(sender As Object, e As EventArgs) Handles cmdSelection.Click
        Dim top, i, temp As Integer
        Dim t1, t2 As Single
        t1 = TimeOfDay.Second

        For top = 0 To lim - 1
            For i = top + 1 To lim
                If myarray(i) < myarray(top) Then
                    temp = myarray(top)
                    myarray(top) = myarray(i)
                    myarray(i) = temp
                End If
            Next
        Next
        t2 = TimeOfDay.Second
        MsgBox("Done")
        txtElapse.Text = t2 - t1

    End Sub
End Class
