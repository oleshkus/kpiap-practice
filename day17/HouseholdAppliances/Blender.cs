namespace HouseholdAppliances;

public class Blender: Technique
{
    public int Speed { get; set; }
    public int Volume { get; set; }
    
    public Blender(string name, string manufacturer, double power, double weight, double price, int speed, int volume)
    {
        Name = name;
        Manufacturer = manufacturer;
        Power = power;
        Weight = weight;
        Price = price;
        Speed = speed;
        Volume = volume;
    }
}