using System;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
         
        Console.WriteLine("Welcome to the Journal Program!");
        List<Entry> entries = new();

        int userCommand;
        
        do
        {   
            
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5.Quit");
            Console.Write("What would you like to do? ");
            string j = Console.ReadLine();
            userCommand = int.Parse(j);



            if (userCommand == 1)
            {
                promptGen PromptGen = new promptGen();

                string randomPrompt = PromptGen.RandomGen();
                Console.WriteLine($"{randomPrompt}");
                string userEntries = Console.ReadLine();

                entries.Add(new Entry(userEntries, randomPrompt));
            }
            else if (userCommand == 2)
            {
                Console.WriteLine("Journal Entries:");
                foreach (Entry altEntry in entries)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"[{altEntry._timeStamp}] {altEntry._promptHolder} \n{altEntry._userEntry}");
                }
            }
            else if (userCommand == 3)
            {
                JournalLoad(ref entries);
            }
            else if (userCommand == 4)
            {
                JournalSave(entries);
            }
            


        }while (userCommand != 5);

 
    }
    public static void JournalSave(List<Entry> entries)
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // outputFile.WriteLine("This will be the first line in the file.");
    
            foreach (Entry altEntry in entries)
            {
                outputFile.WriteLine($"{altEntry._timeStamp} ~ {altEntry._promptHolder} ~ {altEntry._userEntry}");
            }
        }
    }


    public static void JournalLoad(ref List<Entry> entries)
    {
        string fileName = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);
        entries = new();
        foreach(string line in lines)
        {
            string[] sections = line.Split("~");

            string timeStamp = sections[0];
            string promptHolder = sections[1];
            string userEntry = sections[2];
            Entry entry1 = new(userEntry, promptHolder);

            entry1._timeStamp = DateTime.Parse(timeStamp);

            entries.Add(entry1);



        }
    }
}

    