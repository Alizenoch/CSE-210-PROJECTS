class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new Running { _date = new DateTime(2022, 11, 3), _minutes = 30, _distance = 4.8 },
            new Cycling { _date = new DateTime(2022, 11, 4), _minutes = 45, _speed = 20 },
            new Swimming { _date = new DateTime(2022, 11, 5), _minutes = 60, _laps = 20 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}