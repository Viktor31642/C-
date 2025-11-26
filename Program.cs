
using System;

namespace program


{
    class Book
    {
        private string title;
        private string author;
        private int yearPublished;

        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Year Published: {yearPublished}");
        }
    }
    class Program
    {
        static void Main()
        {
            // TASK 1

            //while (true)
            //{
            //    Console.WriteLine("Temperature Converter");

            //    double celsius;

            //    while (true)
            //    {
            //        Console.WriteLine("Enter the temperature in Celsius:");
            //        string input = Console.ReadLine();

            //        bool isValid = double.TryParse(input, out celsius);

            //        if (isValid)
            //            break;

            //        Console.WriteLine("Invalid number. Please try again.");
            //    }

            //    double fahrenheit = (celsius * 9 / 5) + 32;

            //    Console.WriteLine($"The temperature in Fahrenheit: {fahrenheit}");


            //    Console.WriteLine("Do you want to convert another temperature? (yes/no):");

            //    string response = Console.ReadLine().Trim().ToLower();

            //    if (response == "no")
            //    {
            //        Console.WriteLine("Thank you for using the Temperature Converter. Goodbye!");
            //        break;
            //    }

            //    if (response != "yes")
            //    {
            //        Console.WriteLine("Invalid response. Returning to menu...");
            //    }

            //    Console.Clear();
            //}

            // TASK 2

            //while (true)
            //{
            //    int age;


            //    while (true)
            //    {
            //        Console.WriteLine("Enter your age:");
            //        string input = Console.ReadLine();
            //        bool isValid = int.TryParse(input, out age);

            //        if (isValid)
            //            break;

            //        Console.WriteLine("Invalid number. Try again.");
            //    }


            //    if (age < 0)
            //    {
            //        Console.WriteLine("Age cannot be negative.");
            //    }
            //    else if (age >= 0 && age <= 10)
            //    {
            //        Console.WriteLine("You are a kid");
            //    }
            //    else if (age >= 11 && age <= 17)
            //    {
            //        Console.WriteLine("You are a teenager");
            //    }
            //    else if (age >= 18)
            //    {
            //        Console.WriteLine("You are an adult");
            //    }


            //    Console.WriteLine("Do you want to check another age? (yes/no):");
            //    string response = Console.ReadLine().Trim().ToLower();

            //    if (response == "no")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }

            //    if (response != "yes")
            //    {
            //        Console.WriteLine("Invalid response. Returning to menu...");
            //    }

            //    Console.Clear();
            //}

            // TASK 3

            //while (true)
            //{
            //    int number;

            //    while (true)
            //    {
            //        Console.WriteLine("Enter a number between 1 and 10:");
            //        string? input = Console.ReadLine();


            //        bool isValid = int.TryParse(input, out number);

            //        if (!isValid)
            //        {
            //            Console.WriteLine("Invalid input. Not a number. Try again.");
            //            continue;
            //        }

            //        if (number < 1 || number > 10)
            //        {
            //            Console.WriteLine("Number out of range. Try again.");
            //            continue;
            //        }


            //        break;
            //    }
            //    int[] nums = Enumerable.Range(1, 10).ToArray();

            //    foreach (int i in nums)
            //    {
            //        Console.WriteLine($"{number} * {i} = {number * i}");
            //    }

            //    Console.WriteLine("Do you want to check another number? (yes/no):");
            //    string response = Console.ReadLine().Trim().ToLower();

            //    if (response == "no")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }

            //    if (response != "yes")
            //    {
            //        Console.WriteLine("Invalid response. Returning to menu...");
            //    }

            //    Console.Clear();
            //}

            // TASK 4
            //int start, end;

            //while (true)
            //{

            //    while (true)
            //    {
            //        Console.WriteLine("Enter the start number:");
            //        string inputStart = Console.ReadLine();
            //        bool isValidStart = int.TryParse(inputStart, out start);
            //        if (isValidStart)
            //            break;

            //        Console.WriteLine("Invalid number. Please try again.");
            //    }

            //    while (true)
            //    {
            //        Console.WriteLine("Enter the end number:");
            //        string inputEnd = Console.ReadLine();
            //        bool isValidEnd = int.TryParse(inputEnd, out end);
            //        if (isValidEnd && end >= start)
            //            break;

            //        Console.WriteLine("Invalid number or end number is less than start number. Please try again.");
            //    }


            //    int sum = 0;

            //    for (int i = start; i <= end; i++)
            //    {
            //        sum += i;
            //    }

            //    Console.WriteLine($"Sum from {start} to {end} is: {sum}");


            //    Console.WriteLine("Do you want to check another range? (yes/no):");
            //    string response = Console.ReadLine().Trim().ToLower();

            //    if (response == "no")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }

            //    if (response != "yes")
            //    {
            //        Console.WriteLine("Invalid response. Returning to menu...");
            //    }

            //    Console.Clear();
            //}


            // TASK 5

            //Book book1 = new Book("1984", "George Orwell", 1949);
            //Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
            //Book book3 = new Book("Clean Code", "Robert C. Martin", 2008);

            //book1.DisplayInfo();
            //book2.DisplayInfo();
            //book3.DisplayInfo();

            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();




        }

    }


    
    
}


