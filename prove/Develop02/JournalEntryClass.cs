class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry (string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public override string ToString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}