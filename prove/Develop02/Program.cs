using System;

class Program
{
    
    static void Main(string[] args)
    {
      Journal journal = new Journal();
        int number = 5;
        int response;

        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine ("5. Quit");

            string responseAsStrng = Console.ReadLine();
            response = int.Parse(responseAsStrng);

            if (response == 1)
            {
                journal.AddEntry();
            }
            else if ( response == 2 )
            {
                journal.Display();
            }
            else if (response == 3)
            {
                Console.Write ("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.WriteToFile(filename);
            }
            else if (response == 4)
            {
                Console.Write ("Enter filename to load from: ");
                string loadFile = Console.ReadLine();
                journal.ReadFromFile(loadFile);
            }

        } while (response != number);
    }
}