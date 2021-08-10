Public Class WebDesigners
    Inherits PermanentEmployees
    Private MarkUpLangUsed As String
    Private Function SetMaarkupLangused() As String
        Console.WriteLine("Enter the Markup Languages the employee has used")
        MarkUpLangUsed = Console.ReadLine
        Return MarkUpLangUsed
    End Function
End Class
