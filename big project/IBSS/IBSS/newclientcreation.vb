Imports System.Data.SqlClient
Module newclientcreation
    'creating a new client
    Public Function creationclient()

        Dim con As New SqlConnection("Data Source=LAPTOP-2S4KQ8DJ\SQLEXPRESS;Initial Catalog=IBSS;Integrated Security=True")
        Dim cmd As New SqlCommand
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO client([client_id], [first_name], [father_name], [last_name], [email], [dob], [address], [phone_number] ,[profession], [nationality], [gender]) 
VALUES(@client_id, @fir, @midd, @last, @email, @dob, @address, @pn, @pro, @nat, @mf)"

            '--this is the initial num of client known from database
            Dim s As Integer = Int(Rnd() * 100)
            newClient.txtNCli.Text = s

            '----this is to know the first, middle and last name 
            Dim fullname, firstname, lastname, middlename, sep, gender As String
            Dim ps, ps1 As Integer
            firstname = ""
            lastname = ""
            middlename = ""
            fullname = newClient.txtFullN.Text
            fullname = Trim(fullname) '---cleans unwanted spaces
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

            '----
            cmd.Parameters.Add("@client_id", SqlDbType.Int).Value = newClient.txtNCli.Text
            cmd.Parameters.Add("@fir", SqlDbType.VarChar).Value = firstname
            cmd.Parameters.Add("@midd", SqlDbType.VarChar).Value = middlename
            cmd.Parameters.Add("@last", SqlDbType.VarChar).Value = lastname
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = newClient.txtDob.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = newClient.txtEmail.Text
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = newClient.txtAddress.Text
            cmd.Parameters.Add("@pn", SqlDbType.VarChar).Value = newClient.txtPN.Text
            cmd.Parameters.Add("@nat", SqlDbType.VarChar).Value = newClient.txtNat.Text
            cmd.Parameters.Add("@pro", SqlDbType.VarChar).Value = newClient.txtPro.Text
            If newClient.M.Checked = True Then
                gender = "M"
            Else
                gender = "F"
            End If
            cmd.Parameters.Add("@mf", SqlDbType.Char).Value = gender

            cmd.ExecuteNonQuery()
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
