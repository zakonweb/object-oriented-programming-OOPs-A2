Public Class Question
    Private Qno As Integer
    Private QContent As String
    Private QMarks As Integer

    'constructor
    Public Sub New(ByVal qno As Integer, ByVal qcon As String, ByVal qma As Integer)
        Me.Qno = qno
        Me.QContent = qcon
        Me.QMarks = qma
    End Sub

    Public Sub setQno(ByVal qn As Integer)
        Me.Qno = qn
    End Sub

    Public Function getQno() As Integer
        Return Me.Qno
    End Function

    Public Sub setQContent(ByVal con As String)
        Me.QContent = con
    End Sub

    Public Function getQContent() As String
        Return Me.QContent
    End Function

    Public Sub setQm(ByVal Marks As Integer)
        Me.QMarks = Marks
    End Sub

    Public Function getQmarks() As Integer
        Return Me.QMarks
    End Function

End Class
