using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        Goals goals = new Goals();
        Menu menu = new Menu();
        int response = 0;
        while (response != 6)
        {
            Console.Clear();
            goals.DisplayPoints();
            response = menu.DisplayMainMenu();
            if (response == 1)
            {
                response = menu.DisplaySubMenu();
                Goal goal;
                if (response == 1)
                {
                    goal = new SimpleGoal();
                    Console.WriteLine("Creating new Simple Goal");


                }
                else if (response == 2)
                {
                    goal = new EternalGoal();
                    Console.WriteLine("Creating new Eternal Goal");


                }
                else
                {
                    goal = new ChecklistGoal();
                    Console.WriteLine("Creating new Checklist Goal");


                }
                goal.Create();
                goals.AddGoal(goal);

            }
            else if (response == 2)
            {
                goals.DisplayGoals();
            }

            else if (response == 3)
            {
                goals.SaveGoals();
            }

            else if (response == 4)
            {
                goals.LoadGoals();
            }

            else if (response == 5)
            {
                goals.RecordEvent();
            }
        }
    }
}