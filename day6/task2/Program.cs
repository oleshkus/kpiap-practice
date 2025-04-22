namespace Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TASK 1\n");
        var array = new int[20];
        var random = new Random();
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine($"\n {BinarySearch(array, 4, 0, array.Length - 1)}");
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine("TASK 2\n");
        Console.WriteLine(CalculateAverage(array));
    }

    /// <summary>
    /// Выполняет бинарный поиск значения в массиве.
    /// </summary>
    /// <param name="array">Массив для поиска</param>
    /// <param name="searchedValue">Искомое значение</param>
    /// <param name="first">Первый индекс</param>
    /// <param name="last">Последний индекс</param>
    /// <returns>Индекс найденного элемента или -1</returns>
    private static int BinarySearch(int[] array, int searchedValue, int first, int last)
    {
        if (first > last)
        {
            return -1;
        }

        var middle = (first + last) / 2;
        var middleValue = array[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else if (middleValue > searchedValue)
        {
            return BinarySearch(array, searchedValue, first, middle - 1);
        }
        else
        {
            return BinarySearch(array, searchedValue, middle + 1, last);
        }
    }

    /// <summary>
    /// Вычисляет среднее значение элементов массива.
    /// </summary>
    /// <param name="array">Массив чисел</param>
    /// <returns>Среднее значение</returns>
    private static int CalculateAverage(int[] array)
    {
        var sum = 0;
        for (var i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
}