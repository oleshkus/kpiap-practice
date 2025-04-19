namespace Task5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (!IsTriangleExists(a, b, c))
            {
                Console.WriteLine("Треугольник с такими сторонами не существует.");
                return;
            }

            bool isIsosceles = a == b || b == c || a == c;
            Console.WriteLine(isIsosceles
                ? "Треугольник равнобедренный."
                : "Треугольник не равнобедренный.");
        }

        /// <summary>
        /// Проверяет существование треугольника по неравенству треугольника.
        /// </summary>
        static bool IsTriangleExists(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}