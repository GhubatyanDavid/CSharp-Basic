using System;

namespace TwoFer
{
    class Program
    {
        static void Main(string[] args)
       {
            /* Name	String to return Alice	One for Alice, one for me.
                                     Bob	One for Bob, one for me.
                                     One for you, one for me.*/
            Console.WriteLine("Type your name please!");
            while (true)
            {
                string name = Console.ReadLine();
                TwoFer(name);
                static void TwoFer(string name)
                {
                    Console.WriteLine($"One for {name}, one for me.");
                }
            }
        }
    }
}
