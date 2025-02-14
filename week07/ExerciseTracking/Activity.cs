public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public virtual double GetDistance();
    public virtual double GetSpeed();
    public virtual double GetPace();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy HH:mm")} - Distance: {GetDistance()} km - Speed: {GetSpeed()} km/h - Pace: {GetPace()} min per km";
    }
}