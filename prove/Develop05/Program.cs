using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while (response != 6)
        {
            Menu menu = new Menu();
            response = menu.DisplayMainMenu();
            if (response == 1)
            {
                menu.DisplaySubMenu();
                if (response == 1)
                {

                }
            }
        }
    }
}