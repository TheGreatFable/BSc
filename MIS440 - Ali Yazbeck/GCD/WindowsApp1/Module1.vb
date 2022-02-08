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


End Module
