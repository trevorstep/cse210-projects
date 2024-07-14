using System;
using System.Reflection.Metadata;

class Program
{

    static void Main(string[] args)
    {
        int response = 0;
        while (response != 6)
        {
            Menu menu = new Menu();
            response = menu.DisplayMainMenu();
            if (response == 1)
            {

                menu.DisplaySubMenu();
                if (response == 1)
                {
                    Goals goals = new Goals();
                    goals.AddGoal(new SimpleGoal("Somthing", "simple goal", "16", false));


                }

            }
            else if (response == 2)
            {
                Goals goals = new Goals();
                goals.DisplayGoals();
            }
        }
    }
}