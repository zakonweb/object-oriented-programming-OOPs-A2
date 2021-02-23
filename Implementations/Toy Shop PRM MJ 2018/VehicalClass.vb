Public Class VehicalClass
    Inherits ToyClass

    Private Type As String
    Private Height As Integer
    Private Length As Integer
    Private Weight As Single

    Public Sub New(ByVal N As String, ByVal ID As String, ByVal P As Decimal, _
                   ByVal A As Integer, ByVal T As String, ByVal H As Integer, ByVal L As Integer, _
                   ByVal W As Single)
        MyBase.New(N, ID, P, A)
        Me.Type = T
        Me.Height = H
        Me.Length = L
        Me.Weight = W

    End Sub

    Public Function getToyType() As String
        Return Me.Type
    End Function

    Public Function getHeight() As Integer
        Return Me.Type
    End Function

    Public Function getLength() As Integer
        Return Me.Type
    End Function

    Public Function getWeight() As Decimal
        Return Me.Type
    End Function

    Public Sub setToyType(ByVal Value As String)
        Me.Type = Value
    End Sub

    Public Sub setHeight(ByVal Value As Integer)
        Me.Height = Value
    End Sub

    Public Sub setLength(ByVal Value As Integer)
        Me.Length = Value
    End Sub

    Public Sub setWeight(ByVal Value As Decimal)
        Me.Weight = Value
    End Sub



End Class
