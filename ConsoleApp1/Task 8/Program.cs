class Student
{
    public string fullName;
    public int age;

    public Student(string fullName, int age)
    {
        this.fullName = fullName;
        this.age = age;
    }
}

class Program
{

    static void Main()
    {

        Student[] students =
        {
          new Student("Viktor Krupin", 27),
          new Student("Olena Shevchenko", 19),
          new Student("Taras Bondarenko", 21),
          new Student("Iryna Kovalenko", 18),
          new Student("Stepan Hrytsyk", 27),
          new Student("Anastasia Krupin", 27),
          new Student("Roman Lytvynenko", 26),
          new Student("Mykola Chornyi", 23),
          new Student("Natalia Dovzhenko", 27),
          new Student("Bohdan Stetsenko", 29)
        };

        Console.WriteLine("List of students: ");
        foreach (Student student in students)
        {
            Console.WriteLine(student.fullName + " " + student.age);
        }

        Console.WriteLine("\nSort by age:");

        Array.Sort(students, (a, b) => a.age.CompareTo(b.age));
        foreach (Student student in students)
        {

            Console.WriteLine(student.fullName + " - " + student.age);

        }

        int maxAge = students.Max(student => student.age);

        var oldestStudents = students.Where(student => student.age == maxAge);
       
        Console.WriteLine("\nThe oldest student:");
        foreach (var student in oldestStudents)
        {
            Console.WriteLine($"{student.fullName} — {student.age}");
        }

        Console.ReadLine();

    }

}