using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string First_name = Console.ReadLine ();

        Console.WriteLine("What is your last name?");
        string Last_name = Console.ReadLine ();

        Console.WriteLine("");
        Console.WriteLine ($"Your name is {Last_name}, {First_name} {Last_name}.");

    }
}