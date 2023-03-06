using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] weekDays = {
                "Monday",
                "Tuesday",
                "Wendnesday",
                "Thursday",
                "Friday",
                "Satarday",
                "Sunday"
                };

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(weekDays[x - 1]);
        }
    }
}
