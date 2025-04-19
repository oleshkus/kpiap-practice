using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите h: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите начальное значение x (от a): ");
            double xStart = double.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение x (до b): ");
            double xEnd = double.Parse(Console.ReadLine());

            Console.WriteLine("\n  x\t\t f(x)");
            Console.WriteLine("---------------------");
            for (double x = xStart; x <= xEnd; x += h)
            {
                double y = CalculateFunction(x, a, b);
                Console.WriteLine($"{x,6:F2}\t {y,10:F5}");
            }
        }

        /// <summary>
        /// Вычисляет значение функции по условию задачи.
        /// </summary>
        public static double CalculateFunction(double x, double a, double b)
        {
            if (2 * x < 0)
            {
                return a + b * x;
            }
            else if (2 * x <= 5)
            {
                return (a * x != 0) ? b * x / (a * x) : double.NaN;
            }
            else
            {
                return Math.Log(b * x) + Math.Sin(a * x);
            }
        }
    }
}