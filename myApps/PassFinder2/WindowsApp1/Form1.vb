Public Class Form1

    Public num As Integer = Val(20)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            If num <> 0 Then
                Timer1.Start()
                TextBox1.Enabled = False
                Timer1.Interval = Val(TextBox4.Text)

            End If
        End If
        If RadioButton2.Checked = True Then
            Timer2.Start()
        End If
        If CheckBox1.Checked = True Then
            Timer3.Start()
        End If
        If CheckBox2.Checked = True Then
            WebBrowser1.Navigate("http://192.168.1.254/login.lp")
            WebBrowser1.Visible = True
            WebBrowser1.Document.GetElementById("user").SetAttribute("value", TextBox5.Text)
            WebBrowser1.Document.GetElementById("password").SetAttribute("value", TextBox2.Text)
            WebBrowser1.Document.GetElementById("user").GetAttribute("value")
            WebBrowser1.Document.GetElementById("password").GetAttribute("value")
            WebBrowser1.Document.GetElementById("$0").InvokeMember("onclick")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        TextBox1.Enabled = True
        Timer2.Stop()
        Timer3.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Randomize()

        Select Case Int(Rnd() * 77) + 1
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
                    TextBox2.AppendText("A")
                Case 37
                    TextBox2.AppendText("B")
                Case 38
                    TextBox2.AppendText("C")
                Case 39
                    TextBox2.AppendText("D")
                Case 40
                    TextBox2.AppendText("E")
                Case 41
                    TextBox2.AppendText("F")
                Case 42
                    TextBox2.AppendText("G")
                Case 43
                    TextBox2.AppendText("H")
                Case 44
                    TextBox2.AppendText("I")
                Case 45
                    TextBox2.AppendText("J")
                Case 46
                    TextBox2.AppendText("K")
                Case 47
                    TextBox2.AppendText("L")
                Case 48
                    TextBox2.AppendText("M")
                Case 49
                    TextBox2.AppendText("N")
                Case 50
                    TextBox2.AppendText("O")
                Case 51
                    TextBox2.AppendText("P")
                Case 52
                    TextBox2.AppendText("Q")
                Case 53
                    TextBox2.AppendText("R")
                Case 54
                    TextBox2.AppendText("S")
                Case 55
                    TextBox2.AppendText("T")
                Case 56
                    TextBox2.AppendText("U")
                Case 57
                    TextBox2.AppendText("V")
                Case 58
                    TextBox2.AppendText("W")
                Case 59
                    TextBox2.AppendText("X")
                Case 60
                    TextBox2.AppendText("Y")
                Case 61
                    TextBox2.AppendText("Z")
                Case 62
                    TextBox2.AppendText("<")
                Case 63
                    TextBox2.AppendText(">")
                Case 64
                    TextBox2.AppendText(",")
                Case 65
                    TextBox2.AppendText(".")
                Case 66
                    TextBox2.AppendText("?")
                Case 67
                    TextBox2.AppendText("/")
                Case 68
                    TextBox2.AppendText("!")
                Case 69
                    TextBox2.AppendText("@")
                Case 70
                    TextBox2.AppendText("#")
                Case 71
                    TextBox2.AppendText("$")
                Case 72
                    TextBox2.AppendText("%")
                Case 73
                    TextBox2.AppendText("^")
                Case 74
                    TextBox2.AppendText("&")
                Case 75
                    TextBox2.AppendText("*")
                Case 76
                    TextBox2.AppendText("-")
                Case 77
                    TextBox2.AppendText("_")
            End Select

            Console.WriteLine(TextBox2.Text)

            TextBox2.Text = ""
            TextBox3.Text = Val(TextBox3.Text) + 1
        
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Randomize()
        Select Case Int(Rnd() * 90) + 1
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
                TextBox2.AppendText("A")
            Case 37
                TextBox2.AppendText("B")
            Case 38
                TextBox2.AppendText("C")
            Case 39
                TextBox2.AppendText("D")
            Case 40
                TextBox2.AppendText("E")
            Case 41
                TextBox2.AppendText("F")
            Case 42
                TextBox2.AppendText("G")
            Case 43
                TextBox2.AppendText("H")
            Case 44
                TextBox2.AppendText("I")
            Case 45
                TextBox2.AppendText("J")
            Case 46
                TextBox2.AppendText("K")
            Case 47
                TextBox2.AppendText("L")
            Case 48
                TextBox2.AppendText("M")
            Case 49
                TextBox2.AppendText("N")
            Case 50
                TextBox2.AppendText("O")
            Case 51
                TextBox2.AppendText("P")
            Case 52
                TextBox2.AppendText("Q")
            Case 53
                TextBox2.AppendText("R")
            Case 54
                TextBox2.AppendText("S")
            Case 55
                TextBox2.AppendText("T")
            Case 56
                TextBox2.AppendText("U")
            Case 57
                TextBox2.AppendText("V")
            Case 58
                TextBox2.AppendText("W")
            Case 59
                TextBox2.AppendText("X")
            Case 60
                TextBox2.AppendText("Y")
            Case 61
                TextBox2.AppendText("Z")
            Case 62
                TextBox2.AppendText("<")
            Case 63
                TextBox2.AppendText(">")
            Case 64
                TextBox2.AppendText(",")
            Case 65
                TextBox2.AppendText(".")
            Case 66
                TextBox2.AppendText("?")
            Case 67
                TextBox2.AppendText("/")
            Case 68
                TextBox2.AppendText(";")
            Case 69
                TextBox2.AppendText(":")
            Case 70
                TextBox2.AppendText("[")
            Case 71
                TextBox2.AppendText("]")
            Case 72
                TextBox2.AppendText("{")
            Case 73
                TextBox2.AppendText("}")
            Case 74
                TextBox2.AppendText("!")
            Case 75
                TextBox2.AppendText("@")
            Case 76
                TextBox2.AppendText("#")
            Case 77
                TextBox2.AppendText("$")
            Case 78
                TextBox2.AppendText("%")
            Case 79
                TextBox2.AppendText("^")
            Case 80
                TextBox2.AppendText("&")
            Case 81
                TextBox2.AppendText("*")
            Case 82
                TextBox2.AppendText("(")
            Case 83
                TextBox2.AppendText(")")
            Case 84
                TextBox2.AppendText("-")
            Case 85
                TextBox2.AppendText("_")
            Case 86
                TextBox2.AppendText("=")
            Case 87
                TextBox2.AppendText("+")
            Case 88
                TextBox2.AppendText("\")
            Case 89
                TextBox2.AppendText("|")
            Case 90
                TextBox2.AppendText(" ")
        End Select
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Randomize()
        Select Case Int(Rnd() * 90) + 1
            Case 0
                TextBox5.AppendText("a")
            Case 1
                TextBox5.AppendText("b")
            Case 2
                TextBox5.AppendText("c")
            Case 3
                TextBox5.AppendText("d")
            Case 4
                TextBox5.AppendText("e")
            Case 5
                TextBox5.AppendText("f")
            Case 6
                TextBox5.AppendText("g")
            Case 7
                TextBox5.AppendText("h")
            Case 8
                TextBox5.AppendText("i")
            Case 9
                TextBox5.AppendText("j")
            Case 10
                TextBox5.AppendText("k")
            Case 11
                TextBox5.AppendText("l")
            Case 12
                TextBox5.AppendText("m")
            Case 13
                TextBox5.AppendText("n")
            Case 14
                TextBox5.AppendText("o")
            Case 15
                TextBox5.AppendText("p")
            Case 16
                TextBox5.AppendText("q")
            Case 17
                TextBox5.AppendText("r")
            Case 18
                TextBox5.AppendText("s")
            Case 19
                TextBox5.AppendText("t")
            Case 20
                TextBox5.AppendText("u")
            Case 21
                TextBox5.AppendText("v")
            Case 22
                TextBox5.AppendText("w")
            Case 23
                TextBox5.AppendText("x")
            Case 24
                TextBox5.AppendText("y")
            Case 25
                TextBox5.AppendText("z")
            Case 26
                TextBox5.AppendText("1")
            Case 27
                TextBox5.AppendText("2")
            Case 28
                TextBox5.AppendText("3")
            Case 29
                TextBox5.AppendText("4")
            Case 30
                TextBox5.AppendText("5")
            Case 31
                TextBox5.AppendText("6")
            Case 32
                TextBox5.AppendText("7")
            Case 33
                TextBox5.AppendText("8")
            Case 34
                TextBox5.AppendText("9")
            Case 35
                TextBox5.AppendText("0")
            Case 36
                TextBox5.AppendText("A")
            Case 37
                TextBox5.AppendText("B")
            Case 38
                TextBox5.AppendText("C")
            Case 39
                TextBox5.AppendText("D")
            Case 40
                TextBox5.AppendText("E")
            Case 41
                TextBox5.AppendText("F")
            Case 42
                TextBox5.AppendText("G")
            Case 43
                TextBox5.AppendText("H")
            Case 44
                TextBox5.AppendText("I")
            Case 45
                TextBox5.AppendText("J")
            Case 46
                TextBox5.AppendText("K")
            Case 47
                TextBox5.AppendText("L")
            Case 48
                TextBox5.AppendText("M")
            Case 49
                TextBox5.AppendText("N")
            Case 50
                TextBox5.AppendText("O")
            Case 51
                TextBox5.AppendText("P")
            Case 52
                TextBox5.AppendText("Q")
            Case 53
                TextBox5.AppendText("R")
            Case 54
                TextBox5.AppendText("S")
            Case 55
                TextBox5.AppendText("T")
            Case 56
                TextBox5.AppendText("U")
            Case 57
                TextBox5.AppendText("V")
            Case 58
                TextBox5.AppendText("W")
            Case 59
                TextBox5.AppendText("X")
            Case 60
                TextBox5.AppendText("Y")
            Case 61
                TextBox5.AppendText("Z")
            Case 62
                TextBox5.AppendText("<")
            Case 63
                TextBox5.AppendText(">")
            Case 64
                TextBox5.AppendText(",")
            Case 65
                TextBox5.AppendText(".")
            Case 66
                TextBox5.AppendText("?")
            Case 67
                TextBox5.AppendText("/")
            Case 68
                TextBox5.AppendText(";")
            Case 69
                TextBox5.AppendText(":")
            Case 70
                TextBox5.AppendText("[")
            Case 71
                TextBox5.AppendText("]")
            Case 72
                TextBox5.AppendText("{")
            Case 73
                TextBox5.AppendText("}")
            Case 74
                TextBox5.AppendText("!")
            Case 75
                TextBox5.AppendText("@")
            Case 76
                TextBox5.AppendText("#")
            Case 77
                TextBox5.AppendText("$")
            Case 78
                TextBox5.AppendText("%")
            Case 79
                TextBox5.AppendText("^")
            Case 80
                TextBox5.AppendText("&")
            Case 81
                TextBox5.AppendText("*")
            Case 82
                TextBox5.AppendText("(")
            Case 83
                TextBox5.AppendText(")")
            Case 84
                TextBox5.AppendText("-")
            Case 85
                TextBox5.AppendText("_")
            Case 86
                TextBox5.AppendText("=")
            Case 87
                TextBox5.AppendText("+")
            Case 88
                TextBox5.AppendText("\")
            Case 89
                TextBox5.AppendText("|")
            Case 90
                TextBox5.AppendText(" ")
        End Select
        TextBox5.Text = ""
    End Sub
End Class
