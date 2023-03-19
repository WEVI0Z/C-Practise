using System;

namespace task1
{
    using System;

    struct TRAIN
    {
        public string destination;
        public int number;
        public DateTime departureTime;
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[2];

            Console.WriteLine("Введите данные о поездах:");
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Поезд №{i + 1}:");
                Console.Write("Название пункта назначения: ");
                trains[i].destination = Console.ReadLine();
                Console.Write("Номер поезда: ");
                trains[i].number = int.Parse(Console.ReadLine());
                Console.Write("Время отправления (в формате ЧЧ:ММ): ");
                trains[i].departureTime = DateTime.Parse(Console.ReadLine());
            }

            Array.Sort(trains, (t1, t2) => t1.destination.CompareTo(t2.destination));

            Console.Write("Введите время (в формате ЧЧ:ММ): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            bool found = false;
            Console.WriteLine($"Поезда, отправляющиеся после {time.ToString("HH:mm")}:");
            foreach (TRAIN train in trains)
            {
                if (train.departureTime > time)
                {
                    Console.WriteLine($"{train.destination}, поезд №{train.number}, время отправления: {train.departureTime.ToString("HH:mm")}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Нет поездов, отправляющихся после введенного времени.");
            }
        }
    }

}
