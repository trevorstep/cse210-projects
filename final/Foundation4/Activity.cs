public abstract class Activity
{
    public DateTime _date { get; private set; }
    public int _duration { get; private set; }

    protected Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public Activity()
    {
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}