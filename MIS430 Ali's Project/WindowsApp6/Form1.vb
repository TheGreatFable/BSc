Public Class Form1
    '----------------------------Ali_Yazbek_Project---------------------------------------------------------

    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click

        Dim done As Boolean
        done = True

        '-------------------------------Client_validation------------------
        If txtClient.Text = "" Then
            txtClient.Text = "Input the Client name!"
            done = False
        Else
            If (txtClient.Text.Length >= 3) Then
                If (txtClient.Text.Length > 24) Then
                    txtClient.Text = "Not Valid"
                    done = False
                End If
            Else
                txtClient.Text = "Not Valid"
                done = False
            End If
        End If

        '------------------------------Age_validation----------------------
        If txtAge.Text = "" Then
            txtAge.Text = "Input the Age!"
            done = False
        Else
            If (txtAge.Text >= 15) Then
                If (txtAge.Text > 60) Then
                    txtAge.Text = "Not Valid"
                    done = False
                End If
            Else
                txtAge.Text = "Not Valid"
                done = False
            End If
        End If

        '---------------------------------Amount_Validation--------------
        If txtAmount.Text = "" Then
            txtAmount.Text = "Input the Amount!"
            done = False
        Else
            If (txtAmount.Text >= 10) Then
                If (txtAmount.Text > 200) Then
                    txtAmount.Text = "Not Valid"
                    done = False
                End If
            Else
                txtAmount.Text = "Not Valid"
                done = False
            End If
        End If


        If done = True Then
            '---------------------Discount------------------
            Dim amount As Single
            Dim discount As Single
            Dim discamount As Single
            Dim agediscount As Single
            Dim totaldiscount As Single
            Dim net As Single
            amount = txtAmount.Text
            If amount > 20 Then
                If amount <= 100 Then
                    discount = amount * 0.1
                Else
                    discount = 8 + (amount - 100) * 0.25
                End If
            Else
                discount = 0
            End If
            discamount = amount - discount
            '------------Age_discount-----------
            If txtAge.Text < 20 Then
                agediscount = discamount * 0.1
            Else
                agediscount = 0
            End If

            '--------------Result---------------
            totaldiscount = agediscount + discount
            net = amount - totaldiscount

            txtDiscount.Text = totaldiscount
            txtNettopay.Text = net

            '---------------Console-----------------
            Console.WriteLine("Client Name: " & txtClient.Text)
            Console.WriteLine("Age: " & txtAge.Text)
            Console.WriteLine("Net Amount: " & txtNettopay.Text)
        End If

    End Sub

    '------------Restart---------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtAmount.Text = ""
        txtClient.Text = ""
        txtAge.Text = ""
        txtDiscount.Text = ""
        txtNettopay.Text = ""
        Console.Clear()
    End Sub
End Class
