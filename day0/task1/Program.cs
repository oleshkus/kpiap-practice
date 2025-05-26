namespace task1;

class Program
{
    static void Main()
    {
        var a = Convert.ToDouble(Console.ReadLine());
        var b = Convert.ToDouble(Console.ReadLine());
        var c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"({a:F4}+({b:F4}+{c:F4}))=({a:F4}+{b:F4}+{c:F4})");
    }
}