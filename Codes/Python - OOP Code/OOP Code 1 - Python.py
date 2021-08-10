# human class
class human:
    # constructor
    def __init__(self,n,ag,ad): # constructor
        self.__name = n  # __ dunder; means private
        self.__age = ag
        self.__address = ad

    # getters
    def tellName(self): # getter
        return self.__name

    def tellAge(self):
        return self.__age

    def tellAdd(self):
        return self.__address

    def tellAll(self):
        all = self.__name + " " + self.__address + " " + str(self.__age)
        return all

    # setters
    def setAge(self,ag):
        self.__age = ag

    def setAdd(self,add): # setter
        self.__address = add

class teacher(human):
    def __init__(self,n,ad,ag,q,s,e): # constructor
        super().__init__(n,ad,ag) # polymorphism
        self.__qualification = q
        self.__subject = s
        self.__experience = e

    # setter
    def setQualification(self,q):
        self.__qualification = q

    def setExperience(self,e):
        self.__experience = e

    # getter
    def tellSubject(self):
        return self.__subject

    def tellQualification(self):
        return self.__qualification

    def tellExperience(self):
        return self.__experience

    def tellAll(self):
        all = super().tellAll()  #polymorphism
        all = all + " " + self.__subject + " " + self.__qualification + " " + str(self.__experience)
        return all

h1 = human("Raza",18,"Karachi")
print(h1.tellAll())

t1 = teacher("Umair",35,"Clifton","Masters","Mathematics",15)
print(t1.tellName())
print(t1.tellAll())