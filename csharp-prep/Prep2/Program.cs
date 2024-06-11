using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello my dude, what is your letter grade percentage?");
        int letterGrade = int.Parse( Console.ReadLine());    


        string letter = "";

    if (letterGrade >= 90)
        {
        letter = "A";
        }
        
    else if (letterGrade >= 80)
        {
        letter = "B";
        }

    else if (letterGrade >= 70)
        {
        letter = "C";
        }
    else if (letterGrade >= 60)
        {
        letter = "D";
        }
    else 
        {
        letter = "F";
        }
    
    if (letterGrade>= 70)
    {
        Console.WriteLine("You passed"!);
    }
    else
    {
        Console.WriteLine("You did not pass");
    }

        Console.WriteLine ($"Your grade is an {letter}.");

    }
}