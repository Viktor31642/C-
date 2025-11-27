Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter operation (+, -, *, /): ");
string op = Console.ReadLine();

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

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

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
