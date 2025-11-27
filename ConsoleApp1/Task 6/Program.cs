int[] myNumbers = { 5, 1, 8, 9 };

int smallest = myNumbers.Min();
Console.WriteLine("Array: ");
foreach (int num in myNumbers)
{
    
    Console.Write(num + " ");
}
Console.WriteLine("\nSmallest number: " + smallest);
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();