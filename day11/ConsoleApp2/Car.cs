namespace ConsoleApp2;
class Car : Vehicle
{
    private readonly int _numberOfDoors;
    
    public Car(string name, double fuelConsumption, int numberOfDoors)
        : base(name, fuelConsumption)
    {
        this._name = name;
        this.FuelConsumption = fuelConsumption;
        this._numberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Автомобиль: {_name}, Расход топлива: {FuelConsumption} л/100 км, Количество дверей: {_numberOfDoors}");
    }
}