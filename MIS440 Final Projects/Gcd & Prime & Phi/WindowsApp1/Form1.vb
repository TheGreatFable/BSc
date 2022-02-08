Public Class Form1

    '-------------GCD---------------------
    Private Sub cmdgcd_Click(sender As Object, e As EventArgs) Handles cmdgcd.Click
        Dim a, b As Long
        If txtGcd1.Text <> "" And txtGcd2.Text <> "" Then
            a = txtGcd1.Text
            b = txtGcd2.Text
            txtGcdR.Text = gcdfun(a, b)
        End If
    End Sub

    '--------PHI------------------------
    Private Sub cmdphi_Click(sender As Object, e As EventArgs) Handles cmdphi.Click
        Dim a As Long
        If txtPin.Text <> "" Then
            a = txtPin.Text
            txtPhiR.Text = phifun(a)
        End If
    End Sub

    '-----------PRIME-------------------
    Private Sub cmdprime_Click(sender As Object, e As EventArgs) Handles cmdprime.Click
        Dim a As Long
        If txtPin.Text <> "" Then
            a = txtPin.Text
            If isprime(a) = True Then
                txtPrimeR.Text = "it is prime"
            Else
                txtPrimeR.Text = "it is not prime"
            End If
        End If
    End Sub

    '-------------OTHER------------------
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        txtGcd1.Clear()
        txtGcd2.Clear()
        txtGcdR.Clear()
        txtPin.Clear()
        txtPhiR.Clear()
        txtPrimeR.Clear()
    End Sub

    Private Sub txtGcd1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGcd1.KeyPress
        txtGcdR.Clear()
    End Sub
    Private Sub txtGcd2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGcd2.KeyPress
        txtGcdR.Clear()
    End Sub
    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        txtPhiR.Clear()
        txtPrimeR.Clear()
    End Sub

End Class
