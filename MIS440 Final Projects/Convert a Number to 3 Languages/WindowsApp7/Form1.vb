Public Class Form1

    Dim str As String
    Dim k As Integer
    Dim A(30) As Integer
    Dim b As Boolean


    '----------------------------------------------------------- English -----------------------------------
    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------- Button Eng---------------------------------------------------------------------------
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim curE As String = " "
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
                Case 10 : curE = curE & ConvEng1(A(i - 1), A(i), " Billion")
                Case 9 : curE = curE & ConvEng1(A(i - 1), , " Hundred")
                Case 8 : curE = curE & ConvEng2(A(i - 1))
                Case 7 : curE = curE & ConvEng1(A(i - 1), A(i), " Million")
                Case 6 : curE = curE & ConvEng1(A(i - 1), , " Hundred")
                Case 5 : curE = curE & ConvEng2(A(i - 1))
                Case 4 : curE = curE & ConvEng1(A(i - 1), A(i), " Thousand")
                Case 3 : curE = curE & ConvEng1(A(i - 1), , " Hundred")
                Case 2 : curE = curE & ConvEng2(A(i - 1))
                Case 1 : curE = curE & ConvEng1(A(i - 1), A(i))
            End Select
        Next
        If curE = " " Then curE = "Zero"
        lblResultE.Text = curE
    End Sub

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------
    Private Function ConvEng1(ByVal num As Integer, Optional ByVal Nexttime As Integer = 0, Optional ByVal Digit As String = "") As String
        Dim EngN As String = ""
        If Nexttime = 1 Then
            ConvEng1 = ConvEng3(num, Digit)
            Exit Function
        End If
        Select Case num
            Case 9 : EngN = " Nine"
            Case 8 : EngN = " Eight"
            Case 7 : EngN = " Seven"
            Case 6 : EngN = " Six"
            Case 5 : EngN = " Five"
            Case 4 : EngN = " Four"
            Case 3 : EngN = " Three"
            Case 2 : EngN = " Two"
            Case 1 : EngN = " One"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvEng1 = EngN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function ConvEng2(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim EngNN As String = ""
        Select Case num
            Case 9 : EngNN = " Ninety"
            Case 8 : EngNN = " Eighty"
            Case 7 : EngNN = " Seventy"
            Case 6 : EngNN = " Sixty"
            Case 5 : EngNN = " Fifty"
            Case 4 : EngNN = " Fourty"
            Case 3 : EngNN = " Thirty"
            Case 2 : EngNN = " Twenty"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvEng2 = EngNN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function ConvEng3(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim EngNNN As String = ""
        Select Case num
            Case 9 : EngNNN = " Nineteen"
            Case 8 : EngNNN = " Eighteen"
            Case 7 : EngNNN = " Seventeen"
            Case 6 : EngNNN = " Sixteen"
            Case 5 : EngNNN = " Fifteen"
            Case 4 : EngNNN = " Fourteen"
            Case 3 : EngNNN = " Thirteen"
            Case 2 : EngNNN = " Twelve"
            Case 1 : EngNNN = " Eleven"
            Case 0 : EngNNN = " Ten"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvEng3 = EngNNN & Digit
    End Function


    '------------------------------------------------------- Russian -----------------------------------
    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------- Button Rus---------------------------------------------------------------------------
    Private Sub btnConvert2_Click(sender As Object, e As EventArgs) Handles btnConvert2.Click
        Dim curR As String = " "
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
                Case 10 : curR = curR & ConvRus1(A(i - 1), A(i), " Миллиард")
                Case 9 : curR = curR & ConvRus1(A(i - 1), , " Сто")
                Case 8 : curR = curR & ConvRus2(A(i - 1))
                Case 7 : curR = curR & ConvRus1(A(i - 1), A(i), " Миллион")
                Case 6 : curR = curR & ConvRus1(A(i - 1), , " Сто")
                Case 5 : curR = curR & ConvRus2(A(i - 1))
                Case 4 : curR = curR & ConvRus1(A(i - 1), A(i), " Тысяча")
                Case 3 : curR = curR & ConvRus1(A(i - 1), , " Сто")
                Case 2 : curR = curR & ConvRus2(A(i - 1))
                Case 1 : curR = curR & ConvRus1(A(i - 1), A(i))
            End Select
        Next
        If curR = " " Then curR = "Ноль"
        lblResultR.Text = curR
    End Sub

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------
    Private Function ConvRus1(ByVal num As Integer, Optional ByVal Nexttime As Integer = 0, Optional ByVal Digit As String = "") As String
        Dim RusN As String = ""
        If Nexttime = 1 Then
            ConvRus1 = ConvRus3(num, Digit)
            Exit Function
        End If
        Select Case num
            Case 9 : RusN = " Девять"
            Case 8 : RusN = " Восемь"
            Case 7 : RusN = " Семь"
            Case 6 : RusN = " Шесть"
            Case 5 : RusN = " Пять"
            Case 4 : RusN = " Четыре"
            Case 3 : RusN = " Три"
            Case 2 : RusN = " Два"
            Case 1 : RusN = " Один"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvRus1 = RusN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function ConvRus2(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim RusNN As String = ""
        Select Case num
            Case 9 : RusNN = " Девяносто"
            Case 8 : RusNN = " Восемьдесят"
            Case 7 : RusNN = " Семьдесят"
            Case 6 : RusNN = " Шестьдесят"
            Case 5 : RusNN = " Пятьдесят"
            Case 4 : RusNN = " Сорок"
            Case 3 : RusNN = " Тридцать"
            Case 2 : RusNN = " Двадцать"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvRus2 = RusNN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function ConvRus3(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim RusNNN As String = ""
        Select Case num
            Case 9 : RusNNN = " Девятнадцать"
            Case 8 : RusNNN = " Восемнадцать"
            Case 7 : RusNNN = " Семнадцать"
            Case 6 : RusNNN = " Шестнадцать"
            Case 5 : RusNNN = " Пятнадцать"
            Case 4 : RusNNN = " Четырнадцать"
            Case 3 : RusNNN = " Тринадцать"
            Case 2 : RusNNN = " Двенадцать"
            Case 1 : RusNNN = " Одиннадцать"
            Case 0 : RusNNN = " Десять"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvRus3 = RusNNN & Digit
    End Function


    '---------------------------------------------------- Arabic -----------------------------------
    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------- Button Ar---------------------------------------------------------------------------
    Private Sub btnConvert3_Click(sender As Object, e As EventArgs) Handles btnConvert3.Click
        Dim curA As String = " "
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
                Case 10 : curA = curA & ConvAr1(A(i - 1), A(i), " مليار ")
                Case 9 : curA = curA & ConvAr1(A(i - 1), , " مئة ")
                Case 8 : curA = curA & ConvAr2(A(i - 1))
                Case 7 : curA = curA & ConvAr1(A(i - 1), A(i), " مليون ")
                Case 6 : curA = curA & ConvAr1(A(i - 1), , " مئة ")
                Case 5 : curA = curA & ConvAr2(A(i - 1))
                Case 4 : curA = curA & ConvAr1(A(i - 1), A(i), " الف ")
                Case 3 : curA = curA & ConvAr1(A(i - 1), , " مئة ")
                Case 2 : curA = curA & ConvAr2(A(i - 1))
                Case 1 : curA = curA & ConvAr1(A(i - 1), A(i))
            End Select
        Next
        If curA = " " Then curA = "صفر"
        lblResultA.Text = curA
    End Sub

    '-------------------------------------------------------------------------------- Function 1--------------------------------------------

    Private Function ConvAr1(ByVal num As Integer, Optional ByVal Nexttime As Integer = 0, Optional ByVal Digit As String = "") As String
        Dim ArN As String = ""
        If Nexttime = 1 Then
            ConvAr1 = ConvAr3(num, Digit)
            Exit Function
        End If
        Select Case num
            Case 9 : ArN = " تسعة"
            Case 8 : ArN = " ثمانية"
            Case 7 : ArN = " سبعة"
            Case 6 : ArN = " ستة"
            Case 5 : ArN = " خمسة"
            Case 4 : ArN = " اربعة"
            Case 3 : ArN = " ثلاثة"
            Case 2 : ArN = " اثنان"
            Case 1 : ArN = " واحد"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvAr1 = ArN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 2--------------------------------------------
    Private Function ConvAr2(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim ArNN As String = ""
        Select Case num
            Case 9 : ArNN = " تسعون"
            Case 8 : ArNN = " ثمانون"
            Case 7 : ArNN = " سبعون"
            Case 6 : ArNN = " ستون"
            Case 5 : ArNN = " خمسون"
            Case 4 : ArNN = " اربعون"
            Case 3 : ArNN = " ثلاثون"
            Case 2 : ArNN = " عشرون"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""

        End If
c:
        ConvAr2 = ArNN & Digit
    End Function

    '-------------------------------------------------------------------------------- Function 3--------------------------------------------
    Private Function ConvAr3(ByVal num As Integer, Optional ByVal Digit As String = "") As String
        Dim ArNNN As String = ""
        Select Case num
            Case 9 : ArNNN = " تسعة عشر"
            Case 8 : ArNNN = " ثمانية عشر"
            Case 7 : ArNNN = " سبعة عشر"
            Case 6 : ArNNN = " ستة عشر"
            Case 5 : ArNNN = " خمسة عشر"
            Case 4 : ArNNN = " اربعة عشر"
            Case 3 : ArNNN = " ثلاثة عشر"
            Case 2 : ArNNN = " اثنا عشر"
            Case 1 : ArNNN = " احد عشر"
            Case 0 : ArNNN = " عشرة"
        End Select
        If k = 7 Then b = True
        If num = 0 Then
            If k = 7 Then GoTo c
            If b = False And k = 4 Then GoTo c
            Digit = ""
        End If
c:
        ConvAr3 = ArNNN & Digit
    End Function

    '-----------------------Other----------------------------------------------------------------------------

    Private Sub ResetArray()
        Dim i As Integer
        For i = LBound(A) To UBound(A)
            A(i) = 0
        Next
    End Sub

    Private Sub txtCur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCur.KeyPress
        lblResultE.Text = ""
        lblResultR.Text = ""
        lblResultA.Text = ""
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <= 47 Or Asc(e.KeyChar) >= 58 Or txtCur.Text.Length >= 12 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCur.Clear()
        lblResultE.Text = ""
        lblResultR.Text = ""
        lblResultA.Text = ""
    End Sub


End Class
