Imports System.Data.SqlClient
Module policycreationmod

    'this function is for policy creation
    Function createthepol()
        Dim con As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Dim command As New SqlCommand
        Try
            con.Open()
            command.Connection = con

            Dim insura As String = PolicyCreation.cmbIns.Text '--to know which insurance to refere

            If insura = "Car ins." Then
                command.CommandText = "INSERT INTO carinsurance([carinsurance_name],[carinsurance_id], [starting_date], [ending_date], [total_cost], [total_duration], [risks_covered], [details], [client_id]) 
VALUES(@carinsurance_name, @carinsurance_id, @sd, @ed, @cost, @td,  @det, @risk, @client_id)"

                command.Parameters.Add("@carinsurance_name", SqlDbType.VarChar).Value = "Car ins."
                command.Parameters.Add("@carinsurance_id", SqlDbType.VarChar).Value = PolicyCreation.txtPolN.Text
                command.Parameters.Add("@sd", SqlDbType.Date).Value = PolicyCreation.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyCreation.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyCreation.txtTd.Text
                command.Parameters.Add("@cost", SqlDbType.VarChar).Value = PolicyCreation.txtCost.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyCreation.txtDet.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyCreation.txtRisk.Text
                command.Parameters.Add("@client_id", SqlDbType.Int).Value = PolicyCreation.txtECli.Text

            ElseIf insura = "Medical ins." Then
                command.CommandText = "INSERT INTO healthinsurance([healthinsurance_name],[healthinsurance_id], [starting_date], [ending_date], [total_cost], [total_duration], [risks_covered], [details], [client_id]) 
VALUES(@healthinsurance_name, @healthinsurance_id, @sd, @ed, @cost, @td, @risk, @det,  @client_id)"

                command.Parameters.Add("@healthinsurance_name", SqlDbType.VarChar).Value = "Medical ins."
                command.Parameters.Add("@healthinsurance_id", SqlDbType.VarChar).Value = PolicyCreation.txtPolN.Text
                command.Parameters.Add("@sd", SqlDbType.Date).Value = PolicyCreation.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyCreation.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyCreation.txtTd.Text
                command.Parameters.Add("@cost", SqlDbType.VarChar).Value = PolicyCreation.txtCost.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyCreation.txtDet.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyCreation.txtRisk.Text
                command.Parameters.Add("@client_id", SqlDbType.Int).Value = PolicyCreation.txtECli.Text

            Else '---property ins.
                command.CommandText = "INSERT INTO propertyinsurance([propertyinsurance_name],[propertyinsurance_id], [starting_date], [ending_date], [total_cost], [total_duration], [risks_covered], [details], [client_id]) 
VALUES(@propertyinsurance_name, @propertyinsurance_id, @sd, @ed, @cost, @td, @risk, @det, @client_id)"

                command.Parameters.Add("@propertyinsurance_name", SqlDbType.VarChar).Value = "Property ins."
                command.Parameters.Add("@propertyinsurance_id", SqlDbType.VarChar).Value = PolicyCreation.txtPolN.Text
                command.Parameters.Add("@sd", SqlDbType.Date).Value = PolicyCreation.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyCreation.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyCreation.txtTd.Text
                command.Parameters.Add("@cost", SqlDbType.VarChar).Value = PolicyCreation.txtCost.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyCreation.txtDet.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyCreation.txtRisk.Text
                command.Parameters.Add("@client_id", SqlDbType.Int).Value = PolicyCreation.txtECli.Text
            End If

            command.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Create this Record?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Error while creating record on table..." & ex.Message, "Create Records")
        Finally
            con.Close()
        End Try

    End Function

End Module
