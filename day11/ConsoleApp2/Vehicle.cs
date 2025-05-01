namespace ConsoleApp2;

abstract class Vehicle
{
    protected string _name;
    protected double FuelConsumption; 

    public Vehicle(string name, double fuelConsumption)
    {
        this._name = name;
        this.FuelConsumption = fuelConsumption;
    }

    protected string Name
    {
        get => _name;
        set => _name = value;
    }

    public abstract void DisplayInfo();

    public double GetFuelConsumption()
    {
        return FuelConsumption;
    }
}