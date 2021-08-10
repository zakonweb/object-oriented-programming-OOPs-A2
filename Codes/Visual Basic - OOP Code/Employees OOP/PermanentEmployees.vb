Public Class PermanentEmployees
    Inherits $safeprojectname$
    Private SalaryGrade As String
    Private CoursesAttended As String
    Public Function SetSalaryGrade() As String
        Console.WriteLine("Enter the employee's Salary Grade")
        SalaryGrade = Console.ReadLine
        Return SalaryGrade
    End Function
    Public Function SetCoursesAttended() As String
        Console.WriteLine("Enter the courses the Employee has attended")
        CoursesAttended = Console.ReadLine
        Return CoursesAttended
    End Function
End Class
