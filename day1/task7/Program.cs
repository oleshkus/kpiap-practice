namespace Task7
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            double n = double.Parse(Console.ReadLine());

            try
            {
                double z1 = CalculateZ1(m, n);
                double z2 = CalculateZ2(m, n);
                Console.WriteLine($"z1 = {z1:F5}");
                Console.WriteLine($"z2 = {z2:F5}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Вычисляет значение z1 по формуле:
        /// z1 = ((m-1)*sqrt(m) - (n-1)*sqrt(n)) / sqrt(m^3*n + n*m^2 - m)
        /// </summary>
        static double CalculateZ1(double m, double n)
        {
            double numerator = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n);
            double denominator = Math.Sqrt(Math.Pow(m, 3) * n + n * Math.Pow(m, 2) - m);
            if (denominator == 0)
                throw new ArgumentException("Знаменатель равен нулю в формуле z1.");
            return numerator / denominator;
        }

        /// <summary>
        /// Вычисляет значение z2 по формуле:
        /// z2 = (sqrt(m) - sqrt(n)) / m
        /// </summary>
        static double CalculateZ2(double m, double n)
        {
            if (m == 0)
                throw new ArgumentException("m не должно быть равно нулю в формуле z2.");
            return (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        }
    }
}