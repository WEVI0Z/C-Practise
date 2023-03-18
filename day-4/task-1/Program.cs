using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = 1;

            try
            {
                double firstY = 1 - 4 / (4 * x + 8);
                double secondY = Math.Pow(Math.Tan(x), 2) + 1 / (x - 1);

                Console.WriteLine(firstY);
                Console.WriteLine(secondY);
            }
            catch(DivideByZeroException)
            {
                Console.log("Devide by zero exception");
            }
            catch (FormatException)
            {
                Console.log("Format exception");
            }
        }
    }
}
