Module Module1

    Sub Main()
        'Instantiating an Object from a base class
        Dim Ali As New Human("Asad", "Quetta", 13)

        'Instantiating an Object from a sub class
        Dim Zafar As New Teacher("ZAK", "KHI", 35, "MBA", "COMP", 20)

        Zafar.setExp(50)
        Console.WriteLine(Zafar.tellAll)
        Console.WriteLine(Ali.tellAll)
        Console.ReadKey()
    End Sub


End Module
