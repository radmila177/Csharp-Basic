using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz-Buzz");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine(i);
                }
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
