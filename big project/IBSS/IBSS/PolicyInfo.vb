Imports System.Data.SqlClient
Public Class PolicyInfo

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '----search for policy information of a client
        policysearch()

        btnDelete.Visible = True
        btnEdit.Visible = True
    End Sub


    Private Sub cmbCom_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCom.SelectionChangeCommitted
        '--show company info
        company_info()
    End Sub

    Private Sub cmbIns_SelectedChangeCommitted(sender As Object, e As EventArgs) Handles cmbIns.SelectedValueChanged
        'clear
        cmbPli.Items.Clear()
        txtSd.Clear()
        txtEd.Clear()
        txtCost.Clear()
        txtTd.Clear()
        txtRisk.Clear()
        txtDet.Clear()
        policy_info()

    End Sub

    Private Sub cmbPli_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPli.SelectionChangeCommitted
        'clear
        txtSd.Clear()
        txtEd.Clear()
        txtCost.Clear()
        txtTd.Clear()
        txtRisk.Clear()
        txtDet.Clear()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        '--edit policies
        policy_edit()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '--delete a policy
        policy_delete()
    End Sub
End Class