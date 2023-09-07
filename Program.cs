using System;

class Program {
    static void Main(string[] args) {
        
        // Chance the appearance
        Console.Title = "Test C#";
        Console.ForegroundColor = ConsoleColor.Green;

        // Write and Read input from user
        Console.WriteLine("What is your name");

        string? userName = Console.ReadLine();

        Console.WriteLine("Hello " + userName + ", nice to meet you!");

        Ask(userName);
    }

    public static void Ask(string userName) {
        Console.WriteLine("Want to do a calculation yes/no");

        string? yesOrNo = Console.ReadLine();
        
        if (yesOrNo == "yes") {
            Calculator(userName);
            return;
        }
    }

    public static void Calculator(string userName) {
        Console.WriteLine("What do u want todo (+ - / *)");

        string? Math = Console.ReadLine();

        Console.WriteLine("Input your first number");
        int? num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input your second number");
        int? num2 = Convert.ToInt32(Console.ReadLine());

        int result = 0; // Initialize the result as an integer

        if (Math == "+") {
            if (num1.HasValue && num2.HasValue) {
                result = num1.Value + num2.Value;
            }
        } else if (Math == "-") {
            if (num1.HasValue && num2.HasValue) {
                result = num1.Value - num2.Value;
            }
        } else if (Math == "*") {
            if (num1.HasValue && num2.HasValue) {
                result = num1.Value * num2.Value;
            }
        } else if (Math == "/") {
            if (num1.HasValue && num2.HasValue && num2.Value != 0) {
                double quotient = (double)num1.Value / num2.Value; // Perform division with double precision
                Console.WriteLine(userName + " " + num1 + " " + Math + " " + num2 + " = " + quotient);
                Console.ReadLine();
                return;
            } else {
                Console.WriteLine("Invalid input for division");
            }
        } else {
            Console.WriteLine("Invalid math operation");
        }
        
        Console.WriteLine(userName + " " + num1 + " " + Math + " " + num2 + " = " + result);
        Ask(userName);
    }

}