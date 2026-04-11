public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent() { /* Never ends, just adds points */ }
    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}