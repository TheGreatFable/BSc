Public Class Form1

    Public countries() As String = {"lebanon", "france", "russia", "england", "spain", "italy", "germany"}
    Public capitals(6) As String

    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click
        For i = 0 To 6
            capitals(i) = InputBox("what is the capital of " & countries(i))
        Next
        '---a parallel array of capitals is filled
        '---lets sort it by capitals
        Array.Sort(capitals, countries)
        '---lets print it
        For i = 0 To 6
            Console.WriteLine("the capital of " & countries(i) & " is " & capitals(i))
        Next

    End Sub
End Class
