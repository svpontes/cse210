// The Customer class represents a customer, containing a name and an address.
// It provides methods to determine if the customer lives in the USA and to generate a shipping label.
public class Customer
{
    private string _name; // Customer name
    private Address _address; // Customer address (stored as an Address object)

    // Constructor initializes the customer with a name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Returns the customer's name
    public string GetName()
    {
        return _name;
    }

    // Determines if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA(); // Calls the IsInUSA() method from the Address class
    }

    // Generates and returns a shipping label containing the customer's details
    public string GetShippingLabel()
    {
        return $"Customer: {_name}\n{_address.GetFullAddress()}"; // Format the shipping label
    }
}
