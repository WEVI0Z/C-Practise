using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string x = Console.ReadLine();

            Console.WriteLine(
                x[0] == x[1] &&
                x[0] == x[2] &&
                x[1] == x[0] &&
                x[1] == x[2] &&
                x[2] == x[0] &&
                x[2] == x[1]
            );
        }
    }
}
