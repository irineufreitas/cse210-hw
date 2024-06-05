using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your Cart!\n");

        Product product1 = new Product("Coke Lemon", 004, 2.45 , 3);
        Product product2 = new Product("Whey Protein", 003, 35.6, 2);
        Product product3 = new Product("Italian Grapes", 002, 3.50, 2);

        Address address1 = new Address("114 Rising Clouds", "Provo", "Utah", "USA");
        Address address2 = new Address("38 Clock Wise", "London", "London", "UK");

        Customer customer1 = new Customer("Eliashar Green", address1);
        Customer customer2 = new Customer("Sarah Voss", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product1);


        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        Console.WriteLine("Order 1 Details:\n");
        Console.WriteLine($"Totals: ${order1.SumTotal()}");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Shipping to USA - $5");

        Console.WriteLine("<-------->");

        Console.WriteLine("Order 2 Details:\n");
        Console.WriteLine($"Totals: ${order2.SumTotal()}");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Shipping to UK - $35");



    }
}