namespace ConsoleApp1;

class City : Settlement
{
    private readonly int _numberOfResidents;
    private readonly double _area;

    public City(string name, int numberOfResidents, double area)
        : base(name)
    {
        this._numberOfResidents = numberOfResidents;
        this._area = area;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название города: {Name}, Количество жителей: {_numberOfResidents}, Площадь: {_area}");
    }
}