class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int numberOfPoints, bool status) : base(name, description, numberOfPoints, status)
    {
        
    }

    public SimpleGoal()
    {


    }
    public override int RecordEvent()
    {
        MarkedComplete();
        return GetPoints();
    }
}