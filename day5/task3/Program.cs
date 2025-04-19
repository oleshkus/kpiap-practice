using System;

namespace Task3
{
    public class Program
    {
        /// <summary>
        /// Assigns the minimum of x and y to x, and the maximum to y.
        /// </summary>
        private static void Minmax(ref double x, ref double y)
        {
            if (x > y)
            {
                double temp = x;
                x = y;
                y = temp;
            }
        }

        public static void Main()
        {
            try
            {
                Console.Write("Enter A: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter C: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter D: ");
                double d = double.Parse(Console.ReadLine());

                // Первый этап: попарно сравниваем (A, B) и (C, D)
                Minmax(ref a, ref b); // a=min(a,b), b=max(a,b)
                Minmax(ref c, ref d); // c=min(c,d), d=max(c,d)

                // Второй этап: сравниваем минимумы и максимумы
                Minmax(ref a, ref c); // a=min(a,c), c=max(a,c)
                Minmax(ref b, ref d); // b=min(b,d), d=max(b,d)

                // Теперь: a — минимальное, d — максимальное
                Console.WriteLine($"Minimum: {a}");
                Console.WriteLine($"Maximum: {d}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}