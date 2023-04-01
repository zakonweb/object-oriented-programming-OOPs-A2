Public Class $safeprojectname$
    Private EmployeeRfNo As String
    Private DateJoined As Date
    Public Function SetEmployeeRfNo() As String
        Console.WriteLine("Enter Employee's Reference Number")
        EmployeeRfNo = Console.ReadLine()
        Return EmployeeRfNo
    End Function
    Public Function SetDateJoined() As Date
        Console.WriteLine("Enter the Date the Employee joined at")
        DateJoined = Console.ReadLine()
        Return DateJoined
    End Function
End Class

