using System;

namespace Fake_Binary_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123456987";
            int inputNumber = Convert.ToInt32(input);
            const int  ForinputNumber = inputNumber;
            int  divider = 0;
            int result = 0;
            int degree = input.Length - 1;
            for (int i = 0; i < input.Length ;i++, degree--)
            {
                inputNumber = ForinputNumber;
                divider = (int)Math.Pow(10, degree);
                inputNumber = inputNumber / divider;

                if (inputNumber > 0)
                {
                    inputNumber = inputNumber % 10;
                    
                }
                if (inputNumber > 5)
                    result=1;
                else
                    result = 0;
                
                Console.WriteLine(result);
            }
        }
    }
}
