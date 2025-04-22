namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите фамилию, имя и отчество:");
            var input = Console.ReadLine();

            input = input.Replace(" ", "").ToLower();

            int sum = 0;

                
            foreach (char c in input)
            {
                if (c >= 'а' && c <= 'я')
                {
                    sum += c - 'а' + 1; 
                }
                else if (c == 'ё') 
                {
                    sum += 7; 
                }
            }

                
            while (sum >= 10)
            {
                sum = SumOfDigits(sum);
            }

            Console.WriteLine("Код личности: " + sum);
        }

            
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}