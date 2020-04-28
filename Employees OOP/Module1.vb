Module Module1

    Sub Main()
        Dim en As String
        Console.Write("ENTER Employee Number:")
        en = Console.ReadLine

        Dim AsadEmp As New Employees(en, "10/12/17")
        Console.WriteLine(AsadEmp.getERN)

        Console.ReadLine()
    End Sub

End Module
