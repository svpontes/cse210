// The Order class represents a customer's order, containing a list of products and customer details.
// It provides methods to calculate the total cost, generate a packing label, and generate a shipping label.
public class Order
{
    // List to store the products in the order
    private List<Product> _products = new List<Product>();
    
    // Customer associated with the order
    private Customer _customer;

    // Constructor initializes the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Adds a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates the total cost of the order, including shipping
    public double GetTotalCost()
    {
        double total = 0; // Variable to store the total cost
        
        // Iterate over each product and sum up its total cost
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        
        // Determine the shipping cost based on the customer's location
        total += _customer.LivesInUSA() ? 5 : 35; // If in USA, shipping is $5, otherwise $35
        
        return total; // Return the final total cost
    }

    // Generates a packing label listing all products with their IDs
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n"; // Initialize label string
        
        // Iterate over each product and append its details
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        
        return label; // Return the packing label string
    }

    // Generates a shipping label containing the customer's details
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}"; // Return formatted shipping label
    }
}