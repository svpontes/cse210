// The Address class represents a physical address with street, city, state/province, and country.
// It provides methods to check if the address is in the USA and to return the full address as a formatted string.
public class Address
{
    private string _street; // Street address
    private string _city; // City name
    private string _stateProvince; // State or province name
    private string _country; // Country name

    // Constructor initializes the address with given details
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Checks if the address is located in the USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA"; // Converts country name to uppercase for case-insensitive comparison
    }

    // Returns the full address formatted as a string with newline characters
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}"; // Formats the address with line breaks
    }
}