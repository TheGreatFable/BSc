Public Class Form1
    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click


        Dim fullname, firstname, lastname, middlename, sep, newname As String
        Dim ps, ps1 As Integer
        fullname = txtFull.Text
        fullname = Trim(fullname) '---cleans unwanted spaces
        sep = " "
        If fullname = "" Then
            MsgBox("there is no name.")
        Else
            ps = InStr(fullname, sep)
            ps1 = InStr(ps + 1, fullname, sep)
            firstname = Mid(fullname, 1, ps - 1)
            lastname = Mid(fullname, ps1 + 1, Len(fullname) - ps1)
            middlename = Mid(fullname, ps + 1, Len(fullname) - 1 - (Len(firstname) + Len(lastname)))
        End If

        lastname = UCase(lastname)
        firstname = LCase(firstname)
        mid(firstname, 1, 1) = UCase(Mid(firstname, 1, 1))
        txtMiddle.Text = middlename
        txtFirst.Text = firstname
        txtLast.Text = lastname

        newname = lastname & " " & firstname
        txtNew.Text = newname


    End Sub
End Class
