public abstract class Goal
{
    private string _name;
    private string _description;
    private int  _numberOfPoints;

    protected int _CompletedCount = 0;

    private bool _status = false;

public Goal ()
{

}
    public Goal(string name, string description, int numberOfPoints, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = numberOfPoints;
        _status = status;
    }

    public virtual void Create()
    {
        Console.WriteLine ("What is the name of this goal? ");
         _name = Console.ReadLine();
        Console.WriteLine ("What is the description of this goal? ");
        _description = Console.ReadLine();
        Console.WriteLine ("How many points is your goal worth? ");
        _numberOfPoints = Int32.Parse(Console.ReadLine());
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string Checkbox()
    {
        if (_status == true)
        {
            return "[✓]";
        }
        else 
        {
            return "[ ]";
        }
    }

    public void GetPoints()
    {
        Console.WriteLine ($"You have {_numberOfPoints} points.");
    }

    public int SetNumberOfPoints( int points)
    {
        _numberOfPoints = points;
        return _numberOfPoints;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void MarkedComplete()
    {
        _status = true;
    }

    virtual public string ListGoal()
    {

        return $"{Checkbox()} {_name}: {_description} - Points: {_numberOfPoints} - Status: {(_status ? "Complete" : "Incomplete")}";
    }

    public override string ToString()
    {
        return $"Goal(Name: {_name}, Description: {_description}, Points: {_numberOfPoints}, Status: {_status})";
    }


        public void UpdatedCompletedCount()
    {
        _CompletedCount = _CompletedCount +1;
    }


    // abstract string GetGoalType()
    // {
    //     return _name;
    // }
    // abstract int RecordEvent()
    // {
    //     return _numberOfPoints;
    // }


    // abstract void RunGoal()
    // {

    // }
}