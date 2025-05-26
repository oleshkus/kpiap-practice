namespace Task4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 1 && x < 2)
            {
                y = Math.Pow(x - 2, 2) + 6;
            }
            else if (x >= 2)
            {
                y = Math.Log(x + 3 * Math.Sqrt(x));
            }
            else
            {
                Console.WriteLine("x вне области определения функции.");
                return;
            }
            Console.WriteLine($"y = {y:F5}");
        }
    }
}