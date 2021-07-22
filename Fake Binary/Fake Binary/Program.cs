using System;

namespace Fake_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string digith = "7 9 8 11 2 0 5 4 3 2 1";
            string[] digiths = digith.Split(' ');

            for (int i = 0; i < digiths.Length; i++)
            {
                if (Convert.ToInt32(digiths[i]) > 5)
                    Console.Write($"{digiths[i]} ");
                else
                    Console.Write($"{digiths[i]} ");
            }

        }
    }
}
