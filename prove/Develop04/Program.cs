using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while (response != 4)
        {
            Menu menu = new Menu();
            response = menu.DisplayMenu();
            if (response == 1)
            {
                // Call breathing actvity
                Activity activity = new Activity();
                activity.DisplaySpinner();
            }
            else if (response == 2)
            {


            }
            else if (response == 3)
            {

            }
        }
    }
}