Imports System.Data.SqlClient
Public Class newClient

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '--create a new client
        creationclient()
    End Sub

    Private Sub txtFullN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullN.KeyPress
        'hide label
        Label12.Visible = False
    End Sub

End Class