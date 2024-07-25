using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer Customer)
    {
        _customer = Customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateTotal()
    {
        double sum = 0;
        double shippingCost = 0;
        foreach(Product p in _products)
        {
            double totalCost = p.TotalCost();
            sum += totalCost;
        }
        if (_customer.UsaOrOutside() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double totalPrice = sum + shippingCost;

        return totalPrice;
    }
    public string PackingLabel()
    {
        string text = "";
        foreach(Product p in _products)
        {
            text += $"{p.GetProductId()} {p.GetName()}\n";
        }
        return text;
    }
    public string ShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress()}";

        return shippingLabel;
    }
}