namespace task4;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Artist}";
    }
}