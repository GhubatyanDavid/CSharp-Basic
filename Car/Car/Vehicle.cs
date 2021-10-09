using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Vehicle
    {
        //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска)..
        
        public int _year;
        public int _numberofPassenger;

        public Vehicle( int year, int numberofPassenger)
        {
            
            _year = year;
            _numberofPassenger = numberofPassenger;

        }
       

    }
}
