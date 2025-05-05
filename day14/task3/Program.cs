using System;
using System.Threading;

namespace task3
{
    class Program
    {
        static object lockObj = new object();

        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine()!);

            Thread t1 = new Thread(() => SumMethod(a, n));
            Thread t2 = new Thread(() => SumMethod(a, n));
            Thread t3 = new Thread(() => ProductMethod(a, n));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        // Одновременно двумя потоками
        static void SumMethod(int a, int n)
        {
            int sum = a;
            for (int i = 1; i <= n; i++)
                sum += a + i;
            Console.WriteLine($"Сумма: {sum}");
        }

        // Только одним потоком в момент времени
        static void ProductMethod(int a, int n)
        {
            lock (lockObj)
            {
                int prod = a;
                for (int i = 1; i <= n; i++)
                    prod *= a + i;
                Console.WriteLine($"Произведение: {prod}");
            }
        }
    }
}