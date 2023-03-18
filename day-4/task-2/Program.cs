using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = 1;

            try
            {

                if(0 < x && x < 1)
                {
                    double firstY = x - 4;
                    Console.WriteLine(firstY);
                }
                else
                {
                    throw new Exception("x mustbe > 0 and < 1");
                }

                if(1 <= x)
                {
                    double secondY = x / (2 * x - 2);
                    Console.WriteLine(secondY);
                }
                else
                {
                    throw new Exception("x must be > 1")
                }
            }
            catch (DivideByZeroException)
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
