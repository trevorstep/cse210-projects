class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event ()
    {
    }

public string GetStandardDetails()
{
    return $"Event name:{_eventTitle}: {_description}, date: {_date}, {_time}, {_address}.";

}
public virtual string GetFullDetails()
{
return GetStandardDetails();
}
public string GetShortDescription()
{
return $"Event type{this.GetType().Name } Event name: {_eventTitle}-{_date}";
}

}



