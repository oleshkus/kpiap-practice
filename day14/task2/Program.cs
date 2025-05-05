using System;
using System.Diagnostics;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(SumAndTime);
            Thread t2 = new Thread(SumAndTime);

            t1.Start(1);
            t2.Start(2);

            t1.Join();
            t2.Join();
        }

        static void SumAndTime(object? threadNum)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Thread.Sleep(50); // For demonstration
            }
            sw.Stop();
            Console.WriteLine($"Thread {threadNum}: sum = {sum}, time = {sw.ElapsedMilliseconds} ms");
        }
    }
}