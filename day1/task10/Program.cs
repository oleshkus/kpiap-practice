namespace task10;

class Program
{
    static void Main(string[] args)
    {
        var num = Int32.Parse(Console.ReadLine());
        Console.WriteLine(DeleteOddNumbers(num));
    }

    static long DeleteOddNumbers(long num)
    {
        var stringNum = num.ToString();
        string finalNum = "";
        foreach (var bukva in stringNum)
        {
            if ((int)bukva % 2 != 0)
            {
                finalNum += bukva;
            }
        }

        return Int16.Parse(finalNum);
    }
    
}