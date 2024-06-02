// Derived OutdoorEvent class
class OutdoorEvent : Event
{
    private string _weatherStatement;

    public OutdoorEvent(string title, string description, DateTime date, TimeSpan time, Address address,
                        string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public  string OutdoorEventGetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {_weatherStatement}";
    }
}
