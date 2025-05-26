namespace task1;

public struct Marsh
{
    public int Id { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Marsh(int id, string startPoint, string endPoint)
    {
        Id = id;
        StartPoint = startPoint;
        EndPoint = endPoint;
    }
}