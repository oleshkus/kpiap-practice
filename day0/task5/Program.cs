namespace Task5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади поверхности цилиндра.");
            Console.Write("Введите исходные данные:\nРадиус основания (см) -> ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Высота цилиндра (см) -> ");
            double height = double.Parse(Console.ReadLine());

            double surfaceArea = CalculateCylinderSurfaceArea(radius, height);
            Console.WriteLine($"Площадь поверхности цилиндра: {surfaceArea:F2} кв.см.");
        }

        /// <summary>
        /// Вычисляет площадь полной поверхности цилиндра.
        /// </summary>
        /// <param name="radius">Радиус основания цилиндра</param>
        /// <param name="height">Высота цилиндра</param>
        /// <returns>Площадь поверхности цилиндра</returns>
        static double CalculateCylinderSurfaceArea(double radius, double height)
        {
            // S = 2πr^2 + 2πrh
            return 2 * Math.PI * radius * (radius + height);
        }
    }
}