using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}
