namespace Task3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Values of x to evaluate
            double[] xValues = { 1, 3 };
            foreach (var x in xValues)
            {
                try
                {
                    double y = CalculateExpression(x);
                    Console.WriteLine($"x = {x}, y = {y}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"x = {x}: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Calculates the value of the expression:
        /// y = 2 * arctg(sqrt(1 - x^2)) + ln(7x) / (1 + e^x)
        /// </summary>
        /// <param name="x">Input value</param>
        /// <returns>Result of the expression</returns>
        static double CalculateExpression(double x)
        {
            // Check if sqrt(1 - x^2) is valid
            double sqrtArg = 1 - x * x;
            if (sqrtArg < 0)
            {
                throw new ArgumentException($"sqrt(1 - x^2) is not defined for x = {x}");
            }
            double sqrtValue = Math.Sqrt(sqrtArg);
            double arctgValue = Math.Atan(sqrtValue);
            double lnValue = Math.Log(7 * x);
            double expValue = Math.Exp(x);
            double y = 2 * arctgValue + lnValue / (1 + expValue);
            return y;
        }
    }
}