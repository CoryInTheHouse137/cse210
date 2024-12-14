public class Menu
{
    private string _userInput;




    public void Options()
    {
        while(_userInput != "4")
        {
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Enter Discs\n2.Enter Hole\n3.Tracked Score");
            Console.Write("Choose:");
            _userInput = Console.ReadLine();

            Console.Clear();

            switch (_userInput)
            {
                case "1":
                
                    break;
                case "2":
                    HolePlay holePlay = new();
                    holePlay.PromptHole();
                    
                    break;
                case "3":

                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}