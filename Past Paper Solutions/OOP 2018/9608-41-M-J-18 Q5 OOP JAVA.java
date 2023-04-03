import java.util.ArrayList;

// Main program
public class Main {
    public static void main(String[] args) {
        Scenery giftBox = new Scenery(150, 150, 50, 75, "box.png", true, 50);
        System.out.println(giftBox.giveDamagePoints());
    }
}

// Game class
class GameElement {
    private int positionX;
    private int positionY;
    private int width;
    private int height;
    private String imageFilename;

    // constructor
    public GameElement(int positionX, int positionY, int width, int height, String imageFilename) {
        this.positionX = positionX;
        this.positionY = positionY;
        this.width = width;
        this.height = height;
        this.imageFilename = imageFilename;
    }

    // methods
    public String getDetails() {
        return "PositionX: " + positionX + ", PositionY: " + positionY +
                ", Width: " + width + ", Height: " + height + ", ImageFilename: " + imageFilename;
    }
}

// AnimatedElement class
class AnimatedElement {
    private ArrayList<GameElement> animationFrames;
    private String direction;
    private int strength;
    private int health;

    // constructor
    public AnimatedElement() {
        this.animationFrames = new ArrayList<>();
        this.direction = "";
        this.strength = 0;
        this.health = 0;
    }

    // methods
    public void moveLeft() {
        this.direction = "Left";
    }

    public void moveRight() {
        this.direction = "Right";
    }

    public void jump() {
        System.out.println("Jumping...");
    }

    public String getDetails() {
        return "AnimationFrames: " + animationFrames + ", Direction: " + direction +
                ", Strength: " + strength + ", Health: " + health;
    }
}

// Player class
class Player extends AnimatedElement {
    private String name;
    private int score;

    // constructor
    public Player(String name, int score) {
        super();
        this.name = name;
        this.score = score;
    }

    // methods
    @Override
    public String getDetails() {
        return "Name: " + name + ", Score: " + score + ", " + super.getDetails();
    }
}

// Scenery class
class Scenery extends GameElement {
    private boolean causeDamage;
    private int damagePoints;

    // constructor
    public Scenery(int positionX, int positionY, int width, int height, String imageFilename, boolean causeDamage, int damagePoints) {
        super(positionX, positionY, width, height, imageFilename);
        this.causeDamage = causeDamage;
        this.damagePoints = damagePoints;
    }

    // methods
    public int giveDamagePoints() {
        if (causeDamage) {
            return damagePoints;
        } else {
            return 0;
        }
    }

    public String getScenery() {
        return "CauseDamage: " + causeDamage + ", DamagePoints: " + damagePoints + ", " + super.getDetails();
    }
}