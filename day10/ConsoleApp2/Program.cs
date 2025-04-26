using System;
namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine($"Значение свойства c класса A: {a.C}");
        
        B b1 = new B();
        Console.WriteLine($"Значение свойства c2 класса B (по умолчанию): {b1.C2}");
        
        B b2 = new B(25);
        Console.WriteLine($"Значение свойства c2 класса B (собственный конструктор): {b2.C2}");
    }
}