using System;

class Program
{
    static void Main(string[] args)
    {



        int number = 6;
        int response;

        do
        {
            Console.WriteLine("Please select what scripture you would like to memorize. [Choose a number from 1-6 to select]:");
            Console.WriteLine("1. Alma 32:21");
            Console.WriteLine("2. Philippians 4:13");
            Console.WriteLine("3. Psalm 23:1");
            Console.WriteLine("4. Proverbs 3:5");
            Console.WriteLine ("5. Alma 7:11-13");
            Console.WriteLine ("6. Alma 7:11-13");


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