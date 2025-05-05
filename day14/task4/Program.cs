using System;
using System.Threading;

namespace task4
{
    class Program
    {
        static int totalSum = 0;
        static object lockObj = new object();

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            Console.Write("Введите количество потоков: ");
            int threadCount = int.Parse(Console.ReadLine()!);
            Thread[] threads = new Thread[threadCount];
            int part = n / threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                int start = i * part;
                int end = (i == threadCount - 1) ? n : start + part;
                threads[i] = new Thread(() => PartialSum(arr, start, end));
                threads[i].Start();
            }

            foreach (var t in threads)
                t.Join();

            Console.WriteLine($"Сумма четных элементов: {totalSum}");
        }

        static void PartialSum(int[] arr, int start, int end)
        {
            int localSum = 0;
            for (int i = start; i < end; i++)
            {
                if (arr[i] % 2 == 0)
                    localSum += arr[i];
            }
            lock (lockObj)
            {
                totalSum += localSum;
            }
        }
    }
}