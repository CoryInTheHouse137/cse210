using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        

        Menu();


    }

    static void Menu()
    {
        string userMenu;
        
        Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.WriteLine("");
        Console.Write("Select a choice from the Menu: ");
        userMenu = Console.ReadLine();
        switch(userMenu)
        {
            case "1":

                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
            case "5":

                break;
            case "6":

                break;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }

        
            
    }

    
}