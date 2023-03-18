using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Int64 x = Convert.ToInt64(Console.ReadLine());

            if (x >= 4 && x <= 6)
            {
                Console.WriteLine(x);
            }
            else if (x > 6)
            {
                Console.WriteLine(3 * x + 4 * Math.Pow(x, 2));
            }
        }
    }
}
