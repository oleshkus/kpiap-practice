namespace ConsoleApp1;

class Product
{
    private readonly int _quantity;
    private readonly double _price;

    public Product(int quantity, double price)
    {
        this._quantity = quantity;
        this._price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public virtual double Cost()
    {
        return _quantity * _price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"количество: {_quantity}, цена: {_price}");
    }
}