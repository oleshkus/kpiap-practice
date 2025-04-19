namespace Task7
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nЦикл while:");
            int i = a;
            while (i <= b)
            {
                if (i > 0)
                    Console.Write(i + " ");
                i++;
            }

            Console.WriteLine("\n\nЦикл do while:");
            i = a;
            if (a <= b)
            {
                do
                {
                    if (i > 0)
                        Console.Write(i + " ");
                    i++;
                } while (i <= b);
            }

            Console.WriteLine("\n\nЦикл for:");
            for (i = a; i <= b; i++)
            {
                if (i > 0)
                    Console.Write(i + " ");
            }
        }
    }
}