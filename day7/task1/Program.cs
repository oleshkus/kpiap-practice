namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string message = Console.ReadLine();
            string[] words = message.Split(' ');

            foreach (string word in words)
            {
                if (word.Length > 0 && char.IsLower(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}