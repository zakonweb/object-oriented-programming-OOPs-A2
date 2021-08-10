class question:
    def __init__(self):
        self.__quest = ""
        self.__ans = ""
        self.__marks = 0

    #getters
    def getQuest(self):
        return self.__question

    def getAns(self):
        return self.__ans

    def getMarks(self):
        return self.__marks

    #setters
    def setQuest(self, q):
        self.__question = q

    def setAns(self, a):
        self.__ans = a

    def setMarks(self,m):
        self.__marks = m

class QuestPaper:
    def __init__(self):
        self.__quesNo = [question() for i in range(5)] # Aggregation/Containment
        self.__totalMarks = 0
        self.__questCount = 0

    def setQuest(self, q, a, m):
        self.__questCount = self.__questCount +1
        if self.__questCount > 4:
            print("Question number exceeds 4. This question can't be added.")
        else:
            self.__quesNo[self.__questCount].setQuest(q)
            self.__quesNo[self.__questCount].setAns(a)
            self.__quesNo[self.__questCount].setMarks(m)
            self.__totalMarks = self.__totalMarks + m

    def getQ(self, QN):
        if QN < 1 or QN > 4:
            return "Not Found!"
        else:
            return self.__quesNo[QN].getQuest()

    def getTotalMarks(self):
        return self.__totalMarks

comScience = QuestPaper()
q = "What is a class?"
a = "It is a blue print code from which we create objects."
m = 2
comScience.setQuest(q,a,m)

q = "What is an object?"
a = "It is an instance of the class code in computers' main memory."
m = 4
comScience.setQuest(q,a,m)

q = "What is containment?"
a = "When a class object is used as an attribute in another class."
m = 3
comScience.setQuest(q,a,m)

q = "What is inheritance?"
a = "When a child class is inherited from a mother class."
m = 1
comScience.setQuest(q,a,m)

q = "How many types of variables in a class?"
a = "There are two types Class level (Global) and Instance Level (Local)."
m = 3
comScience.setQuest(q,a,m)

print(comScience.getTotalMarks())
print(comScience.getQ(3))
print(comScience.getQ(1))