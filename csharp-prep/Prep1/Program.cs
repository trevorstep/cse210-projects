using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats your first name shawtyh?");
        string First_name = Console.ReadLine ();

        Console.WriteLine("Whats your last name shawtyh?");
        string Last_name = Console.ReadLine ();

        Console.WriteLine("");
        Console.WriteLine ($"Your name is {Last_name}, {First_name} {Last_name}.");

    }
}