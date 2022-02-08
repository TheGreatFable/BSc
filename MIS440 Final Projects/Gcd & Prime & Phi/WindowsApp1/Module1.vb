Module Module1

    '---------GCD------------------------------------------
    Function gcdfun(a As Long, b As Long) As Long
        Dim temp As Long
        Do While b > 0
            temp = b
            b = a Mod b
            a = temp
        Loop
        Return a
    End Function

    '-------------Phi------------------------------
    Function phifun(a As Long) As Long
        Dim count As Long = 1
        Dim gd As Long
        If a < 3 Then
            Return 1
            Exit Function
        End If
        'If isprime(a) Then
        'Return a - 1
        'Exit Function
        'End If
        For i = 2 To a - 1
            gd = gcdfun(i, a)
            If gd = 1 Then
                count = count + 1
            End If
        Next
        Return count
    End Function

    '---------------Prime or not--------------------------
    Function isprime(a As Long) As Long
        For i = 2 To a - 1
            If (a Mod i = 0) Then
                Return False
            End If
        Next
        Return True
    End Function



End Module
