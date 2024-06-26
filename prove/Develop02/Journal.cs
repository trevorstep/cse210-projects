using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    // This list was generated by ChatGPT
    private readonly List<string> prompts = new List<string>

    #region 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
         "How did I challenge myself today?",
          "What are my top priorities for this week?",
           "How did I show kindness to others today?",
            "What is a recent accomplishment I'm proud of?",
            "What emotions did I experience today, and why?",
             "How did I take care of my physical health today?",
              "What is a new skill or lesson I learned recently?",
               "What is a goal I'm currently working towards?",
                "How did I spend quality time with loved ones today?",
                "What is something that inspired me today?",
                 "What did I do to relax and unwind?",
                  "How did I handle a difficult situation today?",
                   "What is a habit I'm trying to cultivate?",
                    "What made me laugh or smile today?",
                     "How did I contribute to my personal growth today?",
                      "What is something I could forgive myself or others for today?",
                      "How did I demonstrate resilience today?",
                      "What is a book, article, or podcast that impacted me recently?",
                       "How can I make tomorrow even better than today?"
    };
    #endregion

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Enter your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        response = response.Replace("#", "[HASH]");

        JournalEntry entry = new JournalEntry(date, prompt, response);
        entries.Add(entry);


    }

public void Display()
{
    foreach (JournalEntry entry in entries)
    {
        Console.WriteLine($"{entry._date}, {entry._prompt}, {entry._response}");
    }
}

    public void WriteToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }


    // This method was created by Chat GPT, Since I don't know a whole lot about file reading within a C# program and we didn't learn about it in class. I will now tell you what it does.

    // This Method starts by checking to see if the File exsists on the computer if it does then it will proceed, if it dosent then it will say that the file is not found and continue itterating through the menu. Next it will read the lines on the text file one at a time and split the statements apart using the # sign. Finnaly it calls the journal entry class.
    public void ReadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('#');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    JournalEntry entry = new JournalEntry(date, prompt, response);
                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}