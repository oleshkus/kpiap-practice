namespace Task1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            double b = double.Parse(Console.ReadLine());

            double perimeter = CalculatePerimeter(a, b);
            double diagonal = CalculateDiagonal(a, b);

            Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
            Console.WriteLine($"Длина диагонали: {diagonal:F2}");
        }

        /// <summary>
        /// Вычисляет периметр прямоугольника.
        /// </summary>
        static double CalculatePerimeter(double a, double b)
        {
            return 2 * (a + b);
        }

        /// <summary>
        /// Вычисляет длину диагонали прямоугольника.
        /// </summary>
        static double CalculateDiagonal(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
}