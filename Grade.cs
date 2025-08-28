using System;

class StudentRecord
{
    // Private fields
    private string _name;
    private int _age;
    private string _grade;

    // Public properties to access private fields
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Grade
    {
        get { return _grade; }
        set { _grade = value; }
    }

    // Method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Age: {_age}");
        Console.WriteLine($"Grade: {_grade}");
    }
}

class Program
{
    static void Main()
    {
        StudentRecord student = new StudentRecord();

        Console.Write("Enter student name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter student age: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter student grade: ");
        student.Grade = Console.ReadLine();

        student.DisplayDetails();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
