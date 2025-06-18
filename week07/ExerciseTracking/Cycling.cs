class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance() => _speed * (base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / 60);

    public override double GetSpeed() => _speed;

    public override double GetPace() => base.GetSummary().Split(" ")[1].Replace("(", "").Replace("min)", "")[0] / GetDistance();

    public override string GetSummary()
    {
       return $"{base.GetSummary()} Cycling: Distance {GetDistance():0.1f} km, Speed {GetSpeed():0.1f} kph, Pace {GetPace():0.2f} min/km"; 
    }
}