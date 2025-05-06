using HouseholdAppliances;

namespace Lab16;
using HouseholdAppliances;

class Program
{
    static void Main(string[] args)
    {
        // Household Appliance
        var technique = new WashingMachine("WashingMachine", "LG", 2000, 100, 500, 5, 1000, 90);

        Console.WriteLine($"Technique: {technique.Name}");
        Console.WriteLine($"Manufacturer: {technique.Manufacturer}");
        Console.WriteLine($"Power: {technique.Power}");
        Console.WriteLine($"Weight: {technique.Weight}");
        Console.WriteLine($"Price: {technique.Price}");
        Console.WriteLine($"MaxLoad: {technique.MaxLoad}");
        Console.WriteLine($"MaxSpinSpeed: {technique.MaxSpinSpeed}");
        Console.WriteLine($"MaxTemperature: {technique.MaxTemperature}");
    }

}