"""
THE PYTHON CODE.
The Character class stores data about the characters. 
Each character has a name and the x coordinate and y coordinate of their current position.
Character class attributes
CharacterName : STRING, stores the name of the character
XCoordinate : INTEGER, stores the x coordinate
YCoordinate : INTEGER, stores the y coordinate
Character class methods
Constructor(), initialises Name, XCoordinate and YCoordinate from the values passed as parameters
GetName(), returns the name of the character
GetX(), returns the x coordinate of the character
GetY(), returns the y coordinate of the character
ChangePosition(), takes XChange as an integer parameter and adds it to the x coordinate, takes YChange as an integer parameter and adds it to the
y coordinate.
All attributes must be private and all methods must be public. If you are writing in Python, include attribute declarations using
comments.
"""
class Character:
    # Declare attributes
    # __CharacterName : STRING
    # __XCoordinate : INTEGER
    # __YCoordinate : INTEGER

    # Constructor
    def __init__(self, Name, XCoordinate, YCoordinate):
        self.__CharacterName = Name
        self.__XCoordinate = XCoordinate
        self.__YCoordinate = YCoordinate
    
    # Getter methods
    def GetName(self):
        return self.__CharacterName
    
    def GetX(self):
        return self.__XCoordinate
    
    def GetY(self):
        return self.__YCoordinate
    
    # Setter methods
    def ChangePosition(self, XChange, YChange):
        self.__XCoordinate += XChange
        self.__YCoordinate += YChange
    
"""
The main program has a 1D array of characters. Each character is stored as an object of type
Character.
The game has a maximum of 10 characters. The character names, x coordinates and y coordinates 
are stored in the file "Characters.txt" in the order:
• name
• x coordinate
• y coordinate
For example, the first character in the file is named Amal, with the x coordinate 0 and the y
coordinate 2.
Write the python code for the main programto:
• declare the array theCharacters[]
• read in all 10 characters from "Characters.txt" text file
• store each character as an object in the array theCharacters[].
"""
# main program code
theCharacters = []
lineNo = 0
with open("c:/Users/ZAK/mu_code/Characters.txt", "r") as file:
    for line in file:
        line = line.strip()
        if line != "":
            if lineNo == 10:
                break
            else:
                theCharacters.append(Character(line, int(file.readline()), int(file.readline())))
                lineNo += 1
file.close()

"""
The main program needs to input a character name from the user, search for the character
in the array theCharacters[] and store the index of its position in indexFound variable. 
It repeats the loop until the user enters a name that exists in the array.
"""
# main program code for searching for a character
indexFound = -1
while indexFound == -1:
    name = input("Enter a character name: ")
    for i in range(len(theCharacters)):
        if theCharacters[i].GetName().lower() == name.lower():
            indexFound = i
            break
"""
The user will enter one of the following letter to identify the direction of the searched character
above at the indexFound and make the character move in that direction.
• If entered ‘A’ is input, the character moves left (x coordinate minus 1).
• If ‘W’ is input, the character moves up (y coordinate plus 1).
• If ‘S’ is input, the character moves down (y coordinate minus 1).
• If ‘D’ is input, the character moves right (x coordinate plus 1).
write program code to:
• take a letter as input until it is a valid move (A, W, S or D)
• change the position of the character using the appropriate action.
"""
# main program code for moving a character
while True:
    direction = input("Enter a direction (A, W, S or D): ")
    if direction.lower() == "a":
        theCharacters[indexFound].ChangePosition(-1, 0)
        break
    elif direction.lower() == "w":
        theCharacters[indexFound].ChangePosition(0, 1)
        break
    elif direction.lower() == "s":
        theCharacters[indexFound].ChangePosition(0, -1)
        break
    elif direction.lower() == "d":
        theCharacters[indexFound].ChangePosition(1, 0)
        break
    else:
        print("Invalid direction")

"""
When a change to a character’s position has been made, the program needs to output
the character’s name and the new x and y coordinates of the character, in the format:
"Qui has changed coordinates to X = 83 and Y = 0"
Add to main program by writing program code to perform these tasks.
"""
# main program code for outputting the character's name and new coordinates
print(f"{theCharacters[indexFound].GetName()} has changed coordinates to X = {theCharacters[indexFound].GetX()} and Y = {theCharacters[indexFound].GetY()}")

# End of main program code