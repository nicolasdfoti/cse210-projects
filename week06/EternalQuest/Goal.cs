public abstract class Goal
{
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public bool isComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return $"{GetName()}, {GetDescription()}, {GetPoints()}";
    } 

    public string GetStringRepresentation()
    {
        return $"[ ] {GetName()}, {GetDescription()}, {GetPoints()}";
    }
}