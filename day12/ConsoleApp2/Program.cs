using System;

class Program
{
    static void Main(string[] args)
    {
        Func<double, double, double> add = (a, b) => a + b;
        Func<double, double, double> sub = (a, b) => a - b;
        Func<double, double, double> mul = (a, b) => a * b;
        Func<double, double, double> div = (a, b) =>
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль.");
            }
            return a / b;
        };

        Console.WriteLine("Выберите операцию: +, -, *, /");
        string operation = Console.ReadLine();

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case "+":
                result = add(num1, num2);
                break;
            case "-":
                result = sub(num1, num2);
                break;
            case "*":
                result = mul(num1, num2);
                break;
            case "/":
                try
                {
                    result = div(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                break;
            default:
                Console.WriteLine("Некорректная операция.");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}