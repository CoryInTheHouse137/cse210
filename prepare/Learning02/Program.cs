using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._company = "Microsoft";
        job1._jobTitle = "Big Nerd";
        job1._startYear = "2000";
        job1._endYear = "2300";
        job1.Display();

        Job job2 = new();
        job2._company = "Apple";
        job2._jobTitle = "Touchscreen tester";
        job2._startYear = "2020";
        job2._endYear = "2023";
        job2.Display();

        Console.WriteLine("");
        
        Resume myResume = new Resume();
        myResume._name = "Cory Stenlund";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}