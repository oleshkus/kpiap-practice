namespace Task4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк массива: ");
        int rowCount = ReadIntFromConsole();
        Console.Write("Введите количество столбцов массива: ");
        int columnCount = ReadIntFromConsole();
        var matrix = GenerateRandomMatrix(rowCount, columnCount, -50, 50);
        Console.WriteLine("\nСгенерированный массив:");
        PrintMatrix(matrix);

        Console.Write("\nВведите номер строки (k, с 0): ");
        int rowIndex = ReadIntFromConsole();
        if (rowIndex < 0 || rowIndex >= rowCount)
        {
            Console.WriteLine("Некорректный номер строки.");
            return;
        }
        Console.Write("Введите номер столбца (s, с 0): ");
        int columnIndex = ReadIntFromConsole();
        if (columnIndex < 0 || columnIndex >= columnCount)
        {
            Console.WriteLine("Некорректный номер столбца.");
            return;
        }

        int rowSum = CalculateRowSum(matrix, rowIndex);
        int columnSum = CalculateColumnSum(matrix, columnIndex);
        int max = Math.Max(rowSum, columnSum);

        Console.WriteLine($"Сумма элементов строки {rowIndex}: {rowSum}");
        Console.WriteLine($"Сумма элементов столбца {columnIndex}: {columnSum}");
        Console.WriteLine($"Максимальное из них: {max}");
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
    /// Считает сумму элементов строки с заданным индексом.
    /// </summary>
    private static int CalculateRowSum(int[,] matrix, int rowIndex)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[rowIndex, j];
        }
        return sum;
    }

    /// <summary>
    /// Считает сумму элементов столбца с заданным индексом.
    /// </summary>
    private static int CalculateColumnSum(int[,] matrix, int columnIndex)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, columnIndex];
        }
        return sum;
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