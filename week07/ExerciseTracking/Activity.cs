abstract class Activity
{
    private string _date;
    private int _duration; // Duration in minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} ({_duration} min)";
    }
}