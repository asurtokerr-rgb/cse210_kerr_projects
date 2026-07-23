using System;
using System.Collections.Generic;

public class Address
// street address, the city, state/province, and country.
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

    public string GetCompleteAddress()
    {
        string completeAddress = $"{_street}, {_city}, {_stateProvince}, {_country}";
        return completeAddress;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA" || _country.Trim().ToUpper() == "UNITED STATES";
    }

}