abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public string GetName() => _shortName;

    public virtual string GetDetailsString() => $"{_shortName}: {_description} ({_points} points)";
    public virtual string GetStringRepresentation() => $"{_shortName},{_description},{_points}";

}