class human:
    def __init__(self, n, ag, add):
        self.__hName = n
        self.__hAge = ag
        self.__hAdd = add

    def setName(self, n):
        self.__hName = n

    def getName(self):
        return self.__hName

    def setAge(self, n):
        self.__hAge = n

    def getAge(self):
        return self.__hAge

    def setAdd(self, n):
        self.__hAdd = n

    def getAdd(self):
        return self.__hAdd

    def tellAll(self):
        all = "Name: " + self.__hName + " Age: " + str(self.__hAge) + " Address: " + self.__hAdd
        return all

class teacher(human):
    def __init__(self, n, ag, add, sub, exp, qua):
        super().__init__(n, ag, add)
        self.__hSubject = sub
        self.__hExperience = exp
        self.__hQualification = qua

    def setSub(self, n):
        self.__hSubject = n

    def getSub(self):
        return self.__hSubject

    def setExp(self, n):
        self.__hExperience = n

    def getExp(self):
        return self.__hExperience

    def setQua(self, n):
        self.__hQualification = n

    def getQua(self):
        return self.__hQualification

    def tellAll(self):
        all = super().tellAll()
        all = all + "Subject: " + self.__hSubject + " Experience: " + str(self.__hExperience) + " Qualification: " + self.__hQualification
        return all


zafar = human("Zafar Ali Khan", 30, "Karachi")
ahmed = teacher("Ahmed Yaqoob", 19, "Sargodha", "Economics", 20, "Masters")


print(zafar.tellAll())
print(ahmed.tellAll())
print(ahmed.getAdd())