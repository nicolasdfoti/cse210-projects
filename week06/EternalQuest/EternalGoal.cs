public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"{GetName()} - +{GetPoints()}");
    }

    public override bool isComplete()
    {
        return false;
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
        return $"[ ],{GetName()},{GetDescription()},{GetPoints()}";
    }
}