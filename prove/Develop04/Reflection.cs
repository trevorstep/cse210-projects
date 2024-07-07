class Reflection : Activity
{
    private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

// ChatGP helped me make the random list selector for the prompt and questions
    public string getRandomListPrompt()
    {
        Random random = new Random();


        int index = random.Next(prompts.Count);


        string randomPrompt = prompts[index];

        return randomPrompt;

    }

    public string getRandomListQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        string randomQuestion = questions[index];

        return randomQuestion;

    }


    public void RunActivity()
    {
        string randomPrompt = getRandomListPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"---{randomPrompt}---");
        ChangeConsoleColorBack();
        Console.WriteLine("");
        Console.WriteLine(@"Once you have something in mind, press ""Enter"" to continue");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this exspereience.");
        Console.Write($"You may begin in: ");
        CountDown();
        Console.Clear();
        _timeForSpinner = 10;

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string randomQuestion = getRandomListQuestion();
            Console.Write($"{randomQuestion}");
            DisplaySpinner();
            Console.WriteLine();
            ChangeConsoleColorBack();

        }
        _timeForSpinner = 5;
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
    }

}
