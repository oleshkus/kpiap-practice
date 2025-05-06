namespace HouseholdAppliances;

public abstract class Technique
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public double Power { get; set; }
    public double Weight { get; set; }
    public double Price { get; set; }
}