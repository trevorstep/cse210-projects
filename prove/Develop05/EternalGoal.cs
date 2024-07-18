using System.Runtime.CompilerServices;

class EternalGoal: Goal
{
    private int _CompletedCountOfGoal = 0;

        public EternalGoal(string name, string description, int numberOfPoints, bool status, int CompletedCountOfGoal) : base(name, description, numberOfPoints, status)
    {
        _CompletedCountOfGoal = CompletedCountOfGoal;
    }

    public EternalGoal() :base("","",0,false)
    {

    }
     public override int RecordEvent()
    {
        // MarkedComplete();
        _CompletedCountOfGoal =_CompletedCountOfGoal +1;
        return GetPoints();
    }   

    public override string ListGoal()
    {
        string value = base.ListGoal();
        return value + $" -You have completed this eternal goal {_CompletedCountOfGoal} time('s)";
    }

        public override string ToString()
    {
        return $"{base.ToString()}#{_CompletedCountOfGoal}";
    }
}