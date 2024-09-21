using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your % grade in the class? ");
        int grade = Console.ReadLine();
        string letter = "Not a grade, try again."

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (90 > grade >= 80)
        {
            letter = "B";
        }
        else if (80 > grade >= 70)
        {
            letter = "C";
        }
        else if (70 > grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine($"Congrats! You passed the class.");
        }
        else
        {
            Console.WriteLine($"Keep trying hard! You can do it next time.");
        }
    }
}