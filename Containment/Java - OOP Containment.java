import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter details of question paper");
        System.out.println("-----------------------------");
        System.out.print("Enter number of questions: ");
        int noOfQuestions = scanner.nextInt();
        scanner.nextLine();

        QuestionPaper thisQuestionPaper = new QuestionPaper(noOfQuestions, scanner);

        System.out.println("Question paper created");
        System.out.println("----------------------");
        System.out.println("Total marks of question paper: " + thisQuestionPaper.getTotalMarks());

        while (true) {
            System.out.println("Enter question number to get question");
            System.out.println("-------------------------------------");
            System.out.print("Enter question number. Enter 0 to exit: ");
            int questionNumber = scanner.nextInt();
            scanner.nextLine();

            if (questionNumber == 0) {
                break;
            } else {
                Question thisQuestion = thisQuestionPaper.getQuestion(questionNumber);
                System.out.println("Question: " + thisQuestion.getQuestion());
                System.out.println("Answer: " + thisQuestion.getAnswer());
                System.out.println("Marks: " + thisQuestion.getMarks());
            }
        }

        scanner.close();
    }
}

class Question {
    private String question;
    private String answer;
    private int marks;

    public Question(String ques, String ans, int mar) {
        question = ques;
        answer = ans;
        marks = mar;
    }

    public String getQuestion() {
        return question;
    }

    public String getAnswer() {
        return answer;
    }

    public int getMarks() {
        return marks;
    }
}

class QuestionPaper {
    private ArrayList<Question> questions;
    private int totalMarks;
    private Scanner scanner;

    public QuestionPaper(int noOfQuestions, Scanner scanner) {
        this.scanner = scanner;
        questions = new ArrayList<>();
        totalMarks = 0;

        for (int i = 0; i < noOfQuestions; i++) {
            createQuestion();
        }
    }

    public Question getQuestion(int questionNumber) {
        return questions.get(questionNumber - 1);
    }

    public int getTotalMarks() {
        return totalMarks;
    }

    private void createQuestion() {
        System.out.print("Enter question: ");
        String quest = scanner.nextLine();
        System.out.print("Enter answer: ");
        String answer = scanner.nextLine();
        System.out.print("Enter marks: ");
        int marks = scanner.nextInt();
        scanner.nextLine();

        Question thisQuestion = new Question(quest, answer, marks);

        questions.add(thisQuestion);

        totalMarks += marks;
    }
}
