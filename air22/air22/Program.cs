using System;

namespace air22
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airpla = new Airpla(140, 2.26F, 100);
            ConsoleKeyInfo input = new ConsoleKeyInfo();
            int tmp;
            while (input.Key != ConsoleKey.Escape)
            {
                Console.Write("Включен ли автопилот? (0, 1)= ");
                tmp = int.Parse(Console.ReadLine());
                if (tmp != 0) airpla.AutoPilotOn = true;
                else airpla.AutoPilotOn = false;
                Console.Write("Включен ли форсаж? (0, 1)= ");
                tmp = int.Parse(Console.ReadLine());
                if (tmp != 0) airpla.Forsage = true;
                else airpla.Forsage = false;
                Console.Write("Введите высоту= ");
                airpla.SetAltitude(int.Parse(Console.ReadLine()));
                Console.Clear();
                Console.WriteLine("Текущая высота= " + airpla.Altitude);
                input = Console.ReadKey();
            }
        }
    }
}
