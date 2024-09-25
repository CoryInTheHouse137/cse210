using System;

class Program
{
    static void Main(string[] args)
    {

        int number = -1;

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 11);


        while(magicNum != number)
        {
            Console.Write("What is your guess? ");
            string h = Console.ReadLine();
            number = int.Parse(h);

            if (magicNum < number)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNum > number)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("Correct!");


    }
}