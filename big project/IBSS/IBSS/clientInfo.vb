Imports System.Data.SqlClient
Public Class clientInfo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '---show clinet info
        client_info()
        '-car, medical, property ins.
        ggg()
        ggg2()
        ggg3()

        btnDelete.Visible = True
        btnEdit.Visible = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliID.KeyPress
        'clean textboxes and other
        txtEmail.Clear()
        txtAddress.Clear()
        txtDob.Clear()
        txtName.Clear()
        txtNat.Clear()
        txtPN.Clear()
        txtPro.Clear()
        txtPoli.Items.Clear()
        txtPoliEd.Items.Clear()
        M.Checked = False
        F.Checked = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'open the edit client info function
        clientinfo_edit()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '--open the delete function
        clientinfo_delete()
    End Sub

    Private Sub txtCliID_TextChanged(sender As Object, e As EventArgs) Handles txtCliID.TextChanged

    End Sub
End Class