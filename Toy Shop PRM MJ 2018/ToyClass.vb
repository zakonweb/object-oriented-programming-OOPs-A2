Public Class ToyClass
    Private toyName As String
    Private toyID As String
    Private toyPrice As Decimal
    Private minAge As Integer

    Public Sub New(ByVal N As String, ByVal ID As String, ByVal P As Decimal, ByVal A As Integer)
        Me.toyID = ID
        Me.toyName = N
        Me.toyPrice = P
        Me.minAge = A

    End Sub

    Public Function getToyName() As String
        Return Me.toyName
    End Function

    Public Function getToyID() As String
        Return Me.toyID
    End Function

    Public Function getToyPrice() As Decimal
        Return Me.toyPrice
    End Function

    Public Function getMinAge() As Integer
        Return Me.minAge
    End Function

    Public Sub setToyID(ByVal Value As String)
        Me.toyID = Value
    End Sub

    Public Sub setToyName(ByVal Value As String)
        Me.toyName = Value
    End Sub

    Public Sub setToyPrice(ByVal Value As Decimal)
        Me.toyPrice = Value
    End Sub

    Public Sub setMinAge(ByVal Value As Integer)
        Me.minAge = Value
    End Sub
End Class
