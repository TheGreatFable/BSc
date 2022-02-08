Public Class Form1



    Public Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click

        Dim num As Integer
        num = txtNScore.Text


        If (num >= 0) And (num <= 100) Then

            txtLGrade.Text = grade1(num)
            txtQPoint.Text = grade2(num)
            txtQuali.Text = grade3(num)
        Else
            txtLGrade.Text = "not valid"
            txtQPoint.Text = "not valid"
            txtQuali.Text = "not valid"
        End If

    End Sub
End Class
