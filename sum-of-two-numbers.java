import java.util.Scanner;

public class AddTwoNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Prompting user to enter the first number
        System.out.print("Enter the first number: ");
        double num1 = scanner.nextDouble();

        // Prompting user to enter the second number
        System.out.print("Enter the second number: ");
        double num2 = scanner.nextDouble();

        // Adding the two numbers
        double sum = num1 + num2;

        // Displaying the result
        System.out.println("The sum of " + num1 + " and " + num2 + " is: " + sum);

        // Closing scanner to prevent resource leak
        scanner.close();
    }
}
