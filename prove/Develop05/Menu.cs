class Menu
{
    public int DisplayMainMenu()
    {
        int response = 0;

        while (response < 1 || response > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflectiong Activity");
            Console.WriteLine("3. Start Listening activity");
            Console.WriteLine("4. Quit");

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