class Product
{
    private string _name
    private int _productId; 
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public object name { get; internal set; }
    public object productID { get; internal set; }

    public decimal CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}