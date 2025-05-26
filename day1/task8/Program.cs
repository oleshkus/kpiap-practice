namespace task8;

class Program
{
    static void Main(string[] args)
    {
        var a = Int32.Parse(Console.ReadLine());
        var b = Int32.Parse(Console.ReadLine());
        int c = 0;
        if (1 <= a || b <= 100)
        {
            for (int i = a; i <= b; i++)
            {
                c = i + c;
                Console.Write(c + " ");
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException("Incorrect data");
        }   
    }
}