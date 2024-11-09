public class BreathingActivity : Activity
{
    private string _welcome;
    private string _end;



    public static void BreathingSummary()
    {
        Console.WriteLine("\nThis acivity will help you relax by walking through breathing in and out slowly.\nClear your mind and focus on your breathing.\n");
    }
    public void AcivityB()
    {
        DisplayWelcome();
        Console.WriteLine("Breathing Activity.");
        BreathingSummary();
        SecondsPrompt();
        



    }

}