public class EternalGoal : Goals
{

    public override void LoadGoalToFile()
    {
        using (StreamWriter outputFile = new StreamWriter("myFile.txt", true)) //true means append
        {
            outputFile.WriteLine($"{_goalName},{_goalDiscription},{_points}");
        }
    }

    public override void ReadGoal(string line)
    {
        string[] parts = line.Split(",");

        _goalName = parts[0];
        _goalDiscription = parts[1];
        int x = int.Parse(parts[2]);
        _points = x;
    }

        public override void ListGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDiscription}), {_points}");
    }

}