using System;
using System.Numerics;

namespace Faktorial
{
    class Program
    {
        static BigInteger Factorial(BigInteger number)
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Type The number!");
                BigInteger number = Convert.ToInt32(Console.ReadLine());
                BigInteger factorial = Factorial(number);
                Console.WriteLine($"{number}! - {factorial}");
            }
        }
    }
}
