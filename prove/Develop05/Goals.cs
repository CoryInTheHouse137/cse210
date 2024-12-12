using System;
using System.IO;


public class Goals
{
    
    protected string _goalName;
    protected string _goalDiscription;
    protected int _points;
    
     

    public virtual void DisplayPrompt()
    {
        Console.Write("What is the name of this goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is the Discription goal? ");
        _goalDiscription = Console.ReadLine();

        Console.Write("How many points do you want to assign this goal? ");
        
        string p = Console.ReadLine();
        _points = int.Parse(p);
    }
    
    public virtual void LoadGoalToFile()
    {

    }

    public virtual void  ReadGoal(string line)
    {
        
    }

    public virtual void ListGoal()
    {
        Console.WriteLine("");
    }



}