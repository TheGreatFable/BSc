Public Class Form1



    Public Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click

        Dim num As Integer
        num = txtNScore.Text
        GroupBox1.Visible = True
        If (num >= 0) And (num <= 100) Then

            txtLGrade.Text = grade1(num)
            txtQPoint.Text = Format(grade2(num), "#0.00")
            txtQuali.Text = grade3(num)
        Else
            txtNScore.Clear()
            GroupBox1.Visible = False
            txtLGrade.Text = ""
            txtQPoint.Text = ""
            txtQuali.Text = ""
        End If

    End Sub

    Private Sub txtNScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNScore.KeyPress
        GroupBox1.Visible = False
    End Sub
End Class
