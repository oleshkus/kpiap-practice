using System;

namespace task1
{
    class Program
    {
        // Делегат для работы с квадратом
        public delegate void SquareDelegate(double side);

        // Метод для подсчета периметра
        public static void Perimeter(double side)
        {
            try
            {
                if (side <= 0) throw new ArgumentException("Сторона квадрата должна быть положительной!");
                double perimeter = 4 * side;
                Console.WriteLine($"Периметр квадрата: {perimeter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в вычислении периметра: {ex.Message}");
            }
        }

        // Метод для подсчета площади
        public static void Area(double side)
        {
            try
            {
                if (side <= 0) throw new ArgumentException("Сторона квадрата должна быть положительной!");
                double area = side * side;
                Console.WriteLine($"Площадь квадрата: {area}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в вычислении площади: {ex.Message}");
            }
        }

        // Метод для вывода стороны квадрата
        public static void ShowSide(double side)
        {
            try
            {
                if (side <= 0) throw new ArgumentException("Сторона квадрата должна быть положительной!");
                Console.WriteLine($"Сторона квадрата: {side}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выводе стороны: {ex.Message}");
            }
        }

        static void CallSquareDelegate(SquareDelegate del, double side)
        {
            Console.WriteLine("Вызов делегата через отдельный метод:");
            del(side);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата: ");
            string input = Console.ReadLine();
            double side;
            if (!double.TryParse(input, out side))
            {
                Console.WriteLine("Ошибка: введено не число!");
                return;
            }

            // Создаем делегат и подписываем методы
            SquareDelegate squareOps = Perimeter;
            squareOps += Area;
            squareOps += ShowSide;

            // Вызываем все методы через делегат
            squareOps(side);

            // ЗАДАЧА 2: Вызов делегата через отдельный метод
            Console.WriteLine("\n--- Задача 2 ---");
            CallSquareDelegate(squareOps, side);

            // ЗАДАЧА 3: MyInfo и событие на изменение имени
            Console.WriteLine("\n--- Задача 3 ---");
            var info = new MyInfo();
            info.NameChanged += (s, e) => Console.WriteLine("Имя было изменено!");
            info.Name = "Олег";
            info.Name = "Иван";
            info.Name = "Иван"; // Не вызовет событие

            // ЗАДАЧА 4: Publisher, ObserverA, ObserverB, события и обработчики
            Console.WriteLine("\n--- Задача 4 ---");
            var publisher = new Publisher();
            var obsA = new ObserverA();
            var obsB = new ObserverB();

            Publisher.Notify? hA1 = obsA.HandlerA1;
            Publisher.Notify? hA2 = obsA.HandlerA2;
            Publisher.Notify? hB = obsB.HandlerB;

            publisher.OnNotify += hA1;
            publisher.OnNotify += hA2;
            publisher.OnNotify += hB;

            Console.WriteLine("Все обработчики:");
            publisher.RaiseEvent("Событие 1");

            publisher.OnNotify -= hA2;
            Console.WriteLine("\nПосле удаления одного обработчика:");
            publisher.RaiseEvent("Событие 2");
        }
    }
}