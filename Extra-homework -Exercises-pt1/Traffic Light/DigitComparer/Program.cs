using System;

namespace DigitComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You need to print a two-digit number where the first digit is greater than the second!");
            Console.WriteLine("Please enter first number");
            int firstDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondDigit = int.Parse(Console.ReadLine());

            if (firstDigit > secondDigit)
            {
                Console.Write(firstDigit + "" + secondDigit);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("First number is smaler then second!");
                Console.ResetColor();
            }
        }
    }
}
