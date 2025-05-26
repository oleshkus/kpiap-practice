namespace Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        // Сумма чисел на отрезке [k, l)
        Console.Write("Введите начало диапазона (K): ");
        int k = ReadIntFromConsole();
        Console.Write("Введите конец диапазона (L): ");
        int l = ReadIntFromConsole();
        int sum = CalculateRangeSum(k, l);
        Console.WriteLine($"Сумма чисел в диапазоне [{k}, {l}): {sum}\n");

        // Работа с двумерным массивом
        Console.Write("Введите количество строк массива: ");
        int rowCount = ReadIntFromConsole();
        Console.Write("Введите количество столбцов массива: ");
        int columnCount = ReadIntFromConsole();
        var matrix = GenerateRandomMatrix(rowCount, columnCount, -50, 50);
        Console.WriteLine("\nСгенерированный массив:");
        PrintMatrix(matrix);

        Console.Write("\nВведите номер столбца (с 0): ");
        int columnIndex = ReadIntFromConsole();
        if (columnIndex < 0 || columnIndex >= columnCount)
        {
            Console.WriteLine("Некорректный номер столбца.");
            return;
        }
        int max = FindMaxInColumn(matrix, columnIndex);
        Console.WriteLine($"Наибольший элемент в столбце {columnIndex}: {max}");
    }

    /// <summary>
    /// Считает сумму целых чисел на отрезке [start, end).
    /// </summary>
    private static int CalculateRangeSum(int start, int end)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += i;
        }
        return sum;
    }

    /// <summary>
    /// Генерирует двумерный массив случайных чисел.
    /// </summary>
    private static int[,] GenerateRandomMatrix(int rows, int columns, int minValue, int maxValue)
    {
        var matrix = new int[rows, columns];
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    /// <summary>
    /// Находит максимальный элемент в заданном столбце матрицы.
    /// </summary>
    private static int FindMaxInColumn(int[,] matrix, int columnIndex)
    {
        int max = matrix[0, columnIndex];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, columnIndex] > max)
            {
                max = matrix[i, columnIndex];
            }
        }
        return max;
    }

    /// <summary>
    /// Печатает двумерный массив в консоль.
    /// </summary>
    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Безопасно читает целое число с консоли.
    /// </summary>
    private static int ReadIntFromConsole()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                return value;
            }
            Console.Write("Ошибка ввода. Повторите попытку: ");
        }
    }
}