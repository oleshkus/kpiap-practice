using System;
using task1;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 5;
            TestClass obj = new TestClass(w);

            // Вызов неявно реализованных методов Ix и Iy
            obj.IxF0(w);
            obj.IxF1();
            obj.F0(w); // Iy.F0
            obj.F1();  // Iy.F1

            // Вызов через интерфейсную ссылку Iy
            Iy iy = obj;
            iy.F0(w);
            iy.F1();

            // Вызов явной реализации через приведение к Iz
            Iz iz = obj;
            iz.F0(w);
            iz.F1();
        }
    }
}