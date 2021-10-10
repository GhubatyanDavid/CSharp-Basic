
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car
{
    class Ship : Vehicle
    {
        public Ship(int numberofPassenger,int year,int cordinat):base(numberofPassenger,year)
        {
            Console.WriteLine($"Ship Passenger number is ` {numberofPassenger}");
            Console.WriteLine($"Ship Port number is` {cordinat}");
            Console.WriteLine($"Ship Year is` {year}");
        }
       
    }
}
