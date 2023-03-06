using System;

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                counter++;
            }

            Console.WriteLine(counter + " - counter");
        }
    }
}
