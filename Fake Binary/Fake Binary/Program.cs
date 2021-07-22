using System;

namespace Fake_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string digith = "123456987";
            int digiths = Convert.ToInt32(digith);
            int result = 0;
            for(int i= 0;i<digith.Length;i++)
            {
                
                result = digiths %10;
                digiths = digiths / 10;
                if (result > 5)
                    result = 0;
                else
                    result = 1;
                Console.WriteLine(result);
            }

        }
    }
}
