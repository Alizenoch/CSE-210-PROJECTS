public class Cycling : Activity
{
    private double _speed { get; set; } // in kph

    public override double GetDistance() => (_speed / 60) * _minutes;
    public override double GetSpeed() => _speed;
    public override double GetPace() => _minutes / GetDistance();
}




