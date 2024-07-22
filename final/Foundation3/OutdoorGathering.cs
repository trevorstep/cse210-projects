class Outdoorgathering :Event
{
private string _weather;

    public Outdoorgathering(string eventTitle, string description, string date, string time, Address eventAddress, string weather)
        : base(eventTitle, description, date, time, eventAddress)
    {
        _weather = weather;
    }
public override string GetFullDetails()
{
    return $"{base.GetFullDetails()} predicted forcast:{_weather}";
}
}