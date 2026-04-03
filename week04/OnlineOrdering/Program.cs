using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Llama Lane", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Brother Burton", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mechanical Keyboard", "KBD-77", 85.00, 1));
        order1.AddProduct(new Product("USB-C Hub", "USB-09", 15.50, 2));

        // Order 2: International Customer
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Gaming Mouse", "MSE-01", 45.00, 1));
        order2.AddProduct(new Product("Mouse Pad", "PAD-02", 12.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "STD-05", 29.99, 1));

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