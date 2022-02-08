Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(9, CliFile, OpenMode.Append)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        CliID = Val(txtCliID.Text)
        CliName = Trim(txtCliName.Text)
        CliAdress = Trim(txtCliAdress.Text)
        CliPhone = Trim(txtCliPhone.Text)
        CliCat = Val(txtCliCategory.Text)
        '--------------------------------------
        Write(9, CliID)
        Write(9, CliName)
        Write(9, CliAdress)
        Write(9, CliPhone)
        Write(9, CliCat & vbCrLf)
        Write(9, vbCrLf)
        MsgBox("done")


    End Sub


End Class

