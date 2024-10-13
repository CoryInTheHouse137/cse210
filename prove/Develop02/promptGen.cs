public class promptGen
{

    private List<string> prompts;
    

    public promptGen()
    {
        prompts = new List<string>
        {
            "What stood out today?",
            "What was the hardest part of your day?",
            "What motivated you today?",
            
        };

    }

    public string RandomGen()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];      
    }
    

}