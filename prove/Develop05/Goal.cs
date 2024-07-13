class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;

    public Goal(string name, string description, int numberOfPoints, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = numberOfPoints;
        _status = status;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription()
    {

    }

    public int GetPoints()
    {
        return _numberOfPoints;
    }

    public int SetNumberOfPoints()
    {
        return _numberOfPoints;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public int MartkedComplete()
    {
        return _numberOfPoints;
    }

    virtual public string ListGoal()
    {
        return _name;
    }

    public override string ToString()
    {
        return base.ToString();
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