namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(0, 0, 5);
        Console.WriteLine($"\nКруг с центром в (0,0) и радиусом 5");
        Console.WriteLine($"Площадь: {circle.GetArea():F2}");
        Console.WriteLine($"Длина окружности: {circle.GetCircumference():F2}");
        Console.WriteLine($"Точка (3,4) внутри круга? {circle.ContainsPoint(3, 4)}");
        Console.WriteLine($"Точка (6,0) внутри круга? {circle.ContainsPoint(6, 0)}");
    }
}