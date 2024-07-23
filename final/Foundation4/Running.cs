class Running : Activity
{
    // Chat GPT helped me to create the constructor and logic for this child class, but I also manipulated most of the data in it so I am well familiar with it, and rewrote most of it
    public double _distance { get; private set; }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }


}