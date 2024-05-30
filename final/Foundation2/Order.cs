class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;
        foreach(var product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        // Add shipping cost based on customers location
        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        // Create a packing label with product names and ids
        string packingLabel = "Packing Label:\n";
        foreach(var product in _products)
        {
          packingLabel +=$"{product.CalculateTotalCost():C}-{product.name}(ID:{product.productID})\n";
        }
        return packingLabel;
        
    }

    public string GetShippingLabel()
    {
        // Create a shipping label with customer name and address.
        return $"Shipping Label:\n {Customer.name}\n{Customer.CustomerAddress}";
    }
}