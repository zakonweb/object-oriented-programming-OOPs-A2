Public Class Employees
    Private EmployeeRfNo As String
    Private DateJoined As Date

    'Aggregation/Containment
    Dim ahmed As New PermanentEmployees
    'Constructor
    Public Sub New(ByVal ern As String, ByVal sdj As Date)
        EmployeeRfNo = ern
        DateJoined = sdj
    End Sub

    Public Sub SetEmployeeRfNo(ByVal ern As String)
        EmployeeRfNo = ern
    End Sub

    Public Sub SetDateJoined(ByVal sdj As Date)
        DateJoined = sdj
    End Sub

    Public Function getERN() As String
        Return EmployeeRfNo
    End Function
End Class

