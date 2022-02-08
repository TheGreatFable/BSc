Public Class Form1


    Private Sub cmdgcd_Click(sender As Object, e As EventArgs) Handles cmdgcd.Click
        Dim a, b As Long
        a = txtgcd1.Text
        b = txtgcd2.Text
        txtgcdr.Text = gcdfun(a, b)

    End Sub


End Class
