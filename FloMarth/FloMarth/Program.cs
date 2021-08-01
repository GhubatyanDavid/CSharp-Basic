using System;

namespace FloMarth
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Earth: orbital period 365.25 Earth days, or 31557600 seconds Mercury: orbital period 0.2408467 Earth years
              Venus: orbital period 0.61519726 Earth years Mars: orbital period 1.8808158 Earth years
              Jupiter: orbital period 11.862615 Earth years Saturn: orbital period 29.447498 Earth years
              Uranus: orbital period 84.016846 Earth years Neptune: orbital period 164.79132 Earth years*/
            double sum = 0;
            Console.WriteLine("The Earth names:Earth,Mercury,Venus,Mars,Jupiter,Saturn,Uranus,Neptune");
            Console.WriteLine("Please type the Earth name");
            string earth = Console.ReadLine();
            Console.WriteLine("Please type your age");
            double seconds = Convert.ToDouble(Console.ReadLine())* 31536000;
            
            if(earth=="Earth")
            {
                sum = seconds / 31557600;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Mercury")
            {
                sum = seconds / 0.2408467;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Venus")
            {
                sum = seconds / 0.6159726;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Mars")
            {
                sum = seconds / 1.8808158;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Jupiter")
            {
                sum = seconds / 11.862615;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Saturn")
            {
                sum = seconds / 29.447498;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Uranus")
            {
                sum = seconds / 84.016846;
                Console.WriteLine($"{sum} seconds");
            }
            if (earth == "Neptune")
            {
                sum = seconds / 164.79132;
                Console.WriteLine($"{sum} seconds");
            }

        }
    }
}
