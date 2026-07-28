using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Kerr", "Homework");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Tom", "Mathematics", "4.1", "3-5");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Carl", "Wrting", "Not a Book");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritinginformation());
    }
}