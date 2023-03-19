using System;

namespace task5
{
    class MainClass
    {
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static double F(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                int factorialNMinus1 = Factorial(n - 1);
                int factorialN = Factorial(n);
                return (double)factorialNMinus1 / factorialN;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            double result = F(n);
            Console.WriteLine($"f({n}) = {result}");
        }
    }
}
