using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 3, 5, 9, 6, 12 };
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] % 3 == 0 ? arr[i] : 0;
            }

            Console.WriteLine(sum);
        }
    }
}
