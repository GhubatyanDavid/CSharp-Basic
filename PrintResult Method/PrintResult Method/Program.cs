using System;

namespace ConsoleApp24
{
    class Program
    {
        static void PrintResult(int a, int b, int c)
        {
            if (a > b && a > c)

                Console.WriteLine($"{a} > {b},{a} > {c}");
            if (a > b && a < c)
                Console.WriteLine($"{a} < {c},{a} > {b}");
            if (a < b && a > c)
                Console.WriteLine($"{a} < {b},{a} > {c}");
            if (a < b && a < c)
            {
                Console.WriteLine($"{a} < {b},{a} < {c}");
            }
        }
        static void PrintResult(int d, int e)
        {
            Console.WriteLine(Math.Pow(d, e));
        }
        static void PrintResult(decimal z, int b, int c)
        {
            Console.WriteLine($"{z}+{b}+{c}");
        }
        static void Main(string[] args)
        {
            /*Создать набор перегрузок метода PrintResult: ◦ Принимает 3 целочисленные переменные и выводит на экран  результат их сложения.
            ◦ Принимает 3 целочисленные переменные и выводит на экран результат их разности. ◦ Принимает 2 целочисленные переменные и выводит первое число 
            в степени второго. ◦ Принимает 3 целочисленные переменные и вводит на экран сумму значений этих переменных представленных в строковом виде 
            (пример: «3» + «4» + «5»).*/
            int a = 3;
            int b = 4;
            int c = 5;
            int d = 3;
            int e = 10;
            decimal z = 12;
            PrintResult(a, b, c);
            PrintResult(d, e);
            PrintResult(z, b, c);

        }
    }
}
