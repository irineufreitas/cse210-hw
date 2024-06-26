using System;

public class Product {

    private string _productname;
    private int _productid;
    private double _price;
    private int _quantity;

    public Product(string product, int id, double price, int quantity)
    {
        _productname = product;
        _productid = id;
        _price = price;
        _quantity = quantity;
    }


    public double ProductTotalCost()
    {
        return _price * _quantity;
        
    }

    public int GetProductId()
    {
        return _productid;
    }

    public string GetProductName()
    {
        return _productname;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }
    
}