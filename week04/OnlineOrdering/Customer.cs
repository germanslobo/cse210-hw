namespace OnlineOrdering;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;

    // Asks the Address class if the customer lives in the USA
    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
}