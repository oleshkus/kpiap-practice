namespace Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        var array = new int[5];
        var random = new Random();
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
            Console.WriteLine(array[i]);
        }

        foreach (var element in array)
        {
            if (element > 0)
            {
                Console.WriteLine($"{element} > 0");
            }
        }

        Console.WriteLine($"{array.Length} - Array length");
    }
}