Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("http://192.168.1.254/login.lp")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.Document.GetElementById("login").SetAttribute("value", TextBox1.Text)
        WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text)

        WebBrowser1.Document.GetElementById(".save").InvokeMember("click")
    End Sub

    Function generater()

    End Function


End Class