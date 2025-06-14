class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        return (_amountCompleted == _target) ? _points + _bonus : _points;
    }
    public override bool IsComplete() => _amountCompleted >= _target;
}