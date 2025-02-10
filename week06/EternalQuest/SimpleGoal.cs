public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {GetName()}, {GetDescription()}");
        }

        else
        {
            Console.WriteLine($"[ ] {GetName()}, {GetDescription()}");
        }
    }

}