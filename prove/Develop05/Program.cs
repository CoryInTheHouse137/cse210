using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        int totalPoints;
        string userMenu;
        List<Goals> goals = new();

        do
        {
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Take Goals from File\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the Menu: ");
            userMenu = Console.ReadLine();
            switch (userMenu)
            {



                case "1":
                    Console.WriteLine("Types of Goals:\n 1. Simple Goal\n 2. Eternal Goal \n 3. Checklist Goal");
                    Console.WriteLine("");
                    Console.Write("What goal would you like to create? ");
                    string userGoal = Console.ReadLine();


                    switch (userGoal)
                    {
                        case "1":
                            SimpleGoal simpleGoal = new();
                            simpleGoal.DisplayPrompt();
                            simpleGoal.LoadGoalToFile();

                            break;
                        case "2":
                            EternalGoal eternalGoal = new();
                            eternalGoal.DisplayPrompt();
                            break;
                        case "3":
                            ChecklistGoal checklistGoal = new();
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }


                    break;
                case "2":
                    foreach (Goals goal in goals)
                    {
                        goal.ListGoal();
                    }
                    break;
                case "3":
                    string[] lines = System.IO.File.ReadAllLines("myFile.txt");
                    foreach (string line in lines)
                    {
                        SimpleGoal simpleG = new();
                        simpleG.ReadGoal(line);
                        goals.Add(simpleG);
                    }
        
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

            // Console.WriteLine($"your total points are: {}");

        } while (userMenu != "6");


    }


}