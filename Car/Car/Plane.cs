using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Plane : Vehicle
    {
        public Plane(int Year,int NumberofPassenger,int cordinat):base(Year,NumberofPassenger)
        {
            Console.WriteLine($"Pleane Height is` {cordinat}");
            Console.WriteLine($"Plane Number of Passengers `{NumberofPassenger}");
            Console.WriteLine($"Plane Year is ` {Year}");
        }


}
}
