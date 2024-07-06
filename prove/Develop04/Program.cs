using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while (response != 4)
        {
            Menu menu = new Menu();
            response = menu.DisplayMenu();
            if (response == 1)
            {
                // Call breathing actvity
                Breathing BreathingActivity = new Breathing();
                BreathingActivity.DisplayWelcomeMessage("Breathing");
                Console.WriteLine("");
                BreathingActivity.GetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("");
                BreathingActivity.GetDuration();
                BreathingActivity.DisplaySpinner();

            }
            else if (response == 2)
            {


            }
            else if (response == 3)
            {

            }
        }
    }
}