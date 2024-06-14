using System;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {
        List<int> listValues = new List<int>();
        int userInput = 0;
        int sumTotal = 0;
        int biggest = 0;
        int smallest = 999999999;
        int averageCounter = 0;

        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when you are satisfied with the amount of number's");
            string userInput2 = Console.ReadLine();
            userInput = int.Parse(userInput2);
            listValues.Add(userInput);
            averageCounter++;
            if (userInput > biggest)
                biggest = userInput;
            if (userInput < smallest)
                smallest = userInput;

        } while (userInput != 0);

        foreach (int number in listValues)
        {
            sumTotal += number;
        }
        Console.WriteLine($"The total sum is {sumTotal}");

        int totalAverage = sumTotal / averageCounter;

        Console.WriteLine($"The average is {totalAverage}");
                Console.WriteLine($"The biggest number is {biggest}");
        Console.WriteLine($"The smallest is {smallest}");
        


    }
}