Imports System.IO
Public Class Form1
    Private Sub cmdGo_Click(sender As Object, es As EventArgs) Handles cmdGo.Click

        Console.WriteLine(" ")
        Console.WriteLine("result for jamaica (from jamaica.txt):")
        Console.WriteLine(" ")
        Dim textfilelink As String
        textfilelink = txtInput.Text

        Try
            ' create an instance of streamreader to read from a file.
            ' the using statement also closes the streamreader.
            Using sr As StreamReader = New StreamReader(textfilelink)
                Dim line1 As String
                ' read and display lines form the file until the end of the file is reached.
                line1 = sr.ReadLine()
                While (line1 <> Nothing)
                    Console.WriteLine(line1)
                    line1 = sr.ReadLine()
                End While
            End Using
        Catch e As Exception
            ' let the user know what went wrong.
            Console.WriteLine("the file could not be read:")
            Console.WriteLine(e.Message)
        End Try

        '====================================================================================

        For i = 0 To 3
            Console.WriteLine(" ")
        Next
        Console.WriteLine("result for names (to names.txt):")
        Console.WriteLine(" ")
        Dim textfilelink2, inputnames As String
        textfilelink2 = txtinput2.Text
        inputnames = txtinput3.Text

        Dim names As String() = New String() {inputnames}
        Dim s As String
        Using sw As StreamWriter = New StreamWriter(textfilelink2)
            For Each s In names
                sw.WriteLine(s)
            Next s
        End Using
        ' Read and show each line from the file.
        Dim line As String
        Using sr As StreamReader = New StreamReader(textfilelink2)
            line = sr.ReadLine()
            While (line <> Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using

        MsgBox("Done")
    End Sub
End Class