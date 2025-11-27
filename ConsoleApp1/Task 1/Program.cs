while (true)
{
    Console.WriteLine("Temperature Converter");

    double celsius;

    while (true)
    {
        Console.WriteLine("Enter the temperature in Celsius:");

        bool isValid = double.TryParse(Console.ReadLine(), out celsius);

        if (isValid)
            break;

        Console.WriteLine("Invalid number. Please try again.");
    }

    double fahrenheit = CelsiusToFahrenheit(celsius);

    Console.WriteLine($"The temperature in Fahrenheit: {fahrenheit}");

    Console.WriteLine("Do you want to convert another temperature? (yes/no):");

    string response = Console.ReadLine().Trim().ToLower();

    if (response == "no")
    {
        Console.WriteLine("Thank you for using the Temperature Converter. Goodbye!");
        break;
    }

    if (response != "yes")
    {
        Console.WriteLine("Invalid response. Returning to menu...");
    }

    Console.Clear();
}

static double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9.0 / 5.0) + 32.0;
}