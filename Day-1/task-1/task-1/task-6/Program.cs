using System;

namespace task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());

            double step = (b - a) / Convert.ToDouble(number);

            double currentNumber = a;

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(Math.Acos(currentNumber));

                currentNumber += step;
            }
        }
    }
}
