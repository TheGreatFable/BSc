Module Module1
    'given a number n, ouptut a- the last l digits: ld   b- the first f digits:fd
    'input n l f output ld fd
    Sub Main()
        Dim n As Single, l As Single, f As Single, ld As Single, ll As Single, fd As Single
        n = Console.ReadLine
        l = Console.ReadLine
        f = Console.ReadLine
        ld = n Mod 10 ^ l
        ll = Int(log10(n)) + 1
        fd = n \ (10 ^ ll)
        Console.WriteLine("results:")
        Console.WriteLine(ld)
        Console.WriteLine(ll)
        Console.WriteLine(fd)
        MsgBox("ok")
    End Sub

End Module
