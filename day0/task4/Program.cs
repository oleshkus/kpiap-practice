namespace Task4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Пример: a = 7, b = 8, c = 9
            double a = 7, b = 8, c = 9;
            try
            {
                double height = CalculateHeight(a, b, c);
                Console.WriteLine($"Высота, опущенная на сторону a = {a}: h = {height}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Вычисляет высоту треугольника, опущенную на сторону a, по известным сторонам a, b, c.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns>Высота h</returns>
        static double CalculateHeight(double a, double b, double c)
        {
            // Проверка существования треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с такими сторонами не существует.");

            // Полупериметр
            double p = (a + b + c) / 2;
            // Площадь по формуле Герона
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            // Высота на сторону a
            double h = 2 * area / a;
            return h;
        }
    }
}