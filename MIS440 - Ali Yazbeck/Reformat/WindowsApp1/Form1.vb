Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(9, CliFile, OpenMode.Append)
        cmbCliCat.Items.Add("Whole Sales")
        cmbCliCat.Items.Add("Retailer")
        cmbCliCat.Items.Add("Other")


    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        CliID = Val(txtCliID.Text)
        CliName = Trim(txtCliName.Text)
        CliAdress = Trim(txtCliAdress.Text)
        CliPhone = Trim(txtCliPhone.Text)
        CliCat = (cmbCliCat.SelectedIndex)
        '--------------------------------------
        Write(9, CliID)
        Write(9, CliName)
        Write(9, CliAdress)
        Write(9, CliPhone)
        Write(9, CliCat)
        Write(9, vbCrLf)
        MsgBox("done")


    End Sub

    Private Sub cmbCliCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliCat.SelectedIndexChanged
        Dim x As String
        'MsgBox(cmbCliCat.Text)
        'x = (cmbCliCat.Items.Item(1))
        'MsgBox(x)
        ' MsgBox(cmbCliCat.SelectedIndex)
    End Sub

    Private Sub cmdReformat_Click(sender As Object, e As EventArgs) Handles cmdReformat.Click
        FileClose(9)
        FileOpen(10, CliFile, OpenMode.Input)
        Dim newm As String
        While Not EOF(10)
            Input(10, CliID)
            Input(10, CliName)
            Input(10, CliAdress)
            Input(10, CliPhone)
            Input(10, CliCat & vbCrLf)
            Input(10, vbCrLf)
            names(CliName, "ali", "yazbek", " ", newm)
        End While
    End Sub
End Class
