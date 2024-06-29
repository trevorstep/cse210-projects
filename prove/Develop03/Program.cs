using System;

class Program
{
    static void Main(string[] args)
    {

        int number = 5;
        int response;

        do
        {
            Console.WriteLine("Please select what scripture you would like to memorize. [Choose a number from 1-6 to select]:");
            Console.WriteLine("1. Alma 32:21");
            Console.WriteLine("2. Philippians 4:13");
            Console.WriteLine("3. Psalm 23:1");
            Console.WriteLine ("4. Alma 7:11-13");
            Console.WriteLine ("5. Quit");


            string responseAsStrng = Console.ReadLine();
            response = int.Parse(responseAsStrng);

            if (response == 1)
            {
                    Reference reference = new Reference("Alma",32, 21);
                    Console.WriteLine (reference.ToString());

            }

            else if ( response == 2 )
            {
                    Reference reference = new Reference("Philippians",4, 13);
                    Console.WriteLine (reference.ToString());
            }

            else if (response == 3)
            {
                    Reference reference = new Reference("Psalm",23, 1);
                    Console.WriteLine (reference.ToString());

            }
            else if (response == 4)
            {
                    Reference reference = new Reference("Alma",7, 11,13);
                    Console.WriteLine (reference.ToString());
            }

        } while (response != number);
    }
}