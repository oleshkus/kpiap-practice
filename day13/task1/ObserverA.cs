namespace task1;

public class ObserverA
{
    public void HandlerA1(string msg)
    {
        Console.WriteLine($"ObserverA HandlerA1 получил: {msg}");
    }
    public void HandlerA2(string msg)
    {
        Console.WriteLine($"ObserverA HandlerA2 получил: {msg}");
    }
}