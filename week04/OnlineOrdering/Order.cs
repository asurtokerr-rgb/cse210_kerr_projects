using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return total + shippingCost;
    }
    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            if (product.GetQuantity() > 2)
            {
                label += $"Item: {product.GetName()} (ID: {product.GetProductId()}) x{product.GetQuantity()}\n";
            }
            else
            {
                label += $"Item: {product.GetName()} (ID: {product.GetProductId()}) x{product.GetQuantity()}\n";
            }
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"{_customer.GetName()}\n{_customer.GetAddress().GetCompleteAddress()}\n";
        return label;
    }

}