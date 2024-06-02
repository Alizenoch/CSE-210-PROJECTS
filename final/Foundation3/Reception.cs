// Derived ReceptionEvent class
class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address,
                          string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public  string  ReceptionEventGetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}