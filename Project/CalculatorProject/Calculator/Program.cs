double num1, num2, result;
int choice;
bool continueCalculation;

do
{
    Console.WriteLine("Choose which calculation you want to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.Write("Enter your choice (1-4): ");
    choice = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    switch (choice)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine($"Addition Result: {result}");
            break;
        case 2:
            result = num1 - num2;
            Console.WriteLine($"Subtraction Result: {result}");
            break;
        case 3:
            result = num1 * num2;
            Console.WriteLine($"Multiplication Result: {result}");
            break;
        case 4:
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"Division Result: {result}");
            }
            else
            {
                Console.WriteLine("Error! Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid choice! Please choose a number between 1 and 4.");
            break;
    }

    Console.Write("Do you want to perform another calculation? (yes/no): ");
    string continueInput = Console.ReadLine().ToLower();
    continueCalculation = (continueInput == "yes");

} while (continueCalculation);
