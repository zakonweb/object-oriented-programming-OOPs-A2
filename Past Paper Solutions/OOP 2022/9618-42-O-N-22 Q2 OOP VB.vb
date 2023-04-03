' Main.vb
Module MainModule
    Sub Main()
        ' Main program code
        Dim theCharacters(9) As Character
        Dim lineNo As Integer = 0
        Dim fileName As String = "c:/Users/ZAK/mu_code/Characters.txt"
        Dim file As System.IO.StreamReader = New System.IO.StreamReader(fileName)
        Dim line As String
        Do While Not file.EndOfStream
            line = file.ReadLine().Trim()
            If line <> "" AndAlso lineNo <= 9 Then
                theCharacters(lineNo) = New Character(line, Integer.Parse(file.ReadLine()), Integer.Parse(file.ReadLine()))
                lineNo += 1
            End If
        Loop
        file.Close()

        ' Main program code for searching for a character
        Dim indexFound As Integer = -1
        Dim name As String
        Dim i As Integer
        While indexFound = -1
            Console.Write("Enter a character name: ")
            name = Console.ReadLine()
            For i = 0 To theCharacters.Length - 1
                If theCharacters(i).GetName().ToLower() = name.ToLower() Then
                    indexFound = i
                    Exit For
                End If
            Next
        End While

        ' Main program code for moving a character
        Dim direction As String
        While True
            Console.Write("Enter a direction (A, W, S or D): ")
            direction = Console.ReadLine().ToLower()
            Select Case direction
                Case "a"
                    theCharacters(indexFound).ChangePosition(-1, 0)
                    Exit While
                Case "w"
                    theCharacters(indexFound).ChangePosition(0, 1)
                    Exit While
                Case "s"
                    theCharacters(indexFound).ChangePosition(0, -1)
                    Exit While
                Case "d"
                    theCharacters(indexFound).ChangePosition(1, 0)
                    Exit While
                Case Else
                    Console.WriteLine("Invalid direction")
            End Select
        End While

        ' Main program code for outputting the character's name and new coordinates
        Console.WriteLine("{0} has changed coordinates to X = {1} and Y = {2}", theCharacters(indexFound).GetName(), theCharacters(indexFound).GetX(), theCharacters(indexFound).GetY())

        Console.ReadKey()
    End Sub

    ' Character.vb
    Public Class Character
        ' Declare attributes
        Private _characterName As String
        Private _xCoordinate As Integer
        Private _yCoordinate As Integer

        ' Constructor
        Public Sub New(ByVal Name As String, ByVal XCoordinate As Integer, ByVal YCoordinate As Integer)
            _characterName = Name
            _xCoordinate = XCoordinate
            _yCoordinate = YCoordinate
        End Sub

        ' Getter methods
        Public Function GetName() As String
            Return _characterName
        End Function

        Public Function GetX() As Integer
            Return _xCoordinate
        End Function

        Public Function GetY() As Integer
            Return _yCoordinate
        End Function

        ' Setter methods
        Public Sub ChangePosition(ByVal XChange As Integer, ByVal YChange As Integer)
            _xCoordinate += XChange
            _yCoordinate += YChange
        End Sub
    End Class
End Module
