Public Class ContractEmployees
    Inherits Employees
    Private AgencySent As String
    Private HourlyPay As Decimal
    Private JobRole As String

    Public Sub New(ByVal ern As String, ByVal doj As Date, ByVal AgS As String, ByVal hP As Decimal, ByVal jr As String)
        MyBase.New(ern, doj)
        AgencySent = AgS
        HourlyPay = hP
        JobRole = jr
    End Sub

    Public Sub SetAgencySent(ByVal sas As String)
        AgencySent = sas
    End Sub
    Public Sub SetHourlyPay(ByVal shp As Integer)
        HourlyPay = shp
    End Sub
    Public Sub SetJobRole(ByVal sjr As String)
        JobRole = sjr
    End Sub
End Class
