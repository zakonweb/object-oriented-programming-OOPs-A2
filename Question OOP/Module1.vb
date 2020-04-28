Module Module1

    Sub Main()
        Dim question1 As New Question(1, "WHO is IK", 10)
        
        Dim question2 As New Question(2, "Who is ZAK?", 2)

        Dim question3 As New Question(3, "Who is MAK?", 5)
        

        Console.WriteLine(question1.getQContent)
        Console.WriteLine(question2.getQContent)
        Console.WriteLine(question3.getQContent)

        Console.ReadKey()
    End Sub

End Module
