Imports System.Data.SqlClient
Module policy_information

    Public Function sqldatabase()
        'this is to connect to database
        Dim connection As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Return connection
    End Function

    'this section shows the company information
    Public Function company_info()

        Dim command As New SqlCommand("select * from company where company_name = @company_name", sqldatabase())
        command.Parameters.Add("@company_name", SqlDbType.VarChar).Value = PolicyInfo.cmbCom.SelectedItem
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() > 0 Then
            PolicyInfo.txtCont.Text = table.Rows(0)(2).ToString()
            PolicyInfo.txtPn.Text = table.Rows(0)(3).ToString()
            PolicyInfo.txtEmail.Text = table.Rows(0)(4).ToString()
            PolicyInfo.txtFax.Text = table.Rows(0)(5).ToString()
            PolicyInfo.txtZCo.Text = table.Rows(0)(6).ToString()
        Else
            PolicyInfo.txtCont.Text = "NO Info"
            PolicyInfo.txtPn.Text = "NO Info"
            PolicyInfo.txtEmail.Text = "NO Info"
            PolicyInfo.txtZCo.Text = "NO Info"
            PolicyInfo.txtFax.Text = "NO Info"
        End If



    End Function

    Function policy_info()
        '--this section show the insurance info for policies
        Dim insura As String = PolicyInfo.cmbIns.Text
        If insura = "Car ins." Then

            Dim command As New SqlCommand("select * from carinsurance where carinsurance_name = @carinsurance_name", sqldatabase())
            command.Parameters.Add("@carinsurance_name", SqlDbType.VarChar).Value = PolicyInfo.cmbIns.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim i, k As Integer
            k = table.Rows.Count()
            If table.Rows.Count() > 0 Then
                For i = 0 To k - 1
                    PolicyInfo.cmbPli.Items.Add(table.Rows(i)(0).ToString())
                Next
            Else
                PolicyInfo.cmbPli.Text = ""
            End If

        ElseIf insura = "Medical ins." Then
            Dim command As New SqlCommand("select * from healthinsurance where healthinsurance_name = @healthinsurance_name", sqldatabase())
            command.Parameters.Add("@healthinsurance_name", SqlDbType.VarChar).Value = PolicyInfo.cmbIns.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim i, k As Integer
            k = table.Rows.Count()
            If table.Rows.Count() > 0 Then
                For i = 0 To k - 1
                    PolicyInfo.cmbPli.Items.Add(table.Rows(i)(0).ToString())
                Next
            Else
                PolicyInfo.cmbPli.Text = ""
            End If

        Else '---property ins.
            Dim command As New SqlCommand("select * from propertyinsurance where propertyinsurance_name = @propertyinsurance_name", sqldatabase())
            command.Parameters.Add("@propertyinsurance_name", SqlDbType.VarChar).Value = PolicyInfo.cmbIns.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim i, k As Integer
            k = table.Rows.Count()
            If table.Rows.Count() > 0 Then
                For i = 0 To k - 1
                    PolicyInfo.cmbPli.Items.Add(table.Rows(i)(0).ToString())
                Next
            Else
                PolicyInfo.cmbPli.Text = ""
            End If
        End If

    End Function

    '--this section shows the policy information
    Function policysearch()
        Dim insura As String = PolicyInfo.cmbIns.SelectedItem
        If insura = "Car ins." Then
            Dim command As New SqlCommand("select * from carinsurance where carinsurance_id = @carinsurance_id", sqldatabase())
            command.Parameters.Add("@carinsurance_id", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim k As Integer = table.Rows.Count() - 1
            If table.Rows.Count() > 0 Then

                'these instructions refer the texbox to the needed data field
                PolicyInfo.txtSd.Text = table.Rows(k)(2).ToString()
                PolicyInfo.txtEd.Text = table.Rows(k)(3).ToString()
                PolicyInfo.txtCost.Text = table.Rows(k)(4).ToString()
                PolicyInfo.txtTd.Text = table.Rows(k)(5).ToString()
                PolicyInfo.txtRisk.Text = table.Rows(k)(6).ToString()
                PolicyInfo.txtDet.Text = table.Rows(k)(7).ToString()

            Else
                PolicyInfo.txtSd.Text = ""
                PolicyInfo.txtEd.Text = ""
                PolicyInfo.txtCost.Text = ""
                PolicyInfo.txtTd.Text = ""
                PolicyInfo.txtRisk.Text = ""
                PolicyInfo.txtDet.Text = ""
            End If

        ElseIf insura = "Medical ins." Then

            Dim command As New SqlCommand("select * from healthinsurance where healthinsurance_id = @healthinsurance_id", sqldatabase())
            command.Parameters.Add("@healthinsurance_id", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim k As Integer = table.Rows.Count() - 1
            If table.Rows.Count() > 0 Then

                PolicyInfo.txtSd.Text = table.Rows(k)(2).ToString()
                PolicyInfo.txtEd.Text = table.Rows(k)(3).ToString()
                PolicyInfo.txtCost.Text = table.Rows(k)(4).ToString()
                PolicyInfo.txtTd.Text = table.Rows(k)(5).ToString()
                PolicyInfo.txtRisk.Text = table.Rows(k)(6).ToString()
                PolicyInfo.txtDet.Text = table.Rows(k)(7).ToString()

            Else
                PolicyInfo.txtSd.Text = ""
                PolicyInfo.txtEd.Text = ""
                PolicyInfo.txtCost.Text = ""
                PolicyInfo.txtTd.Text = ""
                PolicyInfo.txtRisk.Text = ""
                PolicyInfo.txtDet.Text = ""
            End If

        Else '---property ins.
            Dim command As New SqlCommand("select * from propertyinsurance where propertyinsurance_id = @propertyinsurance_id", sqldatabase())
            command.Parameters.Add("@propertyinsurance_id", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim k As Integer = table.Rows.Count() - 1

            If table.Rows.Count() > 0 Then
                PolicyInfo.txtSd.Text = table.Rows(k)(2).ToString()
                PolicyInfo.txtEd.Text = table.Rows(k)(3).ToString()
                PolicyInfo.txtCost.Text = table.Rows(k)(4).ToString()
                PolicyInfo.txtTd.Text = table.Rows(k)(5).ToString()
                PolicyInfo.txtRisk.Text = table.Rows(k)(6).ToString()
                PolicyInfo.txtDet.Text = table.Rows(k)(7).ToString()

            Else
                PolicyInfo.txtSd.Text = ""
                PolicyInfo.txtEd.Text = ""
                PolicyInfo.txtCost.Text = ""
                PolicyInfo.txtTd.Text = ""
                PolicyInfo.txtRisk.Text = ""
                PolicyInfo.txtDet.Text = ""
            End If
        End If

    End Function


    Function policy_edit()
        '--edit botton
        Dim con As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Dim command As New SqlCommand
        Try
            con.Open()
            command.Connection = con

            Dim insura As String = PolicyInfo.cmbIns.SelectedItem
            If insura = "Car ins." Then
                command.CommandText = "UPDATE carinsurance SET carinsurance_id =@name, starting_date =@st, ending_date=@ed, total_duration =@td, total_cost =@tcost, risks_covered =@risk, details =@det
where carinsurance_id = @name"

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
                command.Parameters.Add("@st", SqlDbType.Date).Value = PolicyInfo.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyInfo.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyInfo.txtTd.Text
                command.Parameters.Add("@tcost", SqlDbType.VarChar).Value = PolicyInfo.txtCost.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyInfo.txtRisk.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyInfo.txtDet.Text

            ElseIf insura = "Medical ins." Then
                command.CommandText = "UPDATE healthinsurance SET healthinsurance_id =@name, starting_date =@st, ending_date=@ed, total_duration =@td, total_cost =@tcost, risks_covered =@risk, details =@det
where healthinsurance_id = @name"

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
                command.Parameters.Add("@st", SqlDbType.Date).Value = PolicyInfo.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyInfo.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyInfo.txtTd.Text
                command.Parameters.Add("@tcost", SqlDbType.VarChar).Value = PolicyInfo.txtCost.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyInfo.txtRisk.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyInfo.txtDet.Text

            Else '---property ins.
                command.CommandText = "UPDATE propertyinsurance SET propertyinsurance_id =@name, starting_date =@st, ending_date=@ed, total_duration =@td, total_cost =@tcost, risks_covered =@risk, details =@det
where propertyinsurance_id = @name"

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = PolicyInfo.cmbPli.SelectedItem
                command.Parameters.Add("@st", SqlDbType.Date).Value = PolicyInfo.txtSd.Text
                command.Parameters.Add("@ed", SqlDbType.Date).Value = PolicyInfo.txtEd.Text
                command.Parameters.Add("@td", SqlDbType.VarChar).Value = PolicyInfo.txtTd.Text
                command.Parameters.Add("@tcost", SqlDbType.VarChar).Value = PolicyInfo.txtCost.Text
                command.Parameters.Add("@risk", SqlDbType.VarChar).Value = PolicyInfo.txtRisk.Text
                command.Parameters.Add("@det", SqlDbType.VarChar).Value = PolicyInfo.txtDet.Text
            End If

            Command.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Edit this Record?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Error while editing record on table..." & ex.Message, "Edit Records")
        Finally
            sqldatabase.close()
        End Try
    End Function


    Function policy_delete()
        'delete botton
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From carinsurance where carinsurance_id= @carinsurance_id"
            cmd.Parameters.Add(New SqlParameter("@carinsurance_id", PolicyInfo.cmbPli.SelectedItem))
            cmd.ExecuteNonQuery()

            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        Finally
            con.Close()
        End Try

    End Function



End Module
