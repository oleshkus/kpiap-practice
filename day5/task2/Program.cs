using System;

namespace Task2
{
    public class OutOfRangeException : Exception
    {
        public OutOfRangeException(string message) : base(message) { }
    }

    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());
                double result = CalculateFunction(x);
                Console.WriteLine($"f(x) = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format!");
            }
            catch (OutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        private static double CalculateFunction(double x)
        {
            if (x > -2 && x < 5)
            {
                if (x == 5)
                    throw new DivideByZeroException("Division by zero in expression 3x/(x-5)!");
                return 3 * x / (x - 5);
            }
            else if (x > 5)
            {
                return x - 1;
            }
            else
            {
                throw new OutOfRangeException("x is out of the valid range (-2, +∞)!");
            }
        }
    }
}