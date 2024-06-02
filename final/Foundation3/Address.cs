// Address class
class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _zipCode;

    public  string GetToString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}