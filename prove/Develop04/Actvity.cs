using System.ComponentModel.DataAnnotations;

class Activity
{
    private int _time = 3;
    private string typeOfActvity = "";
    private string _description = "";


    public void DisplayWelcomeMessage(string typeOfActvity)
    {
        Console.WriteLine($"Welcome to the {typeOfActvity} Actvity!");
    }

    public void GetDescription(string _description)
    {
        Console.WriteLine($"{_description}");
    }

    public void CountDown()
    {
        for (int i =5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write ("\b \b");
        }
    }
    public void DisplayExitMessage(string typeOfActvity)
    {
        Console.WriteLine($"Thank you for doing the {typeOfActvity} Actvity!");
    }

    public void GetDuration()
    {
        Console.WriteLine("How long in seconds, would you like for your session to take?");
        _time = int.Parse(Console.ReadLine());
    }

    public void StartTime()
    {

    }
    public void DisplaySpinner()
    {
        {
            Console.WriteLine("Get ready...");
            Console.WriteLine();

            string[] pattern = { "_ ", "_ ", "_ ", "- ", "` ", "` ", "' ", "´ ", "- ",  "_ ", "_ ", "_ " };
            DateTime endTime = DateTime.Now.AddSeconds(3);

            while (DateTime.Now < endTime)
            {
                foreach (var symbol in pattern)
                {
                    if (DateTime.Now >= endTime)
                        break;

                    Console.Write(symbol);
                    Thread.Sleep(45);
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                }
            }
        }



    }
}