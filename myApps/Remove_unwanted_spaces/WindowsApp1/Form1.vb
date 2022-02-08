Public Class Form1
    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click


        Dim oldstr As String
        oldstr = txtinput.Text
        oldstr = Trim(oldstr)

        While InStr(oldstr, "  ") > 0
            oldstr = Replace(oldstr, "  ", " ")
        End While
        While InStr(oldstr, "   ") > 0
            oldstr = Replace(oldstr, "   ", " ")
        End While
        While InStr(oldstr, "    ") > 0
            oldstr = Replace(oldstr, "    ", " ")
        End While
        While InStr(oldstr, "     ") > 0
            oldstr = Replace(oldstr, "     ", " ")
        End While
        While InStr(oldstr, "      ") > 0
            oldstr = Replace(oldstr, "      ", " ")
        End While
        While InStr(oldstr, "       ") > 0
            oldstr = Replace(oldstr, "       ", " ")
        End While
        While InStr(oldstr, "        ") > 0
            oldstr = Replace(oldstr, "        ", " ")
        End While
        While InStr(oldstr, "         ") > 0
            oldstr = Replace(oldstr, "         ", " ")
        End While
        While InStr(oldstr, "          ") > 0
            oldstr = Replace(oldstr, "          ", " ")
        End While

        txtresult.Text = oldstr







    End Sub
End Class
