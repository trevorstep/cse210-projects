abstract class Employee
{
    protected string _name;
    protected double _hoursWorked;
    protected double _hourlyWage;
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

    public override string ToString()
    {
        return $"name {_name}, hours: {_hoursWorked}, wage: {_hourlyWage}"; 
    }

    public abstract double InsuranceCost();
}