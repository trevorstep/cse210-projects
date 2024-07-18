class EternalGoal: Goal
{

        public EternalGoal(string name, string description, int numberOfPoints, bool status) : base(name, description, numberOfPoints, status)
    {
        
    }

    public EternalGoal() :base("","",0,false)
    {

    }
     public override int RecordEvent()
    {
        // MarkedComplete();
        return GetPoints();
    }   
}