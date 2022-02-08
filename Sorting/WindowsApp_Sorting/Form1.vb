Public Class Form1

    Dim thearray(1000000) As Integer
    Dim num As Integer

    '----------------------------------------Load--------------------------------------------------------

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        Dim i As Integer
        num = CInt(txtLimit.Text)
        If num < 1 Then
            MsgBox("please fill in the limit textbox")
            Exit Sub
        End If
        For i = 0 To num
            thearray(i) = Rnd() * 100000
        Next

        Console.WriteLine("Loaded")
    End Sub

    '-------------------------------------------Print--------------------------------------------------

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Dim i As Integer
        Console.Clear()
        For i = 1 To num
            Console.WriteLine(thearray(i))
        Next

    End Sub

    '---------------------------------------------Selection Sort------------------------------------------

    Private Sub cmdSelection_Click(sender As Object, e As EventArgs) Handles cmdSelection.Click

        Dim top, i, temp As Integer
        For top = 0 To num - 1
            For i = top + 1 To num
                If thearray(i) < thearray(top) Then
                    temp = thearray(top)
                    thearray(top) = thearray(i)
                    thearray(i) = temp
                End If
            Next
        Next

        Console.WriteLine("Sorted")
    End Sub

    '---------------------------------------------Bubble up Sort----------------------------------------

    Private Sub cmdBubble_Click(sender As Object, e As EventArgs) Handles cmdBubble.Click

        Dim swaps, i, temp As Integer
        swaps = 1
        While swaps > 0
            swaps = 0
            For i = 0 To num - 1
                If thearray(i) > thearray(i + 1) Then
                    temp = thearray(i + 1)
                    thearray(i + 1) = thearray(i)
                    thearray(i) = temp
                    swaps = swaps + 1
                End If
            Next
        End While

        Console.WriteLine("Sorted")
    End Sub

    '----------------------------------------VB Sort--------------------------------------------
    Private Sub cmdVB_Click(sender As Object, e As EventArgs) Handles cmdVB.Click

        Array.Sort(thearray)

        Console.WriteLine("Sorted")
    End Sub

    '------------------------------------------Binary Search---------------------------------------------

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click

        Dim found As Boolean
        Dim numVal, low, high, mid, location As Integer
        low = 1
        high = num
        found = False
        numVal = CInt(txtVal.Text)
        While (Not found) And (high > low)
            mid = (low + high) \ 2
            If thearray(mid) = numVal Then
                found = True
                location = mid
            Else
                If thearray(mid) > numVal Then
                    high = mid
                Else
                    low = mid
                End If
            End If
        End While
        If found Then
            txtResult.Text = location
        Else
            txtResult.Text = "Not found"
        End If
    End Sub

End Class
