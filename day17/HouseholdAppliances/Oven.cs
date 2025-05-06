namespace HouseholdAppliances;

public class Oven: Technique
{
    public int Temperature { get; set; }
    public int Speed { get; set; }
    public int Volume { get; set; }

    public Oven(string name, string manufacturer, double power, double weight, double price, int temperature, int speed, int volume)
    {
        Name = name;
        Manufacturer = manufacturer;
        Power = power;
        Weight = weight;
        Price = price;
        Temperature = temperature;
        Speed = speed;
        Volume = volume;
    }
}