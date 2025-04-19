namespace task1;

class Program
{
    static void Main(string[] args)
    {
        A a = new A(5, 10);
        Console.WriteLine(a.equation());
        Console.WriteLine(a.square());
    }
}