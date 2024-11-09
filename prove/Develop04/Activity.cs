using System.Diagnostics;

public class Activity
{
    protected int _time;

    private string _activity;
    private List<string> _animationLoading; // new

    

    public static void DisplayWelcome()
    {
        Console.Write("Welcome to the ");
    }
    public void SecondsPrompt()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine(); 
        _time = int.Parse(input);
    }
    public string DisplayEnding()
    {
        return ""; 
    }
    
    public void Animaiton()
    {
        // |/-\|/-\|
        _animationLoading.Add("|");
        _animationLoading.Add("/");
        _animationLoading.Add("-");
        _animationLoading.Add("\\");
        _animationLoading.Add("|");
        _animationLoading.Add("/");
        _animationLoading.Add("-");
        _animationLoading.Add("\\");
       
       foreach(string s in _animationLoading)
       {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
       }
    }






}