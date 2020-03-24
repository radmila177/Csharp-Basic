using System;

namespace DigitComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All two-digit numbers, which have the first digit greater than the second digit.");

            for (int i = 10; i < 100; i++)
            {
                if (i / 10 > i % 10)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
    
}
