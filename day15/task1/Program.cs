namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MyList");
        var list = new MyList<int>();
        list.Add(10);
        list.Add(20);
        Console.WriteLine(list[1]); // 20
        Console.WriteLine(list.Count); // 2
        
        var dict = new MyDictionary<int, string>();
        Console.WriteLine("MyDictionary");
        dict.Add(1, "a");
        dict.Add(2, "b");
        Console.WriteLine(dict[1]); // a
        Console.WriteLine(dict.Count); // 2
        dict.Remove(1);
        Console.WriteLine(dict.Count); // 1
        Console.WriteLine(dict.ContainsKey(1)); // false
        dict.Clear();
        Console.WriteLine(dict.Count); // 0

        var array = list.GetArray();
        Console.WriteLine("MyListExtension");
        Console.WriteLine(array[1]); // 20
    }
}