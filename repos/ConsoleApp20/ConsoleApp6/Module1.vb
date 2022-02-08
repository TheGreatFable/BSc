Module Module1
    Public word As String, age As String, year As Single, j As Single
    Sub Main()
        Console.WriteLine("Hello Mr. Ali")
        Console.WriteLine("How may i serve you today sir?")
        j = 0
        word = Console.ReadLine()
        While word <> "no"
            If word = "hack the world" Then Console.WriteLine("i can't do this now, sry")
            If word = "hack my university" Then Console.WriteLine("i don't have the authority to do this")
            If word = "what is my name?" Then Console.WriteLine("Your full name is Yazbek Ali")
            If word = "surprise me" Then
                Console.WriteLine("would you like to know your age in the future?")
                age = Console.ReadLine()
                If age = "yes" Then
                    Console.WriteLine("please enter the year:")
                    year = Console.ReadLine
                    Console.WriteLine("your age will be " & year - 1997)
                End If
            End If
            If word = "i want to fuck you" Then Console.WriteLine("go fuck your self, Suka")
            j = j + 1
            If j = 5 Then Console.WriteLine(" if you will ask more, ia tebia viebu v jopu suka bliat")
            Console.WriteLine("may i help you with something else?")
            word = Console.ReadLine()
        End While
        MsgBox("goodbye sir, see you later.")
    End Sub

End Module
