namespace Task6
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
            int firstDigit = number / 100;
            int lastDigit = number % 10;
            int product = firstDigit * lastDigit;
            Console.WriteLine($"Произведение первой и последней цифр: {product}");
        }
    }
}