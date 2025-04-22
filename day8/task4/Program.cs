using System.Text.RegularExpressions;

namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string pattern = @"\b([01]?\d|2[0-3]):([0-5]?\d)\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Найденное время:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}