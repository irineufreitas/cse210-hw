using System;

public class Address 
{
    private string _streetaddress;
    private string _city;
    private string _state;

    private string _country;

    public Address (string streetAddress, string city, string state, string country)
    {
        _streetaddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool TrueUsa()
    {
        
        return _country.ToLower()=="usa";
    }


    public string GetAddress()
    {
        if (TrueUsa())
        {
            return $"Address: {_streetaddress}, {_city} {_state}, USA";
        }
        else
        {
            return $"Address: {_streetaddress}, {_city}\n{_state}, {_country}";
        }
        
    }

    

}