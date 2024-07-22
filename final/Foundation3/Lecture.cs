class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address eventAddress, string speakerName,int capacity)
        : base(eventTitle, description, date, time, eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }


public override string GetFullDetails()
{
    return $"{base.GetFullDetails()}Speaker name: {_speakerName}, {_capacity}";
}

}