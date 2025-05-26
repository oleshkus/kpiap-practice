namespace task1;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Начальное состояние - StateA
        Context context = new Context(new StateA());
            
        // Несколько переходов между состояниями
        context.Request(); // StateA -> StateB
        context.Request(); // StateB -> StateA
        context.Request(); // StateA -> StateB

        Console.ReadKey();
    }
}