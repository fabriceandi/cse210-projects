using System;
using System.Reflection.Metadata;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public string CompleteAddress()
    {
        string address = $"{_street}\n{_city}\n{_stateProvince}\n{_country}";
        return address;
    }
    public bool InUsaOrNot()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}