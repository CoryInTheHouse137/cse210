using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        

        int userCommand;
        do
        {   
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5.Quit");
            Console.Write("What would you like to do?");
            string j = Console.ReadLine();
            userCommand = int.Parse(j);

        }while (userCommand == 5);
    }
}