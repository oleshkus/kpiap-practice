namespace HouseholdAppliances;

public class WashingMachine: Technique
{
    public int MaxLoad { get; set; }
    public int MaxSpinSpeed { get; set; }
    public int MaxTemperature { get; set; }

    public WashingMachine(string name, string manufacturer, double power, double weight, double price, int maxLoad, int maxSpinSpeed, int maxTemperature)
    {
        Name = name;
        Manufacturer = manufacturer;
        Power = power;
        Weight = weight;
        Price = price;
        MaxLoad = maxLoad;
        MaxSpinSpeed = maxSpinSpeed;
        MaxTemperature = maxTemperature;
    }
}