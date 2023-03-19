using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "loremz ipsumz some limen";

            string[] words = text.Split(' ');

            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;

            Console.WriteLine(string.Join(" ", words));

            string secondAndThird = string.Join("", new string[] { words[1], words[2] });

            Console.WriteLine(string.Join(" ", new string[] { words[0], secondAndThird, words[3]}));

            string newWord = "";

            for(int i = words[2].Length - 1; i >= 0; i--)
            {
                newWord += words[2][i];
            }

            Console.WriteLine(string.Join(" ", new string[] { words[0], words[1], newWord, words[3] }));

            string cutWord = "";

            for(int i = 2; i < words[0].Length; i++)
            {
                cutWord += words[0][i];
            }

            Console.WriteLine(string.Join(" ", new string[] { cutWord, words[1], words[2], words[3] }));
        }
    }
}
