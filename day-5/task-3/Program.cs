using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[size, size];

            int multi = 1;
            int sum = 0;

            Random random = new Random();

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    arr[i, j] = random.Next(a, b);
                    Console.Write(arr[i, j] + " ");

                    multi *= arr[i, j] % 2 != 0 ? arr[i, j] : 1;

                    sum += k == i ? arr[i, j] : 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine(multi);
            Console.WriteLine(sum);
        }
    }
}
