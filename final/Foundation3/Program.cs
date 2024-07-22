using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "12345");
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "7/25/24", "10:00 AM", address1, "Jane Doe", 100);
        Event reception = new Reception("Annual Gala", "A formal gathering", "7/26/24", "6:00 PM", address1, "rsvp@example.com");
        Event outdoorGathering = new Outdoorgathering("Picnic", "An outdoor picnic event", "7/25/24", "12:00 PM", address1, "Sunny and warm");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());

    }
}