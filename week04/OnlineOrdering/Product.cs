using System;
public class Product
//name, product id, price, and quantity of each product.
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double TotalCost()
    {
        double _total = _price * _quantity;
        return _total;
    }
}