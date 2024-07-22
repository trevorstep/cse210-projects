using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double DomesticShippingCost = 5;
    private const double InternationalShippingCost = 35;

    public Order()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> Products
    {
        get { return _products; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

 public double CalculateTotalCost()
{
    double productPartTotal = _products.Sum(p => p.costOfGoods * p.quantity);
    double productTotal;

    if (_customer.LivesInUSA())
    {
        productTotal = productPartTotal + DomesticShippingCost;
    }
    else
    {
        productTotal = productPartTotal + InternationalShippingCost;
    }
    return productTotal;
}


    public string GeneratePackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.productID})\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        string address = _customer.Address.ToString();
        string label = $"Shipping Label:\n{_customer.Name}\n{address}\n";
        return label;
    }
}