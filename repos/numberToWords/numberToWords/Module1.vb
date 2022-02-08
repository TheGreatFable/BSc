﻿Module Module1
    Function NumberToWord(ByVal MyNumber)
        Dim Temp
        Dim Num, Digits As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Hundred "
        place(4) = "  "
        place(6) = "  "
        place(8) = "  "
        On Error Resume Next
        MyNumber = Trim(Str(MyNumber))
        DecimalPlace = InStr(MyNumber, ".")
        If DecimalPlace > 0 Then
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Digits = " and " & ConvertTens(Temp)
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If
        Dim TM As String
        TM = Right(MyNumber, 2)
        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                NumberToWord = Words & Digits
                Exit Function
            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    NumberToWord = Words & Digits
                    Exit Function
                End If
            End If
        End If
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)
        iCount = 0
        Do While MyNumber <> ""
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then
                If Trim(Words) = "Thousand" Or
                Trim(Words) = "Hundred  Thousand" Or
                Trim(Words) = "Hundred" Then
                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)
                Else
                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)
                End If
            Else
                If Trim(Words) = "Thousand" Or
                   Trim(Words) = "Hundred  Thousand" Or
                   Trim(Words) = "Hundred" Then
                    Words = ConvertTens(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else
                    If Trim(ConvertTens(Temp) & place(iCount)) = "Hundred" Then
                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If
                End If
            End If
            iCount = iCount + 2
        Loop
        NumberToWord = " " & Words & Hundreds & Digits & ""
    End Function

    Private Function ConvertHundreds(ByVal MyNumber)
        Dim Result As String
        If Val(MyNumber) = 0 Then Exit Function
        MyNumber = Right("000" & MyNumber, 3)
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundred "
        End If
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)
    End Function

    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If
        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function
End Module
