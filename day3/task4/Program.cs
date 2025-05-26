namespace task4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 5;
        int b = 4;
        int c = 3;

        Console.WriteLine(Mult(a, b, c));
        Console.WriteLine(Mult(a, b));
    }

    /// <summary>
    /// Сделал без перегрузки, так как это прикольнее
    /// </summary>
    /// <param name="args"></param>
    /// <returns>int</returns>
    static int Mult(params int[] args)
    {
        int result = 1;
        foreach (var arg in args)
        {
            result *= arg;
        }

        return result;
    }
}