Public Class Form1


    Public Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click

        Dim num As Integer = txtNScore.Text

        If (num >= 0 & num <= 100) Then

            Select Case num
                Case 0 To 59
                    txtLGrade.Text = "F"
                    txtQPoint.Text = "0"
                    txtQuali.Text = "Failure"
                Case 60 To 62
                    txtLGrade.Text = "D"
                    txtQPoint.Text = "1"
                    txtQuali.Text = "Lowest Passing"
                Case 63 To 64
                    txtLGrade.Text = "D+"
                    txtQPoint.Text = "1.3"
                    txtQuali.Text = "Passing"
                Case 65 To 69
                    txtLGrade.Text = "C-"
                    txtQPoint.Text = "1.7"
                    txtQuali.Text = "Passing"
                Case 70 To 72
                    txtLGrade.Text = "C"
                    txtQPoint.Text = "2"
                    txtQuali.Text = "Satisfactory"
                Case 73 To 75
                    txtLGrade.Text = "C+"
                    txtQPoint.Text = "2.3"
                    txtQuali.Text = "Satisfactory"
                Case 76 To 79
                    txtLGrade.Text = "B-"
                    txtQPoint.Text = "2.7"
                    txtQuali.Text = "Reasonably Good"
                Case 80 To 84
                    txtLGrade.Text = "B"
                    txtQPoint.Text = "3"
                    txtQuali.Text = "Good"
                Case 85 To 86
                    txtLGrade.Text = "B+"
                    txtQPoint.Text = "3.3"
                    txtQuali.Text = "Very Good"
                Case 87 To 89
                    txtLGrade.Text = "A-"
                    txtQPoint.Text = "3.7"
                    txtQuali.Text = "Skillful"
                Case 90 To 94
                    txtLGrade.Text = "A"
                    txtQPoint.Text = "4"
                    txtQuali.Text = "Excellent"
                Case 95 To 100
                    txtLGrade.Text = "A+"
                    txtQPoint.Text = "4"
                    txtQuali.Text = "Outstanding"
                Case Else
                    txtNScore.Text = ""
                    txtLGrade.Text = ""
                    txtQPoint.Text = ""
                    txtQuali.Text = ""
            End Select
        Else
            txtNScore.Text = ""
            txtLGrade.Text = ""
            txtQPoint.Text = ""
            txtQuali.Text = ""
        End If

    End Sub
End Class
