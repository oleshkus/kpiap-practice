using System;
using System.Threading;

namespace task1
{
    class Program
    {
        static AutoResetEvent ev1 = new AutoResetEvent(true);
        static AutoResetEvent ev2 = new AutoResetEvent(false);
        static AutoResetEvent ev3 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Print0to9) { Priority = ThreadPriority.Highest };
            Thread t2 = new Thread(Print10to19) { Priority = ThreadPriority.Normal };
            Thread t3 = new Thread(Print20to29) { Priority = ThreadPriority.Lowest };

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void Print0to9()
        {
            for (int i = 0; i < 10; i++)
            {
                ev1.WaitOne();
                Console.WriteLine(i);
                Thread.Sleep(100);
                ev2.Set();
            }
        }

        static void Print10to19()
        {
            for (int i = 10; i < 20; i++)
            {
                ev2.WaitOne();
                Console.WriteLine(i);
                Thread.Sleep(100);
                ev3.Set();
            }
        }

        static void Print20to29()
        {
            for (int i = 20; i < 30; i++)
            {
                ev3.WaitOne();
                Console.WriteLine(i);
                Thread.Sleep(100);
                ev1.Set();
            }
        }
    }
}