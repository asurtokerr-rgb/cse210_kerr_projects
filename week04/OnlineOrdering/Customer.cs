using System;
public class Customer
{
    private string _name;
    private Address _fullAddress;

    public Customer(string name, Address fullAddress)
    {
        _name = name;
        _fullAddress = fullAddress;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _fullAddress;
    }
    public bool LivesInUSA()
    {
        return _fullAddress.IsInUSA();
    }
}
