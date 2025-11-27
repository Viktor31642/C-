int start, end;
while (true)
{

    while (true)
    {
        Console.WriteLine("Enter the start number:");
        bool isValidStart = int.TryParse(Console.ReadLine(), out start);
        if (isValidStart)
            break;

        Console.WriteLine("Invalid number. Please try again.");
    }

    while (true)
    {
        Console.WriteLine("Enter the end number:");
        bool isValidEnd = int.TryParse(Console.ReadLine(), out end);
        if (isValidEnd && end >= start)
            break;

        Console.WriteLine("Invalid number or end number is less than start number. Please try again.");
    }

    int sum = 0;

    for (int i = start; i <= end; i++)
    {
        sum += i;
    }

    Console.WriteLine($"Sum from {start} to {end} is: {sum}");

    Console.WriteLine("Do you want to check another range? (yes/no):");
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

    Console.Clear();
}

