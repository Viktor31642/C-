int[] myNumbers = { 5, 1, 8, 9 };

int smallest = myNumbers.Min();
Console.WriteLine("Array: ");
foreach (int num in myNumbers)
{
    
    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine("Smallest number: " + smallest);
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();