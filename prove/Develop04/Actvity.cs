using System.ComponentModel.DataAnnotations;

class Activity
{
    private int _time = 0;
    private string typeOfActvity = "";
    private string _description = "";
    private bool _exitTime = true;
    private DateTime _endTime;

    public void DisplayWelcomeMessage(string typeOfActvity)
    {
        Console.WriteLine($"Welcome to the {typeOfActvity} Actvity!");
    }

    public void GetDescription(string _description)
    {
        Console.WriteLine($"{_description}");
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

    public void Displayspinner()
    {
        string[] pattern = { "_", "_", "_", "-", "`", "`", "'", "´", "-", "_", "_", "_" };

        while (_exitTime == true)
        {
            foreach (var symbol in pattern)
            {
                Console.Write(symbol);
                Thread.Sleep(45);
                Console.Write("\b \b");


            }
        }


    }













}