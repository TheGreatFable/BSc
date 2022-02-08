Public Class Form1
    Dim myname As String
    Private Sub cmdGo_Click(sender As Object, e As EventArgs)
        MsgBox("hello")
        myname = txtinput.Text
        txtText.Text = "You are " & myname
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim day_array(7) As String
        day_array(1) = "Sunday"
        day_array(2) = "Monday"
        day_array(3) = "Tuesday"
        day_array(4) = "Wednesday"
        day_array(5) = "Thursday"
        day_array(6) = "Friday"
        day_array(7) = "Saturday"


    End Sub
End Class
