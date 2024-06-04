public class Swimming : Activity
{
    private int _laps { get; set; } // number of laps

    public override double GetDistance() => _laps * 50.0 / 1000; // in km
    public override double GetSpeed() => (GetDistance() / _minutes) * 60; // in kph
    public override double GetPace() => _minutes / GetDistance(); // in min per km
}
