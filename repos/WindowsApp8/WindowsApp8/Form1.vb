Public Class Form1

    Public Shared Function ConvertNum(ByVal Input As Long) As String
        Dim output As String = Nothing
        If Input < 1000 Then
            output = FindNumber(Input)
        Else
            Dim nparts() As String
            Dim n As String = Input
            Dim i As Long = Input.ToString.Length
            Do Until i - 3 <= 0
                n = n.Insert(i - 3, ",")
                i = i - 3
            Loop
            nparts = n.Split(",")
            i = Input.ToString.Length
            Dim p As Integer = 0
            For Each s As String In nparts
                Dim x As Long = CLng(s)
                p = p + 1
                If p = nparts.Length Then
                    If x <> 0 Then
                        If CLng(s) < 100 Then
                            output = output & " And " & FindNumber(CLng(s))
                        Else
                            output = output & " " & FindNumber(CLng(s))
                        End If
                    End If
                Else
                    If x <> 0 Then
                        If output = Nothing Then
                            output = output & FindNumber(CLng(s)) & " " & FindSuffix(i, CLng(s))
                        Else
                            output = output & " " & FindNumber(CLng(s)) & " " & FindSuffix(i, CLng(s))
                        End If
                    End If
                End If
                i = i - 3
            Next
        End If
        Return output
    End Function

    Private Shared Function FindNumber(ByVal Number As Long) As String
        Dim Words As String = Nothing
        Dim Digits() As String = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
      "Eight", "Nine", "Ten"}
        Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
       "Eighteen", "Nineteen"}
        If Number < 11 Then
            Words = Digits(Number)
        ElseIf Number < 20 Then
            Words = Teens(Number - 10)
        ElseIf Number = 20 Then
            Words = "Twenty"
        ElseIf Number < 30 Then
            Words = "Twenty " & Digits(Number - 20)
        ElseIf Number = 30 Then
            Words = "Thirty"
        ElseIf Number < 40 Then
            Words = "Thirty " & Digits(Number - 30)
        ElseIf Number = 40 Then
            Words = "Fourty"
        ElseIf Number < 50 Then
            Words = "Fourty " & Digits(Number - 40)
        ElseIf Number = 50 Then
            Words = "Fifty"
        ElseIf Number < 60 Then
            Words = "Fifty " & Digits(Number - 50)
        ElseIf Number = 60 Then
            Words = "Sixty"
        ElseIf Number < 70 Then
            Words = "Sixty " & Digits(Number - 60)
        ElseIf Number = 70 Then
            Words = "Seventy"
        ElseIf Number < 80 Then
            Words = "Seventy " & Digits(Number - 70)
        ElseIf Number = 80 Then
            Words = "Eighty"
        ElseIf Number < 90 Then
            Words = "Eighty " & Digits(Number - 80)
        ElseIf Number = 90 Then
            Words = "Ninety"
        ElseIf Number < 100 Then
            Words = "Ninety " & Digits(Number - 90)
        ElseIf Number < 1000 Then
            Words = Number.ToString
            Words = Words.Insert(1, ",")
            Dim wparts As String() = Words.Split(",")
            Words = FindNumber(wparts(0)) & " " & "Hundred"
            Dim n As String = FindNumber(wparts(1))
            If CLng(wparts(1)) <> 0 Then
                Words = Words & " And " & n
            End If
        End If
        Return Words
    End Function

    Private Shared Function FindSuffix(ByVal Length As Long, ByVal l As Long) As String
        Dim word As String
        If l <> 0 Then
            If Length > 12 Then
                word = "Trillion"
            ElseIf Length > 9 Then
                word = "Billion"
            ElseIf Length > 6 Then
                word = "Million"
            ElseIf Length > 3 Then
                word = "Thousand"
            ElseIf Length > 2 Then
                word = "Hundred"
            Else
                word = ""
            End If
        Else
            word = ""
        End If
        Return word
    End Function
End Class
