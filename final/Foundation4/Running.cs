public class Running : Activity
{
    private double _distance { get; set; } // in km

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / _minutes) * 60;
    public override double GetPace() => _minutes / _distance;
}