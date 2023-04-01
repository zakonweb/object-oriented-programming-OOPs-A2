Public Class ContractEmployees
    Inherits $safeprojectname$
    Private AgencySent As String
    Private HourlyPay As Integer
    Private JobRole As String
    Public Function SetAgencySent() As String
        Console.WriteLine("Enter the agency the employee is sent by")
        AgencySent = Console.ReadLine
        Return AgencySent
    End Function
    Public Function SetHourlyPay() As Integer
        Console.WriteLine("Enter the Hourly pay")
        HourlyPay = Console.ReadLine
        Return HourlyPay
    End Function
    Public Function SetJobRole() As String
        Console.WriteLine("Enter the job role the employee has been assigned")
        JobRole = Console.ReadLine
        Return JobRole
    End Function
End Class
