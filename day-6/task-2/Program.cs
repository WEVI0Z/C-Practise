using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "loremz ipsumz...";

            text = text.ToLower();

            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == 'z')
                {
                    text = text.Insert(i + 1, "Z");
                }
            }

            Console.WriteLine(text);
        }
    }
}
