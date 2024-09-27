using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq; // Required for the Sum() method

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers = [];

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNum = -1;
        while (userNum != 0)
        {
            
            Console.Write("Enter number: ");
            string h = Console.ReadLine();
            userNum = int.Parse(h);

            if (userNum != 0)
            {
               numbers.Add(userNum); 
            }
            
        }
        
        int sum = numbers.Sum();
        Console.WriteLine("The sum is: " + sum);

        double average = numbers.Average();
        Console.WriteLine("The Average is: " + average);

        int max = numbers.Max();
        Console.WriteLine("The largest number is:" + max);



        
    }
}