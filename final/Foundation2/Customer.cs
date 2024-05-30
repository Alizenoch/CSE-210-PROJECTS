class Customer
{
    private string _name;
    private Address _customerAddress;
    internal static object name;

    public static object CustomerAddress { get; internal set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _customerAddress = address;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }
}