using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string pattern = @"\b(?:https?://)?(?:www\.)?[a-zA-Z0-9-]+\.[a-zA-Z]{2,}(?:/)?\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Найденные доменные имена:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}