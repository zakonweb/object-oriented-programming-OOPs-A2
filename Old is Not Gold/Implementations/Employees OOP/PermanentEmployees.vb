Public Class PermanentEmployees
    Inherits Employees
    Private SalaryGrade As String
    Private CoursesAttended As String
    Public Sub SetSalaryGrade(ByVal ssg As String)

        SalaryGrade = ssg
    End Sub
    Public Sub SetCoursesAttended(ByVal sca As String)
        CoursesAttended = sca
    End Sub
End Class
