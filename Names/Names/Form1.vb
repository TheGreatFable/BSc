Public Class Form1
    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click


        Dim fullname, firstname, lastname, sep, newname As String
        Dim ps As Integer
        fullname = txtFull.Text
        fullname = Trim(fullname) '---cleans unwanted spaces
        sep = " "
        If fullname = "" Then
            MsgBox("there is no name.")
        Else
            ps = InStr(fullname, sep)
            MsgBox(ps)
            firstname = Mid(fullname, 1, ps - 1)
            lastname = Mid(fullname, ps + 1, Len(fullname) - ps)
        End If

        lastname = UCase(lastname)
        firstname = LCase(firstname)
        mid(firstname, 1, 1) = UCase(Mid(firstname, 1, 1))

        txtFirst.Text = firstname
        txtLast.Text = lastname

        newname = lastname & " " & firstname
        txtNew.Text = newname


    End Sub
End Class
