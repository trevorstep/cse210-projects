class EternalGoal: Goal
{
     public override int RecordEvent()
    {
        // MarkedComplete();
        return GetPoints();
    }   
}