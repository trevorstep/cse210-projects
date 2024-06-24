using System;
using System.Globalization;

class Program
{


    
    static void Main(string[] args)
    {
        

        Random randomGenerator = new Random();
        int number = 5;
        int response;
        Console.WriteLine(number);

        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            string responseAsStrng = Console.ReadLine();
            response = int.Parse(responseAsStrng);

            if (response == 1)
            {
                
            }
            else if ( response == 2 )
            {

            }
            else if (response == 3)
            {

            }
            else if (response == 4)
            {

            }

        } while (response != number);

    }
}