using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("what operation would you want to be done: ( +, - , * , / )");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine("The result of sum is:" + (firstNumber + secondNumber));
            }
            else if (operation == "-")
            {
                Console.WriteLine("The result substraction is:" + (firstNumber - secondNumber));
            }
            else if (operation == "*")
            {
                Console.WriteLine("The result multiplication is:" + (firstNumber * secondNumber));
            }
            else if (operation == "/")
            {
                Console.WriteLine("The result division is:" + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("You did not enter any of the offered operations");
            }
        }
    }
}
