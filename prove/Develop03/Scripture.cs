

using System.ComponentModel;
using System.IO.Pipes;
using System.Reflection.Metadata;

public class Scripture
{

    private List<Word> _words = new();

    private string _scripture1;

    public Scripture(string scripture1)
    {
        _scripture1 = scripture1;
    }

    public void GetWord()
    {
        string[] splitScripture = _scripture1.Split(" ");
        foreach (string word in splitScripture)
        {
            Word word1 = new(word);
            _words.Add(word1);
        }
    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            Console.Write(word.GetterWord());
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void Randomizer()
    {
        
        if (CheckUnder() == false)
        {

            Random randomGenerator = new Random();


            int index = randomGenerator.Next(_words.Count);
            while (_words[index].GetterWord() == "___")
            {
                index = randomGenerator.Next(_words.Count);
            }

            Word randomWord = _words[index];
            string randomString = randomWord.GetterWord();

            randomString = "___";

            Word word = new(randomString);
            _words[index] = word;
        }

    }

    public bool CheckUnder()
    {
        bool allUnder = true;
        foreach (Word word1 in _words)
        {
            if (word1.GetterWord() != "___")
            {
                allUnder = false;
            }
        }
        return allUnder;
    }

}