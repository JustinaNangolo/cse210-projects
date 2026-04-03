using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Hello Lane", "California", "CA", "USA");
        Customer customer1 = new Customer("Brother Henry", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mac book Keyboard", "MBK-77", 35.00, 1));
        order1.AddProduct(new Product("Macbook Charger", "MacC-09", 29.50, 2));

        // Order 2: International Customer
        Address address2 = new Address("412 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Justina Daniel", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("HDMI Cable", "HDMI-01", 15.00, 1));
        order2.AddProduct(new Product("Phone Case", "PC-02", 12.00, 1));
        order2.AddProduct(new Product("Iphone charger", "IC-05", 24.99, 1));

        // Display results
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine(new string('-', 30));
    }
}