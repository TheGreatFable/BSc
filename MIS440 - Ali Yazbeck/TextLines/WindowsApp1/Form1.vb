Public Class Form1

    Dim filename As String
    Dim myline As String
    Dim k As Integer = 0

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        filename = "C:\Users\Ali Yazbek\Desktop\MIS440 - Ali Yazbeck\TextLines\employee.csv"
        FileOpen(98, filename, OpenMode.Input)
        txtFileName.Text = filename

    End Sub

    Private Sub cmdNextLine_Click(sender As Object, e As EventArgs) Handles cmdNextLine.Click

        Dim strline As String = ""
        If Not EOF(98) Then
            strline = LineInput(9)
            txtLines.Text = strline
            k = k + 1
            lblNum.Text = k
        Else
            'MsgBox("end of file")
        End If

    End Sub

    Private Sub cmdReadFields_Click(sender As Object, e As EventArgs) Handles cmdReadFields.Click

        Dim name As String
        Dim dep As String
        Dim work As String

        Input(98, name)
        Input(98, dep)
        Input(98, work)
        MsgBox(name)
        MsgBox(dep)
        MsgBox(work)

    End Sub

    Private Sub cmdOutput_Click(sender As Object, e As EventArgs) Handles cmdOutput.Click
        filename = Trim(Me.txtFileName.Text)
        If filename <> "" Then
            FileOpen(90, filename, OpenMode.Append)
        End If
    End Sub

    Private Sub cmdWriteline_Click(sender As Object, e As EventArgs) Handles cmdWriteline.Click
        Dim strA As String
        strA = Me.txtLines.Text
        Write(90, strA)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        FileClose(98)
    End Sub
End Class
