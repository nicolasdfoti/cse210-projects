public class StationaryBikes : Activity
{
    private int _speed;

    public StationaryBikes(int speed, DateTime date, int length) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}