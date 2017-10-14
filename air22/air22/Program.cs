using System;

namespace air22
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(140, 2.26F, 100);
            bool Enable = true;
            int tmp;
            while (Enable)
            {
                Console.Write("Включен ли автопилот? (0, 1)= ");
                tmp = int.Parse(Console.ReadLine());
                if (tmp != 0) airplane.AutoPilotOn = true;
                else airplane.AutoPilotOn = false;
                Console.Write("Включен ли форсаж? (0, 1)= ");
                tmp = int.Parse(Console.ReadLine());
                if (tmp != 0) airplane.Forsage = true;
                else airplane.Forsage = false;
                Console.Write("Введите высоту= ");
                airplane.SetAltitude(int.Parse(Console.ReadLine()));
                Console.Clear();
                Console.WriteLine("Текущая высота= " + airplane.Altitude);
            }
            Console.ReadLine();
        }
    }
}
