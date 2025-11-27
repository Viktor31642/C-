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

        Book book1 = new Book("1984", "George Orwell", 1949);
        Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        Book book3 = new Book("Clean Code", "Robert C. Martin", 2008);

        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();

        Console.ReadLine();
    }
}