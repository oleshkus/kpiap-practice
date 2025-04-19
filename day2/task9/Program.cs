namespace Task9
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.PI / 8;
            double b = 2 / Math.PI;
            int m = 15;
            double h = (b - a) / m;

            Console.WriteLine($"Табулирование функции y = sin(1/x) на [{a:F5}, {b:F5}] с шагом {h:F5} (M={m}):");
            Console.WriteLine($"{"№",-3} {"x",15} {"y",15}");
            for (int i = 0; i <= m; i++)
            {
                double x = a + i * h;
                double y = Math.Sin(1 / x);
                Console.WriteLine($"{i+1,-3} {x,15:F7} {y,15:F7}");
            }
        }
    }
}