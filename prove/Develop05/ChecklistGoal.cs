class ChecklistGoal : Goal
{
    private int _DesiredCount;

    private int _CompletedCount = 0;

    private int _BonusPoints;

    public ChecklistGoal(string name, string description, int numberOfPoints, bool status, int BonusPoints, int CompletedCount, int DesiredCount) : base(name, description, numberOfPoints, status)
    {
        _BonusPoints = BonusPoints;
        _CompletedCount = CompletedCount;
        _DesiredCount = DesiredCount;
    }
    public ChecklistGoal()
    {

    }

    public override void Create()
    {
        base.Create();
        Console.WriteLine("How many times do you want to accomplish this goal? ");
        _DesiredCount = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"How many bonus points would you like to recieve for comepleting this goal {_DesiredCount} times?");
        _BonusPoints = Int32.Parse(Console.ReadLine());
    }


    public override string ListGoal()
    {
        string value = base.ListGoal();
        return value + $" {_CompletedCount}/{_DesiredCount}";
    }
    public override int RecordEvent()
    {
        _CompletedCount++;
        if (_DesiredCount == _CompletedCount)
        {
            MarkedComplete();
            return GetPoints() + _BonusPoints;
        }
        return GetPoints();
    }
    public override string ToString()
    {
        return $"{base.ToString()}#{_BonusPoints}#{_CompletedCount}#{_DesiredCount}";
    }

}

