using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Jacob", "5", "72");
        Console.WriteLine(reference.referencer());


        Scripture scripture = new Scripture();
        
        // Word word = new Word("wordsss");
        // Console.Write(word.Display());

    }
}