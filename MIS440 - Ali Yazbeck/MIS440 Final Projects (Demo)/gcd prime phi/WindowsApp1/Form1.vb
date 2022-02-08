Public Class Form1




    Private Sub cmdgcd_Click(sender As Object, e As EventArgs) Handles cmdgcd.Click
        Dim a, b As Long
        a = txtgcd1.Text
        b = txtgcd2.Text
        txtgcdr.Text = gcdfun(a, b)

    End Sub

    Private Sub cmdphi_Click(sender As Object, e As EventArgs) Handles cmdphi.Click

        Dim a As Long
        a = txtphi.Text
        txtphir.Text = phifun(a)

    End Sub

    Private Sub cmdprime_Click(sender As Object, e As EventArgs) Handles cmdprime.Click
        Dim a As Long
        a = txtphi.Text
        If isprime(a) = True Then
            txtprimer.Text = "it is prime"
        Else
            txtprimer.Text = "it is not prime"
        End If


    End Sub
End Class
