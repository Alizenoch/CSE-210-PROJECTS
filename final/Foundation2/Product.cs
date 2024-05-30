class Product
{
    private string Name { get; }
    private int ProductId { get; }
    private decimal PricePerUnit { get; }
    private int Quantity { get; }

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}