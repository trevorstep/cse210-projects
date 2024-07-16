class SimpleGoal : Goal
{
    public SimpleGoal()
    {


    }
    public override int RecordEvent()
    {
        MarkedComplete();
        return GetPoints();
    }
}