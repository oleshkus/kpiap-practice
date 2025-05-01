namespace ConsoleApp1;
class Village : Settlement
{
    private readonly int _numberOfHouses;
    private readonly int _population;

    public Village(string name, int numberOfHouses, int population)
        : base(name)
    {
        this._numberOfHouses = numberOfHouses;
        this._population = population;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название села: {Name}, Количество домов: {_numberOfHouses}, Население: {_population}");
    }
}