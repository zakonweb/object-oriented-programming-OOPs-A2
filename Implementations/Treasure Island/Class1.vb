Class IslandClass
    Private Grid(9, 29) As Char

    Public Sub New()
        Const Sand = "."
        Dim row, col As Integer
        For row = 0 To 9
            For col = 0 To 29
                Grid(row, col) = Sand
            Next Col
        Next row
    End Sub

    Public Function GetSquare(ByVal Row As Integer, ByVal col As Integer)
        Return Grid(row, col)
    End Function

    Public Sub HideTreasure()
        Const Treasure = "T"
        Dim row, col As Integer
        Dim RN As New Random
        Do
            row = RN.Next(0, 10)
            col = RN.Next(0, 30)
        Loop Until Grid(row, col) <> Treasure

        Grid(row, col) = Treasure
    End Sub

    Public Sub DigHole(ByVal row As Integer, ByVal Col As Integer)
        Const Treasure = "T"
        Const Hole = "O"
        Const TreasureFound = "X"

        If Grid(row, col) = Treasure Then
            Grid(row, col) = TreasureFound
        Else
            Grid(row, col) = Hole
        End If
    End Sub

End Class


