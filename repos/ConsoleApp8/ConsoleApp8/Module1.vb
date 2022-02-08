Module Module1
    'quadratic equation
    Sub Main()
        Dim a As Single, b As Single, c As Single, delta As Integer
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine
        If a = 0 Then
            Console.WriteLine("this is not a second degree equation")
            End
        Else
            delta = b ^ 2 - 4 * a * c
            If delta < 0 Then
                Console.WriteLine("no solution")
            Else 'delta>=0
                If delta = 0 Then
                    Console.WriteLine(-b / (2 * a))
                Else
                    Console.WriteLine(-b - delta ^ 0.5 / (2 * a))
                    Console.WriteLine(-b + delta ^ 0.5 / (2 * a))
                End If
            End If
        End If
        MsgBox(":)")
    End Sub

End Module
