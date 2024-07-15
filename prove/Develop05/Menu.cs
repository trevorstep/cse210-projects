using System.Security.Cryptography.X509Certificates;

class Menu
{
    public int response = 0;
    public int PointValue = 0;
    public int DisplayMainMenu()
    {

        while (response < 1 || response > 6)
        {
            Console.Clear();
            Console.WriteLine($"You have {PointValue} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select choice from menu: ");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That is an invalid response, please enter a number between 1 and 4.");
                Thread.Sleep(3000);
            }
        }
        return response;
    }
    public int DisplaySubMenu()
    {
        response = 0;

        while (response < 1 || response > 4)
        {
            Console.Clear();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Whichh tyoe of goal woulld you like to create? ");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That is an invalid response, please enter a number between 1 and 3.");
                Thread.Sleep(3000);
            }
        }
        return response;
    }

}

