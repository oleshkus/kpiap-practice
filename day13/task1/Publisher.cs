namespace task1;

// ЗАДАЧА 4: Класс с событием и делегатом, два наблюдателя
public class Publisher
{
    public delegate void Notify(string message);
    public event Notify? OnNotify;
    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message);
    }
}