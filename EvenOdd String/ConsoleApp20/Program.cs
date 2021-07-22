using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "CodeWars";
            string evenOutput = null;
            string oddOutput = null;
            for(int i =0;i<s.Length;i++)
            {
                if (i == 0 || i % 2 == 0)
                    evenOutput += s[i].ToString();
                else
                    oddOutput += s[i].ToString();

            }
            
            Console.Write($"{evenOutput}  {oddOutput}");

        }
    }
}
