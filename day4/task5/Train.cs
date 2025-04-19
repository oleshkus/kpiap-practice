namespace task5;

public class Train
{
    private string _destination;
    private string _id;
    private string _departureTime;
    
    public Train(string destination, string id, string departureTime)
    {
        _destination = destination;
        _id = id;
        _departureTime = departureTime;
    }

    public string Destination
    {
        get => _destination;
        set => _destination = value;
    }

    public string Id
    {
        get => _id;
        set => _id = value;
    }

    public string DepartureTime
    {
        get => _departureTime;
        set => _departureTime = value;
    }
}