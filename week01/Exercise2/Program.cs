using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            if (gradePercentage < 93)
            {
                letterGrade += "-";
            }

        }
        if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letterGrade = "B";
            if (gradePercentage < 83)
            {
                letterGrade += "-";
            }
            else if (gradePercentage >= 87)
            {
                letterGrade += "+";
            }
        }
        if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letterGrade = "C";
            if (gradePercentage < 73)
            {
                letterGrade += "-";
            }
            else if (gradePercentage >= 77)
            {
                letterGrade += "+";
            }
        }
        if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letterGrade = "D";
            if (gradePercentage < 63)
            {
                letterGrade += "-";
            }
            else if (gradePercentage >= 67)
            {
                letterGrade += "+";
            }
        }
        if (gradePercentage < 60)
        {
            letterGrade = "F";
        }

        // comment by kerr. Display result
        Console.WriteLine($"Your Grade is {letterGrade}.");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats, You Passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you have failed. Try again next time.");
        }
    }
}