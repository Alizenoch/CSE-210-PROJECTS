using System;

public abstract class Activity
{
    protected DateTime _date { get; set; }
    protected double _minutes { get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}