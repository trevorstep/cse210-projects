class Reception : Event
{
    private string rsvpEmail;

    public Reception(string eventTitle, string description, string date, string time, Address eventAddress, string rsvpEmail)
        : base(eventTitle, description, date, time, eventAddress)
    {
        this.rsvpEmail = rsvpEmail;
    }
public override string GetFullDetails()
{
    return $"{base.GetFullDetails()} RSVP email:{rsvpEmail}";
}
}