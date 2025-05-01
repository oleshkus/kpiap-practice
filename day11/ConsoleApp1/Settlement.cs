namespace ConsoleApp1;

class Settlement
{
    protected readonly string Name;

    public Settlement(string name)
    {
        this.Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название населённого пункта: {Name}");
    }
}