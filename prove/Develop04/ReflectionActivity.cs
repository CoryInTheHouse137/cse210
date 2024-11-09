public class ReflectionActivity : Activity
{
    private List<string> _promptRelfection;

    private string _welcome;

    private string _end;

    public static void ReflectionSummary()
    {
        Console.WriteLine("This activity will help you relfect on times in your life when you have shown strength and resillience. \nTis will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void AcitivtyR()
    {
        DisplayWelcome();
        Console.WriteLine("Reflection Activity\n");
        ReflectionSummary();
        SecondsPrompt();

        

    }



}