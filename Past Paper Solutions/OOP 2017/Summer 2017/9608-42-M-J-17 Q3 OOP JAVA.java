//import necessary libraries
import java.util.Scanner;
import java.util.Random;

//define constants
class TreasureIsland{
    private static final char sand = '.';
    private static final char treasure = 'T';
    private static final char treasure_found = 'X';
    private static final char treasure_not_found = 'O';
    
    //define IslandClass
    static class IslandClass{
        // attributes
        private char[][] Grid;

        //constructor
        public IslandClass(){
            Grid = new char[10][30];
            for(int i=0;i<10;i++){
                for(int j=0;j<30;j++){
                    Grid[i][j] = sand;
                }
            }
        }

        // methods
        public void HideTreasure(){
            Random r = new Random();
            int row = r.nextInt(10);
            int column = r.nextInt(30);
            Grid[row][column] = treasure;
        }

        public void DigHole(int row, int column){
            if (Grid[row][column] == treasure){
                Grid[row][column] = treasure_found;
            } else {
                Grid[row][column] = treasure_not_found;
            }
        }

        public char GetSquare(int row, int column){
            return Grid[row][column];
        }
    }

    //procedure DisplayGrid to show the current grid data
    public static void DisplayGrid(IslandClass Island){
        for(int row=0; row<10; row++){
            for(int column=0; column<30; column++){
                System.out.print(Island.GetSquare(row, column));
            }
            System.out.println();
        }
    }

    //code for StartDig procedure
    public static void StartDig(IslandClass Island, Scanner input){
        int row, column;
        while (true){
            System.out.print("Enter row number (0-9): ");
            row = input.nextInt();
            System.out.print("Enter column number (0-29): ");
            column = input.nextInt();
            if(row>=0 && row<=9 && column>=0 && column<=29){
                Island.DigHole(row, column);
                break;
            } else {
                System.out.println("Invalid input, try again");
            }
        }
    }

    //main program
    public static void main(String[] args){
        IslandClass Island = new IslandClass(); // instantiate object
        Scanner input = new Scanner(System.in); // initialize Scanner
        DisplayGrid(Island); // output island squares

        // hide 3 treasures
        for (int Treasure=0; Treasure<3; Treasure++){
            Island.HideTreasure();
        }

        StartDig(Island, input); // user to input location of dig
        DisplayGrid(Island); // output island squares

        input.close(); //close Scanner
    }
}
