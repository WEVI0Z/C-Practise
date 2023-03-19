using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[3, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int columnNumber = 2;
            int divisor = 3;

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, columnNumber];
            }

            if (sum % divisor == 0)
            {
                Console.WriteLine($"Сумма элементов столбца {columnNumber} кратна {divisor}");
            }
            else
            {
                Console.WriteLine($"Сумма элементов столбца {columnNumber} не кратна {divisor}");
            }

        }
    }
}
