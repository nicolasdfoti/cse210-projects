public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (isComplete())
        {
            return $"[X] {GetName()}, {GetDescription()} - {GetPoints()} points";
        }

        else
        {
            return $"[ ] {GetName()}, {GetDescription()} - {GetPoints()} points";
        }
        
    }

    public override string GetStringRepresentation()
    {
        if (isComplete())
        {
            return $"[X],{GetName()},{GetDescription()},{GetPoints()}";
        }
        
        else {
            return $"[ ],{GetName()},{GetDescription()},{GetPoints()}";
        }  
    }
}