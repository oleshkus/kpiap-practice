namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        var randNum = random.Next(1000, 9999).ToString();
        Console.WriteLine(randNum);
        var newNum = $"{randNum[1]}{randNum[0]}{randNum[3]}{randNum[2]}";
        if (double.TryParse(newNum, out var result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}