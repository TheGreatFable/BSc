Imports System.Data.SqlClient

Module clientinformation

    Public Function sqldatabase()
        '-----SQL connection
        Dim connection As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Return connection

    End Function
    '-------CLient information
    Public Function client_info()

        Dim gender, fin, fan, lan As String
        Dim command As New SqlCommand("select * from client where client_id = @client_id", sqldatabase())
        command.Parameters.Add("@client_id", SqlDbType.Int).Value = clientInfo.txtCliID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        '---full name
        If table.Rows.Count() > 0 Then
            fin = table.Rows(0)(1).ToString()
        Else
            fin = ""
        End If
        If table.Rows.Count() > 0 Then
            fan = table.Rows(0)(2).ToString()
        Else
            fan = ""
        End If
        If table.Rows.Count() > 0 Then
            lan = table.Rows(0)(3).ToString()
        Else
            lan = ""
        End If
        clientInfo.txtName.Text = fin & " " & fan & " " & lan

        '----other textboxes
        If table.Rows.Count() > 0 Then
            clientInfo.txtEmail.Text = table.Rows(0)(5).ToString()
        Else
            clientInfo.txtEmail.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            clientInfo.txtDob.Text = table.Rows(0)(4).ToString()
        Else
            clientInfo.txtDob.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            clientInfo.txtAddress.Text = table.Rows(0)(6).ToString()
        Else
            clientInfo.txtAddress.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            clientInfo.txtPN.Text = table.Rows(0)(7).ToString()
        Else
            clientInfo.txtPN.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            clientInfo.txtPro.Text = table.Rows(0)(9).ToString()
        Else
            clientInfo.txtPro.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            clientInfo.txtNat.Text = table.Rows(0)(8).ToString()
        Else
            clientInfo.txtNat.Text = "NO Info"
        End If

        If table.Rows.Count() > 0 Then
            gender = table.Rows(0)(10).ToString()
        Else
            gender = "NO Info"
        End If
        If gender <> "NO Info" Then
            If gender = "M" Then
                clientInfo.M.Checked = True
            Else
                clientInfo.F.Checked = True
            End If
        End If

    End Function

    Public Function ggg()
        '----to show Car_insurance of client
        Dim command As New SqlCommand("select * from carinsurance where client_id = @client_id", sqldatabase())
        command.Parameters.Add("@client_id", SqlDbType.Int).Value = clientInfo.txtCliID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoli.Items.Add(table.Rows(0)(0).ToString())
        Else
            clientInfo.txtPoli.Text = ""
        End If
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoliEd.Items.Add(table.Rows(0)(3).ToString())
        Else
            clientInfo.txtPoliEd.Text = ""
        End If

    End Function

    Function ggg2()
        '----to show Medical_insurance of client
        Dim command As New SqlCommand("select * from healthinsurance where client_id = @client_id", sqldatabase())
        command.Parameters.Add("@client_id", SqlDbType.Int).Value = clientInfo.txtCliID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoli.Items.Add(table.Rows(0)(0).ToString())
        Else
            clientInfo.txtPoli.Text = ""
        End If
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoliEd.Items.Add(table.Rows(0)(3).ToString())
        Else
            clientInfo.txtPoliEd.Text = ""
        End If

    End Function

    Function ggg3()
        '----to show Property_insurance of client
        Dim command As New SqlCommand("select * from propertyinsurance where client_id = @client_id", sqldatabase())
        command.Parameters.Add("@client_id", SqlDbType.Int).Value = clientInfo.txtCliID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoli.Items.Add(table.Rows(0)(0).ToString())
        Else
            clientInfo.txtPoli.Text = ""
        End If
        If table.Rows.Count() > 0 Then
            clientInfo.txtPoliEd.Items.Add(table.Rows(0)(3).ToString())
        Else
            clientInfo.txtPoliEd.Text = ""
        End If

    End Function

    '----Edit botton in client info
    Public Function clientinfo_edit()

        Dim con As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Dim command As New SqlCommand
        Try
            con.Open()
            command.Connection = con
            command.CommandText = "UPDATE client SET first_name =@fir, father_name =@midd, last_name =@last, dob =@dob, nationality =@nat, gender =@mf, profession =@pro, email =@email, address =@address, phone_number =@pn where client_id = @client_id"
            command.Parameters.Add("@client_id", SqlDbType.Int).Value = clientInfo.txtCliID.Text

            '----this is to know the first, middle and last name 
            Dim fullname, firstname, lastname, middlename, sep, gender As String
            firstname = ""
            lastname = ""
            middlename = ""
            Dim ps, ps1 As Integer
            fullname = clientInfo.txtName.Text
            fullname = Trim(fullname)
            sep = " "
            If fullname = "" Then
                MsgBox("there is no name.")
            Else
                ps = InStr(fullname, sep)
                ps1 = InStr(ps + 1, fullname, sep)
                firstname = Mid(fullname, 1, ps - 1)
                lastname = Mid(fullname, ps1 + 1, Len(fullname) - ps1)
                middlename = Mid(fullname, ps + 1, Len(fullname) - 1 - (Len(firstname) + Len(lastname)))
            End If

            '---these are the references of variables to the database
            command.Parameters.Add("@fir", SqlDbType.VarChar).Value = firstname
            command.Parameters.Add("@midd", SqlDbType.VarChar).Value = middlename
            command.Parameters.Add("@last", SqlDbType.VarChar).Value = lastname
            command.Parameters.Add("@dob", SqlDbType.Date).Value = clientInfo.txtDob.Text
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = clientInfo.txtEmail.Text
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = clientInfo.txtAddress.Text
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = clientInfo.txtPN.Text
            command.Parameters.Add("@nat", SqlDbType.VarChar).Value = clientInfo.txtNat.Text
            command.Parameters.Add("@pro", SqlDbType.VarChar).Value = clientInfo.txtPro.Text

            If clientInfo.M.Checked = True Then
                gender = "M"
            Else
                gender = "F"
            End If
            command.Parameters.Add("@mf", SqlDbType.Char).Value = gender

            command.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Edit this Record?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Error while editing record on table..." & ex.Message, "Edit Records")
        Finally
            con.Close()
        End Try
    End Function

    '----Delete botton in client info
    Function clientinfo_delete()

        Dim con As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Dim cmd As New SqlCommand
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From client where client_id= @clientID"
            cmd.Parameters.Add(New SqlParameter("@clientID", clientInfo.txtCliID.Text))
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
