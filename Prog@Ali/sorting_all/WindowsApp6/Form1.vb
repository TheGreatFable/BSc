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
        MsgBox("done")
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

    Private Sub cmdBubble_Click(sender As Object, e As EventArgs) Handles cmdBubble.Click
        Dim swaps, i, temp As Integer
        Dim t1, t2 As Single
        t1 = TimeOfDay.Millisecond
        swaps = 1
        While swaps > 0
            swaps = 0
            For i = 0 To lim - 1
                If myarray(i) > myarray(i + 1) Then
                    temp = myarray(i + 1)
                    myarray(i + 1) = myarray(i)
                    myarray(i) = temp
                    swaps = swaps + 1
                End If
            Next
        End While
        t1 = TimeOfDay.Millisecond
        MsgBox("done")
        txtElapse.Text = t2 - t1
    End Sub

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click
        Dim found As Boolean
        Dim numVal, low, high, mid, location As Integer
        '---Start
        low = 1
        high = lim
        found = False
        numVal = CInt(txtVal.Text)
        While (Not found) And (high > low)
            mid = (low + high) \ 2
            If myarray(mid) = numVal Then
                found = True
                location = mid
            Else
                If myarray(mid) > numVal Then
                    high = mid
                Else
                    low = mid
                End If
            End If
        End While
        If found Then
            txtResult.Text = location
        Else
            txtResult.Text = "not found"
        End If
    End Sub
End Class
