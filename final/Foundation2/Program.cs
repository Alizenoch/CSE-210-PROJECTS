class Program
{
    static void Main()
    { 
        // Create sample address and customer
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var customer1 = new Customer("Alison H", address1);

        // Create sample products

        var product1 = new Product("Dell laptop", 101, 3.50m, 5);
        var product2 = new Product("Chuwi laptop", 102, 2.75m, 10);

        // Create an order

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display results

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price:{order1.CalculateTotalPrice():C}");
        
    }
}