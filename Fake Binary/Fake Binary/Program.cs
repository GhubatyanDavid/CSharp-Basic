using System;

namespace Fake_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123456987";
            int inputs = Convert.ToInt32(input);
            int result = 0;
            string output = null;
            for(int i= 0;i<input.Length;i++)
            {
                
                result = inputs %10;
                inputs = inputs / 10;
                if (result > 5)
                    result = 0;
                else
                    result = 1;
                output = output + result;
                
            }
            Console.WriteLine(output);

        }
    }
}
