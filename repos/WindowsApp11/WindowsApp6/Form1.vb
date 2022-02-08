Public Class Form1

    '----------------------------------------Ali's Project-------------------------------------------------
    Dim myarray(1000000) As Integer
    Dim lim As Integer



    '----------------------------------------Load--------------------------------------------------------

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        '----Start the Load------------
        lim = CInt(txtLimit.Text)
        If lim < 1 Then
            MsgBox("please fill in the limit textbox")
            Exit Sub
        End If
        For i = 0 To lim
            myarray(i) = Rnd() * 100000
        Next
        '------Visible-------------
        cmdSelection.Visible = True
        cmdBubble.Visible = True
        cmdVB.Visible = True
        txtElapse.Visible = True

        Label5.Visible = True
        Label9.Visible = True
    End Sub

    '-------------------------------------------Print--------------------------------------------------

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        '------Start the Print button-----------
        Console.Clear()
        For i = 1 To lim
            Console.WriteLine(myarray(i))
        Next
        '------Visible-------------
        cmdBinary.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        txtVal.Visible = True
        txtResult.Visible = True
        Label7.Visible = True
    End Sub

    '---------------------------------------------Selection Sort------------------------------------------

    Private Sub cmdSelection_Click(sender As Object, e As EventArgs) Handles cmdSelection.Click
        Dim top, i, temp As Integer
        Dim t1, t2 As Single
        '---------Start the Selection Sort button------------
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
        txtElapse.Text = t2 - t1
        '------Visible-------------
        cmdPrint.Visible = True
        Label8.Visible = True
        Label2.Visible = True
    End Sub

    '---------------------------------------------Bubble up Sort----------------------------------------

    Private Sub cmdBubble_Click(sender As Object, e As EventArgs) Handles cmdBubble.Click
        Dim swaps, i, temp As Integer
        Dim t1, t2 As Single
        '-----------Start the Bubble up Sort button-------------
        t1 = TimeOfDay.Second
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
        t2 = TimeOfDay.Second
        txtElapse.Text = t2 - t1
        '------Visible-------------
        cmdPrint.Visible = True
        Label8.Visible = True
        Label2.Visible = True
    End Sub

    '----------------------------------------VB Sort--------------------------------------------

    Private Sub cmdVB_Click(sender As Object, e As EventArgs) Handles cmdVB.Click
        Dim t1, t2 As Single
        Dim temp As Integer
        Dim swapped
        Dim i
        '---Start the VB Sort button----------------------------
        t1 = TimeOfDay.Second
        Do
            swapped = False
            For i = 0 To lim - 1
                If myarray(i) > myarray(i + 1) Then
                    temp = myarray(i + 1)
                    myarray(i + 1) = myarray(i)
                    myarray(i) = temp
                    swapped = True
                End If
            Next
            If Not swapped Then Exit Do
            swapped = False
            For i = lim - 1 To 0 Step -1
                If myarray(i) > myarray(i + 1) Then
                    temp = myarray(i + 1)
                    myarray(i + 1) = myarray(i)
                    myarray(i) = temp
                    swapped = True
                End If
            Next
            If Not swapped Then Exit Do
        Loop
        t2 = TimeOfDay.Second
        txtElapse.Text = t2 - t1
        '------Visible-------------
        cmdPrint.Visible = True
        Label8.Visible = True
        Label2.Visible = True
    End Sub

    '------------------------------------------Binary Search---------------------------------------------

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click
        Dim found As Boolean
        Dim numVal, low, high, mid, location As Long
        '---Start the Binary Search button----------------------------
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
            txtResult.Text = "Not found"
        End If
    End Sub

    '-----------------------------------------Restart-------------------------------------------

    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        '-------------Start the Restart button--------------------
        Console.Clear()
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        cmdBinary.Visible = False
        cmdPrint.Visible = False
        cmdSelection.Visible = False
        cmdVB.Visible = False
        cmdBubble.Visible = False
        txtResult.Visible = False
        txtElapse.Visible = False
        txtVal.Visible = False
        txtVal.Clear()
        txtElapse.Text() = "  "
        txtResult.Text = "     "
    End Sub


End Class
