Public Class Form1



    Public Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click

        Dim num As Integer
        num = txtNScore.Text



        txtLGrade.Text = grade1(num)
        txtQPoint.Text = grade2(num)
        txtQuali.Text = grade3(num)


    End Sub
End Class
