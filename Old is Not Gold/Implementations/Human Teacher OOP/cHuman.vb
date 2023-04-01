Public Class Human
    Private hName As String
    Private hAdd As String
    Private hAge As String

    'Constructor method : NEW
    Public Sub New(ByVal n As String, ByVal a As String, ByVal ag As Integer)
        hName = n
        hAdd = a
        hAge = ag
    End Sub

    'Methods return individual variable values are called GETTERS
    Public Function tellName() As String
        Return hName
    End Function

    Public Function tellAddress() As String
        Return hAdd
    End Function

    Public Function tellAge() As Integer
        Return hAge
    End Function

    'Methods required/permitted to be inherited and changed for POLYMORPHISM
    'must be made OVEERRIDABLE
    Public Overridable Function tellAll() As String
        Return "Name: " & hName & ", Address: " & hAdd & ". Age is " & hAge
    End Function
End Class
