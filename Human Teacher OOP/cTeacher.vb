Public Class Teacher
    Inherits Human  ' TEACHER class INHERITS ever attribute and method from HUMAN class

    Private Qualification As String
    Private Subject As String
    Private Experience As Integer

    'Methods those are use to create and instantiate an object are called CONSTRUCTOR
    Public Sub New(ByVal n As String, ByVal ad As String, ByVal age As Integer, _
                   ByVal q As String, ByVal s As String, ByVal e As Integer)

        MyBase.New(n, ad, age) 'Using/refering base class
        Qualification = q
        Subject = s
        Experience = e
    End Sub

    'Methods set individual variable values are called SETTERS
    Public Sub setExp(ByVal x As Integer)
        Experience = x
    End Sub

    'POLYMORPHISM
    Public Overrides Function tellAll() As String
        Return MyBase.tellAll() & _
            ", Qua = " & Qualification & ", Sub = " & _
            Subject & ", Exp is " & Experience
    End Function
End Class
