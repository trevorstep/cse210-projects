using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Chat GPT wrote the addresses,  and helped me muscle through the "writeline"s because I couldnt seem to call them right, but we got there!

        Address address1 = new Address("346 Broadway St", "Idaho Falls", "ID", "USA");
        Address address2 = new Address("456 CN Tower St", "Toronto", "ON", "Canada");
        Address address3 = new Address("357 LDS Lane", "South Royalton", "Vermont", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Joseph Smith", address3);

        Product product1 = new Product("Wire", 1015598782, 3.99, 5);
        Product product2 = new Product("Outlet Cover", 1025598876, 9.99, 2);
        Product product3 = new Product("Wirecutters", 1035594876, 5.99, 3);

        Order order1 = new Order();
        order1.Customer = customer1;
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order();
        order2.Customer = customer2;
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order();
        order3.Customer = customer3;
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine();

        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");

        Console.WriteLine();

        Console.WriteLine(order3.GeneratePackingLabel());
        Console.WriteLine(order3.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost():0.00}");
    }
}