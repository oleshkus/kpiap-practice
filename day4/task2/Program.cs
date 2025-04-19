using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            // Ввод первого набора
            Console.WriteLine("Введите три числа для первого набора:");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());

            // Ввод второго набора
            Console.WriteLine("Введите три числа для второго набора:");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());

            SortInc3(ref a1, ref b1, ref c1);
            SortInc3(ref a2, ref b2, ref c2);

            Console.WriteLine($"Первый набор после сортировки: {a1}, {b1}, {c1}");
            Console.WriteLine($"Второй набор после сортировки: {a2}, {b2}, {c2}");
        }

        /// <summary>
        /// Сортирует три числа по возрастанию.
        /// </summary>
        public static void SortInc3(ref double a, ref double b, ref double c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
            if (a > b)
            {
                Swap(ref a, ref b);
            }
        }

        /// <summary>
        /// Меняет местами два числа.
        /// </summary>
        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}