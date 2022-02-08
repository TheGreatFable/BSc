Public Class Form1


    '-------------------------------------------------------------------------------- English -----------------------------------

    Dim str As String
    Dim k As Integer
    Dim A(30) As Integer
    Dim b As Boolean

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------

    Private Function Convert1(ByVal num As Integer, Optional ByVal Nexttime As Integer = 0, Optional ByVal Digit As String = "") As String

        Dim curR As String = ""
        If Nexttime = 1 Then
            Convert1 = Convert2(num, Digit)
            Exit Function
        End If
        Select Case num
            Case 9 : curR = " Nine"
            Case 8 : curR = " Eight"
            Case 7 : curR = " Seven"
            Case 6 : curR = " Six"
            Case 5 : curR = " Five"
            Case 4 : curR = " Four"
            Case 3 : curR = " Three"
            Case 2 : curR = " Two"
            Case 1 : curR = " One"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        Convert1 = curR & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function Convert2(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim curRRR As String = ""
        Select Case num
            Case 9 : curRRR = " Nineteen"
            Case 8 : curRRR = " Eighteen"
            Case 7 : curRRR = " Seventeen"
            Case 6 : curRRR = " Sixteen"
            Case 5 : curRRR = " Fifteen"
            Case 4 : curRRR = " Fourteen"
            Case 3 : curRRR = " Thirteen"
            Case 2 : curRRR = " Twelve"
            Case 1 : curRRR = " Eleven"
            Case 0 : curRRR = " Ten"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        Convert2 = curRRR & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function Convert3(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim curRR As String = ""
        Select Case num
            Case 9 : curRR = " Ninety"
            Case 8 : curRR = " Eighty"
            Case 7 : curRR = " Seventy"
            Case 6 : curRR = " Sixty"
            Case 5 : curRR = " Fifty"
            Case 4 : curRR = " Fourty"
            Case 3 : curRR = " Thirty"
            Case 2 : curRR = " Twenty"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""

        End If
c:
        Convert3 = curRR & Digit
    End Function

    Private Sub ResetArray()
        Dim i As Integer
        For i = LBound(A) To UBound(A)
            A(i) = 0
        Next
    End Sub

    '---------------------------------------------------------------------------- Button1---------------------------------------------------------------------------
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim curr As String = " "
        Dim l As Integer
        Dim num As Long
        Dim i As Integer
        b = False
        ResetArray()
        str = txtCur.Text & "."
        str = Mid(txtCur.Text, 1, InStr(str, ".") - 1)
        l = Len(str)
        num = Val(str)
        For i = 0 To l
            A(i) = num Mod 10
            num = num \ 10
        Next
        For i = l To 0 Step -1
            k = i
            Select Case i
                Case 10 : curr = curr & Convert1(A(i - 1), A(i), " Billion")
                Case 9 : curr = curr & Convert1(A(i - 1), , " Hundred")
                Case 8 : curr = curr & Convert3(A(i - 1))
                Case 7 : curr = curr & Convert1(A(i - 1), A(i), " Million")
                Case 6 : curr = curr & Convert1(A(i - 1), , " Hundred")
                Case 5 : curr = curr & Convert3(A(i - 1))
                Case 4 : curr = curr & Convert1(A(i - 1), A(i), " Thousand")
                Case 3 : curr = curr & Convert1(A(i - 1), , " Hundred")
                Case 2 : curr = curr & Convert3(A(i - 1))
                Case 1 : curr = curr & Convert1(A(i - 1), A(i))
            End Select
        Next
        If curr = "" Then curr = "Zero"
        lblResult.Text = curr
    End Sub



    '-------------------------------------------------------------------------------- Russian -----------------------------------

    Dim str2 As String
    Dim k2 As Integer
    Dim A2(30) As Integer
    Dim b2 As Boolean

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------

    Private Function Convert12(ByVal num2 As Integer, Optional ByVal Nexttime2 As Integer = 0, Optional ByVal Digit2 As String = "") As String

        Dim curR2 As String = ""
        If Nexttime2 = 1 Then
            Convert12 = Convert22(num2, Digit2)
            Exit Function
        End If
        Select Case num2
            Case 9 : curR2 = " Девять"
            Case 8 : curR2 = " Восемь"
            Case 7 : curR2 = " Семь"
            Case 6 : curR2 = " Шесть"
            Case 5 : curR2 = " Пять"
            Case 4 : curR2 = " Четыре"
            Case 3 : curR2 = " Три"
            Case 2 : curR2 = " Два"
            Case 1 : curR2 = " Один"
        End Select
        If k2 = 7 Then b2 = True
        If num2 = 0 Then
            If k2 = 7 Then GoTo c2
            If b2 = False And k2 = 4 Then GoTo c2
            Digit2 = ""
        End If
c2:
        Convert12 = curR2 & Digit2
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function Convert22(ByVal num2 As Integer, Optional ByVal Digit2 As String = "") As String
        Dim curRRR2 As String = ""
        Select Case num2
            Case 9 : curRRR2 = " Девятнадцать"
            Case 8 : curRRR2 = " Восемнадцать"
            Case 7 : curRRR2 = " Семнадцать"
            Case 6 : curRRR2 = " Шестнадцать"
            Case 5 : curRRR2 = " Пятнадцать"
            Case 4 : curRRR2 = " Четырнадцать"
            Case 3 : curRRR2 = " Тринадцать"
            Case 2 : curRRR2 = " Двенадцать"
            Case 1 : curRRR2 = " Одиннадцать"
            Case 0 : curRRR2 = " Десять"
        End Select
        If k2 = 7 Then b2 = True
        If num2 = 0 Then
            If k2 = 7 Then GoTo c2
            If b2 = False And k2 = 4 Then GoTo c2
            Digit2 = ""
        End If
c2:
        Convert22 = curRRR2 & Digit2
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function Convert32(ByVal num2 As Integer, Optional ByVal Digit2 As String = "") As String
        Dim curRR2 As String = ""
        Select Case num2
            Case 9 : curRR2 = " Девяносто"
            Case 8 : curRR2 = " Восемьдесят"
            Case 7 : curRR2 = " Семьдесят"
            Case 6 : curRR2 = " Шестьдесят"
            Case 5 : curRR2 = " Пятьдесят"
            Case 4 : curRR2 = " Сорок"
            Case 3 : curRR2 = " Тридцать"
            Case 2 : curRR2 = " Двадцать"
        End Select
        If k2 = 7 Then b2 = True
        If num2 = 0 Then
            If k2 = 7 Then GoTo c2
            If b2 = False And k2 = 4 Then GoTo c2
            Digit2 = ""

        End If
c2:
        Convert32 = curRR2 & Digit2
    End Function

    Private Sub ResetArray2()
        Dim i2 As Integer
        For i2 = LBound(A2) To UBound(A2)
            A2(i2) = 0
        Next
    End Sub

    '---------------------------------------------------------------------------- Button2---------------------------------------------------------------------------
    Private Sub btnConvert2_Click(sender2 As Object, e2 As EventArgs) Handles btnConvert2.Click
        Dim curr2 As String = " "
        Dim l2 As Integer
        Dim num2 As Long
        Dim i2 As Integer
        b2 = False
        ResetArray2()
        str2 = txtCur.Text & "."
        str2 = Mid(txtCur.Text, 1, InStr(str2, ".") - 1)
        l2 = Len(str2)
        num2 = Val(str2)
        For i2 = 0 To l2
            A2(i2) = num2 Mod 10
            num2 = num2 \ 10
        Next
        For i2 = l2 To 0 Step -1
            k2 = i2
            Select Case i2
                Case 10 : curr2 = curr2 & Convert12(A2(i2 - 1), A2(i2), " Миллиард")
                Case 9 : curr2 = curr2 & Convert12(A2(i2 - 1), , " Сто ")
                Case 8 : curr2 = curr2 & Convert32(A2(i2 - 1))
                Case 7 : curr2 = curr2 & Convert12(A2(i2 - 1), A2(i2), " Миллион")
                Case 6 : curr2 = curr2 & Convert12(A2(i2 - 1), , " Сто")
                Case 5 : curr2 = curr2 & Convert32(A2(i2 - 1))
                Case 4 : curr2 = curr2 & Convert12(A2(i2 - 1), A2(i2), " Тысяча")
                Case 3 : curr2 = curr2 & Convert12(A2(i2 - 1), , " Сто")
                Case 2 : curr2 = curr2 & Convert32(A2(i2 - 1))
                Case 1 : curr2 = curr2 & Convert12(A2(i2 - 1), A2(i2))
            End Select
        Next
        If curr2 = "" Then curr2 = "Ноль"
        lblResult2.Text = curr2
    End Sub

    '-------------------------------------------------------------------------------- Arabic -----------------------------------

    Dim str3 As String
    Dim k3 As Integer
    Dim A3(30) As Integer
    Dim b3 As Boolean

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------

    Private Function Convert13(ByVal num3 As Integer, Optional ByVal Nexttime3 As Integer = 0, Optional ByVal Digit3 As String = "") As String

        Dim curR3 As String = ""
        If Nexttime3 = 1 Then
            Convert13 = Convert23(num3, Digit3)
            Exit Function
        End If
        Select Case num3
            Case 9 : curR3 = " تسعة "
            Case 8 : curR3 = " ثمانية "
            Case 7 : curR3 = " سبعة "
            Case 6 : curR3 = " ستة "
            Case 5 : curR3 = " خمسة "
            Case 4 : curR3 = " اربعة "
            Case 3 : curR3 = " ثلاثة "
            Case 2 : curR3 = " اثنان "
            Case 1 : curR3 = " واحد "
        End Select
        If k3 = 7 Then b3 = True
        If num3 = 0 Then
            If k3 = 7 Then GoTo c3
            If b3 = False And k = 4 Then GoTo c3
            Digit3 = ""
        End If
c3:
        Convert13 = curR3 & Digit3
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function Convert23(ByVal num3 As Integer, Optional ByVal Digit3 As String = "") As String
        Dim curRRR3 As String = ""
        Select Case num3
            Case 9 : curRRR3 = " تسعة عشر "
            Case 8 : curRRR3 = " ثمانية عشر "
            Case 7 : curRRR3 = " سبعة عشر "
            Case 6 : curRRR3 = " ستة عشر "
            Case 5 : curRRR3 = " خمسة عشر "
            Case 4 : curRRR3 = " اربعة عشر "
            Case 3 : curRRR3 = " ثلاثة عشر "
            Case 2 : curRRR3 = " اثنا عشر "
            Case 1 : curRRR3 = " احد عشر "
            Case 0 : curRRR3 = " عشرة "
        End Select
        If k3 = 7 Then b3 = True
        If num3 = 0 Then
            If k3 = 7 Then GoTo c3
            If b3 = False And k3 = 4 Then GoTo c3
            Digit3 = ""
        End If
c3:
        Convert23 = curRRR3 & Digit3
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function Convert33(ByVal num3 As Integer, Optional ByVal Digit3 As String = "") As String
        Dim curRR3 As String = ""
        Select Case num3
            Case 9 : curRR3 = " تسعون "
            Case 8 : curRR3 = " ثمانون "
            Case 7 : curRR3 = " سبعون "
            Case 6 : curRR3 = " ستون "
            Case 5 : curRR3 = " خمسون "
            Case 4 : curRR3 = " اربعون "
            Case 3 : curRR3 = " ثلاثون "
            Case 2 : curRR3 = " عشرون "
        End Select
        If k3 = 7 Then b3 = True
        If num3 = 0 Then
            If k3 = 7 Then GoTo c3
            If b3 = False And k3 = 4 Then GoTo c3
            Digit3 = ""

        End If
c3:
        Convert33 = curRR3 & Digit3
    End Function

    Private Sub ResetArray3()
        Dim i3 As Integer
        For i3 = LBound(A3) To UBound(A3)
            A3(i3) = 0
        Next
    End Sub

    '---------------------------------------------------------------------------- Button3---------------------------------------------------------------------------
    Private Sub btnConvert3_Click(sender As Object, e As EventArgs) Handles btnConvert3.Click
        Dim curr3 As String = " "
        Dim l3 As Integer
        Dim num3 As Long
        Dim i3 As Integer
        b3 = False
        ResetArray3()
        str3 = txtCur.Text & "."
        str3 = Mid(txtCur.Text, 1, InStr(str3, ".") - 1)
        l3 = Len(str3)
        num3 = Val(str3)
        For i3 = 0 To l3
            A3(i3) = num3 Mod 10
            num3 = num3 \ 10
        Next
        For i3 = l3 To 0 Step -1
            k3 = i3
            Select Case i3
                Case 10 : curr3 = curr3 & Convert13(A3(i3 - 1), A3(i3), "مليار ")
                Case 9 : curr3 = curr3 & Convert13(A3(i3 - 1), , "مءة")
                Case 8 : curr3 = curr3 & Convert33(A3(i3 - 1))
                Case 7 : curr3 = curr3 & Convert13(A3(i3 - 1), A3(i3), " مليون ")
                Case 6 : curr3 = curr3 & Convert13(A3(i3 - 1), , " مءة ")
                Case 5 : curr3 = curr3 & Convert33(A3(i3 - 1))
                Case 4 : curr3 = curr3 & Convert13(A3(i3 - 1), A3(i3), " الف ")
                Case 3 : curr3 = curr3 & Convert13(A3(i3 - 1), , " مءة ")
                Case 2 : curr3 = curr3 & Convert33(A3(i3 - 1))
                Case 1 : curr3 = curr3 & Convert13(A3(i3 - 1), A3(i3))
            End Select
        Next
        If curr3 = "" Then curr3 = " صفر "
        lblResult3.Text = curr3
    End Sub



    '-----------------------Other----------------------------------------------------------------------------

    Private Sub txtCur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or txtCur.Text.Length >= 12 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCur.Clear()
        lblResult.Text = ""
        lblResult2.Text = ""
        lblResult3.Text = ""
    End Sub

End Class
