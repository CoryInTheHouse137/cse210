public class ListingActivity : Activity
{

    private List<string> _promptListing;

    private string _welcome;

    private string _end;

    public static void ListingSummary()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void ActivityL()
    {
        DisplayWelcome();
        Console.WriteLine("Listing Activity\n");
        ListingSummary();
        SecondsPrompt();




    }
}