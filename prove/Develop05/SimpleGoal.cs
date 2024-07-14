class SimpleGoal: Goal
{
    private string goaltype = "Simple";
 public SimpleGoal(string name, string description, string numberOfPoints, bool status)
        : base(name, description, numberOfPoints, status)
    {
    }
}