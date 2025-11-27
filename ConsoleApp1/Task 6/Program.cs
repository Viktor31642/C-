int[] myNumbers = { 5, 1, 8, 9 };

int smallest = myNumbers.Min();
foreach (int num in myNumbers)
{
    Console.WriteLine("Number: " + num);
}

Console.WriteLine("Smallest number: " + smallest);
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();