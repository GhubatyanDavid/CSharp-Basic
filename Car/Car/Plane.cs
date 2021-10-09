using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Plane : Vehicle
    {
        //Для класса Plane должна быть определена высота и количество пассажиров. 
        public int _cordinat;
        public Plane(int Year,int NumberofPassenger,int cordinat):base(Year,NumberofPassenger)
        {
            Console.WriteLine($"Pleane Height is` {cordinat}");
            Console.WriteLine($"Plane Number of Passengers `{NumberofPassenger}");
            Console.WriteLine($"Plane Year is ` {Year}");
        }
    //public void PlaneSettings ()
    //{
    //    Console.WriteLine($"Pleane Height is` {Cordinat}");
    //    Console.WriteLine($"Plane Number of Passengers `{NumberofPassenger}");
    //}


}
}
