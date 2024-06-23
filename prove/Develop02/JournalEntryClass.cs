// C#

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;



    public void JournalEntrys()
    {

    }

    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
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