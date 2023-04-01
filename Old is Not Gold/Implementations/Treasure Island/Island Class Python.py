import random

class IslandClass:

    def __init__(self):
        Sand = "."
        self.__Grid = [[Sand for col in range(30)] for row in range(10)]

    def HideTreasure(self):
        Treasure = "T"

        row = random.randint(0,9) # both 0 and 9 included
        col = random.randint(0,29) # both 0 and 29 are included
        while self.__Grid[row][col] == Treasure:
            row = random.randint(0,9)
            col = random.randint(0,29)

        self.__Grid[row][col] = Treasure

    def digHole(self, row, col):
        Sand = "."
        Treasure = "T"
        FoundTreasure = "X"
        Hole = "O"

        if self.__Grid[row][col] == Treasure:
            self.__Grid[row][col] = FoundTreasure
        else:
            self.__Grid[row][col] = Hole

    def GetSquare(self, row, col):
        return self.__Grid[row][col]

# main program
Island  = IslandClass()

def DisplayGrid():
    for row in range(10):
        for col in range(30):
            x = Island.GetSquare(row,col)
            print(x, end = " ")
        print("")

def StartDig():
    X = int(input("Enter X location: "))
    while X < 0 or X > 29:
        X = int(input("Enter X location: "))

    Y = int(input("Enter Y location: "))
    while Y < 0 or Y > 29:
        Y = int(input("Enter Y location: "))

    Island.digHole(Y, X)

DisplayGrid()
for i in range(3):
    Island.HideTreasure()
#DisplayGrid()
StartDig()
DisplayGrid()