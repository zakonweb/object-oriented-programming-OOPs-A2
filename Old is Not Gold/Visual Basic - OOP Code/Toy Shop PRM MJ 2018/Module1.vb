Module Module1
    Dim myComputerGame(5) As ComputerGame
    Dim myVehical(5) As VehicalClass

    Dim CompuetrGameCounter As Integer = 0
    Dim VehicalCounter As Integer = 0

    Sub Main()
        Dim menuOption As Integer

        Do
            Call showOptions()
            Console.Write("Enter your option... ") : menuOption = Console.ReadLine
            Select Case menuOption
                Case 1 : Call addComputerGame()
                Case 2 : Call addVehical()
                Case 3 : Call DiscountComputerGame()
                Case 4 : Call DiscountedVehicle()
                Case 5 : Call displayComputerGame()
                Case 6 : Call displayVehical()
                Case 7 'exit program
                Case Else
                    Console.WriteLine("Invalid option entered...")
                    Console.ReadKey()
            End Select
        Loop Until menuOption = 7
    End Sub

    Sub displayVehical()
        Dim a As Integer = 0
        Try
            For a = 0 To VehicalCounter
                Console.WriteLine("Name =" & myVehical(a).getToyName)
                Console.WriteLine("ID = " & myVehical(a).getToyID)
                Console.WriteLine("Price = " & myVehical(a).getToyPrice)
                Console.WriteLine("Minimum age = " & myVehical(a).getMinAge)
                Console.WriteLine("Type = " & myVehical(a).getToyType)
                Console.WriteLine("Height = " & myVehical(a).getHeight)
                Console.WriteLine("Length = " & myVehical(a).getLength)
            Next
        Catch
        End Try
        Console.ReadKey()
    End Sub

    Sub displayComputerGame()
        Dim a As Integer = 0
        Try
            For a = 0 To CompuetrGameCounter
                Console.WriteLine("Name =" & myComputerGame(a).getToyName)
                Console.WriteLine("ID = " & myComputerGame(a).getToyID)
                Console.WriteLine("Price = " & myComputerGame(a).getToyPrice)
                Console.WriteLine("Minimum age = " & myComputerGame(a).getMinAge)
                Console.WriteLine("Category = " & myComputerGame(a).getCategory)
                Console.WriteLine("Console = " & myComputerGame(a).getConsole)
            Next
        Catch
        End Try
        Console.ReadKey()
    End Sub

    Sub addComputerGame()
        Dim N, ID, Cat, Con As String
        Dim P As Decimal
        Dim Age As Integer

        If CompuetrGameCounter > 5 Then
            If CompuetrGameCounter > 5 Then CompuetrGameCounter = 5
            Console.WriteLine("Max 6 games can be added. Limit exhausted...")
            Console.ReadKey()
            Exit Sub
        End If

        Do
            Console.Write("*Enter Name...")
            N = Console.ReadLine
        Loop Until N <> ""

        Dim isValid As Boolean
        Do
            isValid = True
            Console.Write("*Enter ID (AA99)...")
            ID = Console.ReadLine

            If Len(ID) <> 4 Then isValid = False
            If Mid(ID, 1) < "A" Or Mid(ID, 1) > "Z" Then isValid = False
            If Mid(ID, 2) < "A" Or Mid(ID, 2) > "Z" Then isValid = False
            If Mid(ID, 3) < "0" Or Mid(ID, 3) > "9" Then isValid = False
            If Mid(ID, 4) < "0" Or Mid(ID, 4) > "9" Then isValid = False
        Loop Until isValid = True

        Console.Write("*Enter Price...")
        P = Console.ReadLine

        Do
            Console.Write("*Enter Age...")
            Age = Console.ReadLine
        Loop Until Age >= 1 And Age <= 18

        Do
            Console.Write("*Enter game category...")
            Cat = Console.ReadLine
        Loop Until Cat <> ""

        Do
            Console.Write("*Enter game console...")
            Con = Console.ReadLine
        Loop Until Con <> ""

        myComputerGame(CompuetrGameCounter) = New ComputerGame(N, ID, P, Age, Cat, Con)
        CompuetrGameCounter += 1
    End Sub

    Sub addVehical()
        Dim N, ID, T As String
        Dim P As Decimal
        Dim Age, H, L As Integer
        Dim W As Single

        If VehicalCounter > 5 Then
            VehicalCounter = 5
            Console.WriteLine("Max 6 vehicles can be added. Limit exhausted...")
            Console.ReadKey()
            Exit Sub
        End If

        Do
            Console.Write("*Enter Name...")
            N = Console.ReadLine
        Loop Until N <> ""

        Dim isValid As Boolean
        Do
            isValid = True
            Console.Write("*Enter ID (AA99)...")
            ID = Console.ReadLine

            If Len(ID) <> 4 Then isValid = False
            If Mid(ID, 1) < "A" Or Mid(ID, 1) > "Z" Then isValid = False
            If Mid(ID, 2) < "A" Or Mid(ID, 2) > "Z" Then isValid = False
            If Mid(ID, 3) < "0" Or Mid(ID, 3) > "9" Then isValid = False
            If Mid(ID, 4) < "0" Or Mid(ID, 4) > "9" Then isValid = False
        Loop Until isValid = True

        Console.Write("*Enter Price...")
        P = Console.ReadLine

        Do
            Console.Write("*Enter Age...")
            Age = Console.ReadLine
        Loop Until Age >= 1 And Age <= 18

        Do
            Console.Write("*Enter Vehical Type..")
            T = Console.ReadLine
        Loop Until T <> ""

        Do
            Console.Write("*Enter Vehical Height(in ft)..")
            H = Console.ReadLine
        Loop Until H > 0 And H <= 2

        Do
            Console.Write("*Enter Vehical Length(in m)..")
            L = Console.ReadLine
        Loop Until L > 0 And L <= 5

        Do
            Console.Write("*Enter Vehical Weight..")
            W = Console.ReadLine
        Loop Until W > 0 And W <= 10

        myVehical(VehicalCounter) = New VehicalClass(N, ID, P, Age, T, H, L, W)
        VehicalCounter += 1
    End Sub

    Sub DiscountComputerGame()
        Dim dis, p As Single
        Dim a As Integer

        Console.Write("Enter discount rate... ") : dis = Console.ReadLine
        Try
            For a = 0 To CompuetrGameCounter
                p = myComputerGame(a).getToyPrice()
                If p > 0 Then
                    p = p - ((p / 100) * dis)
                    If p < 0 Then p = 0
                End If
                myComputerGame(a).setToyPrice(p)

            Next
        Catch
        End Try

    End Sub

    Sub DiscountedVehicle()
        Dim dis, p As Single
        Dim a As Integer

        Console.Write("Enter discount rate... ") : dis = Console.ReadLine
        Try
            For a = 0 To VehicalCounter
                p = myVehical(a).getToyPrice()
                If p > 0 Then
                    p = p - ((p / 100) * dis)
                    If p < 0 Then p = 0
                End If
                myVehical(a).setToyPrice(p)
            Next
        Catch
        End Try

    End Sub


    Sub showOptions()
        Console.Clear()
        Console.WriteLine("1. Add data to Computer game.")
        Console.WriteLine("2. Add data to Vehical toy.")
        Console.WriteLine("3. State discount rate for Computer game.")
        Console.WriteLine("4. State discount rate for Vehical toy.")
        Console.WriteLine("5. Display data of Computer game.")
        Console.WriteLine("6. Display data of Vehical toy.")
        Console.WriteLine("7. Quit the program")
    End Sub
End Module
