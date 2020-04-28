Module Module1
    Dim IsLand As New IslandClass
    Sub Main()
        Call DisplayGrid()
        Console.ReadKey()


        For Treasure = 1 To 3
            Call Island.HideTreasure()
        Next Treasure

        Console.Clear()
        'Call DisplayGrid()
        'Console.ReadKey()


        Call StartDig()
        Call DisplayGrid()
        Console.ReadKey()
    End Sub

    Sub DisplayGrid()
        Dim row, col As Integer
        For row = 0 To 9
            For col = 0 To 29
                Console.Write(IsLand.GetSquare(row, col))
            Next Col
            Console.Writeline()
        Next row
    End Sub

    Sub StartDig()
        Dim X, Y As Integer

        Do
            Console.Write("Input row: ") : X = Console.Readline()
            Console.Write("Input Column: ") : Y = Console.Readline()
        Loop Until (X >= 0 And X <= 9) And (Y >= 0 And Y <= 29)

        Call IsLand.DigHole(X, Y)
    End Sub
End Module
