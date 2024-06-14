using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int response;
        Console.WriteLine(number);
        int UserGuess = 0;

    do
        {
            Console.WriteLine("What is your magic number?");
            string responseAsStrng = Console.ReadLine();
            UserGuess = UserGuess + 1;
            response = int.Parse(responseAsStrng);


            if (response == number)
            {
                Console.WriteLine("You got it!");
                Console. WriteLine (" ");
                Console.WriteLine($"You guessed {UserGuess} times!!");
            }
            else if (response < number)
            {
                Console.WriteLine("Higher");
            }
            else if (response > number)
            {
                Console.WriteLine("Lower");
            }
        } while (response != number);

    }

}