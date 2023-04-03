"""
9608/41/M/J/18 Q:5
code to write a Game class
Each game class has the attributes:
PositionX 
PositionY 
Width
Height
ImageFilename 
Each game class has a method, GetDetails() that returns a string containing all the class attributes.
all the attributes are private and methods are public
"""
class GameElement:
    # declare the attributes
    # __positionX = int
    # __positionY = int
    # __width = int
    # __height = int
    # __imageFilename = str

    # constructor
    def __init__(self, positionX, positionY, width, height, imageFilename):
        self.__positionX = positionX
        self.__positionY = positionY
        self.__width = width
        self.__height = height
        self.__imageFilename = imageFilename
    
    # methods
    def GetDetails(self):
        # return all the attributes as a string
        Ans = f"PositionX: {self.__positionX}, PositionY: {self.__positionY}, \
            Width: {self.__width}, Height: {self.__height}, ImageFilename: {self.__imageFilename}"
        return Ans
        #return "PositionX: " + str(self.__positionX) + ", PositionY: " + str(self.__positionY) + \
        #    ", Width: " + str(self.__width) + ", Height: " + str(self.__height) + ", ImageFilename: " + self.__imageFilename
    
"""
Code for animatedElement class. All animated elements have the attributes:
AnimationFrames An array of GameElement class as GameElement class is contained in animatedElement class
Direction A string giving the direction the object is travelling in. "Left"
Strength A value for the strength that indicates the power of the object. 2000
Health A value for the health that indicates the health of the object. 100
The animatedClass has moveLeft or moveRight, and jump methods.
all the attributes are private and methods are public
"""
class AnimatedElement():
    # declare the attributes
    # __animationFrames = []
    # __direction = str
    # __strength = int
    # __health = int

    # constructor
    def __init__(self):
        self.__animationFrames = []
        self.__direction = ""
        self.__strength = 0
        self.__health = 0
    
    # methods
    def moveLeft(self):
        # move the object to the left
        self.__direction = "Left"
    
    def moveRight(self):
        # move the object to the right
        self.__direction = "Right"
    
    def jump(self):
        # make the object jump
        print("Jumping...")
    
    def GetDetails(self):
        # return all the attributes as a string
        return "AnimationFrames: " + str(self.__animationFrames) + ", Direction: " + self.__direction + \
            ", Strength: " + str(self.__strength) + ", Health: " + str(self.__health)

"""
player class inherits from animatedElement class
"""
class Player(AnimatedElement):
    # declare the attributes
    # __name = str
    # __score = int

    # constructor
    def __init__(self, name, score):
        super().__init__()
        self.__name = name
        self.__score = score
    
    # methods
    def GetDetails(self):
        # return all the attributes as a string
        return "Name: " + self.__name + ", Score: " + str(self.__score) + ", " + super().GetDetails()
    
"""
scenery is a subclass of GameElement
scenery has following attributes:
CauseDamage: BOOLEAN
DamagePoints: INTEGER

and following methods
Constructor()
GiveDamagePoints() returns the damage points

If the attribute CauseDamage is TRUE, then the scenery element can cause damage.
The method GiveDamagePoints() checks whether the object can cause damage. If the
object can cause damage, the method returns the integer value of the DamagePoints
attribute.
"""
class Scenery(GameElement):
    # declare the attributes
    # __causeDamage = bool
    # __damagePoints = int

    # constructor
    def __init__(self, positionX, positionY, width, height, imageFilename, causeDamage, damagePoints):
        super().__init__(positionX, positionY, width, height, imageFilename)
        self.__causeDamage = causeDamage
        self.__damagePoints = damagePoints
    
    # methods
    def GiveDamagePoints(self):
        # return the damage points
        if self.__causeDamage is True:
            return self.__damagePoints
        else:
            return 0
    
    def GetScenery(self):
        # return all the at tributes as a string
        return "CauseDamage: " + str(self.__causeDamage) + ", DamagePoints: " + str(self.__damagePoints) + ", " + super().GetDetails()

"""
M A I N   P R O G R A M
In the main program A new scenery object, GiftBox, is to be created.
The attributes of GiftBox are as follows:
Attribute Value
PositionX = 150
PositionY = 150
Width = 50
Height = 75
ImageFilename = "box.png"
CauseDamage  = TRUE
DamagePoints  = 50
program code to create an instance of GiftBox.
"""
GiftBox = Scenery(150, 150, 50, 75, "box.png", True, 50)
print(GiftBox.GiveDamagePoints())   