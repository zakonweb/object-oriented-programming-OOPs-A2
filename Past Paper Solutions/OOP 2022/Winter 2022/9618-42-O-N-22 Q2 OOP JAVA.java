import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
        // main program code
        ArrayList<Character> theCharacters = new ArrayList<>();

        String currentWorkingDirectory = System.getProperty("user.dir");
        String charactersFilePath = currentWorkingDirectory + File.separator + "Characters.txt";

        try (BufferedReader reader = new BufferedReader(new FileReader(charactersFilePath))) {
            String line;
            int lineNo = 0;
            while ((line = reader.readLine()) != null && lineNo < 10) {
                line = line.trim();
                if (!line.isEmpty()) {
                    String name = line;
                    int xCoordinate = Integer.parseInt(reader.readLine().trim());
                    int yCoordinate = Integer.parseInt(reader.readLine().trim());
                    theCharacters.add(new Character(name, xCoordinate, yCoordinate));
                    lineNo++;
                }
            }
        }
        int indexFound = -1;
        try (Scanner scanner = new Scanner(System.in)) {
            while (indexFound == -1) {
                System.out.print("Enter a character name: ");
                String name = scanner.nextLine();
                for (int i = 0; i < theCharacters.size(); i++) {
                    if (theCharacters.get(i).getName().equalsIgnoreCase(name)) {
                        indexFound = i;
                        break;
                    }
                }
            }

            while (true) {
                System.out.print("Enter a direction (A, W, S or D): ");
                String direction = scanner.nextLine();
                if (direction.equalsIgnoreCase("a")) {
                    theCharacters.get(indexFound).changePosition(-1, 0);
                    break;
                } else if (direction.equalsIgnoreCase("w")) {
                    theCharacters.get(indexFound).changePosition(0, 1);
                    break;
                } else if (direction.equalsIgnoreCase("s")) {
                    theCharacters.get(indexFound).changePosition(0, -1);
                    break;
                } else if (direction.equalsIgnoreCase("d")) {
                    theCharacters.get(indexFound).changePosition(1, 0);
                    break;
                } else {
                    System.out.println("Invalid direction");
                }
            }
        }

        // main program code for outputting the character's name and new coordinates
        System.out.printf("%s has changed coordinates to X = %d and Y = %d%n", theCharacters.get(indexFound).getName(),
                theCharacters.get(indexFound).getX(), theCharacters.get(indexFound).getY());
    }
}

// The Character class stores data about the characters.
class Character {
    // Declare attributes
    private String characterName; // stores the name of the character
    private int xCoordinate; // stores the x coordinate
    private int yCoordinate; // stores the y coordinate

    // Constructor
    public Character(String name, int xCoordinate, int yCoordinate) {
        this.characterName = name;
        this.xCoordinate = xCoordinate;
        this.yCoordinate = yCoordinate;
    }

    // Getter methods
    public String getName() {
        return characterName;
    }

    public int getX() {
        return xCoordinate;
    }

    public int getY() {
        return yCoordinate;
    }

    // Setter methods
    public void changePosition(int xChange, int yChange) {
        xCoordinate += xChange;
        yCoordinate += yChange;
    }
}
