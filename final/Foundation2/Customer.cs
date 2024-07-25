using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address Address)
    {
        _name = name;
        _address = Address;
    }

     public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.CompleteAddress();
    }
    public bool UsaOrOutside()
    {
        return _address.InUsaOrNot();
    }
}