namespace Task3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N (1 <= N <= 10): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 10)
            {
                Console.WriteLine("Ошибка: N должно быть от 1 до 10.");
                return;
            }
            int sum = 0;
            for (int i = n; i <= 2 * n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"Сумма квадратов от N до 2N: {sum}");
        }
    }
}