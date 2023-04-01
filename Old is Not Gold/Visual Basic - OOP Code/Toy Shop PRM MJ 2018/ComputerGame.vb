Public Class ComputerGame
    Inherits ToyClass

    Private Category As String
    Private Console As String

    Public Sub New(ByVal N As String, ByVal ID As String, ByVal P As Decimal, _
                   ByVal A As Integer, ByVal Cat As String, ByVal COn As String)
        MyBase.New(N, ID, P, A)
        Me.Category = Cat
        Me.Console = con

    End Sub

    Public Function getCategory() As String
        Return Me.Category
    End Function

    Public Function getConsole() As String
        Return Me.Console
    End Function

    Public Sub setCategory(ByVal Cat As String)
        Me.Category = Cat
    End Sub

    Public Sub setConsole(ByVal Con As String)
        Me.Console = Con
    End Sub



End Class
