class Breathing : Activity
{


    public void RunActivity()
    {

        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
        string[] pattern = { "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| ", "| " };
        DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            // ChatGPT Helped me with the foreach loop but I got the rest
            foreach (var symbol in pattern)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (DateTime.Now >= endTime)
                    break;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Breathe in...");
                // Print the lines
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(pattern[i % pattern.Length]);
                    Thread.Sleep(25);
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(pattern[i % pattern.Length]);
                    Thread.Sleep(50);
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(pattern[i % pattern.Length]);
                    Thread.Sleep(100);
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.Write(pattern[i % pattern.Length]);
                    Thread.Sleep(150);
                }

                for (int i = 0; i < 4; i++)
                {
                    Console.Write(pattern[i % pattern.Length]);
                    Thread.Sleep(200);
                }

                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Breathe out... ");
                Console.Write("| | | | | | | | | | | | | | | | | | | | | | | | | | | | | | ");

                // Delete the lines

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Thread.Sleep(150);
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Thread.Sleep(120);
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Thread.Sleep(100);
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Thread.Sleep(50);
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Thread.Sleep(25);

                }


            }

        }
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
    }
}
// ChatGPT made some of the for loops since they are pretty simple, and I was feeling lazy and didnt want to type the same thing over and over again like 5 times.