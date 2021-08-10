Public Class Programmers
    Inherits PermanentEmployees
    Private ProgLanguages As String
    Public Function SetProgLanguages() As String
        Console.WriteLine("Enter the programming Languages the employee uses")
        ProgLanguages = Console.ReadLine
        Return ProgLanguages
    End Function
End Class
