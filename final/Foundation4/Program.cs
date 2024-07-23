using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            // Chat GPT provided the randomized data for each object.
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

        }
    }


}