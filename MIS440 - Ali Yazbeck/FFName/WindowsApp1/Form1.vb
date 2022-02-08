Public Class Form1
    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click

        Dim ffname As String '--D:\myDir\project1\Tatiana.dat
        Dim drv As String  '--D:
        Dim folder As String  '--myDir\project1
        Dim fname As String '--Tatiana
        Dim fext As String  '--dat
        Dim pp, pf, pn, pt As Integer
        Dim i As Integer
        ffname = txtffname.Text

        '---drive
        pp = InStr(ffname, ":")
        If pp > 0 Then
            drv = Mid(ffname, 1, pp - 1)
        Else
            drv = ""
        End If
        If pp = 0 Then pp = 1

        '---folder
        folder = ""
        For i = Len(ffname) To pp Step -1
            If Mid(ffname, i, 1) = "\" Then
                pf = Len(ffname) - i  '--position of last \
                folder = Mid(ffname, pp + 1, pf + 1)
                Exit For
            End If
        Next

        '---filename
        pn = i + 1
        fname = Mid(ffname, pn, Len(ffname) - pn)

        '--extension
        pt = InStr(fname, ".")
        If pt > 0 Then
            fext = Mid(fname, pt + 1, Len(fname) - pt)
        Else
            fext = ""
        End If

        '---display
        txtdrive.text = drv
        txtfolder.text = folder
        txtfile.text = fname
        txtextension.text = fext


    End Sub
End Class
