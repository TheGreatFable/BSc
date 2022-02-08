Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fullname, firstname, sta, lastname As String
        fullname = "Sami Mounir Chehab"
        Dim n, m As Integer
        n = fullname.IndexOf(" ")
        m = fullname.LastIndexOf(" ")
        sta = fullname.Substring(n, m)
        firstname = fullname.Substring(0, n)
        lastname = fullname.Substring(m + 1)
        sta = UCase(sta)
        TextBox1.Text = sta
        MsgBox(firstname)
        MsgBox(lastname)

    End Sub

End Class
