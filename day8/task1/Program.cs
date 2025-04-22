using System.Text.RegularExpressions;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string pattern = "^\\+?[1-9][0-9]{7,14}$";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Найденные мобильные номера:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}