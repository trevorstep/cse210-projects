class Employee
{
    private string _name;
    private double _hoursWorked;
    private double _hourlyWage;
    public Employee(string name, double hourlyWage, double hoursWorked)
    {
        _name = name;
        _hoursWorked = hourlyWage;
        _hourlyWage = hoursWorked;
    }

public virtual double GetPay()
{
    return _hoursWorked* _hourlyWage;
}

public string GetName()
{
    return _name;
}
}