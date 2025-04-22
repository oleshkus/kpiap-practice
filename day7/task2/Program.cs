namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == word[i + 1])
                    {
                        Console.WriteLine(word);
                        break; 
                    }
                }
            }
        }
    }
}