class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance() => _laps * 50 / 1000.0; 

    public override double GetSpeed() => GetDistance() / (base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / 60);

    public override double GetPace() => base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / GetDistance();

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming: Distance {GetDistance():0.2f} km, Speed {GetSpeed():0.1f} kph, Pace {GetPace():0.2f} min/km";
    }
    

    
}