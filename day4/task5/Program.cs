namespace task5;

class Program
{
    static void Main(string[] args)
    {
        Train train = new Train("Grodno", "518g49cs20", "2025-04-19");
        Console.WriteLine($"{train.Destination}");
        Console.WriteLine($"{train.Id}");
        Console.WriteLine($"{train.DepartureTime}");
    }
}