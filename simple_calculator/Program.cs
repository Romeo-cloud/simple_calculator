// See https://aka.ms/new-console-template for more information


class calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Simple Calculator\n");
        bool continueCalculating = true;

        while (continueCalculating)
        {
            try
            {
                // Ask for the first number
                Console.WriteLine("Enter the first number");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Ask the user for the operation
                Console.WriteLine("Enter the operation (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                // Ask the user for the second number
                Console.WriteLine("Enter the second number");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Perform the calculation based on the operation
                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation, try again");
                        continue;
                }

                // Display the result
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            // Ask the user if they want to perform another calculation
            Console.WriteLine("Do you want to perform another calculation (y/n)?");
            char choice = Convert.ToChar(Console.ReadLine().ToLower());

            if (choice != 'y')
            {
                continueCalculating = false;
            }
            if (choice == 'y')
            {
                Console.Clear();
            }
        }
    }
}