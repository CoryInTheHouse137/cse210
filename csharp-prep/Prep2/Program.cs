using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your % grade in the class? ");
        string grade = Console.ReadLine();
        int gradeP = int.Parse(grade);

        string letter = "Not a grade, try again.";

        if (gradeP >= 90)
        {
            letter = "A";
        }
        else if (gradeP >= 80)
        {
            letter = "B";
        }
        else if (gradeP >= 70)
        {
            letter = "C";
        }
        else if (gradeP >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        
        if (gradeP >= 70)
        {
            Console.WriteLine($"Congrats! You passed the class.");
        }
        else
        {
            Console.WriteLine($"Keep trying hard! You can do it next time.");
        }
    }
}