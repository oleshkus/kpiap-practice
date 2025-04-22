namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            var input = Console.ReadLine();
            string[] words = input.Split(' ');

            Console.WriteLine("Задание 1 \n");
            if (words.Length > 1)
            {
                string temp = words[0];
                words[0] = words[words.Length - 1];
                words[words.Length - 1] = temp;
            }

            Console.WriteLine("Предложение с первым и последним словом местами: " + string.Join(" ", words));

            Console.WriteLine("Задание 2 \n");
            if (words.Length > 2)
            {
                words[1] = words[1] + words[2];
                Array.Copy(words, 3, words, 2, words.Length - 3);
                Array.Resize(ref words, words.Length - 1);
            }

            Console.WriteLine("Предложение с объединёнными вторым и третьим словами: " + string.Join(" ", words));

            Console.WriteLine("Задание 3 \n");
            if (words.Length > 2)
            {
                char[] thirdWordReversed = words[2].ToCharArray();
                Array.Reverse(thirdWordReversed);
                Console.WriteLine("Третье слово в обратном порядке: " + new string(thirdWordReversed));
            }

            Console.WriteLine("Задание 4");
            if (words.Length > 0 && words[0].Length > 2)
            {
                words[0] = words[0].Substring(2);
            }

            Console.WriteLine("Первое слово без первых двух букв: " + words[0]);
        }
    }
}