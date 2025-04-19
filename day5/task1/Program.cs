using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());

                // Expression: y = sin^3(x) / x^3
                double numerator = Math.Pow(Math.Sin(x), 3);
                double denominator = Math.Pow(x, 3);

                double y = numerator / denominator;

                Console.WriteLine($"Value of expression: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero!");
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