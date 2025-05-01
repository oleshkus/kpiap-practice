using System;
namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        Settlement[] settlements = new Settlement[5];

        settlements[0] = new Village("Село А", 50, 200);
        settlements[1] = new City("Город Б", 100000, 150.5);
        settlements[2] = new Village("Село В", 30, 120);
        settlements[3] = new City("Город Г", 250000, 300.75);
        settlements[4] = new Village("Село Д", 40, 150);

        Console.WriteLine("Информация о населённых пунктах:");
        foreach (var settlement in settlements)
        {
            settlement.DisplayInfo();
        }
    }
}