using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        string menu = "Menu Options:\n 1. Start breathing activity\n 2. Start reflection activity\n 3. Start listing activity\n 4. Quit program\nSelect a choice from the menu:";
        Console.Write(menu);
        string userMenu = Console.ReadLine();
        
        Console.Clear();
        BreathingActivity breathingActivity = new BreathingActivity();
        switch (userMenu)
        {
            case "1":
                breathingActivity.AcivityB();

                break;
            case "2":
                
                break;
            case "3":

                break;
            case "4":
                break;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }

        
    }
}