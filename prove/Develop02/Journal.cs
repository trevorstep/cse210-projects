

class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();
    public string filename = "Journal.txt";





    public void AddEntry()
    {

    }

    public void Display()
    {

    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void ReadFromFile()
    {
        using (StreamReader outputFile = new StreamReader (filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }

    }


}