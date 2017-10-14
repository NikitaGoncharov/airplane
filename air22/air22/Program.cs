using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App started");
            Airplane airplane = new Airplane(140, 2.26F, 100);
            int a;
            a = int.Parse(Console.ReadLine());
            airplane.AutoPilotOn = true;
            airplane.SetAltitude(a);
            Console.WriteLine(airplane.Altitude);

            Console.ReadLine();
        }
    }
}
