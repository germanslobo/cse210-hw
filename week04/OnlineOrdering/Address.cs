namespace OnlineOrdering;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Returns true if the country is USA or United States (case-insensitive)
    public bool IsInUsa()
    {
        string countryLower = _country.Trim().ToLower();
        return countryLower == "usa" || countryLower == "united states" || countryLower == "us";
    }

    // Returns all address fields formatted with newlines
    public string GetFormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}