using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("divided by 3");
            Console.ResetColor();
            for (int i = 1; i <100; i++)
            {
                if(i%3 == 0)
                 Console.Write(i+"-Fizz" + ", ");
              
            }
            Console.WriteLine("\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("divided by 5");
            Console.ResetColor();
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                 Console.Write(i + "-Bizz" + ", ");

            }
            Console.WriteLine("\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("divided by 3 & 5");
            Console.ResetColor();
;            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5==0)
                    Console.Write(i + "-Fizz-Bizz" + ", ");

            }

            Console.WriteLine("\n");
        }

    }
}
