Module TreasureIslandGame
    ' define constants
    Const sand As Char = "."
    Const treasure As Char = "T"
    Const treasure_found As Char = "X"
    Const treasure_not_found As Char = "O"

    ' main program code is as follows:
    ' DECLARE Island : IslandClass.Constructor() // instantiate object
    ' CALL DisplayGrid() // output island squares
    ' FOR Treasure ← 1 TO 3 // hide 3 treasures
    '     CALL Island.HideTreasure()
    ' ENDFOR
    ' CALL StartDig() // user to input location of dig
    ' CALL DisplayGrid() // output island squares

    Dim Island As New IslandClass() ' instantiate object

    Sub Main()
        Randomize()
        DisplayGrid() ' output island squares
        For Treasure As Integer = 1 To 3 ' hide 3 treasures
            Island.HideTreasure()
        Next
        StartDig() ' user to input location of dig
        DisplayGrid() ' output island squares
        Console.ReadKey()
    End Sub

    Class IslandClass
        ' attributes
        ' Grid ARRAY[0 : 9, 0 : 29] OF CHAR
        Public Grid(9, 29) As Char

        ' constructor
        Public Sub New()
            For i As Integer = 0 To 9
                For j As Integer = 0 To 29
                    Grid(i, j) = sand
                Next
            Next
        End Sub

        ' methods
        Public Sub HideTreasure()
            Dim row As Integer = Int(Rnd() * 10)
            Dim column As Integer = Int(Rnd() * 30)
            Grid(row, column) = treasure
        End Sub

        Public Sub DigHole(row As Integer, column As Integer)
            If Grid(row, column) = treasure Then
                Grid(row, column) = treasure_found
            Else
                Grid(row, column) = treasure_not_found
            End If
        End Sub

        Public Function GetSquare(row As Integer, column As Integer) As Char
            Return Grid(row, column)
        End Function
    End Class

    ' The procedure DisplayGrid shows the current grid data.
    ' DisplayGrid makes use of the getter method GetSquare of the Island class.
    ' An example output is:
    ' ..............................
    ' ..............................
    ' ..............................
    ' ..............................
    ' ..............................
    ' ........T.....................
    ' ..............................
    ' ..............................
    ' .........T....................
    ' ...X..........................

    Sub DisplayGrid()
        For i As Integer = 0 To 9
            For j As Integer = 0 To 29
                Console.Write(Island.GetSquare(i, j))
            Next
            Console.WriteLine()
        Next
    End Sub

    ' The code for StartDig procedure will:
    ' prompts the player for a location to dig
    ' validates the user input, column should be 0-29 and row should be 0-9
    ' calls the DigHole method
    Sub StartDig()
        While True
            Console.Write("Enter row number (0-9): ")
            Dim row As Integer = Integer.Parse(Console.ReadLine())
            Console.Write("Enter column number (0-29): ")
            Dim column As Integer = Integer.Parse(Console.ReadLine())
            If row >= 0 AndAlso row < 10 AndAlso column >= 0 AndAlso column < 30 Then
                Island.DigHole(row, column)
                Exit While
            Else
                Console.WriteLine("Invalid input, try again")
            End If
        End While
    End Sub

End Module
