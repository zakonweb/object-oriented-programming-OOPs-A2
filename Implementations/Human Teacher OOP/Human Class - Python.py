class human:
    def __init__(self,n,ad,ag):
        self.__name = n #dunder
        self.__address = ad
        self.__age = ag

    #setters
    def setName(self, n):
        self.__name = n

    def setAddress(sel, ad):
        self.__address = ad

    def setAge(self, ag):
        self.__age = ag

    #getters
    def tellName(self):
        return self.__name

    def tellAdd(self):
        return self.__address

    def tellAge(self):
        return self.__age

    def tellAll(self):
        all = "Name: " + self.__name + "   Address: " + self.__address + "   Age: " + str(self.__age)
        return all

Ahmed = human("Ahmed Raza Mir", "Karachi, Pakistan", 55)
Ali = human("Ali Raza", "Karachi, Pakistan", 35)
Mohsin = human("Mohsin Khan", "Karachi, Pakistan", 56)

print(Ahmed.tellAll())
print(Ali.tellAll())
print(Mohsin.tellAll())