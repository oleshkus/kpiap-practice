namespace task1;

class Program
{
    static void Main(string[] args)
    {
        // Выбор ввода маршрутов
        Console.WriteLine("Автоматическое заполнение/Ручной ввод?\n1 - Автоматическое заполнение\n2 - Ручной ввод");
        int choice = Convert.ToInt32(Console.ReadLine());
        Marsh[] marshes = new Marsh[8];

        // Автоматическое заполнение
        if (choice == 1)
        {
            Random rand = new Random();
            var streetValues = Enum.GetValues(typeof(Streets));

            for (int i = 0; i < marshes.Length; i++)
            {
                var startPoint = Enum.GetName(typeof(Streets), streetValues.GetValue(rand.Next(streetValues.Length)));
                var endPoint = Enum.GetName(typeof(Streets), streetValues.GetValue(rand.Next(streetValues.Length)));
                marshes[i] = new Marsh(i + 1, startPoint, endPoint);
            }
        }
        // Ручной ввод
        else
        {
            for (int i = 0; i < marshes.Length; i++)
            {
                Console.WriteLine($"Id: {i + 1}");
                Console.WriteLine("Start Point:");
                marshes[i].StartPoint = Console.ReadLine();
                Console.WriteLine("End Point:");
                marshes[i].EndPoint = Console.ReadLine();
            }
        }

        foreach (var marsh in marshes)
        {
            Console.WriteLine($"//////\nId: {marsh.Id}\nStart: {marsh.StartPoint}\nEnd: {marsh.EndPoint}");
        }
        
        // Поиск по id
        Console.WriteLine("Поиск по id");
        FindMarshById(marshes, 3);
        
        // Поиск по стартовой точке
        Console.WriteLine("Поиск по стартовой точке");
        FindMarshByStartPoint(marshes, "Девятовка");
        
        // Поиск по конечной точке
        Console.WriteLine("Поиск по конечной точке");
        FindMarshByEndPoint(marshes, "Грандичи");
    }

    private static void PrintMarsh(Marsh marsh)
    {
        Console.WriteLine($"Id: {marsh.Id}\nStart: {marsh.StartPoint}\nEnd: {marsh.EndPoint}");
    }
    
    public static void FindMarshById(Marsh[] marshes, int id)
    {
        foreach (var marsh in marshes)
        {
            if (marsh.Id == id)
                PrintMarsh(marsh);
        }
    }
    
    public static void FindMarshByStartPoint(Marsh[] marshes, string startPoint)
    {
        foreach (var marsh in marshes)
        {
            if (marsh.StartPoint == startPoint)
                PrintMarsh(marsh);
        }
    }
    
    public static void FindMarshByEndPoint(Marsh[] marshes, string endPoint)
    {
        foreach (var marsh in marshes)
        {
            if (marsh.EndPoint == endPoint)
                PrintMarsh(marsh);
        }
    }
}