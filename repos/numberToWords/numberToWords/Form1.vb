
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > 0 Then
            Label1.Text = NumberToWord(Val(TextBox1.Text))
        Else
            MessageBox.Show("Please enter any amount")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c Then
            e.Handled = True
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Dim url As String = "http://www.youtube.com/coderbaba"

        Process.Start(url)
    End Sub
End Class
