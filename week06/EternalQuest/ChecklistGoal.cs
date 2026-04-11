public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        
        return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public int GetBonus() => _bonus;
}