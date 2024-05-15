using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    { 
        // created a simple base Assignment
        Assignment a1 = new Assignment("Alison Hopa", "Programming");
        Console.WriteLine(a1.GetSummary());

        // Here I created a new MathAssignment object and set it's values
        MathAssignment a2 = new MathAssignment("Alison Hopa", "Subtraction", "2.2", "10-5");
        // And I tested the two methods
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        // Tested my new class
        WritingAssignment a3 = new WritingAssignment("Alison Hopa", " Programming", "Inheritance");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.WritingInformation()); 
    }
}


