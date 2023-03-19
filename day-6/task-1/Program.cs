using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "замена русских глассных на *";

            text = text.ToLower();

            char[] letters = { 'а', 'о', 'у', 'ы', 'э', 'е', 'ё', 'и', 'ю', 'я' };

            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < letters.Length; j++)
                {
                    if(text[i] == letters[j])
                    {
                        text = text.Replace(letters[j], '*');
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
