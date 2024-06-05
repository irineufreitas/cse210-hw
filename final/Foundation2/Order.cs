using System;

public class Order {
    
    private Customer _customer;
    private List<Product> _productlist = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _productlist.Add(product);
    }
    public double SumTotal()
    {
        double sumTotal = 0;


        foreach (var product in _productlist)
        {
            sumTotal += product.ProductTotalCost();
        }

        int shipping = 0;

        if (_customer.GetUsa())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        

        return sumTotal + shipping;
    }


    public string PackingLabel()
    {

        string packingLabel = "Packing List:\n";

        foreach (var product in _productlist)
        {
            packingLabel += $"Product: {product.GetProductName()}, ProductId: {product.GetProductId()}, Quantity:{product.GetQuantity()} Price:${product.GetPrice()}\n";
            
        } 

        return packingLabel;
    }

    

    public string ShippingLabel()
    {
        return $"Customer: {_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }

   
}