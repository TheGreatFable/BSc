Public Class Form1
    Dim day_array(7) As String
    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click
        Dim result As String
        result = txtNum.Text
        If (result > 7) Or (result < 1) Then
            txtName.Text = "error"
        Else
            txtName.Text = day_array(result)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        day_array(1) = "Sunday"
        day_array(2) = "Monday"
        day_array(3) = "Tuesday"
        day_array(4) = "Wednesday"
        day_array(5) = "Thursday"
        day_array(6) = "Friday"
        day_array(7) = "Saturday"
    End Sub
End Class
