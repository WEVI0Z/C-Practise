using System;

namespace task1
{
    class A
    {
        public double a, b;

        public A(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double calculate()
        {
            return 1 / (1 + (a + b) / 2);
        }

        public double insertInFormula()
        {
            return Math.Pow((a - b), 2);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            A aClass = new A(a, b);

            Console.WriteLine(aClass.calculate());

            Console.WriteLine(aClass.insertInFormula());
        }
    }
}
