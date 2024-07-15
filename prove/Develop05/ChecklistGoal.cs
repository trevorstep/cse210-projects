class ChecklistGoal : Goal
{
    private int _DesiredCount;

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

    // Updates count if User calls it.
}