using System;

class Program
{
       static void DisplayWelcome()
   {
        Console.WriteLine("Welcome to the program!");
   }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string j = Console.ReadLine();
        int number = int.Parse(j);

        return number;
    }
    static int SquareNumber(int number)
    {
        int squareNum = number * number;

        return squareNum;
    }
    static void DisplayResult(int squareNum, string userName)
    {
        Console.WriteLine(userName + ",  the square of your number is " + squareNum);
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();

        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(square, name);
        
    }

}