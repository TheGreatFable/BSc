Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = Val(TextBox1.Text)
        If TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("error")
        Else
            If num <> 0 Then
                Timer111()
                TextBox1.Enabled = False


            End If
            If TextBox2.Text.Equals(TextBox6.Text) = True And TextBox5.Text.Equals(TextBox7.Text) = True Then
                MsgBox("hacked")
            End If
        End If

    End Sub

    Private Sub Timer111()
        Dim i, a As Integer
        a = 32
        Dim c As Char
        Dim str As String = ""
        For i = 0 To 94
            c = Chr(a)
            str = str + c
            TextBox2.Text = str
            Console.WriteLine(TextBox2.Text)

            TextBox3.Text = Val(TextBox3.Text) + 1
            a = a + 1
        Next



    End Sub

End Class
