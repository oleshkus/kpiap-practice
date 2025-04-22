namespace Task5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = ReadIntFromConsole();
        double result = CalculateF(n);
        Console.WriteLine($"f({n}) = 1/({n}+3)! = {result}");
    }

    /// <summary>
    /// Вычисляет f(n) = 1/(n+3)! рекурсивно.
    /// </summary>
    private static double CalculateF(int n)
    {
        return 1.0 / Factorial(n + 3);
    }

    /// <summary>
    /// Рекурсивно вычисляет факториал числа.
    /// </summary>
    private static long Factorial(int number)
    {
        if (number <= 1)
            return 1;
        return number * Factorial(number - 1);
    }

    /// <summary>
    /// Безопасно читает целое число с консоли.
    /// </summary>
    private static int ReadIntFromConsole()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                return value;
            }
            Console.Write("Ошибка ввода. Повторите попытку: ");
        }
    }
}