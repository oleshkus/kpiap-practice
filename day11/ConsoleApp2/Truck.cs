namespace ConsoleApp2;

class Truck : Vehicle
{
    private readonly double _loadCapacity;

    public Truck(string name, double fuelConsumption, double loadCapacity)
        : base(name, fuelConsumption)
    {
        this._name = name;
        this.FuelConsumption = fuelConsumption;
        this._loadCapacity = loadCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Грузовик: {_name}, Расход топлива: {FuelConsumption} л/100 км, Грузоподъемность: {_loadCapacity} т");
    }
}