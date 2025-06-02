using System;

class Program
{
    static void Main(string[] args)
    {
        var product1 = new Product("Television", "P001", 1600, 1);
        var product2 = new Product("Fan", "P002", 65, 2);
        var product3 = new Product("Speaker", "P003", 80, 1);

        var address = new Address("35 main St", "California", " CA", "USA");
        var customer = new Customer("Richard Moore", address);

        var order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order.CalculateTotalCost()}");
    }
}