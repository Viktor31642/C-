while (true)
{

    double num1;
    while (true)
    {
        Console.Write("Enter first number: ");
        bool isValid = double.TryParse(Console.ReadLine(), out num1);

        if (isValid)
            break;

        Console.WriteLine("Use only double. Try again.");
    }

    double num2;
    while (true)
    {
        Console.Write("Enter second number: ");
        bool isValid = double.TryParse(Console.ReadLine(), out num2);

        if (isValid)
            break;

        Console.WriteLine("Use only double. Try again.");
    }

    Console.Write("Enter operation (+, -, *, /): ");
    string op = Console.ReadLine();



    double result;

    switch (op)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Result: {result}");
            break;

        case "-":
            result = num1 - num2;
            Console.WriteLine($"Result: {result}");
            break;

        case "*":
            result = num1 * num2;
            Console.WriteLine($"Result: {result}");
            break;

        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: division by zero.");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            break;

        default:
            Console.WriteLine("Unknown operation.");
            break;
    }

    Console.WriteLine("Do you want to continue? (yes/no):");
    string response = Console.ReadLine().Trim().ToLower();

    if (response == "no")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    if (response != "yes")
    {
        Console.WriteLine("Invalid response. Returning to menu...");
    }

}

