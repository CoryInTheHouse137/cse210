using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment = new Assignment("Cory Stenlund", "Geology");
        string student = assignment.GetSummary();

        Console.WriteLine(student);

        Console.WriteLine("");
        
        MathAssignment mathAssignment = new MathAssignment("Cory Stenlund", "Fractions", "7.3", "8-19");
        string name = mathAssignment.GetSummary();
        string  next = mathAssignment.GetHomeworkList();

        Console.WriteLine(name);
        Console.WriteLine(next);

        Console.WriteLine("");
        
        WritingAssignment writingAssignment = new WritingAssignment("Cory Stenlund", "History", "The Causes of World War II by Mary Waters");
        string person = writingAssignment.GetSummary();
        string text = writingAssignment.GetWritingInformation();

        Console.WriteLine(person);
        Console.WriteLine(text);
    }
}