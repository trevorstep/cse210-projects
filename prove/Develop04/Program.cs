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
                BreathingActivity.DisplayWelcomeMessage("breathing");
                Console.WriteLine("");
                BreathingActivity.GetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("");
                BreathingActivity.GetDuration();
                Console.WriteLine("Get ready...");
                BreathingActivity.DisplaySpinner();
                BreathingActivity.RunActivity();
                BreathingActivity.ChangeConsoleColorBack();
                BreathingActivity.DisplayExitMessage("breathing");
                BreathingActivity.DisplaySpinner();
            }
            else if (response == 2)
            {
                Reflection reflectionActivity = new Reflection();
                reflectionActivity.DisplayWelcomeMessage("Reflection");
                Console.WriteLine("");
                reflectionActivity.GetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine("");
                reflectionActivity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get Ready...");
                reflectionActivity.DisplaySpinner();
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayExitMessage("Breathing");
                reflectionActivity.DisplaySpinner();
            }
            else if (response == 3)
            {
                List list = new List();
                list.DisplayWelcomeMessage("Listing");
                Console.WriteLine("");
                list.GetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("");
                list.GetDuration();
                Console.Clear();
                list.RunActivity();
                list.DisplayExitMessage("Listing");
                list.DisplaySpinner();
            }
        }
    }
}