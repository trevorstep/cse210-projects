class ChecklistGoal : Goal
{
    private int _DesiredCount;

    private int _CompletedCount = 0;

    private int _BonusPoints;

    public ChecklistGoal (string name, string description, int numberOfPoints, bool status) : base(name, description, numberOfPoints, status)
    {
        
    }
    public ChecklistGoal()
    {

    }

    public override void Create()
    {
        base.Create();
        Console.WriteLine("How many times do you want to accomplish this goal? ");
        _DesiredCount = Int32.Parse(Console.ReadLine());
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
}