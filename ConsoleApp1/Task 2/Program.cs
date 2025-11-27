while (true)
{
    int age;

    while (true)
    {
        Console.WriteLine("Enter your age:");
        bool isValid = int.TryParse(Console.ReadLine(), out age);

        if (isValid)
            break;

        Console.WriteLine("Invalid number. Try again.");
    }

    if (age < 0)
    {
        Console.WriteLine("Age cannot be negative.");
    }
    else if (age >= 0 && age <= 10)
    {
        Console.WriteLine("You are a kid");
    }
    else if (age >= 11 && age <= 17)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age >= 18)
    {
        Console.WriteLine("You are an adult");
    }

    Console.WriteLine("Do you want to check another age? (yes/no):");
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