using System;
using System.Net.Sockets;


public class Customer 
{
    private string _customer;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customer = customerName;
        _address = address;
    }

    public bool GetUsa()
    {
        return _address.TrueUsa();
    }

    public string GetCustomerName()
    {
        return _customer;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }
}