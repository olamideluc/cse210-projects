class Running : Activity
{
    private double _distance;
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;

    public override double GetSpeed() => _distance / (base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / 60);

    public override double GetPace() => base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / _distance;

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running: Distance {GetDistance()} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.2f} min/km";
    }
}