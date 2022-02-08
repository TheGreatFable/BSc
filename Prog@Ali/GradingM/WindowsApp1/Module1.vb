Public Module Module1


    Function grade1(num As String) As String
        If (num >= 0 & num <= 100) Then

            Select Case num
                Case 0 To 59
                    Return "F"

                Case 60 To 62
                    Return "D"

                Case 63 To 64
                    Return "D+"

                Case 65 To 69
                    Return "C-"

                Case 70 To 72
                    Return "C"

                Case 73 To 75
                    Return "C+"

                Case 76 To 79
                    Return "B-"

                Case 80 To 84
                    Return "B"

                Case 85 To 86
                    Return "B+"

                Case 87 To 89
                    Return "A-"

                Case 90 To 94
                    Return "A"

                Case 95 To 100
                    Return "A+"

                Case Else
                    Return ""

            End Select
        End If
    End Function



    Function grade2(num As String) As String
        If (num >= 0 & num <= 100) Then

            Select Case num
                Case 0 To 59

                    Return "0"

                Case 60 To 62

                    Return "1"

                Case 63 To 64

                    Return "1.3"

                Case 65 To 69

                    Return "1.7"

                Case 70 To 72

                    Return "2"

                Case 73 To 75

                    Return "2.3"

                Case 76 To 79

                    Return "2.7"

                Case 80 To 84

                    Return "3"

                Case 85 To 86

                    Return "3.3"

                Case 87 To 89

                    Return "3.7"

                Case 90 To 94

                    Return "4"

                Case 95 To 100

                    Return "4"

                Case Else
                    Return ""

            End Select
        End If
    End Function



    Function grade3(num As String) As String
        If (num >= 0 & num <= 100) Then

            Select Case num
                Case 0 To 59

                    Return "Failure"
                Case 60 To 62

                    Return "Lowest Passing"
                Case 63 To 64

                    Return "Passing"
                Case 65 To 69

                    Return "Passing"
                Case 70 To 72

                    Return "Satisfactory"
                Case 73 To 75

                    Return "Satisfactory"
                Case 76 To 79

                    Return "Reasonably Good"
                Case 80 To 84

                    Return "Good"
                Case 85 To 86

                    Return "Very Good"
                Case 87 To 89

                    Return "Skillful"
                Case 90 To 94

                    Return "Excellent"
                Case 95 To 100

                    Return "Outstanding"
                Case Else
                    Return ""

            End Select
        End If
    End Function






End Module
