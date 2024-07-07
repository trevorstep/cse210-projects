class List: Activity
{
    private int amountOfEntries = 0;
    private List<string> prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();


        int index = random.Next(prompts.Count);


        string randomPrompt = prompts[index];

        return randomPrompt;

    }
    public void RunActivity()
    {
        string randomPrompt = GetRandomPrompt();
                Console.WriteLine("Get ready...");
                        Console.WriteLine();
             Thread.Sleep(2000);
             Console.WriteLine("List as many responses to the following prompt: ");
                     Console.WriteLine($"---{randomPrompt}---");
                     Console.WriteLine();
                     Console.Write($"You may begin in: ");
        CountDown();
        Console.Clear();
         DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime)
    
        {
            Console.ReadLine();
            amountOfEntries = amountOfEntries ++;
        }
    Console.Clear;


    }



}