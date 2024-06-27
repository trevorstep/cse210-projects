class Fraction
{
private int _numerator;
private int _denominator;


public Fraction ()
{
    _numerator= 1;
    _denominator=1;

    Console.WriteLine ($"{_numerator}/{_denominator}");
}

public Fraction (int WholeNumber)
{
    _numerator = WholeNumber;
    _denominator = 1;
    Console.WriteLine ($"{_numerator}/{_denominator}");
}

public Fraction (int numerator,int denominator )
{
    _numerator = numerator;
    _denominator = denominator;

}

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }

}