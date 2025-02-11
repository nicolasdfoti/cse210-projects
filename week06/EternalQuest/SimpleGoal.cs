public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {

        _isComplete = true;

        if (_isComplete)
        {
            Console.WriteLine($"[X] {GetName()}, {GetDescription()}");
        }

        else
        {
            Console.WriteLine($"[ ] {GetName()}, {GetDescription()}");
        }

    }

    public override string GetDetailsString()
    {
        return $"{GetName()}, {GetDescription()}, {GetPoints()} points";
    }

    public override string GetStringRepresentation()
    {
        if (isComplete())
        {
            return $"[X] {GetName()}, {GetDescription()}, {GetPoints()}";
        }
        
        else {
            return $"[ ] {GetName()}, {GetDescription()}, {GetPoints()}";
        }  
    }
}