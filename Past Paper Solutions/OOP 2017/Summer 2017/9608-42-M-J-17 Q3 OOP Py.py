"""
Writing code for a treasure island game to be played on the computer. The island is
a rectangular grid, 30 squares by 10 squares. Each square of the island is represented by an
element in a 2D array. The top left square of the island is represented by the array element [0, 0].
There are 30 squares across and 10 squares down.
The computer will:
• generate three random locations [row,column] where treasure will be buried
• prompt the player for the location of one square where the player chooses to dig
 
following constants will be used:
sand = '.', for only sand in this square
treasure = 'T', for treasure still hidden in sand
treasure_found = 'X', for a hole dug where treasure was found
treasure_not_found = 'O', for a hole dug where no treasure was found.

Here is an example display after the player has chosen to dig at location [9, 3]:
..............................
..............................
..............................
..............................
..............................
........T.....................
..............................
..............................
.........T....................
...X..........................
The game is to be implemented using object-oriented programming OOP.

Design the class IslandClass with following attributes:
Grid ARRAY[0 : 9, 0 : 29] OF CHAR
and methods:
Constructor(), instantiates an object of class IslandClass and initialises all squares to sand
HideTreasure(), generates a pair of random numbers used as the grid location of treasure and marks the location with 'T'
DigHole(Row, Column), takes as parameters a valid grid location and marks the square with 'X' or 'O' as appropriate
GetSquare(Row, Column) returns CHARACTER, takes as parameter a valid grid location and returns the grid value for that square from the IslandClass object

"""
import random as r

# define constants
sand = '.'
treasure = 'T'
treasure_found = 'X'
treasure_not_found = 'O'

class IslandClass:
    # attributes
    # Grid ARRAY[0 : 9, 0 : 29] OF CHAR

    #constructor
    def __init__(self):
        self.Grid = [[sand for x in range(30)] for y in range(10)]
    
    # methods
    def HideTreasure(self):
        row = r.randint(0,9)
        column = r.randint(0,29)
        self.Grid[row][column] = treasure

    def DigHole(self, row, column):
        if self.Grid[row][column] == treasure:
            self.Grid[row][column] = treasure_found
        else:
            self.Grid[row][column] = treasure_not_found
    
    def GetSquare(self, row, column):
        return self.Grid[row][column]

"""
The procedure DisplayGrid shows the current grid data. DisplayGrid makes use of the getter method GetSquare of the Island class.
An example output is:
..............................
..............................
..............................
..............................
..............................
........T.....................
..............................
..............................
.........T....................
...X..........................
"""
def DisplayGrid():
    for row in range(10):
        for column in range(30):
            print(Island.GetSquare(row, column), end='')
        print()

"""
The code for StartDig procedure will:
• prompts the player for a location to dig
• validates the user input, column should be 0-29 and row should be 0-9
• calls the DigHole method
"""
def StartDig():
    while True:
        row = int(input("Enter row number (0-9): "))
        column = int(input("Enter column number (0-29): "))
        if row in range(10) and column in range(30):
            Island.DigHole(row, column)
            break
        else:
            print("Invalid input, try again")

"""
main program code is as follows:
DECLARE Island : IslandClass.Constructor() // instantiate object
CALL DisplayGrid() // output island squares
FOR Treasure ← 1 TO 3 // hide 3 treasures
    CALL Island.HideTreasure()
ENDFOR
CALL StartDig() // user to input location of dig
CALL DisplayGrid() // output island squares
"""
# main program
Island = IslandClass() # instantiate object
DisplayGrid() # output island squares
for Treasure in range(3): # hide 3 treasures
    Island.HideTreasure()
StartDig() # user to input location of dig
DisplayGrid() # output island squares
