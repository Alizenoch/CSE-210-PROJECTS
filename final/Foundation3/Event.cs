using System;

// Base Event class
class Event
{
    // Common attributes
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _eventAddress;
    

    //Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, object address1, string v, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventAddress = address;
    }

    

    // Method to return standard details
    public  string GetStandardDetails()
    {
        return $"Event: {_title}\nDate: {_date.ToShortDateString()} at {_time}";
    }

    // Method to return full details
    public  string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nDescription: {_description}\nAddress: {_eventAddress}";
    }

    // Method to return short description
    public  string GetShortDescription()
    {
        return $"Event Type: Generic\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}





