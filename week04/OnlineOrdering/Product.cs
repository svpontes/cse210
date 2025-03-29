// The Product class represents an individual product with attributes like name, ID, price, and quantity.
public class Product
{
    // Product attributes
    private int _id; // Product ID
    private string _name; // Product name
    private double _price; // Price per unit
    private int _quantity; // Quantity of the product

    // Constructor initializes the product with given details
    public Product(string name, int id, double price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    // Returns the product ID
    public int GetId()
    {
        return _id;
    }

    // Returns the product name
    public string GetName()
    {
        return _name;
    }

    // Returns the product price
    public double GetPrice()
    {
        return _price;
    }

    // Returns the product quantity
    public int GetQuantity()
    {
        return _quantity;
    }

    // Calculates and returns the total cost of this product (price * quantity)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}