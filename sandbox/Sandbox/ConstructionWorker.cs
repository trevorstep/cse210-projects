class ConstrucitonWork: Employee
{
    public ConstrucitonWork(string name, double hours, double wage) :base (name, hours, wage)
    {}

    public override double GetPay()
    {
       return base.GetPay() + 1000;
    }
}