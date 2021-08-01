using System;

namespace Resistor_Color
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Black: 0,Brown: 1,Red: 2,Orange: 3,Yellow: 4,Green: 5,Blue: 6,Violet: 7,Grey: 8,White: 9*/
            string color = null;
            string[] array = { "Black", "Brown", "Red", "Yellow", "Green", "Blue", "Violet", "Grey", "White" };
            Console.WriteLine("The Colors is`");
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write($"{array[i]} :");
            }
            while (true)
            {
                Console.WriteLine("Please print color");
                color = Console.ReadLine();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == color)
                        Console.WriteLine($"{array[i]}={i}");
                }
            }
        }
    }
}
