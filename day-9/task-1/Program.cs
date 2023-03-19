using System;

namespace task1
{
    interface Ix
    {
        void IxF0(int parameter);
        void IxF1();
    }

    interface Iy
    {
        void F0(int parameter);
        void F1();
    }

    interface Iz
    {
        void F0(int parameter);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        public int w;

        // Неявная реализация методов интерфейсов Ix и Iy
        public void IxF0(int parameter)
        {
            Console.WriteLine(parameter * 10);
        }

        public void IxF1()
        {
            Console.WriteLine(10 * w);
        }

        public void F0(int parameter)
        {
            Console.WriteLine(parameter - 10);
        }

        public void F1()
        {
            Console.WriteLine(w - 10);
        }

        // Явная реализация методов интерфейса Iz
        void Iz.F0(int parameter)
        {
            Console.WriteLine(parameter / 10);
        }

        void Iz.F1()
        {
            Console.WriteLine(w / 10);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.w = 20;

            // Вызов функций с явным приведением к типу интерфейса
            Ix ix = test;
            ix.IxF0(30);
            ix.IxF1();

            Iy iy = test;
            iy.F0(50);
            iy.F1();

            Iz iz = (Iz)test;
            iz.F0(40);
            iz.F1();

            // Вызов метода для объекта посредством интерфейсной ссылки
            CallIxF0(test);
            CallF0(test);
            CallIzF0(test);
        }

        static void CallIxF0(Ix ix)
        {
            ix.IxF0(10);
        }

        static void CallF0(Iy iy)
        {
            iy.F0(5);
        }

        static void CallIzF0(Iz iz)
        {
            iz.F0(7);
        }
    }

}
