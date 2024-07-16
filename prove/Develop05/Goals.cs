// ChatGPT helped me write this class, most, if not all of the code was preprovided by me, however it was really scrambled and everywhere so GPT helped me make senese of it.
class Goals
{
    private int _TotalScore;
    private List<Goal> listOfGoals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        listOfGoals.Add(goal);
    }

    public void DisplayPoints ()
    {
        Console.WriteLine ($"You have {_TotalScore} points.");

    }


    public void DisplayGoals()
    {
        foreach (Goal goal in listOfGoals)
        {
            Console.WriteLine(goal.ListGoal());
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    public void SaveGoals()
    {
        string filename = ObtainFileName("Enter the filename to save the goal: ");
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in listOfGoals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
        Thread.Sleep(2000);
    }

    public void LoadGoals()
    {
        string filename = ObtainFileName("Enter the filename to load your goals: ");
        if (File.Exists(filename))
        {
            listOfGoals.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string description = parts[1];
                string points = parts[2];
                bool status = bool.Parse(parts[3]);
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Thread.Sleep(2000);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < listOfGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listOfGoals[i].GetName()}");
        }

        int response = int.Parse(Console.ReadLine()) - 1;
        if (response >= 0 && response < listOfGoals.Count)
        {
            _TotalScore += listOfGoals[response].RecordEvent();
            Console.WriteLine("Goal marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
        Thread.Sleep(2000);
    }

    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}