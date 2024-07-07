class Breathing : Activity
{


    public void RunActivity()
    {
        {
            Console.Clear();

            string[] pattern = { "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| " };
            DateTime endTime = DateTime.Now.AddSeconds(_timeForSpinner);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                foreach (var symbol in pattern)
                {
                    if (DateTime.Now >= endTime)
                        break;


                    // Print the lines
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(pattern[i % pattern.Length]);
                        Thread.Sleep(50);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(pattern[i % pattern.Length]);
                        Thread.Sleep(150);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(pattern[i % pattern.Length]);
                        Thread.Sleep(200);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(pattern[i % pattern.Length]);
                        Thread.Sleep(300);
                    }

                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Breathe out... ");
                    Console.Write("| | | | | | | | | | | | | | | | | | | | | | | | ");

                    // Delete the lines
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                        Thread.Sleep(300);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                        Thread.Sleep(200);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                        Thread.Sleep(150);
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                        Thread.Sleep(100);
                    }
                }
            }
        }

    }
}
