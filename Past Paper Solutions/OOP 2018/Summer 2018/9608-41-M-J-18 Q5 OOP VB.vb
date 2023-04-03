Module mGameElement
    '9608/41/M/J/18 Q:5

    'M A I N P R O G R A M
    'In the main program A new scenery object, GiftBox, is to be created.
    'The attributes of GiftBox are as follows:
    'Attribute Value
    'PositionX = 150
    'PositionY = 150
    'Width = 50
    'Height = 75
    'ImageFilename = "box.png"
    'CauseDamage = TRUE
    'DamagePoints = 50
    'program code to create an instance of GiftBox.

    Sub Main()
        Dim GiftBox As New Scenery(150, 150, 50, 75, "box.png", True, 50)
        Console.WriteLine(GiftBox.GiveDamagePoints())
        Console.ReadKey()
    End Sub

    'code to write a Game class
    'Each game class has the attributes:
    'PositionX
    'PositionY
    'Width
    'Height
    'ImageFilename
    'Each game class has a method, GetDetails() that returns a string containing all the class attributes.
    'all the attributes are private and methods are public

    Class GameElement
        'declare the attributes
        Private __positionX As Integer
        Private __positionY As Integer
        Private __width As Integer
        Private __height As Integer
        Private __imageFilename As String

        'constructor
        Public Sub New(ByVal positionX As Integer, ByVal positionY As Integer, ByVal width As Integer, ByVal height As Integer, ByVal imageFilename As String)
            __positionX = positionX
            __positionY = positionY
            __width = width
            __height = height
            __imageFilename = imageFilename
        End Sub

        'methods
        Public Function GetDetails() As String
            'return all the attributes as a string
            Dim Ans As String = "PositionX: " & __positionX & ", PositionY: " & __positionY & ", Width: " & __width & ", Height: " & __height & ", ImageFilename: " & __imageFilename
            Return Ans
        End Function
    End Class

    'Code for AnimatedElement class. All animated elements have the attributes:
    'AnimationFrames An array of GameElement class as GameElement class is contained in animatedElement class
    'Direction A string giving the direction the object is travelling in. "Left"
    'Strength A value for the strength that indicates the power of the object. 2000
    'Health A value for the health that indicates the health of the object. 100
    'The animatedClass has moveLeft or moveRight, and jump methods.
    'all the attributes are private and methods are public

    Class AnimatedElement
        'declare the attributes
        Private __animationFrames() As GameElement
        Private __direction As String
        Private __strength As Integer
        Private __health As Integer

        'methods
        Public Sub moveLeft()
            'move the object to the left
            __direction = "Left"
        End Sub

        Public Sub moveRight()
            'move the object to the right
            __direction = "Right"
        End Sub

        Public Sub jump()
            'make the object jump
            Console.WriteLine("Jumping...")
        End Sub

        Public Function DisplayAnimation() As String
            Return "Animation played..."
        End Function
    End Class

    'player class inherits from animatedElement class
    Class Player
        Inherits AnimatedElement

        'declare the attributes
        Private __name As String
        Private __score As Integer

        'constructor
        Public Sub New(ByVal name As String, ByVal score As Integer)
            MyBase.New()
            __name = name
            __score = score
        End Sub

        'methods
        Public Function GetDetails() As String
            'return all the attributes as a string
            Dim Ans As String = "Name: " & __name & ", Score: " & __score
            Return Ans
        End Function
    End Class

    'scenery is a subclass of GameElement
    'scenery has following attributes:
    'CauseDamage: BOOLEAN
    'DamagePoints: INTEGER

    'and following methods
    'Constructor()
    'GiveDamagePoints() returns the damage points

    'If the attribute CauseDamage is TRUE, then the scenery element can cause damage.
    'The method GiveDamagePoints() checks whether the object can cause damage. If the
    'object can cause damage, the method returns the integer value of the DamagePoints
    'attribute.

    Class Scenery
        Inherits GameElement
        'declare the attributes
        Private __causeDamage As Boolean
        Private __damagePoints As Integer

        'constructor
        Public Sub New(ByVal positionX As Integer, ByVal positionY As Integer, ByVal width As Integer, ByVal height As Integer, ByVal imageFilename As String, ByVal causeDamage As Boolean, ByVal damagePoints As Integer)
            MyBase.New(positionX, positionY, width, height, imageFilename)
            __causeDamage = causeDamage
            __damagePoints = damagePoints
        End Sub

        'methods
        Public Function GiveDamagePoints() As Integer
            'return the damage points
            If __causeDamage = True Then
                Return __damagePoints
            Else
                Return 0
            End If
        End Function

        Public Function GetScenery() As String
            'return all the attributes as a string
            Dim Ans As String = "CauseDamage: " & __causeDamage & ", DamagePoints: " & __damagePoints & ", " & MyBase.GetDetails()
            Return Ans
        End Function
    End Class

End Module