using System;

namespace Fibonachi_v0._1
{
    class Program
    {
        static int fibonachi(int first,int second,int sum,int number)
        {
            while (sum < number)
            {
                sum = first + second;
                first = second;
                second=sum;
                Console.WriteLine(sum);
            }
            return sum;


        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int sum =0;
            int result = fibonachi(first,second,sum,number);
        }
    }
}
