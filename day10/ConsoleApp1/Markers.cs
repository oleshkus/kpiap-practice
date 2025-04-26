namespace ConsoleApp1;

class Markers : Product
{
    private readonly string _name;
    private readonly int _grade;

    public Markers(int quantity, double price, string name, int grade)
        : base(quantity, price)
    {
        this._name = name;
        this._grade = grade;
    }

    public override double Cost()
    {
        return base.Cost() / Math.Sqrt(_grade);
    }

    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"название: {_name}, сорт: {_grade}");
    }
}