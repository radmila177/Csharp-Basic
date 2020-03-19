using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Please enter First number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping: " + "First number is: " + firstNumber + " Second number is: " + secondNumber);


            x = firstNumber;
            firstNumber = secondNumber;
            secondNumber = x;

            Console.WriteLine("After swapping: " + "First number is: " + firstNumber + " Second number is: " + x);
        }
    }
    
}
