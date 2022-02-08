Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num As Integer = Val(TextBox1.Text)
        If RadioButton1.Checked = True Then
            If num = 5 Then
                Timer1.Start()
                TextBox1.Enabled = False
                Timer1.Interval = Val(TextBox4.Text)

            End If
        End If
        If RadioButton2.Checked = True Then
            timer2.start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        TextBox1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        Select Case Int(Rnd() * 35) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
        End Select
        Randomize()
        Select Case Int(Rnd() * 35) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
        End Select
        Randomize()
        Select Case Int(Rnd() * 35) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
        End Select
        Randomize()
        Select Case Int(Rnd() * 35) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
        End Select
        Randomize()
        Select Case Int(Rnd() * 35) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
        End Select
        SendKeys.Send(TextBox2.Text)
        SendKeys.Send("{enter}")
        TextBox2.Text = ""
        TextBox3.Text = Val(TextBox3.Text) + 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Randomize()
        Select Case Int(Rnd() * 36) + 1
            Case 0
                TextBox2.AppendText("a")
            Case 1
                TextBox2.AppendText("b")
            Case 2
                TextBox2.AppendText("c")
            Case 3
                TextBox2.AppendText("d")
            Case 4
                TextBox2.AppendText("e")
            Case 5
                TextBox2.AppendText("f")
            Case 6
                TextBox2.AppendText("g")
            Case 7
                TextBox2.AppendText("h")
            Case 8
                TextBox2.AppendText("i")
            Case 9
                TextBox2.AppendText("j")
            Case 10
                TextBox2.AppendText("k")
            Case 11
                TextBox2.AppendText("l")
            Case 12
                TextBox2.AppendText("m")
            Case 13
                TextBox2.AppendText("n")
            Case 14
                TextBox2.AppendText("o")
            Case 15
                TextBox2.AppendText("p")
            Case 16
                TextBox2.AppendText("q")
            Case 17
                TextBox2.AppendText("r")
            Case 18
                TextBox2.AppendText("s")
            Case 19
                TextBox2.AppendText("t")
            Case 20
                TextBox2.AppendText("u")
            Case 21
                TextBox2.AppendText("v")
            Case 22
                TextBox2.AppendText("w")
            Case 23
                TextBox2.AppendText("x")
            Case 24
                TextBox2.AppendText("y")
            Case 25
                TextBox2.AppendText("z")
            Case 26
                TextBox2.AppendText("1")
            Case 27
                TextBox2.AppendText("2")
            Case 28
                TextBox2.AppendText("3")
            Case 29
                TextBox2.AppendText("4")
            Case 30
                TextBox2.AppendText("5")
            Case 31
                TextBox2.AppendText("6")
            Case 32
                TextBox2.AppendText("7")
            Case 33
                TextBox2.AppendText("8")
            Case 34
                TextBox2.AppendText("9")
            Case 35
                TextBox2.AppendText("0")
            Case 36
                TextBox2.AppendText(" ")
        End Select
    End Sub
End Class
