using System.Globalization;

public class SwimmingPool : Activity
{
    private int _numberLaps;

    public SwimmingPool(int numberLaps, DateTime date, int length) : base(date, length)
    {
        _numberLaps = numberLaps;
    }

    public override double GetDistance()
    {
        return _numberLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetDistance() / GetDistance();
    }
}