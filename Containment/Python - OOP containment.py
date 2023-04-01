"""
OOP code for containment of question class in question_paper class.
every class has all attributes private and all methods public.
question class has question, answer, marks attributes and get_question, get_answer, get_marks methods
alongside set_question, set_answer, set_marks methods. a constructor is also defined.
question_paper class has no_of_questions parameter to create as many question class objects as needed. question_paper
class can return any question when asked for. it can also return the total marks of the question paper.
a create_question method is also defined to create a question object and add it to the question_paper
object from the question class constructor.
"""

class question:
    # declare attributes
    # __question = ""
    # __answer = ""
    # __marks = 0

    # constructor
    def __init__(self, ques, ans, mar):
        # initialize attributes
        self.__question = ques
        self.__answer = ans
        self.__marks = mar

    def get_question(self):
        return self.__question

    def get_answer(self):
        return self.__answer

    def get_marks(self):
        return self.__marks

    def set_question(self, value):
        self.__question = value

    def set_answer(self, value):
        self.__answer = value

    def set_marks(self, value):
        self.__marks = value


class question_paper:
    # declare attributes
    # __no_of_questions = 0
    # __questions = []

    def __init__(self, no_of_questions):
        self.__no_of_questions = no_of_questions
        self.__questions = []
        self.__total_marks = 0
        for i in range(no_of_questions):
            self.create_question()

    def get_question(self, question_number):
        return self.__questions[question_number - 1]

    def get_total_marks(self):
        return self.__total_marks

    def create_question(self):
        quest = input("Enter question: ")
        answer = input("Enter answer: ")
        marks = int(input("Enter marks: "))
        this_question = question(quest, answer, marks)  # this is the question object
        self.__questions.append(this_question)
        self.__total_marks += marks


# main code
print("Enter details of question paper")
print("-----------------------------")
no_of_questions = int(input("Enter number of questions: "))
this_question_paper = question_paper(no_of_questions)
print("Question paper created")
print("----------------------")
print("Total marks of question paper: ", this_question_paper.get_total_marks())

while True:
    print("Enter question number to get question")
    print("-------------------------------------")
    question_number = int(input("Enter question number. Enter 0 to exit:  "))
    if question_number == 0:
        break
    else:
        this_question = this_question_paper.get_question(question_number)
        print("Question: ", this_question.get_question())
        print("Answer: ", this_question.get_answer())
        print("Marks: ", this_question.get_marks())