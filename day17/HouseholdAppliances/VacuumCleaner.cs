namespace HouseholdAppliances;

public class VacuumCleaner: Technique
{
    public int DustContainerVolume { get; set; }
    public int NoiseLevel { get; set; }
    
    public VacuumCleaner(string name, string manufacturer, double weight, double price, int power, int dustContainerVolume, int noiseLevel)
    {
        Name = name;
        Manufacturer = manufacturer;
        Power = power;
        Weight = weight;
        Price = price;
        Power = power;
        DustContainerVolume = dustContainerVolume;
        NoiseLevel = noiseLevel;
    }
}