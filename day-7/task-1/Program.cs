using System;
using System.Text.RegularExpressions;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Some text with IP addresses 192.168.1.1 and 10.0.0.1.";

            string pattern = @"\b(?:\d{1,3}\.){3}\d{1,3}\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
