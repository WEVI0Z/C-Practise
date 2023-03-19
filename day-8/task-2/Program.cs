using System;

namespace task2
{
    class MainClass
    {
        enum Position
        {
            Manager = 160,
            Engineer = 176,
            Developer = 192,
            Designer = 144,
            Analyst = 168
        }

        class Accauntant
        {
            public bool AskForBonus(Position worker, int hours)
            {
                if (hours > (int)worker)
                {
                    return true;
                }
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();

            Console.WriteLine(accauntant.AskForBonus(Position.Analyst, 10));
        }
    }
}
