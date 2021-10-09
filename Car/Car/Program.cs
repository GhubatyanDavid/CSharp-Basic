using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            int cordinat = 1480;
            int price = 18000;
            int speed = 160;
            int year = 2020;
            int numberofPassenger = 5;
            Vehicle vehicle = new Vehicle(year,numberofPassenger);
            Plane plane = new Plane(year,numberofPassenger,cordinat);
            Ship ship = new Ship(numberofPassenger, year,cordinat);
            Car car = new Car(year, numberofPassenger,price,speed);
            
            
            
            


         }
    }
}
