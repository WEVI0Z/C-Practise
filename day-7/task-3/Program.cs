using System;
using System.Text.RegularExpressions;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Текст с числами 123 и 456.";
            double product = 1;

            string pattern = @"\d+";
            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(text))
            {
                double number = double.Parse(match.Value);
                product *= number;
            }

            Console.WriteLine("Произведение чисел в тексте: " + product);
        }
    }
}
