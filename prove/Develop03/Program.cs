using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Reference reference = new Reference("Jacob", "5", "72");
        Console.WriteLine(reference.Referencer());


        Scripture scripture = new Scripture("And it came to pass that the servants did go and labor with their mights; and the Lord of the vineyard labored also with them; and they did obey the commandments of the Lord of the vineyard in all things.");
        scripture.GetWord();

        scripture.Display();
        Console.Write("Press 'enter' to hide words or 'Quit' to end program: ");
        string userInput = Console.ReadLine();

        while (userInput == "")
        {
            scripture.Randomizer();
            scripture.Randomizer();
            scripture.Randomizer();

            Console.Clear();

            Console.WriteLine(reference.Referencer());

            scripture.Display();

            Console.Write("Press 'enter' to hide words or 'Quit' to end program: ");

            userInput = Console.ReadLine();

            if (scripture.CheckUnder() == true || userInput.ToLower() == "quit")
            {
                break;
            }
        }
    }
}