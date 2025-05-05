namespace task1;

public static class MyListExtension
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        var array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}