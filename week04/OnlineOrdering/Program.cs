using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Scenario: produce packing labels, shipping labels, and compute final prices for billing.
        // The program contains classes for Product, Customer, Address, and Order.

        // Create an address instance
        Address address1 = new Address("123 Main St", "Murray", "SLC", "USA");

        // Create a customer instance using the address
        Customer customer1 = new Customer("John Smith", address1);

        // Create product instances with name, ID, price, and quantity
        Product product1 = new Product("Laptop", 101, 1200.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        
        // Create an order for the customer
        Order order1 = new Order(customer1);
        
        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Print packing label
        Console.WriteLine(order1.GetPackingLabel());
        
        // Print shipping label
        Console.WriteLine(order1.GetShippingLabel());
        
        // Print total cost of the order, formatted to two decimal places
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
    }
}