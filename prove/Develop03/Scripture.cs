

using System.ComponentModel;
using System.IO.Pipes;

public class Scripture
{

    private List<Word> _words = new();

    private string _scripture1; 

    
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
        // foreach(string word in _words)
        // {
        //     Console.WriteLine(word);
        // }
    }
    

}