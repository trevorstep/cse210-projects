class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string filename = "Journal.txt";

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;

    }

    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];
            JournalEntry entry = new JournalEntry(date, question, entryText);
            this.AddEntry(entry);
        }
    }

}