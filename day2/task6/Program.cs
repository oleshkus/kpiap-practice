namespace task6;
/// <summary>
///  Дан номер карты k ( 146k ), определить достоинство карты.
/// Достоинства определяются по следующему правилу: &quot;туз&quot; - 14, &quot;король&quot; - 13,
/// &quot;дама&quot; - 12, &quot;валет&quot; - 11, &quot;десятка&quot; - 10, …, &quot;шестерка&quot; - 6.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        for (int i = 0; i < 48; i++)
        {
            Rank rank = (Rank)rand.Next(6, 15);
            Console.WriteLine(rank);
        }
    }
    
    public enum Rank
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
    }
}