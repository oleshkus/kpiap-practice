namespace task1;
// ЗАДАЧА 3: Класс с событием при изменении поля name

public class MyInfo
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
    public event EventHandler? NameChanged;
}