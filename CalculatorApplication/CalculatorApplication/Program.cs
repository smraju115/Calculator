using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("------------------");

        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            if (!IsValidChoice(choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                continue;
            }

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = PerformOperation(choice, num1, num2);

            Console.WriteLine($"Result: {result}\n");
        }
    }

    static bool IsValidChoice(string choice)
    {
        return choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5";
    }

    static double PerformOperation(string choice, double num1, double num2)
    {
        switch (choice)
        {
            case "1":
                return num1 + num2;
            case "2":
                return num1 - num2;
            case "3":
                return num1 * num2;
            case "4":
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                    return double.NaN;
                }
            default:
                return double.NaN; // This should not happen if IsValidChoice is checked.
        }
    }
}
