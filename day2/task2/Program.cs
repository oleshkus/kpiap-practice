namespace Task2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть трёхзначным.");
                return;
            }
            int first = number / 100;
            int second = (number / 10) % 10;
            int third = number % 10;

            bool isIncreasing = first < second && second < third;
            Console.WriteLine(isIncreasing
                ? "Цифры образуют возрастающую последовательность."
                : "Цифры не образуют возрастающую последовательность.");
        }
    }
}