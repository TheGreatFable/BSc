Module Module1
    Dim myArray(999) As Integer
    Sub Main()
        init()
        lookup()
    End Sub
    Sub init()
        For i = 0 To 999
            myArray(i) = Int(Rnd() * 10000)
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Sub lookup()
        Dim myvalue As Integer
        Dim location As String
        myvalue = 1
        While myvalue <> 0
            Console.WriteLine("input a number from the list above or 0 to end")
            myvalue = Console.ReadLine
            If myvalue <> 0 Then
                location = find(myvalue)
                Console.WriteLine(myvalue & " is found in " & location)
            End If
        End While
        MsgBox(":)")
    End Sub
    Function find(avalue As Integer) As String
        Dim j As Integer
        Dim found As Boolean
        Dim location2 As Integer
        j = 0
        found = False
        While (j <= 999) And found = False
            If myArray(j) = avalue Then
                found = True
                location2 = j
            End If
            j = j + 1
        End While
        If found Then
            Return location2
        Else
            Return "another universe, not in here"
        End If
    End Function
End Module
