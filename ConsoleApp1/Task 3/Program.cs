while (true)
{
    int number;

    while (true)
    {
        Console.WriteLine("Enter a number between 1 and 10:");

        bool isValid = int.TryParse(Console.ReadLine(), out number);

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Not a number. Try again.");
            continue;
        }

        if (number < 1 || number > 10)
        {
            Console.WriteLine("Number out of range. Try again.");
            continue;
        }

        break;
    }
    int[] nums = Enumerable.Range(1, 10).ToArray();

    foreach (int i in nums)
    {
        Console.WriteLine($"{number} * {i} = {number * i}");
    }

    Console.WriteLine("Do you want to check another number? (yes/no):");
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
