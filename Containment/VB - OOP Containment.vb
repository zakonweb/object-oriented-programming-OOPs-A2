Imports System.Collections.Generic

Module Program
    Sub Main()
        ' Main code
        ' Prompt user to enter the details of the question paper
        Console.WriteLine("Enter details of question paper")
        Console.WriteLine("-----------------------------")
        Console.Write("Enter number of questions: ")
        Dim no_of_questions As Integer = Integer.Parse(Console.ReadLine())

        ' Create a new QuestionPaper object with the specified number of questions
        Dim this_question_paper As New QuestionPaper(no_of_questions)

        ' Display that the question paper has been created and its total marks
        Console.WriteLine("Question paper created")
        Console.WriteLine("----------------------")
        Console.WriteLine("Total marks of question paper: " & this_question_paper.GetTotalMarks())

        ' Loop to get question details by entering the question number or exit by entering 0
        While True
            Console.WriteLine("Enter question number to get question")
            Console.WriteLine("-------------------------------------")
            Console.Write("Enter question number. Enter 0 to exit: ")
            Dim question_number As Integer = Integer.Parse(Console.ReadLine())

            ' Exit the loop if the user enters 0
            If question_number = 0 Then
                Exit While
            Else
                ' Get the question details for the specified question number
                Dim this_question As Question = this_question_paper.GetQuestion(question_number)
                Console.WriteLine("Question: " & this_question.GetQuestion())
                Console.WriteLine("Answer: " & this_question.GetAnswer())
                Console.WriteLine("Marks: " & this_question.GetMarks())
            End If
        End While
    End Sub

    ' Question class representing individual questions
    Public Class Question
        ' Private attributes for question, answer, and marks
        Private _question As String
        Private _answer As String
        Private _marks As Integer

        ' Constructor to initialize the question, answer, and marks attributes
        Public Sub New(ByVal ques As String, ByVal ans As String, ByVal mar As Integer)
            _question = ques
            _answer = ans
            _marks = mar
        End Sub

        ' Public methods to get and set the private attributes
        Public Function GetQuestion() As String
            Return _question
        End Function

        Public Function GetAnswer() As String
            Return _answer
        End Function

        Public Function GetMarks() As Integer
            Return _marks
        End Function

        Public Sub SetQuestion(ByVal value As String)
            _question = value
        End Sub

        Public Sub SetAnswer(ByVal value As String)
            _answer = value
        End Sub

        Public Sub SetMarks(ByVal value As Integer)
            _marks = value
        End Sub
    End Class

    ' QuestionPaper class representing a collection of Question objects
    Public Class QuestionPaper
        ' Private attributes for number of questions, list of Question objects, and total marks
        Private _no_of_questions As Integer
        Private _questions As List(Of Question)
        Private _total_marks As Integer

        ' Constructor to initialize the attributes and create Question objects
        Public Sub New(ByVal no_of_questions As Integer)
            _no_of_questions = no_of_questions
            _questions = New List(Of Question)()
            _total_marks = 0

            ' Create the specified number of Question objects
            For i As Integer = 1 To no_of_questions
                CreateQuestion()
            Next
        End Sub

        ' Method to get a specific Question object
        Public Function GetQuestion(ByVal question_number As Integer) As Question
            Return _questions(question_number - 1)
        End Function

        ' Method to get the total marks of the question paper
        Public Function GetTotalMarks() As Integer
            Return _total_marks
        End Function

        ' Method to create a Question object and add it to the QuestionPaper
        Private Sub CreateQuestion()
            ' Prompt user to enter the question, answer, and marks
            Console.Write("Enter question: ")
            Dim quest As String = Console.ReadLine()
            Console.Write("Enter answer: ")
            Dim answer As String = Console.ReadLine()
            Console.Write("Enter marks: ")
            Dim marks As Integer = Integer.Parse(Console.ReadLine())

            ' Create a new Question object with the input data
            Dim this_question As New Question(quest, answer, marks)

            ' Add the created Question object to the list of questions
            _questions.Add(this_question)

            ' Update the total marks of the question paper
            _total_marks += marks
        End Sub
    End Class
End Module
