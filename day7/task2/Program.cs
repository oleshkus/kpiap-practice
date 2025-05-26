using System.Text.RegularExpressions;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string pattern = @"\b\d{7}\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Найденные семизначные номера телефонов:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}