public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (isComplete())
        {
            Console.WriteLine($"Congratulations! You completed '{GetName()}' and earned {GetPoints()+ _bonus} points!");
        }

        else 
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()}");
        }
    }

    public override bool isComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else 
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (isComplete())
        {
            return $"[X] {GetName()} - {GetDescription()} - {_amountCompleted}/{_target} times completed.";
        }

        else
        {
            return $"[ ] {GetName()} - {GetDescription()} - {_amountCompleted}/{_target} times completed.";
        }
        
    }

    public override string GetStringRepresentation()
    {
        if (isComplete())
        {
            return $"[X],{GetName()},{GetDescription()},{GetPoints()}";
        }
        
        else {
            return $"[ ],{GetName()},{GetDescription()},{GetPoints()},{_amountCompleted}/{_target}";
        } 
    }

}