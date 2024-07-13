using System.Security.Cryptography.X509Certificates;

class Menu
{
    int response = 0;
    public int DisplayMainMenu()
    {

        while (response < 1 || response > 6)
        {
            Console.Clear();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

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
        while (response < 1 || response > 4)
        {
            Console.Clear();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

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
}
